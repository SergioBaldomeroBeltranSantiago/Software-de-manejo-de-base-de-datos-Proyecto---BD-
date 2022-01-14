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
        bool TramiteExiste = false;
        public Estudiante chamaco;

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

        private void btn_IniciarTramite_Click(object sender, EventArgs e)
        {
            if (!TramiteExiste)
            {
                CrearSolicitud sig_ventana = new CrearSolicitud();
                sig_ventana.ventana_anterior = this;
                sig_ventana.Visible = true;
                this.Visible = false;
            }
            else {
                MessageBox.Show("Tramite en progreso, no se puede iniciar nuevo tramite.");
            }
        }
    }
}
