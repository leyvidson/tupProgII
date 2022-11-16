using AplicacionCINE.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Datos
{
    internal class ReservasDAO : IReservas
    {      

        public bool EjecutarInsert(Reserva reserva)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert("SP_NvaRESERVA","SP_NvoDETALLE", reserva);
        }

        public DataTable ConsultarDB(string SP)
        {
            return HelperSingleton.ObtenerInstancia().ConsultarDB(SP);
        }

        public bool EjecutarInsert(Pelicula pelicula)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert(pelicula);
        }

        public bool EjecutarInsert(Cliente cliente)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert(cliente);
        }
        public DataTable ConsultaDBVista(string vista)
        {
            return HelperSingleton.ObtenerInstancia().ConsultarDBVista(vista);
        }
    }
}
