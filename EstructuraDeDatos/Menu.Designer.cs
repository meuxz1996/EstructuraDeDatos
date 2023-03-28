namespace EstructuraDeDatos
{
    partial class Menu
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
            this.bt_Pila = new System.Windows.Forms.Button();
            this.bt_Cola = new System.Windows.Forms.Button();
            this.bt_Lista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Pila
            // 
            this.bt_Pila.Location = new System.Drawing.Point(141, 61);
            this.bt_Pila.Name = "bt_Pila";
            this.bt_Pila.Size = new System.Drawing.Size(75, 23);
            this.bt_Pila.TabIndex = 0;
            this.bt_Pila.Text = "Pila";
            this.bt_Pila.UseVisualStyleBackColor = true;
            this.bt_Pila.Click += new System.EventHandler(this.bt_Pila_Click);
            // 
            // bt_Cola
            // 
            this.bt_Cola.Location = new System.Drawing.Point(141, 143);
            this.bt_Cola.Name = "bt_Cola";
            this.bt_Cola.Size = new System.Drawing.Size(75, 23);
            this.bt_Cola.TabIndex = 1;
            this.bt_Cola.Text = "Cola";
            this.bt_Cola.UseVisualStyleBackColor = true;
            this.bt_Cola.Click += new System.EventHandler(this.bt_Cola_Click);
            // 
            // bt_Lista
            // 
            this.bt_Lista.Location = new System.Drawing.Point(141, 215);
            this.bt_Lista.Name = "bt_Lista";
            this.bt_Lista.Size = new System.Drawing.Size(75, 23);
            this.bt_Lista.TabIndex = 2;
            this.bt_Lista.Text = "Lista";
            this.bt_Lista.UseVisualStyleBackColor = true;
            this.bt_Lista.Click += new System.EventHandler(this.bt_Lista_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 333);
            this.Controls.Add(this.bt_Lista);
            this.Controls.Add(this.bt_Cola);
            this.Controls.Add(this.bt_Pila);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Pila;
        private System.Windows.Forms.Button bt_Cola;
        private System.Windows.Forms.Button bt_Lista;
    }
}