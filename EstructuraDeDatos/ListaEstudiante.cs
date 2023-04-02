using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    public class ListaEstudiante
    {
        public string Tipo_Documento { get; set; }
        public string Numero_Documento { get; set; }
        public string Nombre { get; set; }
        public string Estrato { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public int Grado { get; set; }
        public string Servicio_PAE { get; set; }
        public string Comida { get; set; }

        public void Desayuno_Almuerzo()
        {
            if(Grado >= 6 && Grado <= 9)
            {
                Comida = "Desayuno";
            }else if(Grado >= 10 && Grado <= 11)
            {
                Comida = "Almuerzo";
            }
        }
    }
}
