namespace Interfaz
{
    partial class ActualizarCliente
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
            this.textBoxCampo = new System.Windows.Forms.TextBox();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.botonBuscarActCli = new System.Windows.Forms.Button();
            this.botonActualizarActCli = new System.Windows.Forms.Button();
            this.botonCancelarActCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxCampo
            // 
            this.textBoxCampo.Location = new System.Drawing.Point(275, 17);
            this.textBoxCampo.Name = "textBoxCampo";
            this.textBoxCampo.Size = new System.Drawing.Size(195, 20);
            this.textBoxCampo.TabIndex = 0;
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(121, 63);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(121, 20);
            this.textBoxCedula.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(121, 106);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(121, 152);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(121, 20);
            this.textBoxApellido.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Cliente por:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(121, 200);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // botonBuscarActCli
            // 
            this.botonBuscarActCli.Location = new System.Drawing.Point(476, 14);
            this.botonBuscarActCli.Name = "botonBuscarActCli";
            this.botonBuscarActCli.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarActCli.TabIndex = 7;
            this.botonBuscarActCli.Text = "Buscar";
            this.botonBuscarActCli.UseVisualStyleBackColor = true;
            // 
            // botonActualizarActCli
            // 
            this.botonActualizarActCli.Location = new System.Drawing.Point(67, 304);
            this.botonActualizarActCli.Name = "botonActualizarActCli";
            this.botonActualizarActCli.Size = new System.Drawing.Size(75, 23);
            this.botonActualizarActCli.TabIndex = 8;
            this.botonActualizarActCli.Text = "Actualizar";
            this.botonActualizarActCli.UseVisualStyleBackColor = true;
            this.botonActualizarActCli.Click += new System.EventHandler(this.BotonActualizarActCli_Click);
            // 
            // botonCancelarActCli
            // 
            this.botonCancelarActCli.Location = new System.Drawing.Point(167, 304);
            this.botonCancelarActCli.Name = "botonCancelarActCli";
            this.botonCancelarActCli.Size = new System.Drawing.Size(75, 23);
            this.botonCancelarActCli.TabIndex = 9;
            this.botonCancelarActCli.Text = "Cancelar";
            this.botonCancelarActCli.UseVisualStyleBackColor = true;
            this.botonCancelarActCli.Click += new System.EventHandler(this.BotonCancelarActCli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dirección";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(275, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 264);
            this.listBox1.TabIndex = 14;
            // 
            // ActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 345);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonCancelarActCli);
            this.Controls.Add(this.botonActualizarActCli);
            this.Controls.Add(this.botonBuscarActCli);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.textBoxCampo);
            this.Name = "ActualizarCliente";
            this.Text = "ActualizarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCampo;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Button botonBuscarActCli;
        private System.Windows.Forms.Button botonActualizarActCli;
        private System.Windows.Forms.Button botonCancelarActCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
    }
}