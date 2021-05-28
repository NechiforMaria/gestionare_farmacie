using lab_1;
using System;
using System.Collections;
using System.Collections.Generic;

namespace gestionarea_farmaciei
{
    class Program
    {
        public static ArrayList medicamente;


        //private const int NR_MINIM_MEDICAMENTE = 0;
        static void Main(string[] args)
        {
            

            IStocareDate adminMedicamente = Stocare.AdminStocare();

            medicamente = adminMedicamente.GetMedicament();
           // int NrMedicamente = medicamente.Count;

            char op;
            do
            {
                Console.Clear();
                Console.WriteLine("A. Afisare medicament");
                Console.WriteLine("B. Compara doua entitati");
                Console.WriteLine("C. Creare si adaugare medicament");
                Console.WriteLine("D. Modificare medicament");
                Console.WriteLine("E. Cauta un medicament dupa nume");
                Console.WriteLine("F. Adauga si afiseaza in lista generica");
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
                        Comparare();
                        break;
                    case 'D':
                        Console.WriteLine("Introduceti denumirea medicamentului pe care doriti sa il modificati: ");
                        string modifi = Console.ReadLine();
                        medicamente = Modificare(medicamente, modifi, adminMedicamente);
                        break;
                    case 'E':
                        Console.WriteLine("Cauta un medicament dupa nume: ");
                        string nume = Console.ReadLine();
                        Medicament cautare = Cautare(nume);
                        if (cautare != null)
                            Console.WriteLine($"Afisare medicament: \n {cautare.ConversieLaSir()}");
                        else
                            Console.WriteLine("Medicamentul nu exista");
                        break;
                    case 'F':
                        //lab4 2.Liste generice
                        List<Medicament> medicamentele = new List<Medicament>();
                        string medicament = Console.ReadLine();

                        Medicament m = new Medicament(medicament);
                        medicamentele.Add(m);
                        foreach(Medicament med in medicamentele)
                        {
                            Console.WriteLine(med.ConversieLaSir());
                       }
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


            //Lab2 2.Conversielasir
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

        //lab2. 3.Comparare
        public static void Comparare()
        {

            int min = 99;
            int k=0;
            for (int i = 0; i < medicamente.Count; i++)
            {
                Medicament temp = (Medicament) medicamente[i];
                if (temp.Nr_capsule<min)
                {
                    min = temp.Nr_capsule;
                    k = i+1;
                   
                }
            }
            
                Console.WriteLine($"Numarul minim de capsule este: {min}, al medicamentului {k}");

        }

        //lab3 2.Cautare entitate
        public static Medicament Cautare(string nume)
        {

            Medicament temporar = null;
            foreach (Medicament m in medicamente)
            {
               if(nume== m.Nume)
                { temporar = m; }

            }
            if(temporar != null)
            {
                return temporar;
            }
            else
            {
                return null;
            }
            
        }

        //lab3 2.Modificare entitate
        public static ArrayList Modificare(ArrayList medicamente, string modificare, IStocareDate adminMedicamente)
        {
            for(int i=0; i<medicamente.Count;i++)
            {
                Medicament temporar = (Medicament)medicamente[i];
                if(modificare == temporar.Nume)
                {
                    Console.WriteLine("Introduceti datele: ");
                    string medicament = Console.ReadLine();
                    string LinieDeModificat = temporar.ConversieLaSir_pentruFisier();
                    adminMedicamente.ModificareMadicament(LinieDeModificat, medicament, medicamente);

                    Medicament m = new Medicament(medicament);
                    medicamente.RemoveAt(i);
                    medicamente.Insert(i, m);
                    break;
                }
            }
            return medicamente;
        }

        
    }
    
    }

