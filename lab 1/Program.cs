using System;
using System.Collections;

namespace gestionarea_farmaciei
{
    class Program
    {

        private const int NR_MINIM_MEDICAMENTE = 0;
        static void Main(string[] args)
        {
            int nrMedicamente;
            do
            {
                Console.WriteLine("Introduceti numarul de medicamente");
                Int32.TryParse(Console.ReadLine(), out nrMedicamente);
            } while (nrMedicamente <= NR_MINIM_MEDICAMENTE);

            Medicament[] medicamente = new Medicament[nrMedicamente];

            for (int i = 0; i < nrMedicamente; i++)
            {
                Console.WriteLine($"Medicament {i + 1}:");
                Console.Write($"Introduceti denumirea medicamentului ");
                string nume = Console.ReadLine();
                Console.Write($"Introduceti numarul de capsule ");
                int nrCapsule = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Introduceti valabilitatea medicamentului(zz.ll.aaaa) ");
                string valabilitate = Console.ReadLine();
                Medicament medicamentCitit = new Medicament(nume, nrCapsule, valabilitate);
                medicamente[i] = medicamentCitit;

            }

            Console.WriteLine("\nInformatiile despre medicamente sunt:");

            for (int i = 0; i < nrMedicamente; i++)
            {
                Console.WriteLine(medicamente[i].ConversieLaSir());
                
               
            }

            Console.ReadKey();
        }
    }


       
        
    }

