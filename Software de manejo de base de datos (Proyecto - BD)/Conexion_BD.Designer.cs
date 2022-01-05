
namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    partial class Conexion_BD
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_ProbarConexion = new System.Windows.Forms.Button();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.lb_useless_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreServidor = new System.Windows.Forms.TextBox();
            this.lb_NombreServidor_Retro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(34, 212);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(85, 29);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_ProbarConexion
            // 
            this.btn_ProbarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProbarConexion.Location = new System.Drawing.Point(212, 214);
            this.btn_ProbarConexion.Name = "btn_ProbarConexion";
            this.btn_ProbarConexion.Size = new System.Drawing.Size(153, 27);
            this.btn_ProbarConexion.TabIndex = 1;
            this.btn_ProbarConexion.Text = "Probar conexión";
            this.btn_ProbarConexion.UseVisualStyleBackColor = true;
            this.btn_ProbarConexion.Click += new System.EventHandler(this.btn_ProbarConexion_Click);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Enabled = false;
            this.btn_Continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continuar.Location = new System.Drawing.Point(453, 214);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(101, 30);
            this.btn_Continuar.TabIndex = 2;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // lb_useless_1
            // 
            this.lb_useless_1.AutoSize = true;
            this.lb_useless_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_useless_1.Location = new System.Drawing.Point(184, 9);
            this.lb_useless_1.Name = "lb_useless_1";
            this.lb_useless_1.Size = new System.Drawing.Size(287, 26);
            this.lb_useless_1.TabIndex = 3;
            this.lb_useless_1.Text = "Conexión a la base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del servidor : ";
            // 
            // txt_NombreServidor
            // 
            this.txt_NombreServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreServidor.Location = new System.Drawing.Point(179, 117);
            this.txt_NombreServidor.Name = "txt_NombreServidor";
            this.txt_NombreServidor.Size = new System.Drawing.Size(264, 26);
            this.txt_NombreServidor.TabIndex = 5;
            this.txt_NombreServidor.TextChanged += new System.EventHandler(this.txt_NombreServidor_TextChanged);
            // 
            // lb_NombreServidor_Retro
            // 
            this.lb_NombreServidor_Retro.AutoSize = true;
            this.lb_NombreServidor_Retro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreServidor_Retro.Location = new System.Drawing.Point(449, 120);
            this.lb_NombreServidor_Retro.Name = "lb_NombreServidor_Retro";
            this.lb_NombreServidor_Retro.Size = new System.Drawing.Size(268, 20);
            this.lb_NombreServidor_Retro.TabIndex = 6;
            this.lb_NombreServidor_Retro.Text = "Inserte un nombre de servidor valido.";
            // 
            // Conexion_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 266);
            this.Controls.Add(this.lb_NombreServidor_Retro);
            this.Controls.Add(this.txt_NombreServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_useless_1);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.btn_ProbarConexion);
            this.Controls.Add(this.btn_Cerrar);
            this.Name = "Conexion_BD";
            this.Text = "Conexion_BD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_ProbarConexion;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.Label lb_useless_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreServidor;
        private System.Windows.Forms.Label lb_NombreServidor_Retro;
    }
}