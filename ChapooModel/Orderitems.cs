using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Orderitems
    {
        public int orderNummer;
        public int aantal;
        public Menuitems menuItem;
        public bool gereed;
        public DateTime time;

        public decimal TotalPrice 
        {
            get { return menuItem.prijs * aantal; }
        }
    }
}
