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
        public Pelicula Pelicula { get; set; }      
        public DateTime Horario { get; set; }
        public decimal Precio { get; set; }
        public Lenguaje Lenguaje { get; set; }     
        public Sala Sala { get; set; }         


        //public string pelicula { get; set; }
        //public boollenguaje { get; set; }   
        //public int sala { get; set; }
             

        public Funcion(int id, string pelicula, DateTime horario, decimal precio,
            string lenguaje, int sala)
        {
            Id_funcion = id;
            Pelicula = null;
            Horario = horario;
            Precio = precio;
            Lenguaje = null;
            Sala = null;
        }

        public Funcion()
        {
        }
    }
}
