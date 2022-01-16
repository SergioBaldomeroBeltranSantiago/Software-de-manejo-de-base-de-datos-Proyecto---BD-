using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Estudiante
    {
        private string NumeroControl;
        private string Nombre;
        private string FechaNacimiento;
        private string FechaIngreso;
        private decimal Promedio;
        private string CodigoCarrera;
        private int CreditosAcreditados;
        private int CreditosComplementarios;

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

        private string getNumeroControl(){
            return this.NumeroControl;
        }

        private string getNombre(){
            return this.Nombre;
        }

        private string getFechaNacimiento(){
            return this.FechaNacimiento;
        }

        private string getFechaIngreso(){
            return this.FechaIngreso;
        }

        private decimal getPromedio(){
            return this.Promedio;
        }

        private string getCodigoCarrera(){
            return this.CodigoCarrera;
        }

        private int getCreditosAcreditados(){
            return this.CreditosAcreditados;
        }

        private int getCreditosComplementarios(){
            return this.CreditosComplementarios;
        }
    }
}
