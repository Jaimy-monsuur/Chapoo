using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class CurrentUser : Account
    {
        private static CurrentUser uniquelnstance;
        private CurrentUser() { }

        public static CurrentUser Getlnstance()
        {
            if (uniquelnstance == null)
            {
                uniquelnstance = new CurrentUser();
            }
            return uniquelnstance;
        }
        public void SetUser(Account c)
        {
            this.personeelsNummer = c.personeelsNummer;
            this.UserName = c.UserName;
            this.Password = c.Password;
            this.Type = c.Type;
        }

        public override string ToString()
        {
            return $"{UserName}, {Type}";
        }
    }
}
