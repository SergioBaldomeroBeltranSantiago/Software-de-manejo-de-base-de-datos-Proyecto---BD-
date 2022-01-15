using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public partial class SeleccionarUsuario : Form
    {

        public Conexion_Usuarios ventana_anterior;
        public SqlConnection conectao;
        public string TipoUsuario;
        public SeleccionarUsuario()
        {
            InitializeComponent();
            btn_Continuar.Enabled = false;
            CenterToScreen();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ventana_anterior.Visible = true;
            this.Dispose();
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if (TipoUsuario.Equals("Alumno"))
            {
                Interfaz_Estudiante sig_ventana = new Interfaz_Estudiante();
                sig_ventana.ventana_anterior = ventana_anterior;
                sig_ventana.chamaco = parametrizarEstudiante(Conexion.obtenerValores(conectao, "Alumno", "Num_Con", cb_ListaUsuarios.GetItemText(cb_ListaUsuarios.SelectedItem), "", ""));
                sig_ventana.cablesito = conectao;
                sig_ventana.ventana_escoger = this;
                sig_ventana.Visible = true;
                sig_ventana.colocarTextos(sig_ventana.chamaco);
                sig_ventana.obtenerDatosSolicitud();
            }
            else {
                Interfaz_Encargado sig_ventana = new Interfaz_Encargado();
                sig_ventana.ventana_anterior = ventana_anterior;
                sig_ventana.encargao = parametrizarEncargado(Conexion.obtenerValores(conectao, "Encargado", "Num_Con", cb_ListaUsuarios.GetItemText(cb_ListaUsuarios.SelectedItem), "", ""));
                sig_ventana.enchufe = conectao;
                sig_ventana.ventana_escoger = this;
                sig_ventana.Visible = true;
                sig_ventana.llenarTextos();
                sig_ventana.visualizarSolicitudes();
            }
            this.Visible = false;
        }

        public void llenarListaUsuarios() {
            List<string> usuarios = Conexion.obtenerValores(conectao, TipoUsuario, "", "", "", "");
            int conteo = TipoUsuario.Equals("Alumno") ? usuarios.Count / 8 : usuarios.Count / 4;
            int indexmult = TipoUsuario.Equals("Alumno") ? 8 : 4;
            for (int i = 0; i < conteo; i++) {
                cb_ListaUsuarios.Items.Add(usuarios[indexmult*i].ToString());
            }
        }

        private Estudiante parametrizarEstudiante(List<string> atributos)
        {
            return new Estudiante(atributos[0],
                                  atributos[1],
                                  atributos[2],
                                  atributos[3],
                                  Convert.ToDecimal(atributos[4]),
                                  atributos[5],
                                  Convert.ToInt32(atributos[6]),
                                  Convert.ToInt32(atributos[7]));
        }

        private Encargado parametrizarEncargado(List<string> atributos) {
            return new Encargado(atributos[0],
                                 atributos[1],
                                 atributos[2],
                                 atributos[3]);
        }

        private void cb_ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Continuar.Enabled = cb_ListaUsuarios.SelectedIndex != -1;
        }
    }
}
