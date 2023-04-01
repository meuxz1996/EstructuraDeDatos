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
            this.rb_No = new System.Windows.Forms.RadioButton();
            this.rb_Si = new System.Windows.Forms.RadioButton();
            this.tb_Identificacion = new System.Windows.Forms.TextBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Estrato = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Registrar = new System.Windows.Forms.Button();
            this.bt_Consultar = new System.Windows.Forms.Button();
            this.bt_Borrar = new System.Windows.Forms.Button();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Prueba = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 43);
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
            this.cb_Identificacion.Location = new System.Drawing.Point(272, 7);
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
            // tb_Identificacion
            // 
            this.tb_Identificacion.Location = new System.Drawing.Point(272, 40);
            this.tb_Identificacion.Name = "tb_Identificacion";
            this.tb_Identificacion.Size = new System.Drawing.Size(121, 20);
            this.tb_Identificacion.TabIndex = 8;
            this.tb_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(272, 107);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_Fecha.TabIndex = 9;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // bt_Registrar
            // 
            this.bt_Registrar.Location = new System.Drawing.Point(55, 401);
            this.bt_Registrar.Name = "bt_Registrar";
            this.bt_Registrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Registrar.TabIndex = 13;
            this.bt_Registrar.Text = "Registro";
            this.bt_Registrar.UseVisualStyleBackColor = true;
            this.bt_Registrar.Click += new System.EventHandler(this.bt_Registrar_Click);
            // 
            // bt_Consultar
            // 
            this.bt_Consultar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_Consultar.Location = new System.Drawing.Point(200, 401);
            this.bt_Consultar.Name = "bt_Consultar";
            this.bt_Consultar.Size = new System.Drawing.Size(75, 23);
            this.bt_Consultar.TabIndex = 14;
            this.bt_Consultar.Text = "Consultar";
            this.bt_Consultar.UseVisualStyleBackColor = true;
            this.bt_Consultar.Click += new System.EventHandler(this.bt_Consultar_Click);
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.Location = new System.Drawing.Point(329, 401);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Borrar.TabIndex = 15;
            this.bt_Borrar.Text = "Borrrar";
            this.bt_Borrar.UseVisualStyleBackColor = true;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(272, 74);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(121, 20);
            this.tb_Nombre.TabIndex = 17;
            this.tb_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre del estudiante";
            // 
            // lb_Prueba
            // 
            this.lb_Prueba.AutoSize = true;
            this.lb_Prueba.Location = new System.Drawing.Point(447, 173);
            this.lb_Prueba.Name = "lb_Prueba";
            this.lb_Prueba.Size = new System.Drawing.Size(40, 13);
            this.lb_Prueba.TabIndex = 18;
            this.lb_Prueba.Text = "Estrato";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Prueba);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.bt_Consultar);
            this.Controls.Add(this.bt_Registrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Estrato);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.tb_Identificacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Identificacion);
            this.Controls.Add(this.cb_Grado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Estrato;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Registrar;
        private System.Windows.Forms.Button bt_Consultar;
        private System.Windows.Forms.Button bt_Borrar;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lb_Prueba;
    }
}