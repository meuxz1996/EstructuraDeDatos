using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    internal class ColaInfraccion
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Placa { get; set; }
        public string Tipo_Automotor { get; set; }
        public string Fecha_Comparendo { get; set; }
        public int Dias { get; set; }
        public double Comparendo { get; set; } 


        public void Calcular_Comparendo()
        {
            double tempoComparendo = 450000;
            if (Dias < 10)
            {
                Comparendo = tempoComparendo - (tempoComparendo * 0.5);
            }else if (Dias < 20)
            {
                Comparendo = tempoComparendo - (tempoComparendo * 0.25);
            }
            else if (Dias < 30)
            {
                Comparendo = tempoComparendo - (tempoComparendo * 0.1);
            }else if (Dias >= 30)
            {
                Comparendo = tempoComparendo;
            }
        }
    }
}
