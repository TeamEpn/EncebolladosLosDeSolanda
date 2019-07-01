namespace Interfaz
{
    partial class Balance
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFInicio = new System.Windows.Forms.DateTimePicker();
            this.listBoxIngresos = new System.Windows.Forms.ListBox();
            this.listBoxEgresos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalIngresos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTotalEgresos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mostrar Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha inicio";
            // 
            // dateTimePickerFFin
            // 
            this.dateTimePickerFFin.Location = new System.Drawing.Point(140, 72);
            this.dateTimePickerFFin.Name = "dateTimePickerFFin";
            this.dateTimePickerFFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFFin.TabIndex = 7;
            // 
            // dateTimePickerFInicio
            // 
            this.dateTimePickerFInicio.Location = new System.Drawing.Point(140, 46);
            this.dateTimePickerFInicio.Name = "dateTimePickerFInicio";
            this.dateTimePickerFInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFInicio.TabIndex = 6;
            // 
            // listBoxIngresos
            // 
            this.listBoxIngresos.FormattingEnabled = true;
            this.listBoxIngresos.Items.AddRange(new object[] {
            "800",
            "300",
            "200",
            "100",
            "110"});
            this.listBoxIngresos.Location = new System.Drawing.Point(158, 185);
            this.listBoxIngresos.Name = "listBoxIngresos";
            this.listBoxIngresos.Size = new System.Drawing.Size(45, 108);
            this.listBoxIngresos.TabIndex = 12;
            this.listBoxIngresos.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // listBoxEgresos
            // 
            this.listBoxEgresos.FormattingEnabled = true;
            this.listBoxEgresos.Items.AddRange(new object[] {
            "111",
            "222",
            "233",
            "444"});
            this.listBoxEgresos.Location = new System.Drawing.Point(309, 185);
            this.listBoxEgresos.Name = "listBoxEgresos";
            this.listBoxEgresos.Size = new System.Drawing.Size(49, 108);
            this.listBoxEgresos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "TOTAL";
            // 
            // labelTotalIngresos
            // 
            this.labelTotalIngresos.AutoSize = true;
            this.labelTotalIngresos.Location = new System.Drawing.Point(155, 311);
            this.labelTotalIngresos.Name = "labelTotalIngresos";
            this.labelTotalIngresos.Size = new System.Drawing.Size(28, 13);
            this.labelTotalIngresos.TabIndex = 15;
            this.labelTotalIngresos.Text = "###";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "INGRESOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "EGRESOS";
            // 
            // labelTotalEgresos
            // 
            this.labelTotalEgresos.AutoSize = true;
            this.labelTotalEgresos.Location = new System.Drawing.Point(320, 311);
            this.labelTotalEgresos.Name = "labelTotalEgresos";
            this.labelTotalEgresos.Size = new System.Drawing.Size(28, 13);
            this.labelTotalEgresos.TabIndex = 18;
            this.labelTotalEgresos.Text = "###";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Desc.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Desc.2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Desc.3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Desc.4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Desc.5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Desc.4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Desc.3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Desc.2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(262, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Desc.1";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 430);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalEgresos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotalIngresos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEgresos);
            this.Controls.Add(this.listBoxIngresos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFFin);
            this.Controls.Add(this.dateTimePickerFInicio);
            this.Name = "Balance";
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerFInicio;
        private System.Windows.Forms.ListBox listBoxIngresos;
        private System.Windows.Forms.ListBox listBoxEgresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalIngresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTotalEgresos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}