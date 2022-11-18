using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Calificacion
    {
        public int Id_calificacion { get; set; }
        public string Descripcion { get; set; }

        public Calificacion()
        {
            Id_calificacion = 0;
            Descripcion = String.Empty;
        }

        public Calificacion(int id_calificacion, string descripcion)
        {
            this.Id_calificacion = id_calificacion;
            this.Descripcion = descripcion;
        }
        
        
    }
}
