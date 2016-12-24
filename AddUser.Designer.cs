namespace PDA_1._0
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItemImporter = new System.Windows.Forms.MenuItem();
            this.menuItemImporterCSV = new System.Windows.Forms.MenuItem();
            this.menuItemConfiguration = new System.Windows.Forms.MenuItem();
            this.menuItemImportProduits = new System.Windows.Forms.MenuItem();
            this.menuItemDataBase = new System.Windows.Forms.MenuItem();
            this.menuItemRresetDB = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemEditPass = new System.Windows.Forms.MenuItem();
            this.menuItemEditUser = new System.Windows.Forms.MenuItem();
            this.menuItemAddUser = new System.Windows.Forms.MenuItem();
            this.menuItemLogout = new System.Windows.Forms.MenuItem();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemImporter);
            this.mainMenu1.MenuItems.Add(this.menuItemDataBase);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItemLogout);
            // 
            // menuItemImporter
            // 
            this.menuItemImporter.MenuItems.Add(this.menuItemImporterCSV);
            this.menuItemImporter.MenuItems.Add(this.menuItemConfiguration);
            this.menuItemImporter.MenuItems.Add(this.menuItemImportProduits);
            this.menuItemImporter.Text = "Importer";
            // 
            // menuItemImporterCSV
            // 
            this.menuItemImporterCSV.Text = "Importer données de base";
            this.menuItemImporterCSV.Click += new System.EventHandler(this.menuItemImporterCSV_Click);
            // 
            // menuItemConfiguration
            // 
            this.menuItemConfiguration.Text = "Importer Configuration";
            this.menuItemConfiguration.Click += new System.EventHandler(this.menuItemConfiguration_Click);
            // 
            // menuItemImportProduits
            // 
            this.menuItemImportProduits.Text = "Importer Produits";
            this.menuItemImportProduits.Click += new System.EventHandler(this.menuItemImportProduits_Click);
            // 
            // menuItemDataBase
            // 
            this.menuItemDataBase.MenuItems.Add(this.menuItemRresetDB);
            this.menuItemDataBase.Text = "BDD";
            // 
            // menuItemRresetDB
            // 
            this.menuItemRresetDB.Text = "Reset BDD";
            this.menuItemRresetDB.Click += new System.EventHandler(this.menuItemRresetDB_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItemEditPass);
            this.menuItem1.MenuItems.Add(this.menuItemEditUser);
            this.menuItem1.MenuItems.Add(this.menuItemAddUser);
            this.menuItem1.Text = "Compte";
            // 
            // menuItemEditPass
            // 
            this.menuItemEditPass.Text = "Modifier password";
            this.menuItemEditPass.Click += new System.EventHandler(this.menuItemEditPass_Click);
            // 
            // menuItemEditUser
            // 
            this.menuItemEditUser.Text = "Modifier utilisateur";
            this.menuItemEditUser.Click += new System.EventHandler(this.menuItemEditUser_Click);
            // 
            // menuItemAddUser
            // 
            this.menuItemAddUser.Text = "Ajouter utilisateur";
            this.menuItemAddUser.Click += new System.EventHandler(this.menuItemAddUser_Click);
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Text = "Log out";
            this.menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);
            // 
            // showPass
            // 
            this.showPass.Location = new System.Drawing.Point(147, 142);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(88, 20);
            this.showPass.TabIndex = 18;
            this.showPass.Text = "Afficher ?";
            this.showPass.CheckStateChanged += new System.EventHandler(this.showPass_CheckStateChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(14, 139);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(127, 23);
            this.textBoxPass.TabIndex = 17;
            this.textBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyDown);
            // 
            // labelPass
            // 
            this.labelPass.Location = new System.Drawing.Point(14, 119);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(100, 17);
            this.labelPass.Text = "Mot de passe :";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(14, 90);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(201, 23);
            this.textBoxLogin.TabIndex = 16;
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLogin_KeyDown);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(128, 229);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(87, 30);
            this.buttonAjouter.TabIndex = 15;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Location = new System.Drawing.Point(14, 70);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(127, 17);
            this.labelLogin.Text = "Nom d\'utilisateur :";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(24, 229);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(87, 30);
            this.buttonRetour.TabIndex = 21;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.labelConnect.Location = new System.Drawing.Point(11, 35);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(218, 26);
            this.labelConnect.Text = "Ajouter un utilisateur";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(147, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Afficher ?";
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Location = new System.Drawing.Point(14, 191);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.PasswordChar = '*';
            this.textBoxPass2.Size = new System.Drawing.Size(127, 23);
            this.textBoxPass2.TabIndex = 25;
            this.textBoxPass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPass2_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.Text = "Re-entrer le mot de passe :";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.labelLogin);
            this.Menu = this.mainMenu1;
            this.Name = "AddUser";
            this.Text = "Ajouter un utilisateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemImporter;
        private System.Windows.Forms.MenuItem menuItemImporterCSV;
        private System.Windows.Forms.MenuItem menuItemDataBase;
        private System.Windows.Forms.MenuItem menuItemRresetDB;
        private System.Windows.Forms.MenuItem menuItemImportProduits;
        private System.Windows.Forms.MenuItem menuItemLogout;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemEditPass;
        private System.Windows.Forms.MenuItem menuItemEditUser;
        private System.Windows.Forms.MenuItem menuItemAddUser;
        private System.Windows.Forms.MenuItem menuItemConfiguration;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Label label1;

    }
}