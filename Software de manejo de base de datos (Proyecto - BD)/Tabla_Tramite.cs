using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Tramite
    {
        private string Codigo;
        private string Nombre;
        private string Descripcion;
        public Tramite(string codigo, string nombre, string descripcion)
        {
            Codigo = codigo ?? throw new ArgumentNullException(nameof(codigo));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Descripcion = descripcion ?? throw new ArgumentNullException(nameof(descripcion));
        }

        private string getCodigo(){
            return this.Codigo;
        }

        private string getNombre(){
            return this.Nombre;
        }

        private string getDescripcion(){
            return this.Descripcion;
        }
    }
}
