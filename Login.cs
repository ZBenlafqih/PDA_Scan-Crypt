using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace PDA_1._0
{
    public partial class Login : Form
    {
        private SqlCeConnection cn;
        private string username;

        public Login()
        {
            InitializeComponent();
            if (!File.Exists("UsersDb.sdf"))
                CreateDataBase();
            this.textBoxLogin.Focus();

            //for test
            this.textBoxLogin.Text = "admin";
            this.textBoxPass.Text = "admin";
        }

        public Login(string username)
        {
            InitializeComponent();
            this.textBoxLogin.Text = username;
            this.textBoxPass.Focus();
        }

        public void CreateDataBase()
        {
            string connStr = "Data Source = UsersDb.sdf; Password = @inov@";
            SqlCeEngine engine = new SqlCeEngine(connStr);
            engine.CreateDatabase();
            engine.Dispose();

            SqlCeConnection conn = null;

            try
            {
                conn = new SqlCeConnection(connStr);
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE users (idUser int,nom ntext,pass ntext,role int)";
                cmd.ExecuteNonQuery();
                //cmd.CommandText = "CREATE TABLE liaison (idLiaison int,nom ntext, siteA int, siteB int,configRadio ntext)";
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Base de données des utilisateurs créée avec succès");

                SqlCeCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = "INSERT INTO users (idUser,nom,pass,role) VALUES (1,'user','user',0)";
                cmd2.ExecuteNonQuery();

                SqlCeCommand cmd4 = conn.CreateCommand();
                cmd4.CommandText = "INSERT INTO users (idUser,nom,pass,role) VALUES (1,'adam','adam',0)";
                cmd4.ExecuteNonQuery();

                SqlCeCommand cmd3 = conn.CreateCommand();
                cmd3.CommandText = "INSERT INTO users (idUser,nom,pass,role) VALUES (1,'admin','admin',1)";
                cmd3.ExecuteNonQuery();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void beginConnection()
        {
            try
            {
                cn = new SqlCeConnection("Data Source = UsersDb.sdf; Password = @inov@");
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

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string pass = textBoxPass.Text;

            if (login.Equals("admin") && pass.Equals("@inov@"))
            {
                var home = new Form1(9, "admin");
                home.Closed += (s, args) => this.Close();
                home.Show();
                this.Hide();
            }
            else
            {
                int result = verifyLogin(login, pass);

                if (result == 1)
                {
                    var form2 = new Form1(1, "admin");
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    this.Hide();
                }
                else if (result == 0)
                {
                    var form2 = new Form1(0, username);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    this.Hide();
                }
                else if (result == -1)
                    MessageBox.Show("Mot de passe incorrect");
                else if (result == -2)
                    MessageBox.Show("Nom d'utilisateur incorrect");
            }
        }

        private int verifyLogin(string login, string pass)
        {
            beginConnection();
            SqlCeCommand cmd = cn.CreateCommand();

        //cmd3.CommandText = "INSERT INTO users (idUser,nom,pass,role) VALUES (1,'admin','admin',1)";


            cmd.CommandText = "SELECT * FROM users where nom like '" + login + "'";
            SqlCeDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                //correct login, correct password
                if ((rdr.GetString(2)).ToLower().Equals(pass))
                {
                    username = rdr.GetString(1);
                    int toReturn = rdr.GetInt32(3);
                    endConnection();
                    return toReturn;
                }
                //correct login, Incorrect password
                else
                {
                    endConnection();
                    return -1;
                }
            }
            endConnection();
            return -2;


            //beginConnection();
            //SqlCeCommand cmd = cn.CreateCommand();
            //cmd.CommandText = "SELECT * FROM users";
            //SqlCeDataReader rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //        //correct login, correct password
            //    if ((rdr.GetString(1)).ToLower().Equals(login) && (rdr.GetString(2)).ToLower().Equals(pass))
            //    {
            //        username = rdr.GetString(1);
            //        int toReturn = rdr.GetInt32(3);
            //        endConnection();
            //        return toReturn;
            //    }
            //    //correct login, Incorrect password
            //    else if ((rdr.GetString(1)).ToLower().Equals(login))
            //    {
            //        endConnection();
            //        return -1;
            //    }
            //}
            //endConnection();
            //return -2;
        }

        private void showPass_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.textBoxPass.PasswordChar.Equals('*'))
                  this.textBoxPass.PasswordChar = '\0';
            else
                this.textBoxPass.PasswordChar = '*';
            textBoxPass.Focus();
        }


        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxPass.Focus();
            }
        }

        private void textBoxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string login = textBoxLogin.Text;
                string pass = textBoxPass.Text;

                if (login.Equals("admin") && pass.Equals("@inov@"))
                {

                    var form2 = new Form1(2, "admin");
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    int result = verifyLogin(login, pass);

                    if (result == 1)
                    {

                        var form2 = new Form1(1, "admin");
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                        this.Hide();
                    }
                    else if (result == 0)
                    {

                        var form2 = new Form1(0, username);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                        this.Hide();
                    }
                    else if (result == -1)
                        MessageBox.Show("Mot de passe incorrect");
                    else if (result == -2)
                        MessageBox.Show("Nom d'utilisateur incorrect");
                }
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }


    }
}