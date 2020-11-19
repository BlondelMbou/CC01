using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    class CarteEtudiantBLL
    {
        public CarteEtudiantBLL(string dbFolder)
        {
            carteEtudiantBLL = new CarteEtudiantBLL(dbFolder);
        }
        public void CreateCarteEtudiant(CarteEtudiant carteEtudiant)
        {
            carteEtudiantRepo.Add(carteEtudiant);
        }
        public void DeleteCarteEtudiant(CarteEtudiant carteEtudiant)
        {
            carteEtudiantRepo.Remove(carteEtudiant);
        }
        public IEnumerable<CarteEtudiant> GetAllCarteEtudiant()
        {
            return carteEtudiantRepo.Find();
        }
        public IEnumerable<CarteEtudiant> GetByMatricule(string matricule)
        {
            return carteEtudiantRepo.Find(x => x.Matricule == matricule);
        }

        public IEnumerable<CarteEtudiant> GetBy(Func<CarteEtudiant, bool> predicate)
        {
            return carteEtudiantRepo.Find(predicate);
        }

        public void EditCarteEtudiant(CarteEtudiant oldproduct, CarteEtudiant newproduct)
        {
            carteEtudiantRepo.Set(oldcarteEtudiant, new carteEtudiant);
        }
    }
}
}
