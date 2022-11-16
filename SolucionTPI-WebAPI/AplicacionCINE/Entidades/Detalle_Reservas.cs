using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Detalle_Reservas
    {
        public int Id_DetalleReserva { get; set; }        
        public int Id_ticket { get; set; }
        public Pelicula Pelicula { get; set; }
        public Promocion Promocion { get; set; }
        public Funcion Funcion { get; set; }

        public Detalle_Reservas()
        {

        }
    }

}
