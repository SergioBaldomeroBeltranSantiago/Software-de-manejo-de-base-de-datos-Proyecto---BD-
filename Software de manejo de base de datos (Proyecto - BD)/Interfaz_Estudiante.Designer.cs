
namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    partial class Interfaz_Estudiante
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
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lb_useless_1 = new System.Windows.Forms.Label();
            this.lb_useless_2 = new System.Windows.Forms.Label();
            this.txt_NombreEstudiante = new System.Windows.Forms.TextBox();
            this.gb_DatosEstudiante = new System.Windows.Forms.GroupBox();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_CerrarPrograma = new System.Windows.Forms.Button();
            this.btn_IniciarTramite = new System.Windows.Forms.Button();
            this.gb_InformacionTramite = new System.Windows.Forms.GroupBox();
            this.gb_Controles = new System.Windows.Forms.GroupBox();
            this.gb_DatosEstudiante.SuspendLayout();
            this.gb_Controles.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_matricula
            // 
            this.txt_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matricula.Location = new System.Drawing.Point(99, 32);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.ReadOnly = true;
            this.txt_matricula.Size = new System.Drawing.Size(153, 26);
            this.txt_matricula.TabIndex = 1;
            // 
            // lb_useless_1
            // 
            this.lb_useless_1.AutoSize = true;
            this.lb_useless_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_useless_1.Location = new System.Drawing.Point(6, 35);
            this.lb_useless_1.Name = "lb_useless_1";
            this.lb_useless_1.Size = new System.Drawing.Size(81, 20);
            this.lb_useless_1.TabIndex = 2;
            this.lb_useless_1.Text = "Matricula: ";
            // 
            // lb_useless_2
            // 
            this.lb_useless_2.AutoSize = true;
            this.lb_useless_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_useless_2.Location = new System.Drawing.Point(14, 97);
            this.lb_useless_2.Name = "lb_useless_2";
            this.lb_useless_2.Size = new System.Drawing.Size(73, 20);
            this.lb_useless_2.TabIndex = 4;
            this.lb_useless_2.Text = "Nombre: ";
            // 
            // txt_NombreEstudiante
            // 
            this.txt_NombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreEstudiante.Location = new System.Drawing.Point(101, 94);
            this.txt_NombreEstudiante.Name = "txt_NombreEstudiante";
            this.txt_NombreEstudiante.ReadOnly = true;
            this.txt_NombreEstudiante.Size = new System.Drawing.Size(153, 26);
            this.txt_NombreEstudiante.TabIndex = 3;
            // 
            // gb_DatosEstudiante
            // 
            this.gb_DatosEstudiante.Controls.Add(this.lb_useless_1);
            this.gb_DatosEstudiante.Controls.Add(this.lb_useless_2);
            this.gb_DatosEstudiante.Controls.Add(this.txt_matricula);
            this.gb_DatosEstudiante.Controls.Add(this.txt_NombreEstudiante);
            this.gb_DatosEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosEstudiante.Location = new System.Drawing.Point(12, 12);
            this.gb_DatosEstudiante.Name = "gb_DatosEstudiante";
            this.gb_DatosEstudiante.Size = new System.Drawing.Size(287, 142);
            this.gb_DatosEstudiante.TabIndex = 5;
            this.gb_DatosEstudiante.TabStop = false;
            this.gb_DatosEstudiante.Text = "Datos del estudiante";
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.Location = new System.Drawing.Point(60, 93);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(142, 33);
            this.btn_CerrarSesion.TabIndex = 6;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_CerrarPrograma
            // 
            this.btn_CerrarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarPrograma.Location = new System.Drawing.Point(60, 160);
            this.btn_CerrarPrograma.Name = "btn_CerrarPrograma";
            this.btn_CerrarPrograma.Size = new System.Drawing.Size(142, 36);
            this.btn_CerrarPrograma.TabIndex = 7;
            this.btn_CerrarPrograma.Text = "Cerrar Programa";
            this.btn_CerrarPrograma.UseVisualStyleBackColor = true;
            this.btn_CerrarPrograma.Click += new System.EventHandler(this.btn_CerrarPrograma_Click);
            // 
            // btn_IniciarTramite
            // 
            this.btn_IniciarTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarTramite.Location = new System.Drawing.Point(60, 28);
            this.btn_IniciarTramite.Name = "btn_IniciarTramite";
            this.btn_IniciarTramite.Size = new System.Drawing.Size(142, 29);
            this.btn_IniciarTramite.TabIndex = 8;
            this.btn_IniciarTramite.Text = "Iniciar Tramite";
            this.btn_IniciarTramite.UseVisualStyleBackColor = true;
            // 
            // gb_InformacionTramite
            // 
            this.gb_InformacionTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_InformacionTramite.Location = new System.Drawing.Point(305, 12);
            this.gb_InformacionTramite.Name = "gb_InformacionTramite";
            this.gb_InformacionTramite.Size = new System.Drawing.Size(444, 363);
            this.gb_InformacionTramite.TabIndex = 9;
            this.gb_InformacionTramite.TabStop = false;
            this.gb_InformacionTramite.Text = "Información del Tramite";
            // 
            // gb_Controles
            // 
            this.gb_Controles.Controls.Add(this.btn_CerrarSesion);
            this.gb_Controles.Controls.Add(this.btn_IniciarTramite);
            this.gb_Controles.Controls.Add(this.btn_CerrarPrograma);
            this.gb_Controles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Controles.Location = new System.Drawing.Point(12, 160);
            this.gb_Controles.Name = "gb_Controles";
            this.gb_Controles.Size = new System.Drawing.Size(287, 211);
            this.gb_Controles.TabIndex = 10;
            this.gb_Controles.TabStop = false;
            this.gb_Controles.Text = "Controles";
            // 
            // Interfaz_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 383);
            this.Controls.Add(this.gb_Controles);
            this.Controls.Add(this.gb_InformacionTramite);
            this.Controls.Add(this.gb_DatosEstudiante);
            this.Name = "Interfaz_Estudiante";
            this.Text = "Interfaz_Estudiante";
            this.gb_DatosEstudiante.ResumeLayout(false);
            this.gb_DatosEstudiante.PerformLayout();
            this.gb_Controles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lb_useless_1;
        private System.Windows.Forms.Label lb_useless_2;
        private System.Windows.Forms.TextBox txt_NombreEstudiante;
        private System.Windows.Forms.GroupBox gb_DatosEstudiante;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_CerrarPrograma;
        private System.Windows.Forms.Button btn_IniciarTramite;
        private System.Windows.Forms.GroupBox gb_InformacionTramite;
        private System.Windows.Forms.GroupBox gb_Controles;
    }
}