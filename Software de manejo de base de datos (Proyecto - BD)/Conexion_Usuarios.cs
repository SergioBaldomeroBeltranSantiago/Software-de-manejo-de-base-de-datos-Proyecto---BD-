using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public partial class Conexion_Usuarios : Form
    {

        bool NombreUsuarioValido = false;
        bool ContraseñaValida = false;
        bool EstatusConexion = false;
        SqlConnection conectate;
        public string NombreServidor;
        public Conexion_BD ventana_anterior;

        public Conexion_Usuarios()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Botones.cerrarAplicacion();
        }

        private void txt_NombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros_Entrada.soloLetras(e);
        }

        private void txt_NombreUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_NombreUsuario.Text.Equals(""))
            {
                lb_Nombre_Usuario_Retro.Text = "Ingrese un nombre de usuario valido.";
                lb_Nombre_Usuario_Retro.ForeColor = Color.Black;
                NombreUsuarioValido = false;
            }
            else
            {
                lb_Nombre_Usuario_Retro.Text = "Nombre de usuario valido.";
                lb_Nombre_Usuario_Retro.ForeColor = Color.Green;
                NombreUsuarioValido = true;
            }
            habilitarBotonConexion(ContraseñaValida, NombreUsuarioValido);
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Filtros_Entrada.soloLetras(e);
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text.Equals(""))
            {
                lb_Contraseña_Retro.Text = "Ingrese su contraseña.";
                lb_Contraseña_Retro.ForeColor = Color.Black;
                ContraseñaValida = false;
            }
            else
            {
                lb_Contraseña_Retro.Text = "Contraseña aceptada.";
                lb_Contraseña_Retro.ForeColor = Color.Green;
                ContraseñaValida = true;
            }
            habilitarBotonConexion(ContraseñaValida, NombreUsuarioValido);
        }

        public void habilitarBotonConexion(bool ContraValida, bool NomUsValido)
        {
            btn_Conectar.Enabled = ContraValida && NomUsValido;
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            conectate = Conexion.parametrizarConexion(NombreServidor, "ProyectoDB", txt_NombreUsuario.Text, txt_Contraseña.Text);
            EstatusConexion = Conexion.iniciarConexion(conectate);
            if (EstatusConexion)
            {
                switch (txt_NombreUsuario.Text)
                {
                    case "Estudiante":
                        Interfaz_Estudiante sig_ventana = new Interfaz_Estudiante();
                        sig_ventana.Visible = true;
                        sig_ventana.ventana_anterior = this;
                        break;
                    case "Encargado":
                        break;
                    default:
                        break;
                }
                txt_NombreUsuario.Text = "";
                txt_Contraseña.Text = "";
                this.Visible = false;
                
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            ventana_anterior.Visible = true;
            this.Dispose();
        }
    }
}
