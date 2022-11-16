using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Lenguaje
    {
        public int Id_lenguaje { get; set; }
        public string Descripcion { get; set; }

        public Lenguaje(int id_lenguaje, string descripcion)
        {
            Id_lenguaje = id_lenguaje;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
