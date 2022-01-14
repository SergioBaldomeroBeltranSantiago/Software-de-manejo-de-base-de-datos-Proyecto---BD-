using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    class Encargado
    {
        private string NumeroControl { get; set; }
        private string Nombre { get; set; }
        private string Correo { get; set; }
        private string Telefono { get; set; }

        public Encargado(string numeroControl, string nombre, string correo, string telefono)
        {
            NumeroControl = numeroControl ?? throw new ArgumentNullException(nameof(numeroControl));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Correo = correo ?? throw new ArgumentNullException(nameof(correo));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
        }

        public Encargado() { }
    }
}
