namespace EstructuraDeDatos
{
    partial class Pila
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_Id = new System.Windows.Forms.TextBox();
            this.tx_Nombre = new System.Windows.Forms.TextBox();
            this.cb_Estrato = new System.Windows.Forms.ComboBox();
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Registrar = new System.Windows.Forms.Button();
            this.cb_Megas = new System.Windows.Forms.ComboBox();
            this.bt_CalcularTotal = new System.Windows.Forms.Button();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.bt_Borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Megas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mes de afiliacion";
            // 
            // tx_Id
            // 
            this.tx_Id.Location = new System.Drawing.Point(149, 18);
            this.tx_Id.Name = "tx_Id";
            this.tx_Id.Size = new System.Drawing.Size(121, 20);
            this.tx_Id.TabIndex = 6;
            // 
            // tx_Nombre
            // 
            this.tx_Nombre.Location = new System.Drawing.Point(149, 53);
            this.tx_Nombre.Name = "tx_Nombre";
            this.tx_Nombre.Size = new System.Drawing.Size(121, 20);
            this.tx_Nombre.TabIndex = 7;
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
            this.cb_Estrato.Location = new System.Drawing.Point(149, 90);
            this.cb_Estrato.Name = "cb_Estrato";
            this.cb_Estrato.Size = new System.Drawing.Size(121, 21);
            this.cb_Estrato.TabIndex = 8;
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Items.AddRange(new object[] {
            "Urbano",
            "Rural"});
            this.cb_Categoria.Location = new System.Drawing.Point(149, 120);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_Categoria.TabIndex = 9;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(149, 157);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_Fecha.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 130);
            this.dataGridView1.TabIndex = 11;
            // 
            // bt_Registrar
            // 
            this.bt_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Registrar.Location = new System.Drawing.Point(46, 401);
            this.bt_Registrar.Name = "bt_Registrar";
            this.bt_Registrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Registrar.TabIndex = 12;
            this.bt_Registrar.Text = "Registrar";
            this.bt_Registrar.UseVisualStyleBackColor = true;
            this.bt_Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Megas
            // 
            this.cb_Megas.FormattingEnabled = true;
            this.cb_Megas.Items.AddRange(new object[] {
            "5 megas",
            "10 megas",
            "15 megas",
            "20 megas"});
            this.cb_Megas.Location = new System.Drawing.Point(385, 23);
            this.cb_Megas.Name = "cb_Megas";
            this.cb_Megas.Size = new System.Drawing.Size(121, 21);
            this.cb_Megas.TabIndex = 13;
            // 
            // bt_CalcularTotal
            // 
            this.bt_CalcularTotal.Location = new System.Drawing.Point(400, 389);
            this.bt_CalcularTotal.Name = "bt_CalcularTotal";
            this.bt_CalcularTotal.Size = new System.Drawing.Size(82, 35);
            this.bt_CalcularTotal.TabIndex = 14;
            this.bt_CalcularTotal.Text = "Calcular total de pago";
            this.bt_CalcularTotal.UseVisualStyleBackColor = true;
            this.bt_CalcularTotal.Click += new System.EventHandler(this.bt_CalcularTotal_Click);
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(517, 395);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(121, 20);
            this.tb_Total.TabIndex = 15;
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Borrar.Location = new System.Drawing.Point(193, 401);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Borrar.TabIndex = 16;
            this.bt_Borrar.Text = "Borrar";
            this.bt_Borrar.UseVisualStyleBackColor = true;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 448);
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.bt_CalcularTotal);
            this.Controls.Add(this.cb_Megas);
            this.Controls.Add(this.bt_Registrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.cb_Categoria);
            this.Controls.Add(this.cb_Estrato);
            this.Controls.Add(this.tx_Nombre);
            this.Controls.Add(this.tx_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_Id;
        private System.Windows.Forms.TextBox tx_Nombre;
        private System.Windows.Forms.ComboBox cb_Estrato;
        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Registrar;
        private System.Windows.Forms.ComboBox cb_Megas;
        private System.Windows.Forms.Button bt_CalcularTotal;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Button bt_Borrar;
    }
}

