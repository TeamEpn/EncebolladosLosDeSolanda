namespace Interfaz.móduloClientes
{
    partial class DarDeAltaPlato
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelarEliCli = new System.Windows.Forms.Button();
            this.botonDarAltaPlato = new System.Windows.Forms.Button();
            this.textBoxNombrePlato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Plato info...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Datos del Plato seleccionado:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 173);
            this.listBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar plato por nombre";
            // 
            // botonCancelarEliCli
            // 
            this.botonCancelarEliCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonCancelarEliCli.Location = new System.Drawing.Point(179, 363);
            this.botonCancelarEliCli.Name = "botonCancelarEliCli";
            this.botonCancelarEliCli.Size = new System.Drawing.Size(133, 29);
            this.botonCancelarEliCli.TabIndex = 22;
            this.botonCancelarEliCli.Text = "Cancelar";
            this.botonCancelarEliCli.UseVisualStyleBackColor = true;
            this.botonCancelarEliCli.Click += new System.EventHandler(this.BotonCancelarEliCli_Click);
            // 
            // botonDarAltaPlato
            // 
            this.botonDarAltaPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonDarAltaPlato.Location = new System.Drawing.Point(9, 363);
            this.botonDarAltaPlato.Name = "botonDarAltaPlato";
            this.botonDarAltaPlato.Size = new System.Drawing.Size(164, 29);
            this.botonDarAltaPlato.TabIndex = 21;
            this.botonDarAltaPlato.Text = "Dar de alta";
            this.botonDarAltaPlato.UseVisualStyleBackColor = true;
            this.botonDarAltaPlato.Click += new System.EventHandler(this.BotonDarAltaPlato_Click);
            // 
            // textBoxNombrePlato
            // 
            this.textBoxNombrePlato.Location = new System.Drawing.Point(9, 53);
            this.textBoxNombrePlato.Name = "textBoxNombrePlato";
            this.textBoxNombrePlato.Size = new System.Drawing.Size(304, 20);
            this.textBoxNombrePlato.TabIndex = 20;
            // 
            // DarDeAltaPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelarEliCli);
            this.Controls.Add(this.botonDarAltaPlato);
            this.Controls.Add(this.textBoxNombrePlato);
            this.Name = "DarDeAltaPlato";
            this.Text = "DarDeAltaPlato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelarEliCli;
        private System.Windows.Forms.Button botonDarAltaPlato;
        private System.Windows.Forms.TextBox textBoxNombrePlato;
    }
}