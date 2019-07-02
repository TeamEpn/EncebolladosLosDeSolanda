namespace Interfaz.móduloPlatos
{
    partial class DarDeAltaIngrediente
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
            this.label4.Location = new System.Drawing.Point(9, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ingediente info...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Datos del Ingrediente seleccionado:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 225);
            this.listBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Buscar Ingrediente por nombre";
            // 
            // botonCancelarEliCli
            // 
            this.botonCancelarEliCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonCancelarEliCli.Location = new System.Drawing.Point(179, 368);
            this.botonCancelarEliCli.Name = "botonCancelarEliCli";
            this.botonCancelarEliCli.Size = new System.Drawing.Size(133, 29);
            this.botonCancelarEliCli.TabIndex = 29;
            this.botonCancelarEliCli.Text = "Cancelar";
            this.botonCancelarEliCli.UseVisualStyleBackColor = true;
            // 
            // botonDarAltaPlato
            // 
            this.botonDarAltaPlato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonDarAltaPlato.Location = new System.Drawing.Point(9, 368);
            this.botonDarAltaPlato.Name = "botonDarAltaPlato";
            this.botonDarAltaPlato.Size = new System.Drawing.Size(164, 29);
            this.botonDarAltaPlato.TabIndex = 28;
            this.botonDarAltaPlato.Text = "Dar de alta";
            this.botonDarAltaPlato.UseVisualStyleBackColor = true;
            this.botonDarAltaPlato.Click += new System.EventHandler(this.BotonDarAltaPlato_Click);
            // 
            // textBoxNombrePlato
            // 
            this.textBoxNombrePlato.Location = new System.Drawing.Point(13, 33);
            this.textBoxNombrePlato.Name = "textBoxNombrePlato";
            this.textBoxNombrePlato.Size = new System.Drawing.Size(299, 20);
            this.textBoxNombrePlato.TabIndex = 27;
            // 
            // DarDeAltaIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelarEliCli);
            this.Controls.Add(this.botonDarAltaPlato);
            this.Controls.Add(this.textBoxNombrePlato);
            this.Name = "DarDeAltaIngrediente";
            this.Text = "DarDeAltaIngrediente";
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