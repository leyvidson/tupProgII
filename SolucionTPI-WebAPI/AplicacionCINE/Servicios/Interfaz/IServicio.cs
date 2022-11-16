using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionCINE.Entidades;

namespace AplicacionCINE.Servicios
{
     public interface IServicio
    {        
        public DataTable ConsultarDB(string SP);
        public bool EjecutarInsert(Pelicula pelicula);
        public bool EjecutarInsert(Cliente cliente);
        public bool EjecutarInsert(Reserva reserva);
        public bool EjecutarInsert(object objeto); //Intentando refactorizar (PRUEBA)
        public DataTable ConsultaDBVista(string vista);


    }
}
