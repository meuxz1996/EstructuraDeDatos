using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class Buscar : Form
    {
        public string guardar { get; set; }
        public Buscar()
        {
            InitializeComponent();
        }

        public void bt_Validar_Click(object sender, EventArgs e)
        {
            Lista nuevaLista = Owner as Lista;
            nuevaLista.validar = tb_Id.Text;

            this.Close();

        }

        public void enviar()
        {

        }
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Error ingreso una letra");
                e.Handled = true;
            }
        }
    }
}
