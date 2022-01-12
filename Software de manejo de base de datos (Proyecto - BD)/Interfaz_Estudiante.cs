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

    public partial class Interfaz_Estudiante : Form
    {

        public Conexion_Usuarios ventana_anterior;

        public Interfaz_Estudiante()
        {
            InitializeComponent();
        }

        private void btn_CerrarPrograma_Click(object sender, EventArgs e)
        {
            Botones.cerrarAplicacion();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            ventana_anterior.Visible = true;
            this.Dispose();
        }
    }
}
