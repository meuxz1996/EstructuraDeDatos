/*La empresa de telecomunicaciones Tekcom S.A. desea implementar 
una aplicación que se comporte como una estructura de datos tipo 
Pila, es decir que el ultimo registro ingresado sea el primero en salir. 
Que cuente con un menú de opciones para registrar, eliminar datos 
y el reporte del total de los usuarios. Para lo cual requiere que el 
usuario del sistema registre a través del formulario de la pila, los 
datos de cada usuario y se almacenen en una clase llamada 
PilaClientes, la cual tendrá como atributos o propiedades: los datos 
del clientes, (número de identificación, nombre, dirección, estrato (1, 
2, 3, 4, 5, 6) para seleccionar de una lista desplegable, mes de 
afiliación a la empresa de comunicaciones el cual será mediante el 
uso del control DateTimePicker, al igual que la categoría (Urbano o 
Rural) del cliente, es importante que se muestre en otra caja de texto 
el total a pagar por el servicio de mes, sabiendo que el valor a pagar 
depende de la siguiente tabla
Según el canal contratado
*/
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
    public partial class Pila : Form
    {
        //Se crea una lista d tipo pila de la clase cliente. 
        Stack<PilaClientes> Clientes = new Stack<PilaClientes>();

        //Se crea una instancia 
        PilaClientes nuevoCliente;
        public Pila()
        {
            InitializeComponent();
        }


        DateTime soloFecha;
        private void button1_Click(object sender, EventArgs e)
        {
            nuevoCliente = new PilaClientes();
            nuevoCliente.Identificacion = tx_Id.Text;
            nuevoCliente.Nombre = tx_Nombre.Text;
            nuevoCliente.Estrato = cb_Estrato.Text;
            soloFecha = dtp_Fecha.Value;
            nuevoCliente.Afiliacion = soloFecha.ToString("dd/MM/yyyy");
            nuevoCliente.Categoria = cb_Categoria.Text;
            nuevoCliente.Megas = cb_Megas.Text;
            Clientes.Push(nuevoCliente);
            nuevoCliente.calcularPago();

            dataGridView1.DataSource = Clientes.ToArray();
        }
        double temTotal;
        private void bt_CalcularTotal_Click(object sender, EventArgs e)
        {
            temTotal = 0;
            foreach (var x in Clientes)
            {
               temTotal += x.Pago;
                
            }
            tb_Total.Text = temTotal.ToString()
;        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            //condicion pra determnar si la pila esta vacia
            if (Clientes.Count.Equals(0))
            {
                MessageBox.Show("No se encuentra elementos");
            }
            else
            {
                //si la pila esta llena se crea un nuevo objeto de la clase pilaCDT
                PilaClientes usar = new PilaClientes();
                //con el metodo peek pasamoa al objeto el ultimo objeto que se introjo en la pila 
                usar = Clientes.Peek();
                //creamos un string format para crear  la cadena para el message box
                string usar2 = string.Format($"Desea borrar este cliente: {usar.Nombre}"
                    + $"Numero de identificacion: {usar.Identificacion}");
                /// con esta condicional y la utilizacion de dialoresult confirmo si borrar el cliente o no
                DialogResult valorar = MessageBox.Show(usar2, "borrar", MessageBoxButtons.YesNo);
                if (valorar == DialogResult.Yes)
                {
                    Clientes.Pop();

                    dataGridView1.DataSource = Clientes.ToArray();
                }
                //nuevaCliente2 = pilaCdts.Pop();

            }
        }
    }
}
