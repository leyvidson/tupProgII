using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionCINE.Datos;
using AplicacionCINE.Entidades;
using AplicacionCINE.Servicios.Interfaz;

namespace AplicacionCINE.Servicios.Implementacion
{
    class Servicio : IServicio
    {
        private IReservas oDao;
        
        public Servicio()
        {
            oDao = new ReservasDAO();
        }

        public List<Cliente> ConsultarClientes()
        {
            throw new NotImplementedException();
        }

        public DataTable ConsultarDB(string SP)
        {
            return oDao.ConsultarDB(SP);
        }

        public List<Funcion> ConsultarFunciones()
        {
            return oDao.ConsultarFunciones();
        }

        public List<Funcion> ConsultarFuncionxReserva()
        {
            return oDao.ConsultarFuncionxReserva();
        }

        public List<Pelicula> ConsultarPeliculas()
        {
            return oDao.ConsultarPeliculas();
        }

        public List<Reserva> ConsultarReservas()
        {
            return oDao.ConsultarReservas();
        }

        public List<Reserva> ConsultarReservaXFecha(DateTime desde, DateTime hasta)
        {
            return oDao.ConsultarReservaXFecha(desde, hasta);
        }

        public bool EjecutarInsert(object obj)
        {
            return (obj.Equals(obj)); // el equals esta para que no de error nomas . ES UNA PRUEBA DE REFACTORIZACION
        }

        public bool EjecutarInsertClientes(Cliente cliente)
        {
            return oDao.EjecutarInsertClientes(cliente);
        }

        public bool EjecutarInsertPeliculas(Pelicula pelicula)
        {
            return oDao.EjecutarInsertPeliculas(pelicula);
        }

        public bool EjecutarInsertReserva(Reserva reserva)
        {
            return oDao.EjecutarInsertReserva(reserva);
        }

        public bool EjecutarUpdateCliente(int id, string nombre)
        {
            return oDao.EjecutarUpdateCliente(id, nombre);
        }

        public bool EliminarCliente(int id)
        {
            return oDao.EliminarCliente(id);
        }
    }
}
