using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
   public class Origen
    {
        public int Id_origen { get; set; }
        public string Descripcion { get; set; }

        public Origen(int id_origen, string descripcion)
        {
            Id_origen = id_origen;
            Descripcion = descripcion;
        }

        public Origen()
        {
            Id_origen = 0;
            Descripcion = String.Empty;
        }
        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
