namespace Interfaz
{
    partial class PrediccionPlatoFavorito
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
            this.buttonPredecir = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxCedulaCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPredecir
            // 
            this.buttonPredecir.Location = new System.Drawing.Point(82, 118);
            this.buttonPredecir.Name = "buttonPredecir";
            this.buttonPredecir.Size = new System.Drawing.Size(75, 23);
            this.buttonPredecir.TabIndex = 0;
            this.buttonPredecir.Text = "Predecir";
            this.buttonPredecir.UseVisualStyleBackColor = true;
            this.buttonPredecir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(216, 118);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 1;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBoxCedulaCliente
            // 
            this.textBoxCedulaCliente.Location = new System.Drawing.Point(170, 63);
            this.textBoxCedulaCliente.Name = "textBoxCedulaCliente";
            this.textBoxCedulaCliente.Size = new System.Drawing.Size(137, 20);
            this.textBoxCedulaCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número de cédula del cliente";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // PrediccionPlatoFavorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCedulaCliente);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonPredecir);
            this.Name = "PrediccionPlatoFavorito";
            this.Text = "PrediccionPlatoFavorito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPredecir;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxCedulaCliente;
        private System.Windows.Forms.Label label1;
    }
}