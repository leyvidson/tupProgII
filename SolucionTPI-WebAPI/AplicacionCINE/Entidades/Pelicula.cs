using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Pelicula
    {
        public int Id_pelicula { get; set; }   //Identity
        
        public string genero { get; set; }              //<<<<<<<<<<<<<<<<
        public string calificacion { get; set; }        //<<<<<<<<<<<<<<<<
        public string actor_principal { get; set; }     //<<<<<<<<<<<<<<<<
        
        public decimal Duracion { get; set; }
        public bool Subtitulo { get; set; }
        public DateTime Fecha_estreno { get; set; }
        public bool Apto_toto_publico { get; set; }
        public string Sinopsis { get; set; }
        public string Titulo { get; set; } 
        
        
        public Origen Origen { get; set; }
        public Genero Genero { get; set; }
        public Calificacion Calificacion { get; set; }          //                         
        public ActorPrincipal Actor_principal { get; set; }
               

        public Pelicula(Genero genero, Calificacion calificacion,
           decimal duracion, bool subtitolo, DateTime fecha_estreno,
            bool apto_toto_publico, ActorPrincipal actor_principal,
            Origen origen, string sinopsis, string titulo)
        {
            Genero = genero;
            Calificacion = calificacion;
            Duracion = duracion;
            Subtitulo = subtitolo;
            Fecha_estreno = fecha_estreno;
            Apto_toto_publico = apto_toto_publico;
            Actor_principal = actor_principal;
            Origen = origen;
            Sinopsis = sinopsis;
            Titulo = titulo;
        }

        public Pelicula()
        {
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
