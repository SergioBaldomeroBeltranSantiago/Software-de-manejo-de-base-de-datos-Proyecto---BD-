
namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    partial class Interfaz_Encargado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_InformacionEncargado = new System.Windows.Forms.GroupBox();
            this.txt_NombreEncargado = new System.Windows.Forms.TextBox();
            this.txt_MatriculaEncargado = new System.Windows.Forms.TextBox();
            this.lb_useless_2 = new System.Windows.Forms.Label();
            this.lb_useless_1 = new System.Windows.Forms.Label();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_CerrarPrograma = new System.Windows.Forms.Button();
            this.dgv_SolicitudesPendientes = new System.Windows.Forms.DataGridView();
            this.NumeroSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave_Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_TramiteSeleccionado = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarSolicitud = new System.Windows.Forms.Button();
            this.cb_EstatusSolicitud = new System.Windows.Forms.ComboBox();
            this.lb_FechaSolicitud = new System.Windows.Forms.Label();
            this.lb_useless_7 = new System.Windows.Forms.Label();
            this.lb_useless_6 = new System.Windows.Forms.Label();
            this.lb_NombreTramite = new System.Windows.Forms.Label();
            this.lb_NombreSolicitante = new System.Windows.Forms.Label();
            this.lb_useless_5 = new System.Windows.Forms.Label();
            this.lb_useless_4 = new System.Windows.Forms.Label();
            this.lb_useless_3 = new System.Windows.Forms.Label();
            this.lb_NombreEncargado = new System.Windows.Forms.Label();
            this.gb_InformacionEncargado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolicitudesPendientes)).BeginInit();
            this.gb_TramiteSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_InformacionEncargado
            // 
            this.gb_InformacionEncargado.Controls.Add(this.txt_NombreEncargado);
            this.gb_InformacionEncargado.Controls.Add(this.txt_MatriculaEncargado);
            this.gb_InformacionEncargado.Controls.Add(this.lb_useless_2);
            this.gb_InformacionEncargado.Controls.Add(this.lb_useless_1);
            this.gb_InformacionEncargado.Location = new System.Drawing.Point(13, 14);
            this.gb_InformacionEncargado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_InformacionEncargado.Name = "gb_InformacionEncargado";
            this.gb_InformacionEncargado.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_InformacionEncargado.Size = new System.Drawing.Size(251, 164);
            this.gb_InformacionEncargado.TabIndex = 0;
            this.gb_InformacionEncargado.TabStop = false;
            this.gb_InformacionEncargado.Text = "Información del encargado";
            // 
            // txt_NombreEncargado
            // 
            this.txt_NombreEncargado.Location = new System.Drawing.Point(94, 127);
            this.txt_NombreEncargado.Name = "txt_NombreEncargado";
            this.txt_NombreEncargado.ReadOnly = true;
            this.txt_NombreEncargado.Size = new System.Drawing.Size(150, 26);
            this.txt_NombreEncargado.TabIndex = 3;
            // 
            // txt_MatriculaEncargado
            // 
            this.txt_MatriculaEncargado.Location = new System.Drawing.Point(94, 55);
            this.txt_MatriculaEncargado.Name = "txt_MatriculaEncargado";
            this.txt_MatriculaEncargado.ReadOnly = true;
            this.txt_MatriculaEncargado.Size = new System.Drawing.Size(150, 26);
            this.txt_MatriculaEncargado.TabIndex = 2;
            // 
            // lb_useless_2
            // 
            this.lb_useless_2.AutoSize = true;
            this.lb_useless_2.Location = new System.Drawing.Point(7, 127);
            this.lb_useless_2.Name = "lb_useless_2";
            this.lb_useless_2.Size = new System.Drawing.Size(69, 20);
            this.lb_useless_2.TabIndex = 1;
            this.lb_useless_2.Text = "Nombre:";
            // 
            // lb_useless_1
            // 
            this.lb_useless_1.AutoSize = true;
            this.lb_useless_1.Location = new System.Drawing.Point(7, 55);
            this.lb_useless_1.Name = "lb_useless_1";
            this.lb_useless_1.Size = new System.Drawing.Size(81, 20);
            this.lb_useless_1.TabIndex = 0;
            this.lb_useless_1.Text = "Matricula: ";
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(61, 199);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(127, 35);
            this.btn_CerrarSesion.TabIndex = 1;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_CerrarPrograma
            // 
            this.btn_CerrarPrograma.Location = new System.Drawing.Point(48, 268);
            this.btn_CerrarPrograma.Name = "btn_CerrarPrograma";
            this.btn_CerrarPrograma.Size = new System.Drawing.Size(150, 35);
            this.btn_CerrarPrograma.TabIndex = 2;
            this.btn_CerrarPrograma.Text = "Cerrar Programa";
            this.btn_CerrarPrograma.UseVisualStyleBackColor = true;
            this.btn_CerrarPrograma.Click += new System.EventHandler(this.btn_CerrarPrograma_Click);
            // 
            // dgv_SolicitudesPendientes
            // 
            this.dgv_SolicitudesPendientes.AllowUserToAddRows = false;
            this.dgv_SolicitudesPendientes.AllowUserToDeleteRows = false;
            this.dgv_SolicitudesPendientes.AllowUserToResizeColumns = false;
            this.dgv_SolicitudesPendientes.AllowUserToResizeRows = false;
            this.dgv_SolicitudesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SolicitudesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroSolicitud,
            this.Clave_Alumno,
            this.Clave_Encargado,
            this.Clave_Tramite,
            this.Fecha_Solicitud,
            this.Estatus});
            this.dgv_SolicitudesPendientes.Location = new System.Drawing.Point(271, 12);
            this.dgv_SolicitudesPendientes.Name = "dgv_SolicitudesPendientes";
            this.dgv_SolicitudesPendientes.ReadOnly = true;
            this.dgv_SolicitudesPendientes.Size = new System.Drawing.Size(644, 305);
            this.dgv_SolicitudesPendientes.TabIndex = 4;
            this.dgv_SolicitudesPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SolicitudesPendientes_CellClick);
            // 
            // NumeroSolicitud
            // 
            this.NumeroSolicitud.HeaderText = "Número de solicitud";
            this.NumeroSolicitud.Name = "NumeroSolicitud";
            this.NumeroSolicitud.ReadOnly = true;
            this.NumeroSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Clave_Alumno
            // 
            this.Clave_Alumno.HeaderText = "Clave del Alumno";
            this.Clave_Alumno.Name = "Clave_Alumno";
            this.Clave_Alumno.ReadOnly = true;
            // 
            // Clave_Encargado
            // 
            this.Clave_Encargado.HeaderText = "Clave del Encargado";
            this.Clave_Encargado.Name = "Clave_Encargado";
            this.Clave_Encargado.ReadOnly = true;
            // 
            // Clave_Tramite
            // 
            this.Clave_Tramite.HeaderText = "Clave del Tramite";
            this.Clave_Tramite.Name = "Clave_Tramite";
            this.Clave_Tramite.ReadOnly = true;
            // 
            // Fecha_Solicitud
            // 
            this.Fecha_Solicitud.HeaderText = "Fecha de la solicitud";
            this.Fecha_Solicitud.Name = "Fecha_Solicitud";
            this.Fecha_Solicitud.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // gb_TramiteSeleccionado
            // 
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_NombreEncargado);
            this.gb_TramiteSeleccionado.Controls.Add(this.btn_ActualizarSolicitud);
            this.gb_TramiteSeleccionado.Controls.Add(this.cb_EstatusSolicitud);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_FechaSolicitud);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_useless_7);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_useless_6);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_NombreTramite);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_NombreSolicitante);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_useless_5);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_useless_4);
            this.gb_TramiteSeleccionado.Controls.Add(this.lb_useless_3);
            this.gb_TramiteSeleccionado.Location = new System.Drawing.Point(13, 323);
            this.gb_TramiteSeleccionado.Name = "gb_TramiteSeleccionado";
            this.gb_TramiteSeleccionado.Size = new System.Drawing.Size(902, 161);
            this.gb_TramiteSeleccionado.TabIndex = 5;
            this.gb_TramiteSeleccionado.TabStop = false;
            this.gb_TramiteSeleccionado.Text = "Tramite Seleccionado";
            // 
            // btn_ActualizarSolicitud
            // 
            this.btn_ActualizarSolicitud.Enabled = false;
            this.btn_ActualizarSolicitud.Location = new System.Drawing.Point(433, 117);
            this.btn_ActualizarSolicitud.Name = "btn_ActualizarSolicitud";
            this.btn_ActualizarSolicitud.Size = new System.Drawing.Size(163, 28);
            this.btn_ActualizarSolicitud.TabIndex = 10;
            this.btn_ActualizarSolicitud.Text = "Actualizar solicitud";
            this.btn_ActualizarSolicitud.UseVisualStyleBackColor = true;
            this.btn_ActualizarSolicitud.Click += new System.EventHandler(this.btn_ActualizarSolicitud_Click);
            // 
            // cb_EstatusSolicitud
            // 
            this.cb_EstatusSolicitud.FormattingEnabled = true;
            this.cb_EstatusSolicitud.Items.AddRange(new object[] {
            "Pendiente",
            "Revisando",
            "Espera",
            "Cancelado",
            "Compleado"});
            this.cb_EstatusSolicitud.Location = new System.Drawing.Point(602, 65);
            this.cb_EstatusSolicitud.Name = "cb_EstatusSolicitud";
            this.cb_EstatusSolicitud.Size = new System.Drawing.Size(217, 28);
            this.cb_EstatusSolicitud.TabIndex = 8;
            this.cb_EstatusSolicitud.DropDownClosed += new System.EventHandler(this.cb_EstatusSolicitud_DropDownClosed);
            // 
            // lb_FechaSolicitud
            // 
            this.lb_FechaSolicitud.Location = new System.Drawing.Point(602, 32);
            this.lb_FechaSolicitud.Name = "lb_FechaSolicitud";
            this.lb_FechaSolicitud.Size = new System.Drawing.Size(217, 20);
            this.lb_FechaSolicitud.TabIndex = 7;
            // 
            // lb_useless_7
            // 
            this.lb_useless_7.AutoSize = true;
            this.lb_useless_7.Location = new System.Drawing.Point(429, 68);
            this.lb_useless_7.Name = "lb_useless_7";
            this.lb_useless_7.Size = new System.Drawing.Size(167, 20);
            this.lb_useless_7.TabIndex = 6;
            this.lb_useless_7.Text = "Estatus de la solicitud:";
            // 
            // lb_useless_6
            // 
            this.lb_useless_6.AutoSize = true;
            this.lb_useless_6.Location = new System.Drawing.Point(455, 32);
            this.lb_useless_6.Name = "lb_useless_6";
            this.lb_useless_6.Size = new System.Drawing.Size(141, 20);
            this.lb_useless_6.TabIndex = 5;
            this.lb_useless_6.Text = "Fecha de solicitud:";
            // 
            // lb_NombreTramite
            // 
            this.lb_NombreTramite.Location = new System.Drawing.Point(193, 108);
            this.lb_NombreTramite.Name = "lb_NombreTramite";
            this.lb_NombreTramite.Size = new System.Drawing.Size(217, 20);
            this.lb_NombreTramite.TabIndex = 4;
            // 
            // lb_NombreSolicitante
            // 
            this.lb_NombreSolicitante.Location = new System.Drawing.Point(194, 32);
            this.lb_NombreSolicitante.Name = "lb_NombreSolicitante";
            this.lb_NombreSolicitante.Size = new System.Drawing.Size(217, 20);
            this.lb_NombreSolicitante.TabIndex = 3;
            // 
            // lb_useless_5
            // 
            this.lb_useless_5.AutoSize = true;
            this.lb_useless_5.Location = new System.Drawing.Point(36, 108);
            this.lb_useless_5.Name = "lb_useless_5";
            this.lb_useless_5.Size = new System.Drawing.Size(151, 20);
            this.lb_useless_5.TabIndex = 2;
            this.lb_useless_5.Text = "Nombre del tramite: ";
            // 
            // lb_useless_4
            // 
            this.lb_useless_4.AutoSize = true;
            this.lb_useless_4.Location = new System.Drawing.Point(18, 68);
            this.lb_useless_4.Name = "lb_useless_4";
            this.lb_useless_4.Size = new System.Drawing.Size(170, 20);
            this.lb_useless_4.TabIndex = 1;
            this.lb_useless_4.Text = "Nombre del encargado";
            // 
            // lb_useless_3
            // 
            this.lb_useless_3.AutoSize = true;
            this.lb_useless_3.Location = new System.Drawing.Point(19, 32);
            this.lb_useless_3.Name = "lb_useless_3";
            this.lb_useless_3.Size = new System.Drawing.Size(169, 20);
            this.lb_useless_3.TabIndex = 0;
            this.lb_useless_3.Text = "Nombre del solicitante:";
            // 
            // lb_NombreEncargado
            // 
            this.lb_NombreEncargado.Location = new System.Drawing.Point(193, 68);
            this.lb_NombreEncargado.Name = "lb_NombreEncargado";
            this.lb_NombreEncargado.Size = new System.Drawing.Size(217, 20);
            this.lb_NombreEncargado.TabIndex = 11;
            // 
            // Interfaz_Encargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 496);
            this.Controls.Add(this.gb_TramiteSeleccionado);
            this.Controls.Add(this.dgv_SolicitudesPendientes);
            this.Controls.Add(this.btn_CerrarPrograma);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.gb_InformacionEncargado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Interfaz_Encargado";
            this.Text = "Interfaz_Encargado";
            this.gb_InformacionEncargado.ResumeLayout(false);
            this.gb_InformacionEncargado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SolicitudesPendientes)).EndInit();
            this.gb_TramiteSeleccionado.ResumeLayout(false);
            this.gb_TramiteSeleccionado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_InformacionEncargado;
        private System.Windows.Forms.TextBox txt_NombreEncargado;
        private System.Windows.Forms.TextBox txt_MatriculaEncargado;
        private System.Windows.Forms.Label lb_useless_2;
        private System.Windows.Forms.Label lb_useless_1;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_CerrarPrograma;
        private System.Windows.Forms.DataGridView dgv_SolicitudesPendientes;
        private System.Windows.Forms.GroupBox gb_TramiteSeleccionado;
        private System.Windows.Forms.Button btn_ActualizarSolicitud;
        private System.Windows.Forms.ComboBox cb_EstatusSolicitud;
        private System.Windows.Forms.Label lb_FechaSolicitud;
        private System.Windows.Forms.Label lb_useless_7;
        private System.Windows.Forms.Label lb_useless_6;
        private System.Windows.Forms.Label lb_NombreTramite;
        private System.Windows.Forms.Label lb_NombreSolicitante;
        private System.Windows.Forms.Label lb_useless_5;
        private System.Windows.Forms.Label lb_useless_4;
        private System.Windows.Forms.Label lb_useless_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave_Tramite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.Label lb_NombreEncargado;
    }
}