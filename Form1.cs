using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Collections;
using System.Runtime.InteropServices;

namespace PDA_1._0
{
    public partial class Form1 : Form
    {
        private SqlCeConnection cn;
        private Liaison currentLiaison = new Liaison();
        private Site currentSite_a = new Site();
        private Site currentSite_b = new Site();
        private List<Site> sites = null;
        private List<Liaison> liaisons = null;
        private string username;
        private System.Windows.Forms.MenuItem menuItemEditAdmin;
        //0:user - 1:admin - 9:Constructor(@inov@)
        int role;

        public Form1(int role, string name)
        {

            this.role = role;
            this.username = name;

            InitializeComponent();

            if (role == 0)
            {
                this.menuItem1.MenuItems.Remove(menuItemAddUser);
                this.menuItem1.MenuItems.Remove(menuItemEditUser);
                this.mainMenu1.MenuItems.Remove(menuItemDataBase);

                //menuItemAddUser.Enabled = false;
                //menuItemEditUser.Enabled = false;
                //menuItemDataBase.Enabled = false;
            }
            else if (role == 9)
            {
                this.menuItem1.MenuItems.Remove(menuItemEditPass);
                //menuItemEditPass.Enabled = false;
                menuItemEditAdmin = new System.Windows.Forms.MenuItem();
                this.menuItem1.MenuItems.Add(menuItemEditAdmin);
                menuItemEditAdmin.Text = "Modifier l'ADMIN";
                menuItemEditAdmin.Click += new System.EventHandler(this.menuItemEditAdmin_Click);
            
            }
            try
            {
                if (!File.Exists("myDb.sdf"))
                    CreateDataBase();
                fillComboBoxLiaison();
            }
            catch (Exception) { }
        }

        //this constructor is used to call a non-static methode (listArticleConfig) from FormValidate
        public Form1(string s) { s = ""; }

        private void insertConfigToDB(List<List<string>> list)
        {
            beginConnection();
            int colonne;
            int ligne = 0;
            string type = "";
            string config = "";
            string article = "";
            string designation = "";
            //insert Sites
            foreach (List<string> L in list)
            {
                colonne = 0;
                ligne++;
                if (ligne != 1)
                {
                    foreach (string s in L)
                    {
                        string chaine = s.Replace("'", "''");
                        colonne++;
                        if (colonne == 1)
                        {
                            if (s.Length > 0)
                                type = chaine;
                        }
                        else if (colonne == 2)
                        {
                            if (s.Length > 0)
                                config = chaine;
                        }
                        else if (colonne == 3)
                        {
                            article = chaine;
                        }
                        else if (colonne == 4)
                        {
                            designation = chaine;
                        }
                    }
                    SqlCeCommand cmd = cn.CreateCommand();
                    //MessageBox.Show(type + "','" + config + "','" + article);
                    cmd.CommandText = "INSERT INTO article (nom, config, type, designation) VALUES ('" + article + "','" + config + "','" + type + "','" + designation + "')";
                    cmd.ExecuteNonQuery();
                }
            }  
           
            endConnection();
        }

        private void insertProduitsToDB(List<List<string>> list)
        {
            beginConnection();
            int colonne;
            int ligne = 0;
            string ucParent = "";
            string parentSN = "";
            string UC = "";
            string numSerie = "";
            string immo = "";
            //insert Sites
            foreach (List<string> L in list)
            {
                colonne = 0;
                ligne++;
                if (ligne != 1)
                {
                    foreach (string s in L)
                    {
                        colonne++;            
                        if (colonne == 1)
                        {
                            ucParent = s;
                        }
                        else if (colonne == 2)
                        {
                            parentSN = s;
                        }
                        else if (colonne == 3)
                        {
                            UC = s;
                        }
                        else if (colonne == 4)
                        {
                            numSerie = s;
                        }
                        else if (colonne == 5)
                        {
                            immo = s;
                        }

                    }
                    SqlCeCommand cmd = cn.CreateCommand();
                    //MessageBox.Show(ucParent + " - " + parentSN + " - " + UC + " - " + numSerie + " - " + immo);
                    cmd.CommandText = "INSERT INTO produits VALUES ('" + ucParent + "','" + parentSN + "','" + UC + "','" + numSerie + "','" + immo + "')";
                    cmd.ExecuteNonQuery();
                }
            }

            endConnection();
        }

        private void insertListToDB(List<List<string>> list)
        {
            beginConnection();
            int colonne;
            int ligne = 0;

            //insert Sites
            foreach (List<string> L in list)
            {
                colonne = 0;
                ligne++;
                if (ligne != 1)
                {
                    foreach (string s in L)
                    {
                        colonne++;

                        if (colonne == 2 || colonne == 3)
                        {
                            //if (getSiteID(s) == 0)
                            //{
                                SqlCeCommand cmd = cn.CreateCommand();
                                Random r = new Random();
                                int n = r.Next();
                                cmd.CommandText = "INSERT INTO site (idSite,nom) VALUES (" + n + ",'" + s + "')";
                                cmd.ExecuteNonQuery();
                            //}
                        }
                    }
                }
            }

            //insert Liaisons
            ligne = 0;
            string nomLiaison = "";
            string site_a = "";
            string site_b = "";
            string configRadio = "";
            foreach (List<string> L in list)
            {
                colonne = 0;
                ligne++;
                if (ligne != 1)
                {
                    foreach (string s in L)
                    {
                        colonne++;
                        if (colonne == 1)
                            nomLiaison = s;
                        else if (colonne == 2)
                            site_a = s;
                        else if (colonne == 3)
                            site_b = s;
                        else if (colonne == 4)
                            configRadio = s;
                    }
                    
                    SqlCeCommand cmd = cn.CreateCommand();
                    cmd.CommandText = "INSERT INTO liaison (nom, siteA, siteB, configRadio) VALUES ('" + nomLiaison + "'," + getSiteID(site_a) + "," + getSiteID(site_b) + ",'" + configRadio + "')";
                    cmd.ExecuteNonQuery(); 
                }
            }
            endConnection();
        }

        /*public int getSiteID(string nom)
        {
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT idSite FROM site where config nom '%" + nom + "%'";
            //cmd.Parameters.Add(new SqlCeParameter("@name", nom));
            //cmd.CommandText = "SELECT * FROM site WHERE nom = '" + nom + "'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                    int num = rdr.GetInt32(0);
                    rdr.Close();
                    return num;
            }
            rdr.Close();
            return 0;
        }

        public int getLiaisonID(string nom)
        {
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT idLiaison FROM liaison where nom like '%" + nom + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {   
                int num = rdr.GetInt32(0);
                rdr.Close();
                return num;
            }
            rdr.Close();
            return 0;
        }*/

        public List<Site> ListSites()
        {
            Site site = new Site();
            List<Site> all = new List<Site>();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM site";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                site = new Site();
                site.Id = rdr.GetInt32(0);
                site.Nom = rdr.GetString(1);
                all.Add(site);
            }
            rdr.Close();
            return all;
        }

        public List<Liaison> ListLiaisons()
        {
            Liaison liaison = new Liaison();
            List<Liaison> all = new List<Liaison>();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM liaison";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                liaison = new Liaison();
                liaison.Id= rdr.GetInt32(0);
                liaison.Nom= rdr.GetString(1);
                all.Add(liaison);
            }
            rdr.Close();
            return all;
        }

        public int getSiteID(string nom)
        {
            if(sites==null)
                sites=ListSites();

            foreach(Site site in sites)
            {
                if (site.Nom.ToLower().Equals(nom.ToLower()))
                    return site.Id;
            }
            return 0;
        }

        public int getLiaisonID(string nom)
        {
            if (liaisons == null)
                liaisons = ListLiaisons();

            foreach (Liaison liaison in liaisons)
            {
                if (liaison.Nom.ToLower().Equals(nom.ToLower()))
                    return liaison.Id;
            }
            return 0;
        }

        public void fillComboBoxLiaison()
        {
            this.comboBoxLiaison.Items.Clear();
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT * FROM liaison";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            ComboboxLiasonItem item;
            while (rdr.Read())
            {
                item = new ComboboxLiasonItem();
                item.nom = rdr.GetString(1);
                item.siteA = rdr.GetInt32(2);
                item.siteB = rdr.GetInt32(3);
                if (rdr.GetString(4) != null)
                    item.configRadio = rdr.GetString(4);
                this.comboBoxLiaison.Items.Add(item);
            }
            rdr.Close();
            endConnection();
        }

        public void CreateDataBase()
        {
            if (File.Exists("myDb.sdf"))
                File.Delete("myDb.sdf");

            string connStr = "Data Source = myDb.sdf; Password = <password>";

            SqlCeEngine engine = new SqlCeEngine(connStr);
            engine.CreateDatabase();
            engine.Dispose();

            SqlCeConnection conn = null;

            try
            {
                conn = new SqlCeConnection(connStr);
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE liaison (idLiaison int,nom ntext, siteA int, siteB int,configRadio ntext)";
                cmd.ExecuteNonQuery();

                SqlCeCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "CREATE TABLE site (idSite int, nom ntext)";
                cmd2.ExecuteNonQuery();

                SqlCeCommand cmd3 = conn.CreateCommand();
                cmd3.CommandText = "CREATE TABLE article (idArticle int, nom ntext, config ntext, type ntext, designation ntext)";
                cmd3.ExecuteNonQuery();

                SqlCeCommand cmd4 = conn.CreateCommand();
                // UC parent (ucParent)- Parent S/N (parentSN) _ UC (UC)
                // Numero de serie (numSerie) _ Code immo (immo)
                cmd4.CommandText = "CREATE TABLE produits (ucParent ntext, parentSN ntext, UC ntext,numSerie ntext, immo ntext)";
                cmd4.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("Base de données vide créée avec succès");
            fillComboBoxLiaison();
        }

        private void beginConnection()
        {
            try
            {
                cn = new SqlCeConnection("Data Source = myDb.sdf; Password = <password>");
                cn.Open();
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show("la connexion à la base de données a échoué :" + ex.Message);

            }
        }

        private void endConnection()
        {
            cn.Close();
        }

        private void comboBoxLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT nom FROM site where idSite = " + (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).siteA;
                SqlCeDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.buttonSiteA.Text = rdr.GetString(0);
                    this.buttonSiteA.Enabled = true;
                }
                cmd.CommandText = "SELECT nom FROM site where idSite =" + (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).siteB;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    this.buttonSiteB.Text = rdr.GetString(0);
                    this.buttonSiteB.Enabled = true;
                }
                rdr.Close();

            }
            catch (Exception) { }
            endConnection();
        }
     
        private List<string> splitString(string stringToSplit)
        {
            char[] characters = stringToSplit.ToCharArray();
            List<string> returnValueList = new List<string>();
            string tempString = "";
            bool blockUntilEndQuote = false;
            int characterCount = 0;
            foreach (char character in characters)
            {
                characterCount = characterCount + 1;

                if (character == '"')
                {
                    if (blockUntilEndQuote == false)
                    {
                        blockUntilEndQuote = true;
                    }
                    else if (blockUntilEndQuote == true)
                    {
                        blockUntilEndQuote = false;
                    }
                }

                if (character != ',')
                {
                    tempString = tempString + character;
                }
                else if (character == ',' && blockUntilEndQuote == true)
                {
                    tempString = tempString + character;
                }
                else
                {
                    tempString = tempString.TrimEnd('"').TrimStart('"');
                    returnValueList.Add(tempString);
                    tempString = "";
                }

                if (characterCount == characters.Length)
                {
                    tempString = tempString.TrimEnd('"').TrimStart('"');
                    //var tmp = tempString.Substring(0, tempString.Length - 1).EndsWith(".") ? tempString.Substring(0, tempString.Length - 3) : tempString;
                    returnValueList.Add(tempString);
                    tempString = "";
                }
            }

            return returnValueList;
        }

        public List<string> listArticleConfig(string config)
        {
            List<string> list = new List<string>();

            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT nom FROM article where config like '%" + config + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                list.Add(rdr.GetString(0));
            }
            rdr.Close();
            endConnection();

            return list;
        }

        public string getUcByImmo(string immo)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            //ucParent parentSN UC numSerie immo

            cmd.CommandText = "SELECT UC FROM produits where immo like '%" + immo + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return rdr.GetString(0);
            }
            rdr.Close();
            endConnection();
            return "";
        }

        public string getUcName(string uc)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT designation FROM article where nom like '%" + uc + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return rdr.GetString(0);
            }
            rdr.Close();
            endConnection();

            return "";
        }
  
        public string getNumSerie(string uc)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT numSerie FROM produits where UC like '%" + uc + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return rdr.GetString(0);
            }
            rdr.Close();
            endConnection();

            return "";
        }
        
        public string getUcParent(string uc)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT ucParent FROM produits where UC like '%" + uc + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return rdr.GetString(0);
            }
            rdr.Close();
            endConnection();

            return "";
        }
        
        public string getparentSN(string uc)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT parentSN FROM produits where UC like '%" + uc + "%'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                return rdr.GetString(0);
            }
            rdr.Close();
            endConnection();

            return "";
        }

        private void menuItemImportProduits_Click(object sender, EventArgs e)
        {
            try 
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "CSV (*.csv)|*.csv";

                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var reader = new StreamReader(File.OpenRead(@"" + openfile1.FileName));
                    List<List<string>> listA = new List<List<string>>();


                    List<string> listVals;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listVals = splitString(line);
                        listA.Add(listVals);
                    }
                    openfile1.Dispose();
                    reader.Close();
                    reader.Dispose();
                    
                    insertProduitsToDB(listA);
                }
            }
            catch { }
        }

        private void menuItemImporterCSV_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "CSV (*.csv)|*.csv";

                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var reader = new StreamReader(File.OpenRead(@"" + openfile1.FileName));
                    List<List<string>> listA = new List<List<string>>();


                    List<string> listVals = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        listVals = splitString(line);

                        listA.Add(listVals);
                    }
                    openfile1.Dispose();
                    reader.Close();
                    reader.Dispose();

                    //editableDataGrid.ColumnHeadersVisible = false;
                    //editableDataGrid.DataSource = CreateDataTable(listVals, listA);
                    insertListToDB(listA);
                    fillComboBoxLiaison();

                }
            }
            catch { }
        }

        private void menuItemRresetDB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vraiment réinitialiser la base de données ?", "Reset database", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CreateDataBase();
                this.buttonSiteA.Text = "Site A";
                this.buttonSiteB.Text = "Site B";
                this.buttonSiteA.Enabled = false;
                this.buttonSiteB.Enabled = false;
            }
        }

        private void buttonSiteA_Click(object sender, EventArgs e)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();

            try
            {
                currentLiaison.Nom = (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).nom;
                currentLiaison.ConfigRadio = (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).configRadio;

                cmd.CommandText = "SELECT * FROM site where idSite = " + (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).siteA;
                SqlCeDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    currentSite_a.Id = rdr.GetInt32(0);
                    currentSite_a.Nom = rdr.GetString(1);
                    currentLiaison.Site_a = new Site(currentSite_a);

                    buttonSiteA.BSite = new Site(currentSite_a);
                    buttonSiteA.BLiaison = new Liaison(currentLiaison);
                }
                rdr.Close();
                endConnection();
            }
            catch (Exception) { }

            var Form = new FormScan(buttonSiteA);
            Form.Show();
        }

        private void buttonSiteB_Click(object sender, EventArgs e)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();

            try
            {
                currentLiaison.Nom = (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).nom;
                currentLiaison.ConfigRadio = (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).configRadio;

                cmd.CommandText = "SELECT * FROM site where idSite =" + (comboBoxLiaison.SelectedItem as ComboboxLiasonItem).siteB;
                SqlCeDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    currentSite_b.Id = rdr.GetInt32(0);
                    currentSite_b.Nom = rdr.GetString(1);
                    currentLiaison.Site_b = new Site(currentSite_b);

                    buttonSiteB.BSite = new Site(currentSite_b);
                    buttonSiteB.BLiaison = new Liaison(currentLiaison);

                    this.buttonSiteB.Text = rdr.GetString(1);
                    this.buttonSiteB.Enabled = true;
                }

                rdr.Close();
                endConnection();
            }
            catch (Exception) { }

            var Form = new FormScan(buttonSiteB);
            Form.Show();
        }

        private void menuItemConfiguration_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "CSV (*.csv)|*.csv";

                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var reader = new StreamReader(File.OpenRead(@"" + openfile1.FileName));
                    List<List<string>> listA = new List<List<string>>();


                    List<string> listVals;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        listVals = splitString(line);
                        listA.Add(listVals);
                    }
                    openfile1.Dispose();
                    reader.Close();
                    reader.Dispose();

                    //editableDataGrid.ColumnHeadersVisible = false;
                    //editableDataGrid.DataSource = CreateDataTable(listVals, listA);
                    insertConfigToDB(listA);
                }
            }
            catch { }
        }

        private void menuItemLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                var form2 = new Login(username);
                form2.Closed += (s, args) => this.Close();
                form2.Show();
                this.Hide();
            }
            
        }


        private void menuItemEditUser_Click(object sender, EventArgs e)
        {
            var Form = new EditUser(role, username);
            Form.Closed += (s, args) => this.Close();
            Form.Show();
            this.Hide();
        }

        private void menuItemAddUser_Click_1(object sender, EventArgs e)
        {
            var Form = new AddUser(role, username);
            Form.Closed += (s, args) => this.Close();
            Form.Show();
            this.Hide();
        }

        private void menuItemEditPass_Click(object sender, EventArgs e)
        {
            var Form = new EditPass(role, username);
            Form.Closed += (s, args) => this.Close();
            Form.Show();
            this.Hide();
        }

        private void menuItemEditAdmin_Click(object sender, EventArgs e)
        {
            var Form = new EditPass(9, "admin");
            Form.Closed += (s, args) => this.Close();
            Form.Show();
            this.Hide();
        }


    }
}
