using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    class CarteEtudiantDAL
    {
        public static List<CarteEtudiant> carteEtudiants;
        private const string FILE_NAME = @"infosEtudiant.json";
        private readonly string dbFolder;
        private FileInfos file;

        public CarteEtudiantDAL(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName, true))
                {
                    string json = sr.ReadToEnd();
                    CarteEtudiant = JsonConvert.DeserializeObject<List<Product>>(json);
                }
            }
            if (CarteEtudiant == null)
            {
                CarteEtudiant = new List<CarteEtudiant>();
            }
            public void Set(CarteEtudiant oldcarteEtudiant, CarteEtudiant newcarteEtudiant)
            {
                var oldIndex = CarteEtudiant.IndexOf(oldcarteEtudiant);
                var newIndex = CarteEtudiant.IndexOf(newcarteEtudiant);

                if (oldIndex < 0)
                    throw new KeyNotFoundException("This Matricule doesn't exists !");

                if (newIndex > 0 && newIndex != oldIndex)
                    throw new DuplicateNameException("This Matricule already exists !");

                products[oldIndex] = newproduct;
                Save();

            }

            public void Add(CarteEtudiant carteEtudiant)
            {
                var index = carteEtudiant.IndexOf(CarteEtudiant);
                if (index >= 0)
                    throw new DuplicateNameException("The Matricule already exist !");

                carteEtudiant.Add(carteEtudiant);
                Save();
            }
            public void Remove(CarteEtudiant carteEtudiant)
            {
                carteEtudiant.Remove(carteEtudiant);
                Save();

            }
            public void Save()
            {
                using (StreamWriter sw = new StreamWriter(file.FullName, false))
                {
                    string json = JsonConvert.SerializeObject(carteEtudiant);
                    sw.WriteLine(json);
                }
            }
            public IEnumerable<CarteEtudiant> Find()
            {
                return new List<CarteEtudiant>(carteEtudiant);
            }
            public IEnumerable<arteEtudiant> Find(Func<CarteEtudiant, bool> predicate)
            {
                return new List<CarteEtudiant>(carteEtudiant.Where(predicate).ToArray());
            }


        }
    }
}
