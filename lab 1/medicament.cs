using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace gestionarea_farmaciei
{
    class Medicament
    {
        public string Nume { get; set; }
        public int Nr_capsule { get; set; }
        public string Valabilitate { get; set; }
        public string Afectiune { get; set; }
        //constructor fara parametri
        public Medicament()
        {
            Nume = string.Empty;
            Nr_capsule = 0;
            Valabilitate = string.Empty;
            Afectiune = string.Empty;
        }
        //constructor cu parametri
        public Medicament(string nume,
            int nr_capsule,
            string valabilitate,
            string afectiune)
        {
            Nume = nume;
            Nr_capsule = nr_capsule;
            Valabilitate = valabilitate;
            Afectiune = afectiune;
        }

        public string ConversieLaSir()
        {
            return $"Medicamentul {Nume} are {Nr_capsule} capsule si expira la data de {Valabilitate}. Este pentru afectiunea: {Afectiune}";
        }

       
    }
}


