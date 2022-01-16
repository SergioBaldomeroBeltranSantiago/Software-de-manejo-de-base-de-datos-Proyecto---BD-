using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Encargado
    {
        private string NumeroControl;
        private string Nombre;
        private string Correo;
        private string Telefono;

        public Encargado(string numeroControl, string nombre, string correo, string telefono)
        {
            NumeroControl = numeroControl ?? throw new ArgumentNullException(nameof(numeroControl));
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Correo = correo ?? throw new ArgumentNullException(nameof(correo));
            Telefono = telefono ?? throw new ArgumentNullException(nameof(telefono));
        }

        private string getNUmeroControl(){
            return this.NumeroControl;
        }

        private string getNombre(){
            return this.Nombre;
        }

        private string getCorreo(){
            return this.Correo;
        }

        private string getTelefono(){
            return this.Telefono;
        }
    }
}
