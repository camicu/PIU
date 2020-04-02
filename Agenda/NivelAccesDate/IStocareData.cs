using Librarie;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    { 
        void AddPersoana(Persoana s);
        Persoana[] GetPersoane(out int nrPersoane);
    }
}
