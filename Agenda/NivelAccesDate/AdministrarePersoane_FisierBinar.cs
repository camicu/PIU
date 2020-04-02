using Librarie;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrarePersoane_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrarePersoane_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddPersoana(Persoana s)
        {
            throw new Exception("Optiunea AddPersoana nu este implementata");
        }

        public Persoana[] GetPersoane(out int nrPersoane)
        {
            throw new Exception("Optiunea GetPersoane nu este implementata");
        }

       
    }
}
