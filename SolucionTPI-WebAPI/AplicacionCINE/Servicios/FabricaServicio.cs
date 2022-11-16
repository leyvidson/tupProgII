using AplicacionCINE.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Servicios.Interfaz
{
    abstract public class FabricaServicio
    {
        public abstract IServicio CrearServicio();
    }
}
