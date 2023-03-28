using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    /*
     (número de identificación, nombre, dirección, estrato (1, 
2, 3, 4, 5, 6) para seleccionar de una lista desplegable, mes de 
afiliación a la empresa de comunicaciones el cual será mediante el 
uso del control DateTimePicker, al igual que la categoría (Urbano o 
Rural) del cliente,*/
    public class PilaClientes
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Estrato { get; set; }
        public string Afiliacion { get; set; }
        public string  Categoria { get; set; }
        public double Pago { get; set; }
        public string Megas { get; set; }

        public void calcularPago()
        {
            double temp = DescuentoEstrato();
            double temp2;
            if (Categoria.Equals("Rural"))
            {
                if(Megas.Equals("5 megas"))
                {
                    temp2 = 30000;
                    Pago = temp2 - (temp2 * temp);
                }else if(Megas.Equals("10 megas"))
                {
                    temp2 = 40000;
                    Pago = temp2 - (temp2 * temp);
                }
                else if (Megas.Equals("15 megas"))
                {
                    temp2 = 55000;
                    Pago = temp2 - (temp2 * temp);
                }
                else if (Megas.Equals("20 megas"))
                {
                    temp2 = 70000;
                    Pago = temp2 - (temp2 * temp);
                }
            }
            else if (Categoria.Equals("Urbano"))
            {
                if (Megas.Equals("5 megas"))
                {
                    temp2 = 20000;
                    Pago = temp2 - (temp2 * temp);
                }
                else if (Megas.Equals("10 megas"))
                {
                    temp2 = 30000;
                    Pago = temp2 - (temp2 * temp);
                }
                else if (Megas.Equals("15 megas"))
                {
                    temp2 = 45000;
                    Pago = temp2 - (temp2 * temp);
                }
                else if (Megas.Equals("20 megas"))
                {
                    temp2 = 60000;
                    Pago = temp2 - (temp2 * temp);
                }
            }
        }

        public double DescuentoEstrato()
        {
            if(Estrato.Equals("1") || Estrato.Equals("2") || Estrato.Equals("3"))
            {
                return 0.15;
            }else if (Estrato.Equals("4") || Estrato.Equals("5") || Estrato.Equals("6"))
            {
                return 0.1;
            }
                return default;
        }
    }
}
