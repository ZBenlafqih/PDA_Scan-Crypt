namespace PDA_1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxLiaison = new System.Windows.Forms.ComboBox();
            this.labelLiaison = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
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
            this.buttonSiteB = new PDA_1._0.SiteButton();
            this.buttonSiteA = new PDA_1._0.SiteButton();
            this.liaison1 = new PDA_1._0.Liaison();
            this.site1 = new PDA_1._0.Site();
            this.site2 = new PDA_1._0.Site();
            this.site3 = new PDA_1._0.Site();
            this.liaison2 = new PDA_1._0.Liaison();
            this.site4 = new PDA_1._0.Site();
            this.site5 = new PDA_1._0.Site();
            this.site6 = new PDA_1._0.Site();
            this.SuspendLayout();
            // 
            // comboBoxLiaison
            // 
            this.comboBoxLiaison.Location = new System.Drawing.Point(35, 69);
            this.comboBoxLiaison.Name = "comboBoxLiaison";
            this.comboBoxLiaison.Size = new System.Drawing.Size(170, 23);
            this.comboBoxLiaison.TabIndex = 0;
            this.comboBoxLiaison.SelectedIndexChanged += new System.EventHandler(this.comboBoxLiaison_SelectedIndexChanged);
            // 
            // labelLiaison
            // 
            this.labelLiaison.Location = new System.Drawing.Point(35, 46);
            this.labelLiaison.Name = "labelLiaison";
            this.labelLiaison.Size = new System.Drawing.Size(100, 20);
            this.labelLiaison.Text = "Liaison :";
            // 
            // labelSite
            // 
            this.labelSite.Location = new System.Drawing.Point(35, 114);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(100, 20);
            this.labelSite.Text = "Site :";
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
            this.menuItemAddUser.Click += new System.EventHandler(this.menuItemAddUser_Click_1);
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Text = "Log out";
            this.menuItemLogout.Click += new System.EventHandler(this.menuItemLogout_Click);
            // 
            // buttonSiteB
            // 
            this.buttonSiteB.Enabled = false;
            this.buttonSiteB.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.buttonSiteB.Location = new System.Drawing.Point(35, 198);
            this.buttonSiteB.Name = "buttonSiteB";
            this.buttonSiteB.Size = new System.Drawing.Size(170, 43);
            this.buttonSiteB.TabIndex = 12;
            this.buttonSiteB.Text = "Site B";
            this.buttonSiteB.Click += new System.EventHandler(this.buttonSiteB_Click);
            // 
            // buttonSiteA
            // 
            this.buttonSiteA.Enabled = false;
            this.buttonSiteA.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.buttonSiteA.Location = new System.Drawing.Point(35, 137);
            this.buttonSiteA.Name = "buttonSiteA";
            this.buttonSiteA.Size = new System.Drawing.Size(170, 43);
            this.buttonSiteA.TabIndex = 11;
            this.buttonSiteA.Text = "Site A";
            this.buttonSiteA.Click += new System.EventHandler(this.buttonSiteA_Click);
            // 
            // liaison1
            // 
            this.liaison1.ConfigRadio = null;
            this.liaison1.Nom = null;
            // 
            // site1
            // 
            this.site1.Id = 0;
            this.site1.Nom = null;
            // 
            // site2
            // 
            this.site2.Id = 0;
            this.site2.Nom = null;
            // 
            // site3
            // 
            this.site3.Id = 0;
            this.site3.Nom = null;
            // 
            // liaison2
            // 
            this.liaison2.ConfigRadio = null;
            this.liaison2.Nom = null;
            // 
            // site4
            // 
            this.site4.Id = 0;
            this.site4.Nom = null;
            // 
            // site5
            // 
            this.site5.Id = 0;
            this.site5.Nom = null;
            // 
            // site6
            // 
            this.site6.Id = 0;
            this.site6.Nom = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.buttonSiteB);
            this.Controls.Add(this.buttonSiteA);
            this.Controls.Add(this.labelSite);
            this.Controls.Add(this.labelLiaison);
            this.Controls.Add(this.comboBoxLiaison);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Intratel - Liaisons et Sites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLiaison;
        private System.Windows.Forms.Label labelLiaison;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemImporter;
        private System.Windows.Forms.MenuItem menuItemImporterCSV;
        private System.Windows.Forms.MenuItem menuItemDataBase;
        private System.Windows.Forms.MenuItem menuItemRresetDB;
        private SiteButton buttonSiteA;
        private SiteButton buttonSiteB;
        private System.Windows.Forms.MenuItem menuItemConfiguration;
        private Liaison liaison1;
        private Site site1;
        private Site site2;
        private Site site3;
        private Liaison liaison2;
        private Site site4;
        private Site site5;
        private Site site6;
        private System.Windows.Forms.MenuItem menuItemImportProduits;
        private System.Windows.Forms.MenuItem menuItemLogout;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemEditPass;
        private System.Windows.Forms.MenuItem menuItemEditUser;
        private System.Windows.Forms.MenuItem menuItemAddUser;

    }
}

