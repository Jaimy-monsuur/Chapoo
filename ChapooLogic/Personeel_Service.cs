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
        public List<Personeels_Lid> GetPersoneel()
        {
            return Personeel_DOA.GetPersoneel();
        }
        public void DeletePersonel(int personeelnummer)
        {
            Personeel_DOA.DeletePersonel(personeelnummer);
        }
        public void Addpersonle(string voornaam, string achternaam, string functie, string username, string password, string type)
        {
            Personeel_DOA.Addpersonle(voornaam, achternaam, functie, username, password, type);
        }
    }
}
