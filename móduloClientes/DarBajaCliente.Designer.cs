namespace Interfaz
{
    partial class DarAltaBajaCliente
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.botonEliminarEliCli = new System.Windows.Forms.Button();
            this.botonCancelarEliCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(4, 50);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(304, 20);
            this.textBoxCedula.TabIndex = 0;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.TextBoxCedula_TextChanged);
            // 
            // botonEliminarEliCli
            // 
            this.botonEliminarEliCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonEliminarEliCli.Location = new System.Drawing.Point(4, 367);
            this.botonEliminarEliCli.Name = "botonEliminarEliCli";
            this.botonEliminarEliCli.Size = new System.Drawing.Size(164, 29);
            this.botonEliminarEliCli.TabIndex = 1;
            this.botonEliminarEliCli.Text = "Dar de baja";
            this.botonEliminarEliCli.UseVisualStyleBackColor = true;
            this.botonEliminarEliCli.Click += new System.EventHandler(this.BotonEliminarEliCli_Click);
            // 
            // botonCancelarEliCli
            // 
            this.botonCancelarEliCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.botonCancelarEliCli.Location = new System.Drawing.Point(174, 367);
            this.botonCancelarEliCli.Name = "botonCancelarEliCli";
            this.botonCancelarEliCli.Size = new System.Drawing.Size(141, 29);
            this.botonCancelarEliCli.TabIndex = 2;
            this.botonCancelarEliCli.Text = "Cancelar";
            this.botonCancelarEliCli.UseVisualStyleBackColor = true;
            this.botonCancelarEliCli.Click += new System.EventHandler(this.BotonCancelarEliCli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Cliente por cédula";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Cliente 1"});
            this.listBox1.Location = new System.Drawing.Point(8, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 173);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(4, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datos del Cliente seleccionado:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(4, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente 1 su estado es...";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // DarAltaBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 408);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonCancelarEliCli);
            this.Controls.Add(this.botonEliminarEliCli);
            this.Controls.Add(this.textBoxCedula);
            this.Name = "DarAltaBajaCliente";
            this.Text = "Dar de baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Button botonEliminarEliCli;
        private System.Windows.Forms.Button botonCancelarEliCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}