using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Ecole
    {
        public abstract class Ecole
        {
            public string Nom_Ecole { get; set; }
            public string Contact_Ecole { get; set; }
            public string Email_Ecole { get; set; }

            public Ecole()
            {

            }

            public Ecole(string nom_Ecole, string contact_Ecole, string email_Ecole)
            {
                this.Nom_Ecole = nom_Ecole;
                this.Contact_Ecole = contact_Ecole;
                this.Email_Ecole = email_Ecole;
            }
        }
}
