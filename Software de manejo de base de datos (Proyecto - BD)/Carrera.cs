using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Carrera
    {
        public string CodigoCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public int CreditosTotales { get; set; }

        public Carrera(string codigoCarrera, string nombreCarrera, int creditosTotales)
        {
            CodigoCarrera = codigoCarrera ?? throw new ArgumentNullException(nameof(codigoCarrera));
            NombreCarrera = nombreCarrera ?? throw new ArgumentNullException(nameof(nombreCarrera));
            CreditosTotales = creditosTotales;
        }

        public Carrera()
        {
        }
    }
}
