using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class EntradaVIP : Entrada
    {
        public string BeneficiExtra = "";
        public EntradaVIP(string NomAssistent = "", DateTime DataConcert = default(DateTime), string Preu = "", string Zona = "", string BeneficiExtra = ""):base(NomAssistent,DataConcert,Preu,Zona) {
            this.BeneficiExtra = BeneficiExtra;
        }
        public string ImprimirTiquet()
        {
            string imprimir = this.NomAssistent + " " + this.DataConcert + " " + this.Preu + " " + this.Zona + " " +this.BeneficiExtra;
            return imprimir;
        }
    }
}
