using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PDA_1._0
{
    public class Site
    {
        private int id;
        private string nom;

        public Site(Site s)
        {
            this.id = s.Id;
            this.nom = s.Nom;
        }

        public Site()
        {
            
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
    }
}
