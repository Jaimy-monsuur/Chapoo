using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public List<Orderitems> orderItemList;
        public int orderNummer;        
        public string opmerking;
        public Tafel tafel;
        public Personeels_Lid personeel;
        public DateTime datum;
    }
}
