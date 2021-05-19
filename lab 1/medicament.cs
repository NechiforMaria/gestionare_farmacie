using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace gestionarea_farmaciei
{
    public class Medicament
    {
        public string Nume { get; set; }
        public int Nr_capsule { get; set; }
        public string Valabilitate { get; set; }
        public string Afectiune { get; set; }
        //2.constructor fara parametri
        public Medicament()
        {
            Nume = string.Empty;
            Nr_capsule = 0;
            Valabilitate = string.Empty;
            Afectiune = string.Empty;
        }
        //2.constructor cu parametri
        public Medicament(string Informatii)
        {
            string[] informatii = Informatii.Split(' ');
            Nume = informatii[0];
            Nr_capsule = Int32.Parse(informatii[1]);
            Valabilitate = informatii[2];
            Afectiune = informatii[3];
        }

        //2.Conversie la sir 
        public string ConversieLaSir()
        {
            return $"Medicamentul {Nume} are {Nr_capsule} capsule si expira la data de {Valabilitate}. Este pentru afectiunea: {Afectiune}";
        }

        public string ConversieLaSir_pentruFisier()
        {
            return $"{Nume} {Nr_capsule} {Valabilitate} {Afectiune} ";
        }

    }
}


