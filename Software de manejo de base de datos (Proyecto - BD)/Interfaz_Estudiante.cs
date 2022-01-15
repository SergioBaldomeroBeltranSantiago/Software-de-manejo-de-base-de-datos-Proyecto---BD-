using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{

    public partial class Interfaz_Estudiante : Form
    {

        public Conexion_Usuarios ventana_anterior;
        public SeleccionarUsuario ventana_escoger;
        bool TramiteExiste = false;
        public Estudiante chamaco;
        public Tramite solicitud;
        public SqlConnection cablesito;

        public Interfaz_Estudiante()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_CerrarPrograma_Click(object sender, EventArgs e)
        {
            Botones.cerrarAplicacion();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            ventana_anterior.Visible = true;
            this.Dispose();
            ventana_escoger.Dispose();
        }

        private void btn_IniciarTramite_Click(object sender, EventArgs e)
        {
            if (!TramiteExiste)
            {
                CrearSolicitud sig_ventana = new CrearSolicitud();
                sig_ventana.ventana_anterior = this;
                sig_ventana.Visible = true;
                sig_ventana.antenas = cablesito;
                sig_ventana.esquincle = chamaco;
                sig_ventana.cargarListaTramites();
                this.Visible = false;
            }
            else {
                MessageBox.Show("Tramite en progreso, no se puede iniciar nuevo tramite.");
            }
        }

        public void colocarTextos(Estudiante chamacos) {
            txt_NombreEstudiante.Text = chamacos.Nombre;
            txt_matricula.Text = chamacos.NumeroControl;
        }

        public void obtenerDatosSolicitud() {
            if (chamaco != null)
            {
                List<string> valoresSolicitud = Conexion.obtenerValores(cablesito, "Solicitud", "Clave_Al", chamaco.NumeroControl, "", "");
                if (valoresSolicitud.Count > 0)
                {
                    List<string> valoresTramite = Conexion.obtenerValores(cablesito, "Tramite", "Codigo", valoresSolicitud[3].ToString(), "", "");
                    List<string> valoresEncargado = Conexion.obtenerValores(cablesito, "Encargado", "Num_Con", valoresSolicitud[2].ToString(), "", "");
                    lb_NumeroSolicitud.Text = valoresSolicitud[0].ToString();
                    lb_NombreTramite.Text = valoresTramite[1].ToString();
                    lb_FechaSolicitud.Text = valoresSolicitud[4].ToString();
                    lb_NombreEncargado.Text = valoresEncargado[1].ToString();
                    lb_EstatusTramite.Text = valoresSolicitud[5].ToString();
                    TramiteExiste = true;
                }
                else
                {
                    lb_NumeroSolicitud.Text = "No Aplica";
                    lb_NombreTramite.Text = "No Existe";
                    lb_FechaSolicitud.Text = "2022/02/31";
                    lb_NombreEncargado.Text = "Mr. Smith";
                    lb_EstatusTramite.Text = "Mimido";
                    TramiteExiste = false;
                }
            }
        }
    }
}
