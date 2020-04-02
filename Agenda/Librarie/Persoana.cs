using System;

namespace Librarie
{
	public class Persoana
	{
		//constante
		private const string SEPARATOR_AFISARE = " ";
		private const char SEPARATOR_PRINCIPAL_FISIER = ';';
		//lista de parametrii
		public static int IdUltimaPersoana { get; set; } = 0;
		public int IdPersoana { get; set; }
		public string Nume { get; set; }
		public string Prenume { get; set; }
		public string DataDeNastere { get; set; }
		public int NrDeTelefon { get; set; }
		public string Email { get; set; }

		public Grup Grupul { get; set; }

		//Constructor fara parametrii
		public Persoana()
		{
			Nume = string.Empty;
			Prenume = string.Empty;
			DataDeNastere = string.Empty;
			NrDeTelefon = 0;
			Email = string.Empty;
			IdPersoana = IdUltimaPersoana;
			IdUltimaPersoana++;
			Grupul = Grup.Necunoscut;

		}

		//Constructor cu parametrii
		public Persoana(string _nume, string _prenume, string _data, int _nr_de_telefon, string _email)
		{
			Nume = _nume;
			Prenume = _prenume;
			DataDeNastere = _data;
			NrDeTelefon = _nr_de_telefon;
			Email = _email;
			IdPersoana = IdUltimaPersoana;
			IdUltimaPersoana++;
			Grupul = Grup.Necunoscut;
		}
		public Persoana(string Sir)
		{
			string[] buff = Sir.Split(',');
			Nume = buff[0];
			Prenume = buff[1];
			DataDeNastere = buff[2];
			NrDeTelefon = Int32.Parse(buff[3]);
			Email = buff[4];
			Grupul = Grup.Necunoscut;
			IdPersoana = IdUltimaPersoana;
			IdUltimaPersoana++;
		}
		public string ConversieLaSir_PentruFisier()
		{
			string sNote = string.Empty;
			if (Nume != null)
			{
				sNote = string.Join(SEPARATOR_AFISARE, Nume);
			}

			string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", SEPARATOR_PRINCIPAL_FISIER, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (DataDeNastere ?? "NECUNOSCUT"), (Email ?? "NECUNOSCUT"), NrDeTelefon, Grupul);

			return s;
		}
		public string ConversieLaSir()
		{
			string sir = string.Empty;
			sir = String.Concat("Numele este:", Nume, "\nPrenumele este:", Prenume, "\nData nasterii este:", DataDeNastere, "\nEmail-ul este:", Email, String.Format("\nNumarul de telefon este:{0}", NrDeTelefon), "\nGrupul din care face parte este:", Grupul);
			return sir;
		}

	}
}

