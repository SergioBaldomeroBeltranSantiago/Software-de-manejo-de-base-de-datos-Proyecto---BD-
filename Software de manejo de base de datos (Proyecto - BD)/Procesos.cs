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

        public static void soloLetras(EventArgs e)
        {
            if (!Char.IsLetter(e.ToString()) && !Char.IsControl(e.ToString()))
            {
                e.Handled = true;
            }
        }

        public static void soloNumeros(EventArgs e)
        {
            if (!Char.IsNumber(e.ToString()) && !Char.IsControl(e.ToString()))
            {
                e.Handled = true;
            }
        }
    }
}