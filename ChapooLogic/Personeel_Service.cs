using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using ChapooDAL;
namespace ChapooLogic
{
    public class Personeel_Service
    {
        Personeel_DOA Personeel_DOA = new Personeel_DOA();
        public List<Personeels_Lid> GetPersoneel()// haalt al het personeel
        {
            return Personeel_DOA.GetPersoneel();
        }
        public void DeletePersonel(int personeelnummer)// delete personeels lid
        {
            Personeel_DOA.DeletePersonel(personeelnummer);
        }
        public void Addpersonle(string voornaam, string achternaam, string functie, string username, string password, string type)// nieuw personeels lid
        {
            Personeel_DOA.Addpersonle(voornaam, achternaam, functie, username, password, type);
        }
    }
}
