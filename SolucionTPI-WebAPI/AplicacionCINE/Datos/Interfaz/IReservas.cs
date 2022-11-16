using AplicacionCINE.Entidades;
using System.Data;

namespace AplicacionCINE.Datos
{
    public interface IReservas
    {
        DataTable ConsultarDB(string SP);

        List<Cliente> ConsultarClientes();
        
        List<Funcion> ConsultarFunciones();
        
        List<Reserva> ConsultarReservas();
        
        List<Pelicula> ConsultarPeliculas();

        List<Reserva> ConsultarReservaXFecha(DateTime desde, DateTime hasta); //Falta implementar
        
        bool EjecutarInsertReserva(Reserva reserva);

        bool EliminarCliente(int id);
        
        bool EjecutarInsertClientes(Cliente cliente);
        
        bool EjecutarInsertPeliculas(Pelicula pelicula);
        



    }
}
