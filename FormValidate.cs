using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PDA_1._0
{
    public partial class FormValidate : Form
    {
        //to set focus if return to scan
        private TextBox scanTextBox;
        private string nomLiaison;
        private string nomSite;
        private List<codeImmoUc> listeImmoUc = new List<codeImmoUc>();
        private List<ImmoIndex> listeImmoIndex = new List<ImmoIndex>();
        
        public FormValidate(List<string> articles,TextBox scanTextBox,
            string originalConfig, string liaison, string site)
        {

            fillListImmoUc(articles);

            nomSite = site;
            nomLiaison = liaison;

            string configuration = originalConfig.Substring(0, originalConfig.Length - 1)
                .EndsWith(".") ? originalConfig.Substring(0, originalConfig.Length - 3)
                : originalConfig;


            List<string> articlesBdd;
            InitializeComponent();
            this.scanTextBox = scanTextBox;

            Form1 f = new Form1("");
            //string config = f.getLiaisonConfig();

            articlesBdd = f.listArticleConfig(configuration);

            List<List<string>> listA = new List<List<string>>();
            List<string> listVals = new List<string>();
            int index = 0;
            ImmoIndex ii ;
            foreach (string article in articlesBdd)
            {
                listVals = new List<string>();
                listVals.Add(article);
                if (verifArticle(article, articles)!=null)
                {
                    ii = new ImmoIndex();
                    ii.ImmoCode = verifArticle(article, articles);
                    ii.Index = index;
                    listeImmoIndex.Add(ii);
                    listVals.Add("ok");
                }
                else
                    listVals.Add("Non ok");
                listA.Add(listVals);
                index++;
            }
          
            //this.dataGrid1.ColumnHeadersVisible = false;
            
            this.dataGrid1.DataSource = CreateDataTable(listVals, listA);
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "articlesTable";
            DataGridTextBoxColumn column1 = new DataGridTextBoxColumn();
            column1.MappingName = "Article";
            column1.HeaderText = "Article";
            column1.Width = 152;
            ts.GridColumnStyles.Add(column1);
            DataGridTextBoxColumn column2 = new DataGridTextBoxColumn();
            column2.MappingName = "Etat";
            column2.HeaderText = "Etat";
            column2.Width = 45;
            ts.GridColumnStyles.Add(column2);
            this.dataGrid1.TableStyles.Add(ts);
            colorDatagrid();
            //this.dataGrid1.CurrentCell = null;
            this.button2.Focus();
        }

        private void fillListImmoUc(List<string> articles)
        {
            Form1 f = new Form1("");
            codeImmoUc ciu;
            foreach (string article in articles)
            {
                ciu = new codeImmoUc();
                ciu.Immo = article;
                ciu.Uc = f.getUcByImmo(article);
                listeImmoUc.Add(ciu);
            }
        }

        private System.Data.DataTable CreateDataTable(List<string> columnDefinitions,
            List<List<string>> rows)
        {
            DataTable table = new DataTable("articlesTable");
            table.Columns.Add(new DataColumn("Article"));
            table.Columns.Add(new DataColumn("Etat"));

            foreach (List<string> rowData in rows)
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < rowData.Count; i++)
                    row[i] = rowData[i];
                table.Rows.Add(row);
            }
            return table;
        }

        public void colorDatagrid()
        {
            DataTable dataTable = (DataTable)dataGrid1.DataSource;
            int index1 = -1;
            DataGridTableStyle ts = new DataGridTableStyle();
            foreach (DataRow dr in dataTable.Rows)
            {
                index1++;
                if (dr[1].ToString() == "Non ok")
                {
                    dataGrid1.Select(index1);
                    dataGrid1.SelectionBackColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            scanTextBox.Focus();
        }

        private string verifArticle(string article, List<string> articles)
        {
            string articleUc;

            foreach (string artc in articles)
            {
                articleUc = getuc(artc);
                if (article.ToLower().Equals(articleUc.ToLower()))
                    return artc;
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = nomLiaison;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = ((sfd.FileName).Substring(0,(sfd.FileName)
                    .Length - (Path.GetFileName(sfd.FileName)).Length))
                      + nomLiaison +".csv";
                //MessageBox.Show(Path.GetFileName(sfd.FileName));
                //CsvFpath += filename;
                MessageBox.Show("Fichier créé avec succès");
                if (File.Exists(path))
                {
                    try
                    {
                        File.Delete(path);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Erreur de création.\n" + ex.Message);
                    }
                }
                string Fpath = @"" + path;

                Encoding ecd = System.Text.Encoding.GetEncoding(1252);
                StreamWriter swFile = new StreamWriter(Fpath, true, ecd);
                
                Form1 f = new Form1("");
              
                

                DataTable dt;
                dt = (DataTable)dataGrid1.DataSource;
                int maxIx = dt.Rows.Count;
                int maxIy = dt.Columns.Count;

                string uc;
                string nom;
                string numSerie;
                string etat;
                string immo;
                string liaison = nomLiaison;
                string site = nomSite;
                string ucParent;
                string parentSN;

                swFile.Write("UC,Nom,Numero de serie,Etat,Code immo,Liaison,Site,UC parent,Parent S/N\n");

                for (int i = 0; i < maxIx; i++)
                {
                    uc = (string)dataGrid1[i, 0];
                    nom = f.getUcName(uc);
                    numSerie = f.getNumSerie(uc);
                    etat = (string)dataGrid1[i, 1];
                    if (etat.ToLower().Equals("ok"))
                        immo = getImmoByIndex(i);
                    else 
                        immo = "Non scanné";
                    ucParent = f.getUcParent(uc);
                    parentSN = f.getparentSN(uc);

                    swFile.Write(uc);
                    swFile.Write(",");
                    swFile.Write("\"" + nom + "\"");
                    swFile.Write(",");
                    swFile.Write(numSerie);
                    swFile.Write(",");
                    swFile.Write(etat);
                    swFile.Write(",");
                    swFile.Write("\"" + immo + "\"");
                    swFile.Write(",");
                    swFile.Write("\"" + liaison + "\"");
                    swFile.Write(",");
                    swFile.Write(site);
                    swFile.Write(",");
                    swFile.Write(ucParent);
                    swFile.Write(",");
                    swFile.Write(parentSN);
                    swFile.Write("\n");
                }

                
                swFile.Flush();
                swFile.Close();
                swFile.Dispose();

                RijndaelManagedEncryption.EncryptFile(Fpath, Fpath.Substring(0, Fpath.Length - 4) + ".crypt", "airakaza");

                //CSEncryptDecrypt.EncryptFile(Fpath, Fpath + ".crypt", "airakaza");

                //try
                //{
                //    File.Delete(CsvFpath);
                //}
                //catch (IOException ex)
                //{
                //    MessageBox.Show("Erreur de supression du"
                //        +" fichier non crypté.\n" + ex.Message);
                //}
            }
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            colorDatagrid();
        }

        private void dataGrid1_Click(object sender, EventArgs e)
        {
            colorDatagrid();
            this.button2.Focus();
        }

        private void dataGrid1_DoubleClick(object sender, System.EventArgs e)
        {
            Form1 f = new Form1("");
            DataGridCell editCell = dataGrid1.CurrentCell;

            string uc = (string)dataGrid1[editCell.RowNumber, 0];
            string designation = f.getUcName(uc);
            string immo;
            if (((string)dataGrid1[editCell.RowNumber, 1]).ToLower().Equals("ok"))
            {
                immo = getImmoByIndex(editCell.RowNumber);
                MessageBox.Show("UC : " + uc +
                    "\n___________________\n" +
                    "\nNom : " + designation +
                    "\n___________________\n" +
                    "\nCode immo : " + immo);
            }
            else
            {
                MessageBox.Show("UC : " + uc +
                    "\n___________________\n" +
                    "\nNom : " + designation);
            }
            this.button2.Focus();
        }

        private string getImmoByIndex(int index)
        {
            foreach (ImmoIndex ii in listeImmoIndex)
            {
                if (ii.Index == index)
                    return ii.ImmoCode;
            }
            return "";
        }

        private string getuc(string immo)
        {
            foreach (codeImmoUc ciu in listeImmoUc)
            {
                if (ciu.Immo.ToLower().Equals(immo.ToLower()))
                    return ciu.Uc;
            }
            return "";
        }

        
    }
}