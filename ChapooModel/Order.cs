using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public List<Orderitems> orderItems;
        public int orderNummer;
        public int tafelNummer;
        public int personeelNummer;
        public string opmerking;
        public bool gereed;

    }
}
