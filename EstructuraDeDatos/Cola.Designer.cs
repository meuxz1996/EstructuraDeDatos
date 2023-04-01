namespace EstructuraDeDatos
{
    partial class Cola
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Identificacion = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Placa = new System.Windows.Forms.TextBox();
            this.tb_Dias = new System.Windows.Forms.TextBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.cb_Automotor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Registrar = new System.Windows.Forms.Button();
            this.bt_Calcular = new System.Windows.Forms.Button();
            this.tb_Registros = new System.Windows.Forms.TextBox();
            this.bt_Borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion de residencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa del automotor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de automotor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Año de la matricula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Expredicion del \r\ncomparendo dias";
            // 
            // tb_Identificacion
            // 
            this.tb_Identificacion.Location = new System.Drawing.Point(195, 6);
            this.tb_Identificacion.Name = "tb_Identificacion";
            this.tb_Identificacion.Size = new System.Drawing.Size(100, 20);
            this.tb_Identificacion.TabIndex = 8;
            this.tb_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(195, 32);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 9;
            this.tb_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras_KeyPress);
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Location = new System.Drawing.Point(195, 68);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(100, 20);
            this.tb_Direccion.TabIndex = 10;
            // 
            // tb_Placa
            // 
            this.tb_Placa.Location = new System.Drawing.Point(195, 101);
            this.tb_Placa.Name = "tb_Placa";
            this.tb_Placa.Size = new System.Drawing.Size(100, 20);
            this.tb_Placa.TabIndex = 11;
            // 
            // tb_Dias
            // 
            this.tb_Dias.Location = new System.Drawing.Point(551, 94);
            this.tb_Dias.Name = "tb_Dias";
            this.tb_Dias.Size = new System.Drawing.Size(100, 20);
            this.tb_Dias.TabIndex = 12;
            this.tb_Dias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(551, 61);
            this.dtp_Fecha.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtp_Fecha.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(100, 20);
            this.dtp_Fecha.TabIndex = 13;
            // 
            // cb_Automotor
            // 
            this.cb_Automotor.FormattingEnabled = true;
            this.cb_Automotor.Items.AddRange(new object[] {
            "Automovil",
            "Motocicleta",
            "Taxi",
            "Camion o bus"});
            this.cb_Automotor.Location = new System.Drawing.Point(551, 22);
            this.cb_Automotor.Name = "cb_Automotor";
            this.cb_Automotor.Size = new System.Drawing.Size(100, 21);
            this.cb_Automotor.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // bt_Registrar
            // 
            this.bt_Registrar.Location = new System.Drawing.Point(64, 362);
            this.bt_Registrar.Name = "bt_Registrar";
            this.bt_Registrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Registrar.TabIndex = 16;
            this.bt_Registrar.Text = "Registrar";
            this.bt_Registrar.UseVisualStyleBackColor = true;
            this.bt_Registrar.Click += new System.EventHandler(this.bt_Registrar_Click);
            // 
            // bt_Calcular
            // 
            this.bt_Calcular.Location = new System.Drawing.Point(392, 362);
            this.bt_Calcular.Name = "bt_Calcular";
            this.bt_Calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_Calcular.TabIndex = 17;
            this.bt_Calcular.Text = "Calcular";
            this.bt_Calcular.UseVisualStyleBackColor = true;
            this.bt_Calcular.Click += new System.EventHandler(this.bt_Calcular_Click);
            // 
            // tb_Registros
            // 
            this.tb_Registros.Location = new System.Drawing.Point(513, 365);
            this.tb_Registros.Name = "tb_Registros";
            this.tb_Registros.Size = new System.Drawing.Size(100, 20);
            this.tb_Registros.TabIndex = 18;
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.Location = new System.Drawing.Point(231, 362);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Borrar.TabIndex = 19;
            this.bt_Borrar.Text = "Borrar";
            this.bt_Borrar.UseVisualStyleBackColor = true;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 449);
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.tb_Registros);
            this.Controls.Add(this.bt_Calcular);
            this.Controls.Add(this.bt_Registrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_Automotor);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.tb_Dias);
            this.Controls.Add(this.tb_Placa);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.tb_Identificacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Cola";
            this.Text = "Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_Identificacion;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Placa;
        private System.Windows.Forms.TextBox tb_Dias;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.ComboBox cb_Automotor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Registrar;
        private System.Windows.Forms.Button bt_Calcular;
        private System.Windows.Forms.TextBox tb_Registros;
        private System.Windows.Forms.Button bt_Borrar;
    }
}