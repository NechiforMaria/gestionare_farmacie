using gestionarea_farmaciei;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_1
{
    class AdministrareMedicamente: IStocareDate
    {
        string NumeFisier { get; set; }

        public AdministrareMedicamente(string numefisier)
        {
            this.NumeFisier = numefisier;
            using (Stream fisier = File.Open(numefisier, FileMode.OpenOrCreate)) { }

        }

        public void AddMedicament(Medicament m)
        {
              using(StreamWriter fisier =new StreamWriter(NumeFisier, true))
            {
                fisier.WriteLine(m.ConversieLaSir_pentruFisier());
            }
        }

        public ArrayList GetMedicament()
        {
            ArrayList medicamente = new ArrayList();
            using (StreamReader sr= new StreamReader(NumeFisier) )
            {
                string line;
                while((line= sr.ReadLine()) != null)
                {
                    Medicament medicamentDinFisier = new Medicament(line);
                    medicamente.Add(medicamentDinFisier);
                }
            }
            return medicamente;
        }

        public void ModificareMadicament(string LinieDeModificat, string LiniaModificata, ArrayList medicamente)
        {
            

            ArrayList medicamentenoi = new ArrayList();
            string[] LiniiCitite = new string[medicamente.Count];
            //Console.WriteLine(medicamente.Count);
            int i = 0;
            using (StreamReader citire=  new StreamReader(NumeFisier))
            {
                string linia;

                while((linia=citire.ReadLine())!= null)
                    {
                    Medicament medicamentDinFisier = new Medicament(linia);
                    medicamentenoi.Add(medicamentDinFisier);
                    LiniiCitite[i] = linia;
                    i++;
                }
            }
            i = 0;
            using (StreamWriter scriere= new StreamWriter(NumeFisier))
            {
                string linie = null;
                while (i< medicamente.Count && (linie=LiniiCitite[i])!= null)
                {
                    if(String.Compare(linie, LinieDeModificat) ==0)
                    {
                        scriere.WriteLine(LinieDeModificat);
                        i++;
                        continue;
                    }
                    scriere.WriteLine(linie);
                    i++;
                }
            }
        }

    }
}
