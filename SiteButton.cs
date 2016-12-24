using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace PDA_1._0
{
    public class SiteButton : Button
    {
        private Liaison bLiaison;
        private Site bSite;

        public SiteButton(SiteButton sb)
        {
            this.bLiaison = new Liaison(sb.BLiaison);
            this.bSite = new Site(sb.BSite);
        }

        public SiteButton()
        {
            this.bLiaison = new Liaison();
            this.bSite = new Site();
        }

        public Liaison BLiaison
        {
            get { return bLiaison; }
            set { bLiaison = value; }
        }

        public Site BSite
        {
            get { return bSite; }
            set { bSite = value; }
        }
    }
}
