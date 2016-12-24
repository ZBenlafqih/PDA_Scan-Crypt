using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PDA_1._0
{
    class ComboboxLiasonItem
    {
        public string nom { get; set; }
        public int siteA { get; set; }
        public int siteB { get; set; }
        public string configRadio { get; set; }

        public override string ToString()
        {
            return nom;
        }
    }
}
