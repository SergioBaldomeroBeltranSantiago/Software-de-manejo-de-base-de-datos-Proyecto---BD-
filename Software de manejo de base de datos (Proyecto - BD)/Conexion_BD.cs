using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public partial class Conexion_BD : Form
    {

        public SqlConnection conectasion;

        public Conexion_BD()
        {
            InitializeComponent();
            CenterToScreen();
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
            conectasion = Conexion.parametrizarConexion(txt_NombreServidor.Text, "ProyectoDB", "Tester", "Tester");
            btn_Continuar.Enabled = Conexion.iniciarConexion(conectasion);
            Conexion.cerrarConexion(conectasion);
            
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            Conexion_Usuarios sig_ventana = new Conexion_Usuarios();
            sig_ventana.Visible = true;
            sig_ventana.NombreServidor = txt_NombreServidor.Text;
            sig_ventana.ventana_anterior = this;
            this.Visible = false;
        }
    }
}
