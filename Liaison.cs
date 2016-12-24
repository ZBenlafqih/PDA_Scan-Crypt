using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PDA_1._0
{
    public class Liaison
    {
        private int id;
        private string nom;
        private Site site_a;
        private Site site_b;
        private string configRadio;

        public Liaison(Liaison l)
        {
            this.nom = l.Nom;
            this.configRadio = l.configRadio;
            this.site_a = new Site(l.Site_a);
            this.site_b = new Site(l.Site_b);

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Liaison()
        {
            this.site_a = new Site();
            this.site_b = new Site();
        }

        public Site Site_a
        {
            get { return site_a; }
            set { site_a = value; }
        }

        public Site Site_b
        {
            get { return site_b; }
            set { site_b = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string ConfigRadio
        {
            get { return configRadio; }
            set { configRadio = value; }
        }
    }
}
