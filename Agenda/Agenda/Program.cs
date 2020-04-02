using Librarie;
using NivelAccesDate;
using System;
namespace Agenda
{
    class Program
    {
        public const Grup GRUP = Grup.Necunoscut;
        public int nrPersoane;
        static void Main(string[] args)
        {
            Persoana[] persoane;
            IStocareData adminPersoane = StocareFactory.GetAdministratorStocare();
            int nrPersoane;
            persoane = adminPersoane.GetPersoane(out nrPersoane);
            Persoana.IdUltimaPersoana = nrPersoane;
            Program a = new Program();
            bool ok = true;
            string opt;
            Persoana s;
            while (ok)
            {
                Console.Clear();
                Console.WriteLine("MENIU\n------------------------------------------------------\n");
                Console.WriteLine("1) Adaugati un contact in agenda\n");
                Console.WriteLine("2) Afisati agenda\n");
                Console.WriteLine("3) Comparati doua persoane dupa nume si prenume\n");
                Console.WriteLine("4) Adaugare din tastarura cu functie string\n");
                Console.WriteLine("5) Modificati o persoana din agenda\n");
                Console.WriteLine("6) Iesire din meniu\n");
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
                            Console.WriteLine("Introduceti numele persoanei:...");
                            string _nume = Console.ReadLine();
                            Console.WriteLine("Introduceti prenumele persoanei:...");
                            string _prenume = Console.ReadLine();
                            Console.WriteLine("Introduceti email-ul persoanei");
                            string _email = Console.ReadLine();
                            Console.WriteLine("Introduceti data nasterii a persoanei");
                            string _data = Console.ReadLine();
                            Console.WriteLine("Introduceti numarul de telefon al persoaneri");
                            int _nr = Int32.Parse(Console.ReadLine());
                            s = new Persoana();
                            s.Nume = _nume;
                            s.Prenume = _prenume;
                            s.Email = _email;
                            s.NrDeTelefon = _nr;
                            s.DataDeNastere = _data;

                            if (opt1 == "1")
                            {
                                s.Grupul = Grup.Prieteni;
                            }
                            else
                            {
                                if (opt1 == "2")
                                {
                                    s.Grupul = Grup.Familie;
                                }
                                else
                                {
                                    if (opt1 == "3")
                                    {
                                        s.Grupul = Grup.Serviciu;
                                    }
                                    else
                                    {
                                        s.Grupul = Grup.Necunoscut;
                                    }
                                }
                            }
                            Console.WriteLine(s.ConversieLaSir());
                            persoane[nrPersoane] = s;
                            nrPersoane++;
                            adminPersoane.AddPersoana(s);
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Agenda este:...\n");
                            for (int i = 0; i < nrPersoane; i++)
                            {
                                Console.WriteLine("\nPersonele sunt:\n{0}", persoane[i].ConversieLaSir());
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {

                            if (!a.IsEqualNumeComplet(persoane[0], persoane[1]))
                            {
                                Console.WriteLine("Numele si prenumele nu sunt egale!!\n");
                            }
                            else
                            {
                                Console.WriteLine("Numele si prenumelesunt egale!!\n");
                            }
                            Console.ReadKey();
                            break;
                        }


                    case "4":
                        {
                            Console.WriteLine("Dati datele unei persoane, is formatul: nume, prenume, data nasterii, nr telefon, email\n");
                            s = new Persoana(Console.ReadLine());
                            Console.WriteLine("{0}\n", s.ConversieLaSir());
                            persoane[nrPersoane] = s;
                            nrPersoane++;
                            adminPersoane.AddPersoana(s);
                            Console.ReadKey();
                            break;
                        }
                    case "5":
                        {
                            string _nume;
                            Console.WriteLine("Dati numele persoanei pe care o doriti sa se modifice:");
                            _nume = Console.ReadLine();
                            for (int i = 0; i < nrPersoane; i++)
                            {
                                if (persoane[i].Nume == _nume)
                                {
                                    Console.WriteLine("Selectati ce doriti sa modificati:\n");
                                    Console.WriteLine("1) Nume\n");
                                    Console.WriteLine("2) Prenume\n");
                                    Console.WriteLine("3) Email\n");
                                    Console.WriteLine("4) Data nasterii\n");
                                    Console.WriteLine("5) Nr Telefon\n");
                                    Console.WriteLine("6) Grupul\n");
                                    string optiune = Console.ReadLine();
                                    switch (optiune)
                                    {
                                        case "1":
                                            Console.Clear();
                                            Console.WriteLine("Dati numele nou:...");
                                            string NUME = Console.ReadLine();
                                            persoane[i].Nume = NUME;
                                            Console.ReadKey();
                                            break;
                                        case "2":
                                            Console.Clear();
                                            Console.WriteLine("Dati prenumele nou:...");
                                            string PRENUME = Console.ReadLine();
                                            persoane[i].Prenume = PRENUME;
                                            Console.ReadKey();
                                            break;
                                        case "3":
                                            Console.Clear();
                                            Console.WriteLine("Dati email-ul nou:...");
                                            string EMAIL = Console.ReadLine();
                                            persoane[i].Email = EMAIL;
                                            Console.ReadKey();
                                            break;
                                        case "4":
                                            Console.Clear();
                                            Console.WriteLine("Dati data de nastere noua:...");
                                            string DATA = Console.ReadLine();
                                            persoane[i].DataDeNastere = DATA;
                                            Console.ReadKey();
                                            break;
                                        case "5":
                                            Console.Clear();
                                            Console.WriteLine("Dati numarul de telefon nou:...");
                                            string NR = Console.ReadLine();
                                            persoane[i].NrDeTelefon = Int32.Parse(Console.ReadLine());
                                            Console.ReadKey();
                                            break;
                                        case "6":
                                            Console.Clear();
                                            Console.WriteLine("Selectati grupul nou:\n");

                                            Console.WriteLine("1) Prieteni\n");
                                            Console.WriteLine("2) Familie\n");
                                            Console.WriteLine("3) Serviciu\n");
                                            string G = Console.ReadLine();
                                            if (G == "1")
                                            {
                                                persoane[i].Grupul = Grup.Prieteni;
                                            }
                                            if (G == "2")
                                            {
                                                persoane[i].Grupul = Grup.Familie;
                                            }
                                            if (G == "3")
                                            {
                                                persoane[i].Grupul = Grup.Serviciu;
                                            }
                                            Console.ReadKey();
                                            break;
                                    }
                                    break;
                                }
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("Se inchide programul");
                            ok = false;
                            break;
                        }
                    default:
                        break;

                }
            }

        }
        /*  public Persoana CautaPersoana(string _nume,string _prenume,string _data, int nr,string email)
          {
              for(int i = 0; i < nrPersoane++)
              {

              }
              return
              Console.WriteLine("Dati datele unei; persoane, is formatul: nume, prenume, data nasterii, nr telefon, email\n");
          }
          */
       /* public static Pharmacy citireTastatura()
        {
            Console.WriteLine("Introduceti numele medicamentului pe care doriti sa-l inserati in baza de date:");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti pretul:");
            int pret = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti daca este valabil momentan[1-valabil 0-nevalabil]:");
            int valabilitate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti locatia unde se poate gasi:");
            string locatie = Console.ReadLine();


            Console.WriteLine("Va rugam sa verificicati din nou informatiile despre medicamente.");

            Pharmacy m = new Pharmacy(nume, pret, valabilitate, locatie);

            return m;
        }
        */
        public bool IsEqualNumeComplet(Persoana a, Persoana b)
        {
            if ((a.Nume == b.Nume) && (a.Prenume == b.Prenume))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
