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

    }
}
