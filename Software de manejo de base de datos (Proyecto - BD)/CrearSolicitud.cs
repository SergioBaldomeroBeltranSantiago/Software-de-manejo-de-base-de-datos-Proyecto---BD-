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
    public partial class CrearSolicitud : Form
    {

        public Interfaz_Estudiante ventana_anterior;

        public CrearSolicitud()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ventana_anterior.Visible = true;
            this.Dispose();
        }

        private void btn_SolicitarTramite_Click(object sender, EventArgs e)
        {
            switch (cb_ListaTramites.SelectedIndex) {
                case 0:
                    break;
                default:
                    break;
            }
        }
    }
}
