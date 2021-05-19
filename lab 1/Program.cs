using lab_1;
using System;
using System.Collections;



namespace gestionarea_farmaciei
{
    class Program
    {
        public static ArrayList medicamente;


        private const int NR_MINIM_MEDICAMENTE = 0;
        static void Main(string[] args)
        {
            

            IStocareDate adminMedicamente = Stocare.AdminStocare();

            medicamente = adminMedicamente.GetMedicament();
            int NrMedicamente = medicamente.Count;

            char op;
            do
            {
                Console.Clear();
                Console.WriteLine("A. Afisare medicament");
                Console.WriteLine("C. Creare si adaugare medicament");
                Console.WriteLine("B. Compara doua entitati");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                op = Char.ToUpper(Char.Parse(Console.ReadLine()));
                switch (op)
                {
                    case 'A':
                        Console.WriteLine("Medicamentele sunt: ");
                        for (int i = 0; i < medicamente.Count; i++)
                        {
                            Console.WriteLine(((Medicament)medicamente[i]).ConversieLaSir());
                        }
                        break;
                    case 'C':
                        Medicament medicamentCitit = CitireMedicament();
                        medicamente.Add(medicamentCitit);
                        adminMedicamente.AddMedicament(medicamentCitit);
                        break;
                    case 'B':
                        Console.WriteLine($"Introduceti afectiunea pentru afectiunea pe care o cautati ");
                        Comparare();
                        break;
                    case 'X':
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
                Console.ReadKey();
            } while (op != 'X');

            /* citire de la tastatura si afisare
            int nrMedicamente;
            do
            {
                Console.WriteLine("Introduceti numarul de medicamente");
                Int32.TryParse(Console.ReadLine(), out nrMedicamente);
            } while (nrMedicamente <= NR_MINIM_MEDICAMENTE);

            Medicament[] medicamente = new Medicament[nrMedicamente];
            Console.WriteLine("Introduceti datele: ");
            string informatii = Console.ReadLine();
            for (int i = 0; i < nrMedicamente; i++)
            {
                
                medicamente[i] = new Medicament(informatii);

            }

            Console.WriteLine("\nInformatiile despre medicamente sunt:");

            for (int i = 0; i < nrMedicamente; i++)
            {
                Console.WriteLine(medicamente[i].ConversieLaSir());
            }
            */

            Console.ReadKey();
        }

        public static Medicament CitireMedicament()
        {
            Console.WriteLine("Introduceti datele medicamentului ");
            string medicament = Console.ReadLine();

            Medicament m = new Medicament(medicament);

            return m;
        }

        public static void Comparare()
        {

            string cautarea = Console.ReadLine();
            int gasit = 0;
            for (int i = 0; i < medicamente.Count; i++)
            {
                Medicament temp = (Medicament) medicamente[i];
                if (cautarea == temp.Afectiune)
                {
                    Console.WriteLine($"Am gasit medicamentul: {temp.Nume}");
                    gasit = 1;
                }
            }
            if(gasit !=1)
            {
                Console.WriteLine("Nu sunt medicamente cu aceasta afectiune");
            }
        }

        public static void Cautare(Medicament m)
        {

            int gasit = 0;
            for (int i = 0; i < medicamente.Count; i++)
            {
                Medicament temp = (Medicament)medicamente[i];
                if (cautarea == temp.Afectiune)
                {
                    Console.WriteLine($"Am gasit medicamentul: {temp.Nume}");
                    gasit = 1;
                }
            }
            if (gasit != 1)
            {
                Console.WriteLine("Nu sunt medicamente cu aceasta afectiune");
            }
        }
    }
    
    }

