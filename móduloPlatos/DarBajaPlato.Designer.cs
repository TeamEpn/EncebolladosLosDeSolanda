namespace Interfaz
{
    partial class EliminarPlato
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
            this.botonEliminarEliCli = new System.Windows.Forms.Button();
            this.textBoxNombrePlato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Plato info...";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Datos del Plato seleccionado:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 173);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar plato por nombre";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // botonCancelarEliCli
            // 
            this.botonCancelarEliCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonCancelarEliCli.Location = new System.Drawing.Point(179, 368);
            this.botonCancelarEliCli.Name = "botonCancelarEliCli";
            this.botonCancelarEliCli.Size = new System.Drawing.Size(133, 29);
            this.botonCancelarEliCli.TabIndex = 12;
            this.botonCancelarEliCli.Text = "Cancelar";
            this.botonCancelarEliCli.UseVisualStyleBackColor = true;
            this.botonCancelarEliCli.Click += new System.EventHandler(this.BotonCancelarEliCli_Click);
            // 
            // botonEliminarEliCli
            // 
            this.botonEliminarEliCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonEliminarEliCli.Location = new System.Drawing.Point(9, 368);
            this.botonEliminarEliCli.Name = "botonEliminarEliCli";
            this.botonEliminarEliCli.Size = new System.Drawing.Size(164, 29);
            this.botonEliminarEliCli.TabIndex = 11;
            this.botonEliminarEliCli.Text = "Dar de baja";
            this.botonEliminarEliCli.UseVisualStyleBackColor = true;
            this.botonEliminarEliCli.Click += new System.EventHandler(this.BotonEliminarEliCli_Click);
            // 
            // textBoxNombrePlato
            // 
            this.textBoxNombrePlato.Location = new System.Drawing.Point(9, 58);
            this.textBoxNombrePlato.Name = "textBoxNombrePlato";
            this.textBoxNombrePlato.Size = new System.Drawing.Size(304, 20);
            this.textBoxNombrePlato.TabIndex = 10;
            this.textBoxNombrePlato.TextChanged += new System.EventHandler(this.TextBoxNombrePlato_TextChanged);
            // 
            // EliminarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelarEliCli);
            this.Controls.Add(this.botonEliminarEliCli);
            this.Controls.Add(this.textBoxNombrePlato);
            this.Name = "EliminarPlato";
            this.Text = "Dar Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelarEliCli;
        private System.Windows.Forms.Button botonEliminarEliCli;
        private System.Windows.Forms.TextBox textBoxNombrePlato;
    }
}