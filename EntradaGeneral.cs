using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class EntradaGeneral:Entrada
    {
        public EntradaGeneral(string NomAssistent = "", DateTime DataConcert = default(DateTime), string Preu = "", string Zona = "") : base(NomAssistent, DataConcert, Preu, Zona)
        {
            ImprimirTiquet();
        }
    }
}
