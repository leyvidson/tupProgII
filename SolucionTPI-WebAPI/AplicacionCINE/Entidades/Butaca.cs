using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Entidades
{
    public class Butaca
    {
        public int Id_butaca { get; set; }
        public Sala Id_sala { get; set; }
       
        public Butaca(int id_butaca, Sala id_sala)
        {
            Id_butaca = id_butaca;
            Id_sala = id_sala;
        }
    }
}
