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

        //constructor fara parametri
        public Medicament()
        {
            Nume = string.Empty;
            Nr_capsule = 0;
            Valabilitate = string.Empty;
        }
        //constructor cu parametri
        public Medicament(string nume,
            int nr_capsule,
            string valabilitate)
        {
            Nume = nume;
            Nr_capsule = nr_capsule;
            Valabilitate = valabilitate;
        }

        public string ConversieLaSir()
        {
            return $"Medicamentul {Nume} are {Nr_capsule} capsule si expira la data de {Valabilitate}";
        }

        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public string ConversieLaSir_PentruScriereInFisier()
        {
            string mValabilitate = string.Empty;
            if (Valabilitate != null)
            {
                mValabilitate = string.Join(SEPARATOR_AFISARE, Valabilitate);
            }
            string m = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, Nume.ToString(), (Nume ?? " NECUNOSCUT "), (Valabilitate ?? " NECUNOSCUT "), mValabilitate);

            return m;
        }
        private const int NUME = 0;
        private const int NR_CAPSULE = 1;
        private const int VALABILITATE = 2;

        public Medicament(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            Nume = dateFisier[NUME];
            Nr_capsule = NR_CAPSULE;
            Valabilitate= dateFisier[VALABILITATE];
            
        }
    }
}


