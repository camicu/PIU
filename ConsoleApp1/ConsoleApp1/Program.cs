﻿using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok = true;
            string opt;
            Persoana a=new Persoana();
            Persoana b;
            while (ok)
            { 
                Console.Clear();
                Console.WriteLine("MENIU\n------------------------------------------------------\n");
                Console.WriteLine("1) Adaugati un contact in agenda\n");
                Console.WriteLine("2) Afisati agenda\n");
                Console.WriteLine("4)Adaugare din tastarura cu functie string\n");
                Console.WriteLine("5) Iesire din meniu\n");
                Console.Write("\r\nAlegeti o optiune: ");

                opt = Console.ReadLine();
                switch (opt)
                {
                case "1":
                        {
                            Console.WriteLine("Selectati grupul in care apartile:...\n");
                            Console.WriteLine("1) Prieteni\n");
                            Console.WriteLine("2) Familie\n");
                            Console.WriteLine("3) Serviciu\n");

                            string opt1 = Console.ReadLine();

                            string _nume, _prenume, _email, _data;
                            int _nr;
                            Console.WriteLine("Introduceti numele persoanei:...");
                            _nume = Console.ReadLine();
                            Console.WriteLine("Introduceti prenumele persoanei:...");
                            _prenume = Console.ReadLine();
                            Console.WriteLine("Introduceti email-ul persoanei");
                            _email = Console.ReadLine();
                            Console.WriteLine("Introduceti data nasterii a persoanei");
                            _data = Console.ReadLine();
                            Console.WriteLine("Introduceti numarul de telefon al persoaneri");
                            _nr = Int32.Parse(Console.ReadLine());
                            a.SetNume(_nume);
                            a.SetPrenume(_prenume);
                            a.SetEmail(_email);
                            a.SetNr(_nr);
                            a.SetData(_data);

                            if (opt1 == "1")
                            {
                                a.SetPrieten();
                            }
                            if (opt1 == "2")
                            {
                                a.SetFamilie();
                            }
                            if (opt1 == "3")
                            {
                                a.SetServiciu();
                            }
                            a.Afis();
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Samdkhsakjdhkasj");
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("BITCH IM A COW");
                            Console.ReadKey();
                            break;
                        }

                    case "5":
                        {
                            ok = false;
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Dati datele unei persoane, is formatul: nume, prenume, data nasterii, nr telefon, email");
                            b = new Persoana("Cojocaru, Ana, 01.02.1999,747828207,ana.cojocaru@yahoo.com");
                            b.Afis();
                            Console.ReadKey();
                            break;
                        }
                    default:
                        break;

                }
            }

        }
    }
    
}
