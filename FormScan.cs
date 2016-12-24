using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDA_1._0
{
    public partial class FormScan : Form
    {
        private SiteButton original = new SiteButton();
        private List<string> articles = new List<string>();
        private int nombreArticles = 0;
        public FormScan(SiteButton sb)
        {
            InitializeComponent();
            original = new SiteButton(sb);
            original.BSite = new Site(sb.BSite);
            original.BLiaison = new Liaison(sb.BLiaison);

            this.labelSite.Text = original.BSite.Nom;
            this.labelLiaison.Text = original.BLiaison.Nom;
            
        }

        public FormScan()
        {
            InitializeComponent();
        }

        private void textBoxArticle_EnterButton(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (!articleExist(this.textBoxArticle.Text))
                {
                    this.labelExist.Visible = false;
                    this.labelArticle.Text = this.textBoxArticle.Text;
                    articles.Add(this.textBoxArticle.Text);
                    nombreArticles++;
                    this.labelNombre.Text = nombreArticles.ToString();
                }
                else
                {
                    this.labelExist.ForeColor = Color.Red;
                    this.labelExist.Visible = true;
                }
                this.textBoxArticle.Text = "";
                this.textBoxArticle.Focus(); 
            }
        }


        private Boolean articleExist(string article)
        {
            foreach (string a in articles)
            {
                if(a.ToLower().Equals(article.ToLower()))
                    return true;
            }
            return false;
        }

        private void buttonTerminer_Click(object sender, EventArgs e)
        {
            var Form = new FormValidate(articles, this.textBoxArticle, original.BLiaison.ConfigRadio, original.BLiaison.Nom, original.BSite.Nom);
            Form.Show();
        }
   }
}