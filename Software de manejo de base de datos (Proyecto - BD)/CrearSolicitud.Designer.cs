
namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    partial class CrearSolicitud
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
            this.gb_Solicitudes = new System.Windows.Forms.GroupBox();
            this.btn_SolicitarTramite = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lb_useless_1 = new System.Windows.Forms.Label();
            this.cb_ListaTramites = new System.Windows.Forms.ComboBox();
            this.gb_Solicitudes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Solicitudes
            // 
            this.gb_Solicitudes.Controls.Add(this.btn_SolicitarTramite);
            this.gb_Solicitudes.Controls.Add(this.btn_Cancelar);
            this.gb_Solicitudes.Controls.Add(this.lb_useless_1);
            this.gb_Solicitudes.Controls.Add(this.cb_ListaTramites);
            this.gb_Solicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Solicitudes.Location = new System.Drawing.Point(12, 12);
            this.gb_Solicitudes.Name = "gb_Solicitudes";
            this.gb_Solicitudes.Size = new System.Drawing.Size(361, 230);
            this.gb_Solicitudes.TabIndex = 0;
            this.gb_Solicitudes.TabStop = false;
            this.gb_Solicitudes.Text = "Solicitudes";
            // 
            // btn_SolicitarTramite
            // 
            this.btn_SolicitarTramite.Location = new System.Drawing.Point(232, 174);
            this.btn_SolicitarTramite.Name = "btn_SolicitarTramite";
            this.btn_SolicitarTramite.Size = new System.Drawing.Size(94, 32);
            this.btn_SolicitarTramite.TabIndex = 3;
            this.btn_SolicitarTramite.Text = "Solicitar";
            this.btn_SolicitarTramite.UseVisualStyleBackColor = true;
            this.btn_SolicitarTramite.Click += new System.EventHandler(this.btn_SolicitarTramite_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 174);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // lb_useless_1
            // 
            this.lb_useless_1.AutoSize = true;
            this.lb_useless_1.Location = new System.Drawing.Point(18, 68);
            this.lb_useless_1.Name = "lb_useless_1";
            this.lb_useless_1.Size = new System.Drawing.Size(164, 20);
            this.lb_useless_1.TabIndex = 1;
            this.lb_useless_1.Text = "Selecciona el tramite: ";
            // 
            // cb_ListaTramites
            // 
            this.cb_ListaTramites.FormattingEnabled = true;
            this.cb_ListaTramites.Location = new System.Drawing.Point(188, 68);
            this.cb_ListaTramites.Name = "cb_ListaTramites";
            this.cb_ListaTramites.Size = new System.Drawing.Size(121, 28);
            this.cb_ListaTramites.TabIndex = 0;
            // 
            // CrearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(this.gb_Solicitudes);
            this.Name = "CrearSolicitud";
            this.Text = "CrearSolicitud";
            this.gb_Solicitudes.ResumeLayout(false);
            this.gb_Solicitudes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Solicitudes;
        private System.Windows.Forms.Button btn_SolicitarTramite;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lb_useless_1;
        private System.Windows.Forms.ComboBox cb_ListaTramites;
    }
}