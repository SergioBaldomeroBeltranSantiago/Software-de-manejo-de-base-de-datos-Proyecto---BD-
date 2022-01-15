using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    public partial class CrearSolicitud : Form
    {

        public Interfaz_Estudiante ventana_anterior;
        public SqlConnection antenas;
        public Estudiante esquincle;

        public CrearSolicitud()
        {
            InitializeComponent();
            btn_SolicitarTramite.Enabled = false;
            CenterToScreen();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            ventana_anterior.Visible = true;
            this.Dispose();
        }

        private void btn_SolicitarTramite_Click(object sender, EventArgs e)
        {
            var aleatorio = new Random();
            List<string> encargao = Conexion.obtenerValores(antenas, "Encargado", "", "", "", "");
            int conteo = encargao.Count / 4;
            List<string> tramitasion = Conexion.obtenerValores(antenas, "Tramite", "Nombre", cb_ListaTramites.GetItemText(cb_ListaTramites.SelectedItem), "", "");
            Conexion.insertarValoresSolicitud(antenas, esquincle.NumeroControl, encargao[(aleatorio.Next(conteo)*4)].ToString(), tramitasion[0].ToString());
            ventana_anterior.obtenerDatosSolicitud();
            ventana_anterior.Visible = true;
            this.Dispose();
        }

        public void cargarListaTramites() {
            List<string> valoresTramites = Conexion.obtenerValores(antenas, "Tramite", "", "", "", "");
            int conteo = valoresTramites.Count / 3;
            for (int i = 0; i < conteo; i++) {
                cb_ListaTramites.Items.Add(valoresTramites[((i*3)+1)]);
            }
        }

        private void cb_ListaTramites_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_SolicitarTramite.Enabled = cb_ListaTramites.SelectedIndex != -1;
        }
    }
}
