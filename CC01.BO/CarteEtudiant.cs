using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class CarteEtudiant:Ecole
    {
        public String Nom { get; set; }
        public string Prenom { get; set; }
        public string Matricule { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Numero_Tell { get; set; }

        public string Classe { get; set; }
        public string Email { get; set; }

        public CarteEtudiant() : base()
        {

        }

        public CarteEtudiant(string nom, string prenom, string matricule, int age, string sex, string numero_Tell, string classe, string Email string nom_Ecole) : base(nom_Ecole, contact_Ecole, email_Ecole)
        {
            Nom = nom;
            Prenom = prenom;
            Matricule = matricule;
            Age = age;
            Sex = sex;
            Numero_Tell = numero_Tell;
            Classe = classe;
            Email = Email;
        }

        public override bool Equals(object obj)
        {
            return obj is CarteEtudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }

    }
}

