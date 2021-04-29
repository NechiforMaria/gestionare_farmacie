using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lab_1
{
    class medicament
    {
        public string Nume { get; set; }
        public int Nr_capsule { get; set; }
        public string Valabilitate { get; set; }
        public medicament(string nume,
            int nr_capsule,
            string valabilitate)
        {
            Nume = nume;
            Nr_capsule = nr_capsule;
            Valabilitate = valabilitate;
        }
    }
}
