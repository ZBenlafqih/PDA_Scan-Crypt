namespace PDA_1._0
{
    partial class EditUser
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
            this.labelListUser = new System.Windows.Forms.Label();
            this.comboBoxListUsers = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.checkBoxNewPass2 = new System.Windows.Forms.CheckBox();
            this.checkBoxNewPass1 = new System.Windows.Forms.CheckBox();
            this.textBoxNewPass2 = new System.Windows.Forms.TextBox();
            this.labelNewPass2 = new System.Windows.Forms.Label();
            this.textBoxNewPass1 = new System.Windows.Forms.TextBox();
            this.labelNewPass1 = new System.Windows.Forms.Label();
            this.buttonDelete = new PDA_1._0.SiteButton();
            this.buttonShowPass = new PDA_1._0.SiteButton();
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
            this.menuItemEditUser.Enabled = false;
            this.menuItemEditUser.Text = "Modifier utilisateur";
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
            // labelListUser
            // 
            this.labelListUser.Location = new System.Drawing.Point(33, 37);
            this.labelListUser.Name = "labelListUser";
            this.labelListUser.Size = new System.Drawing.Size(145, 20);
            this.labelListUser.Text = "Liste des utilisateurs :";
            // 
            // comboBoxListUsers
            // 
            this.comboBoxListUsers.Location = new System.Drawing.Point(33, 60);
            this.comboBoxListUsers.Name = "comboBoxListUsers";
            this.comboBoxListUsers.Size = new System.Drawing.Size(170, 23);
            this.comboBoxListUsers.TabIndex = 1;
            this.comboBoxListUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxListUsers_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(128, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 25);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Enregistrer";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(11, 230);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(98, 25);
            this.buttonRetour.TabIndex = 21;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // checkBoxNewPass2
            // 
            this.checkBoxNewPass2.Enabled = false;
            this.checkBoxNewPass2.Location = new System.Drawing.Point(144, 198);
            this.checkBoxNewPass2.Name = "checkBoxNewPass2";
            this.checkBoxNewPass2.Size = new System.Drawing.Size(87, 20);
            this.checkBoxNewPass2.TabIndex = 20;
            this.checkBoxNewPass2.Text = "Afficher ?";
            this.checkBoxNewPass2.CheckStateChanged += new System.EventHandler(this.checkBoxNewPass2_CheckStateChanged);
            // 
            // checkBoxNewPass1
            // 
            this.checkBoxNewPass1.Enabled = false;
            this.checkBoxNewPass1.Location = new System.Drawing.Point(144, 147);
            this.checkBoxNewPass1.Name = "checkBoxNewPass1";
            this.checkBoxNewPass1.Size = new System.Drawing.Size(87, 20);
            this.checkBoxNewPass1.TabIndex = 19;
            this.checkBoxNewPass1.Text = "Afficher ?";
            this.checkBoxNewPass1.CheckStateChanged += new System.EventHandler(this.checkBoxNewPass1_CheckStateChanged);
            // 
            // textBoxNewPass2
            // 
            this.textBoxNewPass2.Enabled = false;
            this.textBoxNewPass2.Location = new System.Drawing.Point(11, 195);
            this.textBoxNewPass2.Name = "textBoxNewPass2";
            this.textBoxNewPass2.PasswordChar = '*';
            this.textBoxNewPass2.Size = new System.Drawing.Size(130, 23);
            this.textBoxNewPass2.TabIndex = 18;
            // 
            // labelNewPass2
            // 
            this.labelNewPass2.Location = new System.Drawing.Point(11, 176);
            this.labelNewPass2.Name = "labelNewPass2";
            this.labelNewPass2.Size = new System.Drawing.Size(226, 20);
            this.labelNewPass2.Text = "Re-Entrer le nouveau mot de passe :";
            // 
            // textBoxNewPass1
            // 
            this.textBoxNewPass1.Enabled = false;
            this.textBoxNewPass1.Location = new System.Drawing.Point(11, 144);
            this.textBoxNewPass1.Name = "textBoxNewPass1";
            this.textBoxNewPass1.PasswordChar = '*';
            this.textBoxNewPass1.Size = new System.Drawing.Size(130, 23);
            this.textBoxNewPass1.TabIndex = 17;
            // 
            // labelNewPass1
            // 
            this.labelNewPass1.Location = new System.Drawing.Point(11, 125);
            this.labelNewPass1.Name = "labelNewPass1";
            this.labelNewPass1.Size = new System.Drawing.Size(215, 20);
            this.labelNewPass1.Text = "Entrer le nouveau mot de passe :";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.buttonDelete.Location = new System.Drawing.Point(120, 89);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowPass
            // 
            this.buttonShowPass.Enabled = false;
            this.buttonShowPass.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.buttonShowPass.Location = new System.Drawing.Point(11, 89);
            this.buttonShowPass.Name = "buttonShowPass";
            this.buttonShowPass.Size = new System.Drawing.Size(106, 23);
            this.buttonShowPass.TabIndex = 12;
            this.buttonShowPass.Text = "Afficher Pass";
            this.buttonShowPass.Click += new System.EventHandler(this.buttonShowPass_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.checkBoxNewPass2);
            this.Controls.Add(this.checkBoxNewPass1);
            this.Controls.Add(this.textBoxNewPass2);
            this.Controls.Add(this.labelNewPass2);
            this.Controls.Add(this.textBoxNewPass1);
            this.Controls.Add(this.labelNewPass1);
            this.Controls.Add(this.buttonShowPass);
            this.Controls.Add(this.labelListUser);
            this.Controls.Add(this.comboBoxListUsers);
            this.Menu = this.mainMenu1;
            this.Name = "EditUser";
            this.Text = "Modifier un utilisateur";
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
        private System.Windows.Forms.Label labelListUser;
        private System.Windows.Forms.ComboBox comboBoxListUsers;
        private SiteButton buttonShowPass;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.CheckBox checkBoxNewPass2;
        private System.Windows.Forms.CheckBox checkBoxNewPass1;
        private System.Windows.Forms.TextBox textBoxNewPass2;
        private System.Windows.Forms.Label labelNewPass2;
        private System.Windows.Forms.TextBox textBoxNewPass1;
        private System.Windows.Forms.Label labelNewPass1;
        private SiteButton buttonDelete;

    }
}