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
            /*bt_Consultar.Enabled = false;*/
            bt_Borrar.Enabled = false;
        }

        private void bt_Registrar_Click(object sender, EventArgs e)
        {
            
            
            nuevoEstudiante = new ListaEstudiante();
            nuevoEstudiante.Tipo_Documento = cb_Identificacion.Text;
            nuevoEstudiante.Numero_Documento = tb_Identificacion.Text;
            nuevoEstudiante.Nombre = tb_Nombre.Text;
            nuevoEstudiante.Estrato = cb_Estrato.Text;
            nuevoEstudiante.Grado = Convert.ToInt32(cb_Grado.Text);
            fecha = dtp_Fecha.Value;
            nuevoEstudiante.Fecha_Nacimiento = fecha.ToString("dd/MMM/yyyy");
            if(rb_Si.Checked == true)
            {
                nuevoEstudiante.Servicio_PAE = rb_Si.Text;
            }else if(rb_No.Checked == true)
            {
                nuevoEstudiante.Servicio_PAE = rb_No.Text;
            }
            /*bt_Consultar.Enabled = true;*/
            if(consultarLista(tb_Identificacion.Text) == null)
            {
                nuevaListaEstudiante.Add(nuevoEstudiante);
            }
            else
            {
                MessageBox.Show("El usuario ya esta registrado");
            }
           
            this.BorrarInformacion();
            dataGridView1.DataSource = nuevaListaEstudiante.ToArray();
        }

        ListaEstudiante nuevo;
        private void bt_Consultar_Click(object sender, EventArgs e)
        {
            /*Buscar nuevoBuscar = new Buscar();
            nuevoBuscar.enviar();*/
            if(nuevaListaEstudiante.Count == 0)
            {
                MessageBox.Show("No hay registros");
            }
            else
            {
                Buscar nuevoBuscar = new Buscar();
                AddOwnedForm(nuevoBuscar);
                nuevoBuscar.ShowDialog();
                bool seguir;
                nuevo = consultarLista(validar);

                do
                {
                    if (nuevo == null)
                    {
                        DialogResult Continuar = MessageBox.Show("el usuario no se encuentra vuelva a intentar", "Mensaje", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes.Equals(Continuar))
                        {
                            nuevoBuscar.tb_Id.Text = "";
                            nuevoBuscar.ShowDialog();
                            
                            nuevo = consultarLista(validar);
                            seguir = true;
                        }
                        else
                        {
                            seguir = false;
                        }
                        
                       
                    }
                    else
                    {
                        seguir = false;
                        tb_Identificacion.Text = nuevo.Numero_Documento;
                        cb_Identificacion.Text = nuevo.Tipo_Documento;
                        tb_Nombre.Text = nuevo.Nombre;
                        cb_Estrato.Text = nuevo.Estrato;
                        cb_Grado.Text = nuevo.Grado.ToString();
                        bt_Borrar.Enabled = true;

                    }


                } while (seguir);
            }

        }

        //método para consultar 

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

        //metodo para borrar
        void BorrarInformacion()
        {
            tb_Identificacion.Clear();
            tb_Nombre.Clear();
            cb_Estrato.Text = "";
            cb_Grado.Text = "";
            cb_Estrato.Text = "";
            rb_No.Checked = false;
            rb_Si.Checked = false;
            cb_Identificacion.Text = "";
        }

        private void bt_Borrar_Click(object sender, EventArgs e)
        {
            //esto nos srive para borrar-
            DialogResult usar = MessageBox.Show("Esta seguro que desea eliminar al usuario", "Eliminar", MessageBoxButtons.YesNo);
            if (usar == DialogResult.Yes)
            {
                nuevaListaEstudiante.Remove(nuevo);
            }


            dataGridView1.DataSource = nuevaListaEstudiante.ToArray();
            bt_Borrar.Enabled = false;
            this.BorrarInformacion();
        }
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Error ingreso una letra");
                e.Handled = true;
            }
        }
        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Error ingreso un valor numérico");
                e.Handled = true;

            }
        }


    }
}
