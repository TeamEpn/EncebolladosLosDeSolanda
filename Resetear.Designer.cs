namespace Interfaz.móduloAdministracion1
{
    partial class Resetear
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tContraseñaActual = new System.Windows.Forms.TextBox();
            this.tnombreactual = new System.Windows.Forms.TextBox();
            this.nuevoNombre = new System.Windows.Forms.TextBox();
            this.nuevaContraseña = new System.Windows.Forms.TextBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nuevo nombre de usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nueva contraseña";
            // 
            // tContraseñaActual
            // 
            this.tContraseñaActual.Location = new System.Drawing.Point(230, 64);
            this.tContraseñaActual.Name = "tContraseñaActual";
            this.tContraseñaActual.Size = new System.Drawing.Size(100, 20);
            this.tContraseñaActual.TabIndex = 5;
            // 
            // tnombreactual
            // 
            this.tnombreactual.Location = new System.Drawing.Point(230, 132);
            this.tnombreactual.Name = "tnombreactual";
            this.tnombreactual.Size = new System.Drawing.Size(100, 20);
            this.tnombreactual.TabIndex = 6;
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Location = new System.Drawing.Point(230, 199);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.nuevoNombre.TabIndex = 7;
            // 
            // nuevaContraseña
            // 
            this.nuevaContraseña.Location = new System.Drawing.Point(230, 259);
            this.nuevaContraseña.Name = "nuevaContraseña";
            this.nuevaContraseña.Size = new System.Drawing.Size(100, 20);
            this.nuevaContraseña.TabIndex = 8;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(381, 219);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 9;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(381, 258);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 10;
            this.salir.Text = "Salir";
            this.salir.UseMnemonic = false;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.nuevaContraseña);
            this.Controls.Add(this.nuevoNombre);
            this.Controls.Add(this.tnombreactual);
            this.Controls.Add(this.tContraseñaActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tContraseñaActual;
        private System.Windows.Forms.TextBox tnombreactual;
        private System.Windows.Forms.TextBox nuevoNombre;
        private System.Windows.Forms.TextBox nuevaContraseña;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button salir;
    }
}