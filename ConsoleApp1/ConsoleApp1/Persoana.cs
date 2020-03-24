using System;
using System.Collections.Generic;
using System.Text;

using System;
namespace Agenda
{

	public class Persoana
	{
		//lista de parametrii
		string nume;
		string prenume;
		string data_de_nastere;
		int nr_de_telefon;
		string email;

		//Constructor fara parametrii
		public Persoana()
		{
			nume = string.Empty;
			prenume = string.Empty;
			data_de_nastere = string.Empty;
			nr_de_telefon = 0;
			email = string.Empty;

		}

		//Constructor cu parametrii
		public Persoana(string _nume, string _prenume, string _data, int _nr_de_telefon, string _email)
		{
			nume = _nume;
			prenume = _prenume;
			data_de_nastere = _data;
			nr_de_telefon = _nr_de_telefon;
			email = _email;
		}

		// Serie de functii get si set
		public string getNume()
		{
			return nume;

		}
		public string getPrenume()
		{
			return prenume;

		}
		public string getData()
		{
			return data_de_nastere;
		}
		public int getNrTelefon()
		{
			return nr_de_telefon;
		}
		public string getEmail()
		{
			return email;
		}
		public void SetNume(string _nume)
		{
			if (_nume != null)
			{
				nume = _nume;
			}
			else
			{
				Console.Write("Numele nu este valid!");
			}
		}
		public void SetPrenume(string _prenume)
		{
			if (_prenume!= null)
			{
				prenume = _prenume;
			}
			else
			{
				Console.Write("Prenumele nu este valid!");
			}
		}
		public void SetData (string _data)
		{
			if (_data != null)
			{
				data_de_nastere = _data;
			}
			else
			{
				Console.Write("Data nu este valid!");
			}
		}
		public void SetEmail(string _email)
		{
			if (_email != null)
			{
				email= _email;
			}
			else
			{
				Console.Write("Email-ul nu este valid!");
			}
		}
		public void SetNr(int  _nr)
		{
			if ((_nr >= 700000000) && (_nr<800000000))
			{
				nr_de_telefon = _nr;
			}
			else
			{
				Console.Write("Numarul nu este valid!");
			}
		}

	}
}
