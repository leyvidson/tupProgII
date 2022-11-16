using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Funcion
    {
        public int Id_funcion { get; set; }
        public string Pelicula { get; set; }      //<<<<<<<<<<<
        public DateTime Horario { get; set; }
        public decimal Precio { get; set; }
        public string Lenguaje { get; set; }     //<<<<<<<<<<<<<
        public int Sala { get; set; }         //<<<<<<<<<<<<<
        
        
        //public Pelicula pelicula { get; set; }
        //public Lenguaje enguaje { get; set; }   
        //public Sala sala { get; set; }


        public Funcion(int id, string pelicula, DateTime horario, decimal precio,
            string lenguaje, int sala)
        {
            Id_funcion = id;
            Pelicula = pelicula;
            Horario = horario;
            Precio = precio;
            Lenguaje = lenguaje;
            Sala = sala;
        }

        public Funcion()
        {
        }
    }
}
