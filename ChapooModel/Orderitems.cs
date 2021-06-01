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
        public int itemnummer;
        public string itemNaam;
        public int aantal;
        public string type;
        public decimal itemPrijs;
        public decimal TotalPrice 
        {
            get { return itemPrijs * aantal; }
                
        }
    }
}
