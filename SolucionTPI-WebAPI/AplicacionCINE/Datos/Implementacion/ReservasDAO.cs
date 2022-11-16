using AplicacionCINE.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCINE.Datos
{
    public class ReservasDAO : IReservas
    {      

        public bool EjecutarInsertReserva(Reserva reserva)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert("SP_NvaRESERVA","SP_NvoDETALLE", reserva);
        }


        public bool EjecutarInsertPeliculas(Pelicula pelicula)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert(pelicula); //////////////////
        }

        public bool EjecutarInsertClientes(Cliente cliente)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert(cliente); ////////////////////
        }
        

        public List<Cliente> ConsultarClientes()
        {
            List<Cliente> Lcliente = new List<Cliente>();
            DataTable tabla = HelperSingleton.ObtenerInstancia().ConsultarDB("SP_CONSULTAR_CLIENTES");
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c = new Cliente();
                c.Id_cliente = Convert.ToInt32(fila["id_cliente"]);
                c.Nombre = fila["Nombre"].ToString();
                c.Apellido = fila["Apellido"].ToString();
                c.Fecha_nacimiento = Convert.ToDateTime(fila["fec_nac"]);
                Lcliente.Add(c);
            }
            return Lcliente;
        }

        public List<Funcion> ConsultarFunciones()
        {
            List<Funcion> Lfuncion = new List<Funcion>();
            DataTable tabla = HelperSingleton.ObtenerInstancia().ConsultarDB("SP_CONSULTAR_FUNCION");
            foreach (DataRow fila in tabla.Rows)
            {
                Funcion f = new Funcion();
                f.Id_funcion = Convert.ToInt32(fila["id_funcion"]);
                f.Pelicula = fila["titulo"].ToString();
                f.Horario = Convert.ToDateTime(fila["horario"]);
                f.Precio = Convert.ToDecimal(fila["precio"]);
                f.Lenguaje = fila["lenguaje"].ToString();
                f.Sala = Convert.ToInt32(fila["id_sala"]);
                Lfuncion.Add(f);
            }
            return Lfuncion;

        }

        public List<Reserva> ConsultarReservas()
        {
            throw new NotImplementedException();
        }

        public List<Pelicula> ConsultarPeliculas()
        {
            throw new NotImplementedException();
        }

        public List<Reserva> ConsultarReservaXFecha(DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }
     

        public DataTable ConsultarDB(string SP)
        {
            return HelperSingleton.ObtenerInstancia().ConsultarDB(SP);
        }
    }
}
