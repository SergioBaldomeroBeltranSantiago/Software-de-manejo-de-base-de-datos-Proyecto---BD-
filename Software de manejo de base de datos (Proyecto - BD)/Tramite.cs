using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    class Tramite
    {
        private string Codigo { get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }

        public Tramite(string codigo, string nombre, string descripcion)
        {
            Codigo = codigo ?? throw new ArgumentNullException(nameof(codigo));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
        }

        public Tramite()
        {
        }
    }
}
