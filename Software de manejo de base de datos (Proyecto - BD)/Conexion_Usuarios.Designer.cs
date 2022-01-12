
namespace Software_de_manejo_de_base_de_datos__Proyecto___BD_
{
    partial class Conexion_Usuarios
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.txt_NombreUsuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lb_useless_1 = new System.Windows.Forms.Label();
            this.lb_useless_2 = new System.Windows.Forms.Label();
            this.lb_useless_3 = new System.Windows.Forms.Label();
            this.lb_Nombre_Usuario_Retro = new System.Windows.Forms.Label();
            this.lb_Contraseña_Retro = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(53, 192);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 38);
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.Text = "Cerrar";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Enabled = false;
            this.btn_Conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Conectar.Location = new System.Drawing.Point(395, 192);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(93, 38);
            this.btn_Conectar.TabIndex = 1;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUsuario.Location = new System.Drawing.Point(187, 92);
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Size = new System.Drawing.Size(198, 26);
            this.txt_NombreUsuario.TabIndex = 2;
            this.txt_NombreUsuario.TextChanged += new System.EventHandler(this.txt_NombreUsuario_TextChanged);
            this.txt_NombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreUsuario_KeyPress);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(187, 142);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(198, 26);
            this.txt_Contraseña.TabIndex = 3;
            this.txt_Contraseña.TextChanged += new System.EventHandler(this.txt_Contraseña_TextChanged);
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            // 
            // lb_useless_1
            // 
            this.lb_useless_1.AutoSize = true;
            this.lb_useless_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_useless_1.Location = new System.Drawing.Point(211, 24);
            this.lb_useless_1.Name = "lb_useless_1";
            this.lb_useless_1.Size = new System.Drawing.Size(162, 26);
            this.lb_useless_1.TabIndex = 4;
            this.lb_useless_1.Text = "Inicio de sesión";
            // 
            // lb_useless_2
            // 
            this.lb_useless_2.AutoSize = true;
            this.lb_useless_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_useless_2.Location = new System.Drawing.Point(30, 92);
            this.lb_useless_2.Name = "lb_useless_2";
            this.lb_useless_2.Size = new System.Drawing.Size(151, 20);
            this.lb_useless_2.TabIndex = 5;
            this.lb_useless_2.Text = "Nombre de usuario :";
            // 
            // lb_useless_3
            // 
            this.lb_useless_3.AutoSize = true;
            this.lb_useless_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_useless_3.Location = new System.Drawing.Point(49, 142);
            this.lb_useless_3.Name = "lb_useless_3";
            this.lb_useless_3.Size = new System.Drawing.Size(100, 20);
            this.lb_useless_3.TabIndex = 6;
            this.lb_useless_3.Text = "Contraseña :";
            // 
            // lb_Nombre_Usuario_Retro
            // 
            this.lb_Nombre_Usuario_Retro.AutoSize = true;
            this.lb_Nombre_Usuario_Retro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nombre_Usuario_Retro.Location = new System.Drawing.Point(391, 95);
            this.lb_Nombre_Usuario_Retro.Name = "lb_Nombre_Usuario_Retro";
            this.lb_Nombre_Usuario_Retro.Size = new System.Drawing.Size(269, 20);
            this.lb_Nombre_Usuario_Retro.TabIndex = 7;
            this.lb_Nombre_Usuario_Retro.Text = "Ingrese un nombre de usuario valido.";
            // 
            // lb_Contraseña_Retro
            // 
            this.lb_Contraseña_Retro.AutoSize = true;
            this.lb_Contraseña_Retro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contraseña_Retro.Location = new System.Drawing.Point(391, 145);
            this.lb_Contraseña_Retro.Name = "lb_Contraseña_Retro";
            this.lb_Contraseña_Retro.Size = new System.Drawing.Size(172, 20);
            this.lb_Contraseña_Retro.TabIndex = 8;
            this.lb_Contraseña_Retro.Text = "Ingrese su contraseña.";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.Location = new System.Drawing.Point(233, 192);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(98, 38);
            this.btn_Regresar.TabIndex = 9;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // Conexion_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 246);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lb_Contraseña_Retro);
            this.Controls.Add(this.lb_Nombre_Usuario_Retro);
            this.Controls.Add(this.lb_useless_3);
            this.Controls.Add(this.lb_useless_2);
            this.Controls.Add(this.lb_useless_1);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_NombreUsuario);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.btn_Salir);
            this.Name = "Conexion_Usuarios";
            this.Text = "Conexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.TextBox txt_NombreUsuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lb_useless_1;
        private System.Windows.Forms.Label lb_useless_2;
        private System.Windows.Forms.Label lb_useless_3;
        private System.Windows.Forms.Label lb_Nombre_Usuario_Retro;
        private System.Windows.Forms.Label lb_Contraseña_Retro;
        private System.Windows.Forms.Button btn_Regresar;
    }
}

