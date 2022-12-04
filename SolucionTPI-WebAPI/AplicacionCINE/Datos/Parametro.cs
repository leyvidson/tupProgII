using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Datos
{
    internal class Parametro
    {
        public string clave { get; set; }
        public object valor { get; set; }

        public Parametro()
        {
            clave = string.Empty;
            valor = null;
        }
    }
}
