namespace EstructuraDeDatos
{
    partial class Buscar
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
            this.bt_Validar = new System.Windows.Forms.Button();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el documento";
            // 
            // bt_Validar
            // 
            this.bt_Validar.Location = new System.Drawing.Point(64, 107);
            this.bt_Validar.Name = "bt_Validar";
            this.bt_Validar.Size = new System.Drawing.Size(75, 23);
            this.bt_Validar.TabIndex = 1;
            this.bt_Validar.Text = "Validar";
            this.bt_Validar.UseVisualStyleBackColor = true;
            this.bt_Validar.Click += new System.EventHandler(this.bt_Validar_Click);
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(50, 61);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 20);
            this.tb_Id.TabIndex = 2;
            this.tb_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 184);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.bt_Validar);
            this.Controls.Add(this.label1);
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Validar;
        public System.Windows.Forms.TextBox tb_Id;
    }
}