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
    public partial class Interfaz_Admin : Form
    {

        public Conexion_Usuarios ventana_anterior;
        public SqlConnection red;
        public string tabla;
        public Carrera carrera;
        public Estudiante alumno;
        public Encargado encargado;
        public Tramite tramite;
        public Solicitud solicitud;

        public Interfaz_Admin()
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

        private void construirTabla(string tabla) {
            if (dgv_Tablas.Rows.Count > 0) dgv_Tablas.Rows.Clear();
            if (dgv_Tablas.Columns.Count > 0) dgv_Tablas.Columns.Clear();
            List<string> listacolumnas = Conexion.obtenerColumnas(red, tabla);
            dgv_Tablas.ColumnCount = listacolumnas.Count;
            for (int i = 0; i < listacolumnas.Count; i++) {
                dgv_Tablas.Columns[i].Name = listacolumnas[i].ToString();
            }
            llenarTabla(tabla);
        }

        private void llenarTabla(string tabla) {
            List<string> listaregistros = Conexion.obtenerValores(red, tabla, "", "", "", "");
            int indice;
            int conteo;
            switch (tabla)
            {
                case "Carrera":
                    indice = 3;
                    conteo = listaregistros.Count / indice;
                    for (int i = 0; i < conteo; i++)
                    {
                        dgv_Tablas.Rows.Add(listaregistros[((indice * i) + 0)], 
                                            listaregistros[((indice * i) + 1)],
                                            listaregistros[((indice * i) + 2)]);
                    }
                    break;
                case "Alumno":
                    indice = 8;
                    conteo = listaregistros.Count / indice;
                    for (int i = 0; i < conteo; i++)
                    {
                        dgv_Tablas.Rows.Add(listaregistros[((indice * i) + 0)],
                                            listaregistros[((indice * i) + 1)],
                                            listaregistros[((indice * i) + 2)],
                                            listaregistros[((indice * i) + 3)],
                                            listaregistros[((indice * i) + 4)],
                                            listaregistros[((indice * i) + 5)],
                                            listaregistros[((indice * i) + 6)],
                                            listaregistros[((indice * i) + 7)]);
                    }
                    break;
                case "Encargado":
                    indice = 4;
                    conteo = listaregistros.Count / indice;
                    for (int i = 0; i < conteo; i++)
                    {
                        dgv_Tablas.Rows.Add(listaregistros[((indice * i) + 0)],
                                            listaregistros[((indice * i) + 1)],
                                            listaregistros[((indice * i) + 2)],
                                            listaregistros[((indice * i) + 3)]);
                    }
                    break;
                case "Tramite":
                    indice = 3;
                    conteo = listaregistros.Count / indice;
                    for (int i = 0; i < conteo; i++)
                    {
                        dgv_Tablas.Rows.Add(listaregistros[((indice * i) + 0)],
                                            listaregistros[((indice * i) + 1)],
                                            listaregistros[((indice * i) + 2)]);
                    }
                    break;
                default:
                    indice = 6;
                    conteo = listaregistros.Count / indice;
                    for (int i = 0; i < conteo; i++)
                    {
                        dgv_Tablas.Rows.Add(listaregistros[((indice * i) + 0)],
                                            listaregistros[((indice * i) + 1)],
                                            listaregistros[((indice * i) + 2)],
                                            listaregistros[((indice * i) + 3)],
                                            listaregistros[((indice * i) + 4)],
                                            listaregistros[((indice * i) + 5)]);
                    }
                    break;
            }
        }

        private void btn_Carrera_Click(object sender, EventArgs e)
        {
            construirTabla("Carrera");
            tabla = "Carrera";
            tbc_RegistroUnico.SelectedIndex = 0;
        }

        private void btn_Alumno_Click(object sender, EventArgs e)
        {
            construirTabla("Alumno");
            tabla = "Alumno";
            tbc_RegistroUnico.SelectedIndex = 1;
        }

        private void btn_Encargado_Click(object sender, EventArgs e)
        {
            construirTabla("Encargado");
            tabla = "Encargado";
            tbc_RegistroUnico.SelectedIndex = 2;
        }

        private void btn_Tramite_Click(object sender, EventArgs e)
        {
            construirTabla("Tramite");
            tabla = "Tramite";
            tbc_RegistroUnico.SelectedIndex = 3;
        }

        private void btn_Solicitud_Click(object sender, EventArgs e)
        {
            construirTabla("Solicitud");
            tabla = "Solicitud";
            tbc_RegistroUnico.SelectedIndex = 4;
        }

        private void dgv_Tablas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0) {
                switch (tabla) {
                    case "Carrera":
                        txt_CodigoCarrera.Text = dgv_Tablas.Rows[indice].Cells[0].Value.ToString();
                        txt_NombreCarrera.Text = dgv_Tablas.Rows[indice].Cells[1].Value.ToString();
                        txt_CreditosTotales.Text = dgv_Tablas.Rows[indice].Cells[2].Value.ToString();
                        carrera = new Carrera(dgv_Tablas.Rows[indice].Cells[0].Value.ToString(),
                                              dgv_Tablas.Rows[indice].Cells[1].Value.ToString(),
                                              Convert.ToInt32(dgv_Tablas.Rows[indice].Cells[2].Value));
                        break;
                    case "Alumno":
                        txt_NumeroControlAlumno.Text = dgv_Tablas.Rows[indice].Cells[0].Value.ToString();
                        txt_NombreAlumno.Text = dgv_Tablas.Rows[indice].Cells[1].Value.ToString();
                        txt_FechaNacimiento.Text = dgv_Tablas.Rows[indice].Cells[2].Value.ToString();
                        txt_FechaIngreso.Text = dgv_Tablas.Rows[indice].Cells[3].Value.ToString();
                        txt_Promedio.Text = dgv_Tablas.Rows[indice].Cells[4].Value.ToString();
                        txt_CodigoCarreraAlumno.Text = dgv_Tablas.Rows[indice].Cells[5].Value.ToString();
                        txt_CreditosCursados.Text = dgv_Tablas.Rows[indice].Cells[6].Value.ToString();
                        txt_CreditosComplementarios.Text = dgv_Tablas.Rows[indice].Cells[7].Value.ToString();
                        alumno = new Estudiante(dgv_Tablas.Rows[indice].Cells[0].Value.ToString(),
                                                dgv_Tablas.Rows[indice].Cells[1].Value.ToString(),
                                                dgv_Tablas.Rows[indice].Cells[2].Value.ToString(),
                                                dgv_Tablas.Rows[indice].Cells[3].Value.ToString(),
                                                Convert.ToDecimal(dgv_Tablas.Rows[indice].Cells[4].Value),
                                                dgv_Tablas.Rows[indice].Cells[5].Value.ToString(),
                                                Convert.ToInt32(dgv_Tablas.Rows[indice].Cells[6].Value),
                                                Convert.ToInt32(dgv_Tablas.Rows[indice].Cells[7].Value));
                        break;
                    case "Encargado":
                        txt_ClaveEncargado.Text = dgv_Tablas.Rows[indice].Cells[0].Value.ToString();
                        txt_NombreEncargado.Text = dgv_Tablas.Rows[indice].Cells[1].Value.ToString();
                        txt_CorreoE.Text = dgv_Tablas.Rows[indice].Cells[2].Value.ToString();
                        txt_Telefono.Text = dgv_Tablas.Rows[indice].Cells[3].Value.ToString();
                        encargado = new Encargado(dgv_Tablas.Rows[indice].Cells[0].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[1].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[2].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[3].Value.ToString());
                        break;
                    case "Tramite":
                        txt_CodigoTramite.Text = dgv_Tablas.Rows[indice].Cells[0].Value.ToString();
                        txt_NombreTramite.Text = dgv_Tablas.Rows[indice].Cells[1].Value.ToString();
                        txt_Descripcion.Text = dgv_Tablas.Rows[indice].Cells[2].Value.ToString();
                        tramite = new Tramite(dgv_Tablas.Rows[indice].Cells[0].Value.ToString(),
                                              dgv_Tablas.Rows[indice].Cells[1].Value.ToString(),
                                              dgv_Tablas.Rows[indice].Cells[2].Value.ToString());
                        break;
                    default:
                        txt_NumeroSolicitud.Text = dgv_Tablas.Rows[indice].Cells[0].Value.ToString();
                        txt_MatriculaAlumno.Text = dgv_Tablas.Rows[indice].Cells[1].Value.ToString();
                        txt_ClaveEncargadoSolicitud.Text = dgv_Tablas.Rows[indice].Cells[2].Value.ToString();
                        txt_ClaveTramiteSoli.Text = dgv_Tablas.Rows[indice].Cells[3].Value.ToString();
                        txt_FechaSolicitud.Text = dgv_Tablas.Rows[indice].Cells[4].Value.ToString();
                        txt_Estatus.Text = dgv_Tablas.Rows[indice].Cells[5].Value.ToString();
                        solicitud = new Solicitud(Convert.ToInt32(dgv_Tablas.Rows[indice].Cells[0].Value),
                                                  dgv_Tablas.Rows[indice].Cells[1].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[2].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[3].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[4].Value.ToString(),
                                                  dgv_Tablas.Rows[indice].Cells[5].Value.ToString());
                        break;
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            switch (tabla)
            {
                case "Carrera":
                    txt_CodigoCarrera.Text = "";
                    txt_NombreCarrera.Text = "";
                    txt_CreditosTotales.Text = "";
                    break;
                case "Alumno":
                    txt_NumeroControlAlumno.Text = "";
                    txt_NombreAlumno.Text = "";
                    txt_FechaNacimiento.Text = "";
                    txt_FechaIngreso.Text = "";
                    txt_Promedio.Text = "";
                    txt_CodigoCarreraAlumno.Text = "";
                    txt_CreditosCursados.Text = "";
                    txt_CreditosComplementarios.Text = "";
                    break;
                case "Encargado":
                    txt_ClaveEncargado.Text = "";
                    txt_NombreEncargado.Text = "";
                    txt_CorreoE.Text = "";
                    txt_Telefono.Text = "";
                    break;
                case "Tramite":
                    txt_CodigoTramite.Text = "";
                    txt_NombreTramite.Text = "";
                    txt_Descripcion.Text = "";
                    break;
                default:
                    txt_NumeroSolicitud.Text = "";
                    txt_MatriculaAlumno.Text = "";
                    txt_ClaveEncargadoSolicitud.Text = "";
                    txt_ClaveTramiteSoli.Text = "";
                    txt_FechaSolicitud.Text = "";
                    txt_Estatus.Text = "";
                    break;
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string campofiltro;
            string filtro;
            switch (tabla) {
                case "Carrera":
                    campofiltro = "Cod_Car";
                    filtro = txt_CodigoCarrera.Text;
                    break;
                case "Alumno":
                    campofiltro = "Num_Con";
                    filtro = txt_NumeroControlAlumno.Text;
                    break;
                case "Encargado":
                    campofiltro = "Num_Con";
                    filtro = txt_ClaveEncargado.Text;
                    break;
                case "Tramite":
                    campofiltro = "Codigo";
                    filtro = txt_CodigoTramite.Text;
                    break;
                default:
                    campofiltro = "Num_Sol";
                    filtro = txt_NumeroSolicitud.Text;
                    break;
            }
            Conexion.eliminarRegistro(red, tabla, campofiltro, filtro);
            construirTabla(tabla);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            List<string> camposfiltro = new List<string>();
            List<string> filtros = new List<string>();
            switch (tabla)
            {
                case "Carrera":
                    camposfiltro.Add("Cod_Car");
                    camposfiltro.Add("Nom_Car");
                    camposfiltro.Add("Cred_Tot");
                    filtros.Add(txt_CodigoCarrera.Text);
                    filtros.Add(txt_NombreCarrera.Text);
                    filtros.Add(txt_CreditosTotales.Text);
                    break;
                case "Alumno":
                    camposfiltro.Add("Num_Con");
                    camposfiltro.Add("Nombre");
                    camposfiltro.Add("Fec_Nac");
                    camposfiltro.Add("Fec_Ingreso");
                    camposfiltro.Add("Promedio");
                    camposfiltro.Add("Cod_Car");
                    camposfiltro.Add("Cred_Acred");
                    camposfiltro.Add("Cred_Com");
                    filtros.Add(txt_NumeroControlAlumno.Text);
                    filtros.Add(txt_NombreAlumno.Text);
                    filtros.Add(txt_FechaNacimiento.Text);
                    filtros.Add(txt_FechaIngreso.Text);
                    filtros.Add(txt_Promedio.Text);
                    filtros.Add(txt_CodigoCarreraAlumno.Text);
                    filtros.Add(txt_CreditosCursados.Text);
                    filtros.Add(txt_CreditosComplementarios.Text);
                    break;
                case "Encargado":
                    camposfiltro.Add("Num_Con");
                    camposfiltro.Add("Nombre");
                    camposfiltro.Add("Correo");
                    camposfiltro.Add("Telefono");
                    filtros.Add(txt_ClaveEncargado.Text);
                    filtros.Add(txt_NombreEncargado.Text);
                    filtros.Add(txt_CorreoE.Text);
                    filtros.Add(txt_Telefono.Text);
                    break;
                case "Tramite":
                    camposfiltro.Add("Codigo");
                    camposfiltro.Add("Nombre");
                    camposfiltro.Add("Descripcion");
                    filtros.Add(txt_CodigoTramite.Text);
                    filtros.Add(txt_NombreTramite.Text);
                    filtros.Add(txt_Descripcion.Text);
                    break;
                default:
                    camposfiltro.Add("Num_Sol");
                    camposfiltro.Add("Clave_Al");
                    camposfiltro.Add("Clave_En");
                    camposfiltro.Add("Clave_Tr");
                    camposfiltro.Add("Fec_Sol");
                    camposfiltro.Add("Estatus");
                    filtros.Add(txt_NumeroSolicitud.Text);
                    filtros.Add(txt_MatriculaAlumno.Text);
                    filtros.Add(txt_ClaveEncargadoSolicitud.Text);
                    filtros.Add(txt_ClaveTramiteSoli.Text);
                    filtros.Add(txt_FechaSolicitud.Text);
                    filtros.Add(txt_Estatus.Text);
                    break;
            }
            Conexion.actualizarRegistroUniversal(red, tabla, camposfiltro, filtros);
            construirTabla(tabla);
        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            List<string> camposfiltro = new List<string>();
            List<string> filtros = new List<string>();
            switch (tabla)
            {
                case "Carrera":
                    camposfiltro.Add("Cod_Car");
                    camposfiltro.Add("Nom_Car");
                    camposfiltro.Add("Cred_Tot");
                    filtros.Add(txt_CodigoCarrera.Text);
                    filtros.Add(txt_NombreCarrera.Text);
                    filtros.Add(txt_CreditosTotales.Text);
                    break;
                case "Alumno":
                    camposfiltro.Add("Num_Con");
                    camposfiltro.Add("Nombre");
                    camposfiltro.Add("Fec_Nac");
                    camposfiltro.Add("Fec_Ingreso");
                    camposfiltro.Add("Promedio");
                    camposfiltro.Add("Cod_Car");
                    camposfiltro.Add("Cred_Acred");
                    camposfiltro.Add("Cred_Com");
                    filtros.Add(txt_NumeroControlAlumno.Text);
                    filtros.Add(txt_NombreAlumno.Text);
                    filtros.Add(txt_FechaNacimiento.Text);
                    filtros.Add(txt_FechaIngreso.Text);
                    filtros.Add(txt_Promedio.Text);
                    filtros.Add(txt_CodigoCarreraAlumno.Text);
                    filtros.Add(txt_CreditosCursados.Text);
                    filtros.Add(txt_CreditosComplementarios.Text);
                    break;
                case "Encargado":
                    camposfiltro.Add("Num_Con");
                    camposfiltro.Add("Nombre");
                    camposfiltro.Add("Correo");
                    camposfiltro.Add("Telefono");
                    filtros.Add(txt_ClaveEncargado.Text);
                    filtros.Add(txt_NombreEncargado.Text);
                    filtros.Add(txt_CorreoE.Text);
                    filtros.Add(txt_Telefono.Text);
                    break;
                case "Tramite":
                    camposfiltro.Add("Codigo");
                    camposfiltro.Add("Nombre");
                    camposfiltro.Add("Descripcion");
                    filtros.Add(txt_CodigoTramite.Text);
                    filtros.Add(txt_NombreTramite.Text);
                    filtros.Add(txt_Descripcion.Text);
                    break;
                default:
                    camposfiltro.Add("Num_Sol");
                    camposfiltro.Add("Clave_Al");
                    camposfiltro.Add("Clave_En");
                    camposfiltro.Add("Clave_Tr");
                    camposfiltro.Add("Fec_Sol");
                    camposfiltro.Add("Estatus");
                    filtros.Add(txt_NumeroSolicitud.Text);
                    filtros.Add(txt_MatriculaAlumno.Text);
                    filtros.Add(txt_ClaveEncargadoSolicitud.Text);
                    filtros.Add(txt_ClaveTramiteSoli.Text);
                    filtros.Add(txt_FechaSolicitud.Text);
                    filtros.Add(txt_Estatus.Text);
                    break;
            }
            Conexion.insertarRegistroUniversal(red, tabla, camposfiltro, filtros);
            construirTabla(tabla);
        }
    }
}
