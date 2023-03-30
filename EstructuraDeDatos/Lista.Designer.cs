namespace EstructuraDeDatos
{
    partial class Lista
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
            this.cb_Grado = new System.Windows.Forms.ComboBox();
            this.cb_Identificacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Si = new System.Windows.Forms.RadioButton();
            this.rb_No = new System.Windows.Forms.RadioButton();
            this.tb_Identificacion = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Estrato = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion del estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // cb_Grado
            // 
            this.cb_Grado.FormattingEnabled = true;
            this.cb_Grado.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cb_Grado.Location = new System.Drawing.Point(272, 165);
            this.cb_Grado.Name = "cb_Grado";
            this.cb_Grado.Size = new System.Drawing.Size(121, 21);
            this.cb_Grado.TabIndex = 3;
            // 
            // cb_Identificacion
            // 
            this.cb_Identificacion.FormattingEnabled = true;
            this.cb_Identificacion.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT"});
            this.cb_Identificacion.Location = new System.Drawing.Point(272, 40);
            this.cb_Identificacion.Name = "cb_Identificacion";
            this.cb_Identificacion.Size = new System.Drawing.Size(121, 21);
            this.cb_Identificacion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_No);
            this.groupBox1.Controls.Add(this.rb_Si);
            this.groupBox1.Location = new System.Drawing.Point(538, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilizo el servico del PAE";
            // 
            // rb_Si
            // 
            this.rb_Si.AutoSize = true;
            this.rb_Si.Location = new System.Drawing.Point(18, 33);
            this.rb_Si.Name = "rb_Si";
            this.rb_Si.Size = new System.Drawing.Size(34, 17);
            this.rb_Si.TabIndex = 0;
            this.rb_Si.TabStop = true;
            this.rb_Si.Text = "Si";
            this.rb_Si.UseVisualStyleBackColor = true;
            // 
            // rb_No
            // 
            this.rb_No.AutoSize = true;
            this.rb_No.Location = new System.Drawing.Point(20, 67);
            this.rb_No.Name = "rb_No";
            this.rb_No.Size = new System.Drawing.Size(39, 17);
            this.rb_No.TabIndex = 1;
            this.rb_No.TabStop = true;
            this.rb_No.Text = "No";
            this.rb_No.UseVisualStyleBackColor = true;
            // 
            // tb_Identificacion
            // 
            this.tb_Identificacion.Location = new System.Drawing.Point(272, 73);
            this.tb_Identificacion.Name = "tb_Identificacion";
            this.tb_Identificacion.Size = new System.Drawing.Size(121, 20);
            this.tb_Identificacion.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estrato";
            // 
            // cb_Estrato
            // 
            this.cb_Estrato.FormattingEnabled = true;
            this.cb_Estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_Estrato.Location = new System.Drawing.Point(272, 133);
            this.cb_Estrato.Name = "cb_Estrato";
            this.cb_Estrato.Size = new System.Drawing.Size(121, 21);
            this.cb_Estrato.TabIndex = 10;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Estrato);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_Identificacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Identificacion);
            this.Controls.Add(this.cb_Grado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lista";
            this.Text = "Lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Grado;
        private System.Windows.Forms.ComboBox cb_Identificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_No;
        private System.Windows.Forms.RadioButton rb_Si;
        private System.Windows.Forms.TextBox tb_Identificacion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Estrato;
    }
}