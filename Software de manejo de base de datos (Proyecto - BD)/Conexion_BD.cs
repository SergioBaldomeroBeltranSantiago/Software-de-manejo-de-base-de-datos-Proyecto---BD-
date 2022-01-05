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
    public partial class Conexion_BD : Form
    {

        bool EstatusConexion = false;

        public Conexion_BD()
        {
            InitializeComponent();
        }

        private void txt_NombreServidor_TextChanged(object sender, EventArgs e)
        {
            if (txt_NombreServidor.Text.Equals(""))
            {
                lb_NombreServidor_Retro.Text = "Ingrese un nombre de servidor valido.";
                lb_NombreServidor_Retro.ForeColor = Color.Black;
            }
            else {
                lb_NombreServidor_Retro.Text = "Nombre de servidor aceptado.";
                lb_NombreServidor_Retro.ForeColor = Color.Green;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Botones.cerrarAplicacion();
        }

        private void btn_ProbarConexion_Click(object sender, EventArgs e)
        {
            //EstatusConexion = procedimiento para conectar a la base de datos como testeo;
            btn_Continuar.Enabled = EstatusConexion;
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            Conexion_Usuarios sig_ventana = new Conexion_Usuarios();
            sig_ventana.Visible = true;
            this.Visible = false;
        }
    }
}
