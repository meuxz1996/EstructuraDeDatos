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
    public partial class Cola : Form
    {
        Queue<ColaInfraccion> nuevaCola = new Queue<ColaInfraccion>();
        DateTime fecha;
        ColaInfraccion nuevaInfracccion;

        public Cola()
        {
            InitializeComponent();
        }

        private void bt_Registrar_Click(object sender, EventArgs e)
        {
            nuevaInfracccion = new ColaInfraccion();
            nuevaInfracccion.Identificacion = tb_Identificacion.Text;
            nuevaInfracccion.Nombre = tb_Nombre.Text;
            nuevaInfracccion.Direccion = tb_Direccion.Text;
            nuevaInfracccion.Placa = tb_Placa.Text;
            nuevaInfracccion.Tipo_Automotor = cb_Automotor.Text;
            fecha = dtp_Fecha.Value;
            nuevaInfracccion.Fecha_Comparendo = fecha.ToString("dd/MMM/yyyy");
            nuevaInfracccion.Dias = Convert.ToInt32(tb_Dias.Text);
            nuevaInfracccion.Calcular_Comparendo();

            nuevaCola.Enqueue(nuevaInfracccion);

            dataGridView1.DataSource = nuevaCola.ToArray();
        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            if (nuevaCola.Count == 0)
            {

                MessageBox.Show("Por el momento no se ha ingresado registros");
                tb_Registros.Text = "0";
            }
            else
            {
                tb_Registros.Text = nuevaCola.Count.ToString();
            }
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            if (nuevaCola.Count.Equals(0))
            {
                MessageBox.Show("No se encuentra elementos");
            }
            else
            {
                //si la pila esta llena se crea un nuevo objeto de la clase pilaCDT
                ColaInfraccion usar = new ColaInfraccion();
                //con el metodo peek pasamoa al objeto el ultimo objeto que se introjo en la pila 
                usar = nuevaCola.Peek();
                //creamos un string format para crear  la cadena para el message box
                string usar2 = string.Format($"Desea borrar este cliente: {usar.Nombre}"
                    + $"Numero de identificacion: {usar.Identificacion}");
                /// con esta condicional y la utilizacion de dialoresult confirmo si borrar el cliente o no
                DialogResult valorar = MessageBox.Show(usar2, "borrar", MessageBoxButtons.YesNo);
                if (valorar == DialogResult.Yes)
                {
                    nuevaCola.Dequeue();

                    dataGridView1.DataSource = nuevaCola.ToArray();
                }
                //nuevaCliente2 = pilaCdts.Pop();

            }
        }
    }
}
