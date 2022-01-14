using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Estudiante
    {
        public string NumeroControl { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public string FechaIngreso { get; set; }
        public decimal Promedio { get; set; }
        public string CodigoCarrera { get; set; }
        public int CreditosAcreditados { get; set; }
        public int CreditosComplementarios { get; set; }

        public Estudiante(string numeroControl, string nombre, string fechaNacimiento, string fechaIngreso, decimal promedio, string codigoCarrera, int creditosAcreditados, int creditosComplementarios)
        {
            NumeroControl = numeroControl ?? throw new ArgumentNullException(nameof(numeroControl));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            FechaNacimiento = fechaNacimiento ?? throw new ArgumentNullException(nameof(fechaNacimiento));
            FechaIngreso = fechaIngreso ?? throw new ArgumentNullException(nameof(fechaIngreso));
            Promedio = promedio;
            CodigoCarrera = codigoCarrera ?? throw new ArgumentNullException(nameof(codigoCarrera));
            CreditosAcreditados = creditosAcreditados;
            CreditosComplementarios = creditosComplementarios;
        }

        public Estudiante()
        {

        }
    }
}
