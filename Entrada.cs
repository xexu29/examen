using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class Entrada
    {
        public string NomAssistent = "";
        public DateTime DataConcert;
        public string Preu = "";
        public string Zona = "";
        public Entrada(string NomAssistent="", DateTime DataConcert=default(DateTime), string Preu = "", string Zona = "") { 
            this.NomAssistent = NomAssistent;
            this.DataConcert = DataConcert;
            this.Preu = Preu;
            this.Zona = Zona;
        }
        public string ImprimirTiquet() {
            string imprimir = this.NomAssistent + " " + this.DataConcert + " " + this.Preu + " " + this.Zona;
            return imprimir;
        }
    }
}
