namespace PDA_1._0
{
    partial class EditPass
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
            this.labelNomDutils = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.labelNewPass1 = new System.Windows.Forms.Label();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.labelNewPass2 = new System.Windows.Forms.Label();
            this.checkBoxOldPass = new System.Windows.Forms.CheckBox();
            this.checkBoxNewPass1 = new System.Windows.Forms.CheckBox();
            this.checkBoxNewPass2 = new System.Windows.Forms.CheckBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAlert = new System.Windows.Forms.Label();
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
            this.menuItemEditPass.Enabled = false;
            this.menuItemEditPass.Text = "Modifier password";
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
            // labelNomDutils
            // 
            this.labelNomDutils.Location = new System.Drawing.Point(12, 36);
            this.labelNomDutils.Name = "labelNomDutils";
            this.labelNomDutils.Size = new System.Drawing.Size(121, 20);
            this.labelNomDutils.Text = "Nom d\'utilisateur :";
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelUsername.Location = new System.Drawing.Point(129, 36);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 20);
            // 
            // labelOldPass
            // 
            this.labelOldPass.Location = new System.Drawing.Point(12, 65);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(196, 20);
            this.labelOldPass.Text = "Entrer l\'encien mot de passe :";
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Location = new System.Drawing.Point(12, 88);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(130, 23);
            this.textBoxOldPass.TabIndex = 3;
            this.textBoxOldPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOldPass_KeyDown);
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Location = new System.Drawing.Point(12, 145);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.PasswordChar = '*';
            this.textBoxNewPass1.Size = new System.Drawing.Size(130, 23);
            this.textBoxNewPass1.TabIndex = 5;
            this.textBoxNewPass1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewPass1_KeyDown);
            // 
            // labelNewPass1
            // 
            this.labelNewPass1.Location = new System.Drawing.Point(12, 122);
            this.labelNewPass1.Name = "labelNewPass1";
            this.labelNewPass1.Size = new System.Drawing.Size(215, 20);
            this.labelNewPass1.Text = "Entrer le nouveau mot de passe :";
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Location = new System.Drawing.Point(12, 203);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.PasswordChar = '*';
            this.textBoxNewPass2.Size = new System.Drawing.Size(130, 23);
            this.textBoxNewPass2.TabIndex = 8;
            this.textBoxNewPass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewPass2_KeyDown);
            // 
            // labelNewPass2
            // 
            this.labelNewPass2.Location = new System.Drawing.Point(12, 180);
            this.labelNewPass2.Name = "labelNewPass2";
            this.labelNewPass2.Size = new System.Drawing.Size(226, 20);
            this.labelNewPass2.Text = "Re-Entrer le nouveau mot de passe :";
            // 
            // checkBoxOldPass
            // 
            this.checkBoxOldPass.Location = new System.Drawing.Point(145, 90);
            this.checkBoxOldPass.Name = "checkBoxOldPass";
            this.checkBoxOldPass.Size = new System.Drawing.Size(87, 20);
            this.checkBoxOldPass.TabIndex = 10;
            this.checkBoxOldPass.Text = "Afficher ?";
            this.checkBoxOldPass.CheckStateChanged += new System.EventHandler(this.checkBoxOldPass_CheckStateChanged);
            // 
            // checkBoxNewPass1
            // 
            this.checkBoxNewPass1.Location = new System.Drawing.Point(145, 148);
            this.checkBoxNewPass1.Name = "checkBoxNewPass1";
            this.checkBoxNewPass1.Size = new System.Drawing.Size(87, 20);
            this.checkBoxNewPass1.TabIndex = 11;
            this.checkBoxNewPass1.Text = "Afficher ?";
            this.checkBoxNewPass1.CheckStateChanged += new System.EventHandler(this.checkBoxNewPass1_CheckStateChanged);
            // 
            // checkBoxNewPass2
            // 
            this.checkBoxNewPass2.Location = new System.Drawing.Point(145, 206);
            this.checkBoxNewPass2.Name = "checkBoxNewPass2";
            this.checkBoxNewPass2.Size = new System.Drawing.Size(87, 20);
            this.checkBoxNewPass2.TabIndex = 12;
            this.checkBoxNewPass2.Text = "Afficher ?";
            this.checkBoxNewPass2.CheckStateChanged += new System.EventHandler(this.checkBoxNewPass2_CheckStateChanged);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(12, 238);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(98, 25);
            this.buttonRetour.TabIndex = 13;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(129, 238);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 25);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelAlert
            // 
            this.labelAlert.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelAlert.Location = new System.Drawing.Point(22, 56);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(205, 66);
            this.labelAlert.Text = "vous allez changer le mot de passe de l\'administrateur";
            this.labelAlert.Visible = false;
            // 
            // EditPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.checkBoxNewPass2);
            this.Controls.Add(this.checkBoxNewPass1);
            this.Controls.Add(this.checkBoxOldPass);
            this.Controls.Add(this.textBoxNewPass2);
            this.Controls.Add(this.labelNewPass2);
            this.Controls.Add(this.textBoxNewPass1);
            this.Controls.Add(this.labelNewPass1);
            this.Controls.Add(this.textBoxOldPass);
            this.Controls.Add(this.labelOldPass);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelNomDutils);
            this.Menu = this.mainMenu1;
            this.Name = "EditPass";
            this.Text = "Modifier mot de passe";
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
        private System.Windows.Forms.Label labelNomDutils;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass1;
        private System.Windows.Forms.Label labelNewPass1;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.Label labelNewPass2;
        private System.Windows.Forms.CheckBox checkBoxOldPass;
        private System.Windows.Forms.CheckBox checkBoxNewPass1;
        private System.Windows.Forms.CheckBox checkBoxNewPass2;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelAlert;

    }
}