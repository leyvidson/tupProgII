using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Reserva
    {
        public int Id_reserva { get; set; }
       // public int id_Funcion { get; set; }         //<<<<<<<<<<<<<<<<<
       //public string cliente { get; set; }        //<<<<<<<<<<<<<<<<<<  Para consultas
       //public string pelicula { get; set; }      //<<<<<<<<<<<<<<<<<<< 
       // public int id_pelicula { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Cantidad { get; set; }
        
        public Funcion Funcion { get; set; }
        public Cliente Cliente { get; set; }
        public Pelicula Pelicula { get; set; }           // estos atributos son para insert
        
        public List<Detalle_Reservas> Ldetalle;

    
        public Reserva()
        {
            Ldetalle = new List<Detalle_Reservas>();
            Id_reserva = 0;
            Funcion = null;
            Cliente = null;
            Pelicula = null;
            FechaReserva = DateTime.Now;
            Cantidad = 0;
        }


        public Reserva(int id_reserva, Funcion funcion, Cliente cliente, Pelicula pelicula, DateTime fechaReserva, int cantidad)
        {
            Id_reserva = id_reserva;
            Funcion = funcion;
            Cliente = cliente;
            Pelicula = pelicula;
            FechaReserva = fechaReserva;
            Cantidad = cantidad;
        }

    }
}
