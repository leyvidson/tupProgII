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
            List<Reserva> lReserva = new List<Reserva>();
            DataTable tabla = HelperSingleton.ObtenerInstancia().ConsultarDB("SP_CONSULTAR_RESERVA");
            foreach (DataRow fila in tabla.Rows)
            {
                Reserva r = new Reserva();

                r.Id_reserva = Convert.ToInt32(fila["id_reserva"]);
                r.id_Funcion = Convert.ToInt32(fila["id_funcion"]);
                r.cliente = fila["cliente"].ToString();
                r.pelicula = fila["titulo"].ToString();
                r.FechaReserva = Convert.ToDateTime(fila["fecha"]);
                r.Cantidad = Convert.ToInt32(fila["cantidad"]);
                lReserva.Add(r);
            }
            return lReserva;
        }

        public List<Pelicula> ConsultarPeliculas()
        {
            List<Pelicula> lPeliculas = new List<Pelicula>();
            DataTable tabla = HelperSingleton.ObtenerInstancia().ConsultarDB("SP_CONSULTAR_PELICULA");
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula p = new Pelicula();

                p.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                p.Titulo = fila["titulo"].ToString();
                p.Duracion = Convert.ToDecimal(fila["duracion"]);
                p.calificacion = fila["calificacion"].ToString();
                p.Apto_toto_publico = Convert.ToBoolean(fila["apto_para_todo_publico"]);
                p.Subtitulo = Convert.ToBoolean(fila["subtitulos"]);
                p.Fecha_estreno = Convert.ToDateTime(fila["fecha_de_estreno"]);
                p.genero = fila["genero"].ToString();
                lPeliculas.Add(p);
            }
            return lPeliculas;
        }

       
        public bool EliminarCliente(int id)
        {
            return HelperSingleton.ObtenerInstancia().EliminarCliente(id, "SP_OCULTAR_CLIENTE");
        }
     

        public DataTable ConsultarDB(string SP)
        {
            return HelperSingleton.ObtenerInstancia().ConsultarDB(SP);
        }

        public List<Reserva> ConsultarReservaXFecha(DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public bool EjecutarUpdateCliente(int id, string nombre)
        {
            return HelperSingleton.ObtenerInstancia().EjecutarUpdateCliente(id, "SP_ACTUALIZAR_CLIENTE", nombre);
        }
    }
}
