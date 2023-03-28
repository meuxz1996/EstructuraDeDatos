using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDeDatos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_Pila_Click(object sender, EventArgs e)
        {
            Pila nuevaPila = new Pila();
            nuevaPila.Show();
        }

        private void bt_Cola_Click(object sender, EventArgs e)
        {
            Cola nuevaCola = new Cola();
            nuevaCola.Show();
        }

        private void bt_Lista_Click(object sender, EventArgs e)
        {

        }
    }
}
