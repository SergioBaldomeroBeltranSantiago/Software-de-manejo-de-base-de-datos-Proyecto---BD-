
namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    partial class SeleccionarUsuario
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
            this.cb_ListaUsuarios = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.lb_useless_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_ListaUsuarios
            // 
            this.cb_ListaUsuarios.FormattingEnabled = true;
            this.cb_ListaUsuarios.Location = new System.Drawing.Point(186, 9);
            this.cb_ListaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_ListaUsuarios.Name = "cb_ListaUsuarios";
            this.cb_ListaUsuarios.Size = new System.Drawing.Size(180, 28);
            this.cb_ListaUsuarios.TabIndex = 0;
            this.cb_ListaUsuarios.SelectedIndexChanged += new System.EventHandler(this.cb_ListaUsuarios_SelectedIndexChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(13, 95);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 35);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(254, 95);
            this.btn_Continuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(112, 35);
            this.btn_Continuar.TabIndex = 2;
            this.btn_Continuar.Text = "Seleccionar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // lb_useless_1
            // 
            this.lb_useless_1.AutoSize = true;
            this.lb_useless_1.Location = new System.Drawing.Point(13, 12);
            this.lb_useless_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_useless_1.Name = "lb_useless_1";
            this.lb_useless_1.Size = new System.Drawing.Size(169, 20);
            this.lb_useless_1.TabIndex = 3;
            this.lb_useless_1.Text = "Seleccione un usuario:";
            // 
            // SeleccionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 148);
            this.Controls.Add(this.lb_useless_1);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cb_ListaUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeleccionarUsuario";
            this.Text = "SeleccionarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ListaUsuarios;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.Label lb_useless_1;
    }
}