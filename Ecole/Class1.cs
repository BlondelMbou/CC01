using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecole
{
    public class Class1
    {
        public abstract class Ecole
        {
            public string Nom_Ecole { get; set; }

            public Ecole()
            {

            }

            public Ecole(string nom_Ecole)
            {
                this.Nom_Ecole = nom_Ecole;
            }

        }
    }
}
