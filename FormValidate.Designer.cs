namespace PDA_1._0
{
    partial class FormValidate
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
            this.labelScanes = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelScanner
            // 
            this.labelScanner.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelScanner.Location = new System.Drawing.Point(45, 9);
            this.labelScanner.Name = "labelScanner";
            this.labelScanner.Size = new System.Drawing.Size(154, 28);
            this.labelScanner.Text = "Liste des articles";
            // 
            // labelScanes
            // 
            this.labelScanes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelScanes.Location = new System.Drawing.Point(77, 35);
            this.labelScanes.Name = "labelScanes";
            this.labelScanes.Size = new System.Drawing.Size(108, 28);
            this.labelScanes.Text = "scannés";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 63);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(232, 138);
            this.dataGrid1.TabIndex = 29;
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            this.dataGrid1.DoubleClick += new System.EventHandler(this.dataGrid1_DoubleClick);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Continuer le scan";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Terminer";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormValidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.labelScanes);
            this.Controls.Add(this.labelScanner);
            this.Name = "FormValidate";
            this.Text = "Intratel - Validation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelScanner;
        private System.Windows.Forms.Label labelScanes;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }

}