using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Personeels_Lid
    {
        public int Nummer;
        public string Voornaam;
        public string Achternaam;
        public string functie;

        // een personeels lid heeft account gegevens
        public Account account;
    }
}
