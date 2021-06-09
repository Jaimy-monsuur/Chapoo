using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Tafel_Reservering
    {
        public int reserveringsnummer;
        public string naam;
        public Tafel tafel;
        public DateTime Datum;
        public TimeSpan startTijd;
        public TimeSpan eindTijd;
    }
}
