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
    public partial class Lista : Form
    {
        List<ListaEstudiante> nuevaListaEstudiante = new List<ListaEstudiante> ();
        ListaEstudiante nuevoEstudiante;
        public string validar { get; set; }
        DateTime fecha;
        

        public Lista()
        {
            InitializeComponent();
            bt_Consultar.Enabled = false;
            bt_Borrar.Enabled = false;
        }

        private void bt_Registrar_Click(object sender, EventArgs e)
        {
            nuevoEstudiante = new ListaEstudiante();
            nuevoEstudiante.Tipo_Documento = cb_Identificacion.Text;
            nuevoEstudiante.Numero_Documento = tb_Identificacion.Text;
            nuevoEstudiante.Nombre = tb_Nombre.Text;
            nuevoEstudiante.Estrato = cb_Estrato.Text;
            nuevoEstudiante.Grado = cb_Grado.Text;
            fecha = dtp_Fecha.Value;
            nuevoEstudiante.Fecha_Nacimiento = fecha.ToString("dd/MMM/yyyy");
            if(rb_Si.Checked == true)
            {
                nuevoEstudiante.Servicio_PAE = rb_Si.Text;
            }else if(rb_No.Checked == true)
            {
                nuevoEstudiante.Servicio_PAE = rb_No.Text;
            }
            bt_Consultar.Enabled = true;
            nuevaListaEstudiante.Add(nuevoEstudiante);
            dataGridView1.DataSource = nuevaListaEstudiante.ToArray();
        }

        private void bt_Consultar_Click(object sender, EventArgs e)
        {
            /*Buscar nuevoBuscar = new Buscar();
            nuevoBuscar.enviar();*/
            Buscar nuevoBuscar = new Buscar();
            AddOwnedForm(nuevoBuscar);
            nuevoBuscar.ShowDialog();
            bool seguir;
            var nuevo = consultarLista(validar);

            do
            {   
                if(nuevo == null)
                {
                    nuevoBuscar.ShowDialog();
                    seguir = true;
                }
                else
                {
                    seguir = false;
                    tb_Identificacion.Text = nuevo.Numero_Documento;
                    cb_Identificacion.Text = nuevo.Tipo_Documento;

                }
                

            } while (seguir);
            


        }

        //metodo para consultar 

        public ListaEstudiante consultarLista(string id)
        {
            foreach(ListaEstudiante x in nuevaListaEstudiante)
            {
                if (x.Numero_Documento.Equals(id))
                {
                    return x;
                }
            }
                return null;

        }
    }
}
