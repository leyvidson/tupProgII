using AplicacionCINE.Entidades;
using System.Data;

namespace AplicacionCINE.Datos
{
    internal interface IReservas
    {       
        bool EjecutarInsert(Reserva reserva);
        DataTable ConsultarDB(string SP);
        bool EjecutarInsert(Cliente cliente);
        bool EjecutarInsert(Pelicula pelicula);
        DataTable ConsultaDBVista(string vista);


    }
}
