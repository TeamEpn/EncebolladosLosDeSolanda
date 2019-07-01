namespace Interfaz
{
    partial class IngresarCliente
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
            this.botonIngresarIngCli = new System.Windows.Forms.Button();
            this.botonCancelarIngCli = new System.Windows.Forms.Button();
            this.textBoxNombreCli = new System.Windows.Forms.TextBox();
            this.textBoxApellidoCli = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.escogeOpcion = new System.Windows.Forms.ComboBox();
            this.labelErrorCliente = new System.Windows.Forms.Label();
            this.labelOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "N. de Documento";
            // 
            // botonIngresarIngCli
            // 
            this.botonIngresarIngCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonIngresarIngCli.Location = new System.Drawing.Point(12, 332);
            this.botonIngresarIngCli.Name = "botonIngresarIngCli";
            this.botonIngresarIngCli.Size = new System.Drawing.Size(143, 29);
            this.botonIngresarIngCli.TabIndex = 3;
            this.botonIngresarIngCli.Text = "Ingresar";
            this.botonIngresarIngCli.UseVisualStyleBackColor = true;
            this.botonIngresarIngCli.Click += new System.EventHandler(this.BotonIngresarIngCli_Click);
            // 
            // botonCancelarIngCli
            // 
            this.botonCancelarIngCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonCancelarIngCli.Location = new System.Drawing.Point(161, 332);
            this.botonCancelarIngCli.Name = "botonCancelarIngCli";
            this.botonCancelarIngCli.Size = new System.Drawing.Size(139, 29);
            this.botonCancelarIngCli.TabIndex = 4;
            this.botonCancelarIngCli.Text = "Cancelar";
            this.botonCancelarIngCli.UseVisualStyleBackColor = true;
            this.botonCancelarIngCli.Click += new System.EventHandler(this.BotonCancelarIngCli_Click);
            // 
            // textBoxNombreCli
            // 
            this.textBoxNombreCli.Location = new System.Drawing.Point(147, 149);
            this.textBoxNombreCli.Name = "textBoxNombreCli";
            this.textBoxNombreCli.Size = new System.Drawing.Size(153, 20);
            this.textBoxNombreCli.TabIndex = 5;
            this.textBoxNombreCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNombreCli_KeyDown);
            // 
            // textBoxApellidoCli
            // 
            this.textBoxApellidoCli.Location = new System.Drawing.Point(147, 187);
            this.textBoxApellidoCli.Name = "textBoxApellidoCli";
            this.textBoxApellidoCli.Size = new System.Drawing.Size(153, 20);
            this.textBoxApellidoCli.TabIndex = 6;
            this.textBoxApellidoCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxApellidoCli_KeyDown);
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(147, 75);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(153, 20);
            this.textBoxDocumento.TabIndex = 7;
            this.textBoxDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDocumento_KeyDown);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(51, 233);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Dirección";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(147, 226);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(153, 20);
            this.textBoxDireccion.TabIndex = 9;
            this.textBoxDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDireccion_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo:";
            // 
            // escogeOpcion
            // 
            this.escogeOpcion.FormattingEnabled = true;
            this.escogeOpcion.Location = new System.Drawing.Point(147, 101);
            this.escogeOpcion.Name = "escogeOpcion";
            this.escogeOpcion.Size = new System.Drawing.Size(153, 21);
            this.escogeOpcion.TabIndex = 11;
            // 
            // labelErrorCliente
            // 
            this.labelErrorCliente.AutoSize = true;
            this.labelErrorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelErrorCliente.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCliente.Location = new System.Drawing.Point(8, 299);
            this.labelErrorCliente.Name = "labelErrorCliente";
            this.labelErrorCliente.Size = new System.Drawing.Size(301, 20);
            this.labelErrorCliente.TabIndex = 12;
            this.labelErrorCliente.Text = "Alguno  o varios de los campos incorrecto";
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOk.ForeColor = System.Drawing.Color.Black;
            this.labelOk.Location = new System.Drawing.Point(39, 279);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(239, 20);
            this.labelOk.TabIndex = 13;
            this.labelOk.Text = "Cliente ingresado existosamente";
            // 
            // formIngresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 373);
            this.Controls.Add(this.labelOk);
            this.Controls.Add(this.labelErrorCliente);
            this.Controls.Add(this.escogeOpcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxApellidoCli);
            this.Controls.Add(this.textBoxNombreCli);
            this.Controls.Add(this.botonCancelarIngCli);
            this.Controls.Add(this.botonIngresarIngCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formIngresarCliente";
            this.Text = "formIngresarCliente";
            this.Load += new System.EventHandler(this.FormIngresarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox textBoxNombreCli;
        private System.Windows.Forms.TextBox textBoxApellidoCli;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button botonIngresarIngCli;
        private System.Windows.Forms.Button botonCancelarIngCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox escogeOpcion;
        private System.Windows.Forms.Label labelErrorCliente;
        private System.Windows.Forms.Label labelOk;
    }
}