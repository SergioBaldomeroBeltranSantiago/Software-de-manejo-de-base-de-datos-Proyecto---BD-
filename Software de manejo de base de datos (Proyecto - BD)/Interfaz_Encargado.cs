using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public partial class Interfaz_Encargado : Form
    {

        public Conexion_Usuarios ventana_anterior;
        public SqlConnection enchufe;
        public SeleccionarUsuario ventana_escoger;
        public Encargado encargao;
        public string EncargaoOriginal;
        public string EstatusOriginal;
        public int indice;

        public Interfaz_Encargado()
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

        public void llenarTextos() {
            txt_NombreEncargado.Text = encargao.Nombre;
            txt_MatriculaEncargado.Text = encargao.NumeroControl;
        }

        public List<string> cargarSolicitudes() {
            List<string> salida = Conexion.obtenerValores(enchufe, "Solicitud", "", "", "Fec_Sol", "ASC");
            return salida;
        }

        public void visualizarSolicitudes() {
            if(dgv_SolicitudesPendientes.Rows.Count > 0) dgv_SolicitudesPendientes.Rows.Clear();
            List<string> solicitudes = cargarSolicitudes();
            int conteo = solicitudes.Count / 6;
            for (int i = 0; i < conteo; i++) {
                dgv_SolicitudesPendientes.Rows.Add(solicitudes[((6 * i) + 0)].ToString(),
                                                   solicitudes[((6 * i) + 1)].ToString(),
                                                   solicitudes[((6 * i) + 2)].ToString(),
                                                   solicitudes[((6 * i) + 3)].ToString(),
                                                   solicitudes[((6 * i) + 4)].ToString(),
                                                   solicitudes[((6 * i) + 5)].ToString());
            }
        }

        private void dgv_SolicitudesPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_SolicitudesPendientes.Rows[indice].Cells[n].Value.ToString();
            indice = e.RowIndex;
            if (indice >= 0) {
                List<string> datos_Alumno = Conexion.obtenerValores(enchufe, "Alumno", "Num_Con", dgv_SolicitudesPendientes.Rows[indice].Cells[1].Value.ToString(), "", "");
                List<string> datos_Encargado = Conexion.obtenerValores(enchufe, "Encargado", "Num_Con", dgv_SolicitudesPendientes.Rows[indice].Cells[2].Value.ToString(), "", "");
                List<string> datos_Tramite = Conexion.obtenerValores(enchufe, "Tramite", "Codigo", dgv_SolicitudesPendientes.Rows[indice].Cells[3].Value.ToString(), "", "");
                lb_NombreSolicitante.Text = datos_Alumno[1].ToString();
                lb_NombreEncargado.Text = datos_Encargado[1].ToString();
                EncargaoOriginal = datos_Encargado[1].ToString();
                lb_NombreTramite.Text = datos_Tramite[1].ToString();
                lb_FechaSolicitud.Text = dgv_SolicitudesPendientes.Rows[indice].Cells[4].Value.ToString();
                cb_EstatusSolicitud.SelectedIndex = cb_EstatusSolicitud.Items.IndexOf(dgv_SolicitudesPendientes.Rows[indice].Cells[5].Value.ToString());
                EstatusOriginal = dgv_SolicitudesPendientes.Rows[indice].Cells[5].Value.ToString();
            }
        }
        private void btn_ActualizarSolicitud_Click(object sender, EventArgs e)
        {
            Conexion.actualizarValoresSolicitud(enchufe, Convert.ToInt32(dgv_SolicitudesPendientes.Rows[indice].Cells[0].Value), cb_EstatusSolicitud.SelectedItem.ToString());
            visualizarSolicitudes();
            btn_ActualizarSolicitud.Enabled = false;
        }

        private void cb_EstatusSolicitud_DropDownClosed(object sender, EventArgs e)
        {
            btn_ActualizarSolicitud.Enabled = !cb_EstatusSolicitud.SelectedItem.ToString().Equals(EstatusOriginal);
        }
    }
}
