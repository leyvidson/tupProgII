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
        DataTable ConsultarDB(string SP);

        List<Funcion> ConsultarFuncionxReserva();

        List<Cliente> ConsultarClientes();

        List<Funcion> ConsultarFunciones();

        List<Reserva> ConsultarReservas();

        List<Pelicula> ConsultarPeliculas();

        List<Reserva> ConsultarReservaXFecha(DateTime desde, DateTime hasta); //Falta implementar

        bool EjecutarUpdateCliente(int id, string nombre);

        bool EjecutarInsertReserva(Reserva reserva);

        bool EliminarCliente(int id);

        bool EjecutarInsertClientes(Cliente cliente);

        bool EjecutarInsertPeliculas(Pelicula pelicula);
    }
}
