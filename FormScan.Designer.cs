namespace PDA_1._0
{
    partial class FormScan
    {
        // <summary>
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
            this.labelScanner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitreLiaison = new System.Windows.Forms.Label();
            this.labelTitreSite = new System.Windows.Forms.Label();
            this.labelSite = new System.Windows.Forms.Label();
            this.labelLiaison = new System.Windows.Forms.Label();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.labelVousAv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTerminer = new System.Windows.Forms.Button();
            this.labelDernier = new System.Windows.Forms.Label();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelExist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScanner
            // 
            this.labelScanner.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelScanner.Location = new System.Drawing.Point(41, 9);
            this.labelScanner.Name = "labelScanner";
            this.labelScanner.Size = new System.Drawing.Size(154, 28);
            this.labelScanner.Text = "Scanner les codes";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.Text = "________________";
            // 
            // labelTitreLiaison
            // 
            this.labelTitreLiaison.Location = new System.Drawing.Point(13, 61);
            this.labelTitreLiaison.Name = "labelTitreLiaison";
            this.labelTitreLiaison.Size = new System.Drawing.Size(57, 20);
            this.labelTitreLiaison.Text = "Liaison : ";
            // 
            // labelTitreSite
            // 
            this.labelTitreSite.Location = new System.Drawing.Point(13, 85);
            this.labelTitreSite.Name = "labelTitreSite";
            this.labelTitreSite.Size = new System.Drawing.Size(57, 20);
            this.labelTitreSite.Text = "Site : ";
            // 
            // labelSite
            // 
            this.labelSite.Location = new System.Drawing.Point(73, 85);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(165, 20);
            // 
            // labelLiaison
            // 
            this.labelLiaison.Location = new System.Drawing.Point(73, 61);
            this.labelLiaison.Name = "labelLiaison";
            this.labelLiaison.Size = new System.Drawing.Size(165, 20);
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(12, 111);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(209, 23);
            this.textBoxArticle.TabIndex = 6;
            this.textBoxArticle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxArticle_EnterButton);
            // 
            // labelVousAv
            // 
            this.labelVousAv.Location = new System.Drawing.Point(21, 197);
            this.labelVousAv.Name = "labelVousAv";
            this.labelVousAv.Size = new System.Drawing.Size(114, 20);
            this.labelVousAv.Text = "Vous avez scanné";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(163, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.Text = "articles";
            // 
            // labelNombre
            // 
            this.labelNombre.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelNombre.Location = new System.Drawing.Point(137, 197);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(40, 20);
            this.labelNombre.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(65, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.Text = "des articles";
            // 
            // buttonTerminer
            // 
            this.buttonTerminer.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.buttonTerminer.Location = new System.Drawing.Point(62, 222);
            this.buttonTerminer.Name = "buttonTerminer";
            this.buttonTerminer.Size = new System.Drawing.Size(108, 38);
            this.buttonTerminer.TabIndex = 16;
            this.buttonTerminer.Text = "Terminer";
            this.buttonTerminer.Click += new System.EventHandler(this.buttonTerminer_Click);
            // 
            // labelDernier
            // 
            this.labelDernier.Location = new System.Drawing.Point(2, 153);
            this.labelDernier.Name = "labelDernier";
            this.labelDernier.Size = new System.Drawing.Size(148, 20);
            this.labelDernier.Text = "Dernier article scanné:";
            // 
            // labelArticle
            // 
            this.labelArticle.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Underline);
            this.labelArticle.Location = new System.Drawing.Point(3, 173);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(235, 20);
            // 
            // labelExist
            // 
            this.labelExist.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.labelExist.Location = new System.Drawing.Point(134, 155);
            this.labelExist.Name = "labelExist";
            this.labelExist.Size = new System.Drawing.Size(104, 20);
            this.labelExist.Text = "(Article déjà scanné)";
            this.labelExist.Visible = false;
            // 
            // FormScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.labelExist);
            this.Controls.Add(this.labelArticle);
            this.Controls.Add(this.labelDernier);
            this.Controls.Add(this.buttonTerminer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelVousAv);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.labelLiaison);
            this.Controls.Add(this.labelSite);
            this.Controls.Add(this.labelTitreSite);
            this.Controls.Add(this.labelTitreLiaison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScanner);
            this.Name = "FormScan";
            this.Text = "Intratel - Scan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelScanner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitreLiaison;
        private System.Windows.Forms.Label labelTitreSite;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Label labelLiaison;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Label labelVousAv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTerminer;
        private System.Windows.Forms.Label labelDernier;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelExist;


    }
}