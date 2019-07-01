namespace Interfaz{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEncebollados = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEncebollados
            // 
            this.labelEncebollados.AutoSize = true;
            this.labelEncebollados.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelEncebollados.Location = new System.Drawing.Point(52, 0);
            this.labelEncebollados.Name = "labelEncebollados";
            this.labelEncebollados.Size = new System.Drawing.Size(228, 57);
            this.labelEncebollados.TabIndex = 0;
            this.labelEncebollados.Text = "Encebollados";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelUsuario.Location = new System.Drawing.Point(24, 381);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelContrasenia.Location = new System.Drawing.Point(12, 415);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(92, 20);
            this.labelContrasenia.TabIndex = 2;
            this.labelContrasenia.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(129, 383);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(204, 20);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxUsuario_KeyPress);
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Location = new System.Drawing.Point(129, 415);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.Size = new System.Drawing.Size(204, 20);
            this.textBoxContrasenia.TabIndex = 4;
            this.textBoxContrasenia.UseSystemPasswordChar = true;
            this.textBoxContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxContrasenia_KeyPress);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonIngresar.Location = new System.Drawing.Point(11, 459);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(157, 33);
            this.buttonIngresar.TabIndex = 5;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonSalir.Location = new System.Drawing.Point(174, 459);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(159, 33);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(98, 360);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(246, 20);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Usuario o Contraseña incorrectas";
            this.labelError.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Los de Solanda";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.textBoxContrasenia);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelEncebollados);
            this.Name = "Principal";
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEncebollados;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
    }
}