using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public class Filtros_Entrada
    {

        public static void soloLetras(KeyPressEventArgs entrada)
        {
            if (!char.IsLetter(entrada.KeyChar) && !char.IsControl(entrada.KeyChar))
            {
                entrada.Handled = true;
            }
        }

        public static void soloNumeros(KeyPressEventArgs entrada)
        {
            if (!char.IsNumber(entrada.KeyChar) && !char.IsControl(entrada.KeyChar))
            {
                entrada.Handled = true;
            }
        }

        public static bool validarLongitudEntrada(string entrada, int longitud_deseada) {
            return entrada.ToString().Length == longitud_deseada;
        }
    }

    public class Botones
    {
        public static void cerrarAplicacion()
        {
            if (Application.MessageLoop)
            {
                // WinForms app
                Application.Exit();
            }
            else
            {
                // Console app
                Environment.Exit(0);
            }
        }
    }
}