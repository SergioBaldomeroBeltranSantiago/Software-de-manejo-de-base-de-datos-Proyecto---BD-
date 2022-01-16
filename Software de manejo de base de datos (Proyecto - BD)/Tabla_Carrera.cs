using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Carrera
    {
        private string CodigoCarrera;
        private string NombreCarrera;
        private int CreditosTotales;

        public Carrera(string codigoCarrera, string nombreCarrera, int creditosTotales)
        {
            CodigoCarrera = codigoCarrera ?? throw new ArgumentNullException(nameof(codigoCarrera));
            NombreCarrera = nombreCarrera ?? throw new ArgumentNullException(nameof(nombreCarrera));
            CreditosTotales = creditosTotales;
        }

        private string getCarrera(){
            return this.CodigoCarrera;
        }

        private string getNombreCarrera(){
            return this.NombreCarrera;
        }

        private int getCreditosTotales(){
            return this.CreditosTotales;
        }
    }
}
