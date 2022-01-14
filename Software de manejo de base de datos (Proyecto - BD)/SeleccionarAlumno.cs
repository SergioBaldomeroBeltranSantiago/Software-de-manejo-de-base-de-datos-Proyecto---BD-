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
    public partial class SeleccionarAlumno : Form
    {

        public Conexion_Usuarios ventana_anterior;
        public SqlConnection conectao;
        public SeleccionarAlumno()
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
            Interfaz_Estudiante sig_ventana = new Interfaz_Estudiante();
            sig_ventana.ventana_anterior = ventana_anterior;
            sig_ventana.chamaco = parametrizarEstudiante(Conexion.obtenerValores(conectao, "Alumno", "Num_Con", cb_ListaAlumnos.GetItemText(cb_ListaAlumnos.SelectedItem), "", ""));
            sig_ventana.colocarTextos(sig_ventana.chamaco);
            sig_ventana.cablesito = conectao;
            sig_ventana.obtenerDatosSolicitud();
            sig_ventana.ventana_escoger = this;
            sig_ventana.Visible = true;
            this.Visible = false;
        }

        private void cb_ListaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Continuar.Enabled = cb_ListaAlumnos.SelectedIndex != -1;
        }

        public void llenarListaAlumnos() {
            List<string> alumnos = Conexion.obtenerValores(conectao, "Alumno", "", "", "", "");
            int conteo = alumnos.Count / 8;
            for (int i = 0; i < conteo; i++) {
                cb_ListaAlumnos.Items.Add(alumnos[8*i].ToString());
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
    }
}
