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

        public bool EjecutarInsertReserva(Reserva reserva) ///////////////////
        {
            return HelperSingleton.ObtenerInstancia().EjecutarInsert("SP_NUEVA_RESERVA","SP_DETALLE_RESERVA", reserva);
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
                Pelicula peli = new Pelicula();
                peli.Titulo = (string)fila["titulo"];

                Lenguaje len = new Lenguaje();
                len.Descripcion = (string)fila["lenguaje"];

                Sala sala = new Sala();
                sala.Id_sala = (int)fila["id_sala"];

                Funcion f = new Funcion();
                f.Id_funcion = Convert.ToInt32(fila["id_funcion"]);
                f.Horario = Convert.ToDateTime(fila["horario"]);
                f.Precio = Convert.ToDecimal(fila["precio"]);

                f.Pelicula = peli;
                f.Lenguaje = len;
                f.Sala = sala;

                Lfuncion.Add(f);
            }
            return Lfuncion;

        }

        public List<Funcion> ConsultarFuncionxReserva()
        {
            List<Funcion> Lfuncion = new List<Funcion>();
            DataTable tabla = HelperSingleton.ObtenerInstancia().ConsultarDB("SP_FUNCIONxRESERVA");
            foreach (DataRow fila in tabla.Rows)
            {
                Pelicula peli = new Pelicula();
                peli.Id_pelicula = (int)fila["id_pelicula"];
                peli.Titulo = (string)fila["titulo"];                             
                
                Sala sala = new Sala();
                sala.Id_sala = (int)fila["id_sala"];
                
                Funcion f = new Funcion();
                f.Id_funcion = Convert.ToInt32(fila["id_funcion"]);                               
                f.Precio = Convert.ToDecimal(fila["precio"]);
                
                f.Pelicula = peli;                
                f.Sala = sala;
                
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
                                               
                Funcion fun = new Funcion();
                fun.Id_funcion = (int)(fila["id_funcion"]);
                
                Cliente cli = new Cliente();
                cli.Nombre = (string)fila["cliente"];
                                        
               
                Pelicula peli = new Pelicula();
                peli.Titulo = (string)fila["titulo"];
                
                Reserva r = new Reserva();
                r.Id_reserva = Convert.ToInt32(fila["id_reserva"]);                         
                r.FechaReserva = Convert.ToDateTime(fila["fecha"]);
                r.Cantidad = Convert.ToInt32(fila["cantidad"]);
                
                r.Cliente = cli;
                r.Pelicula = peli;
                r.Funcion = fun;

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
                Calificacion cal = new Calificacion();
                cal.Descripcion = (string)fila["calificacion"];

                Genero gen = new Genero(); 
                gen.Descripcion = (string)fila["genero"];
                
                Pelicula p = new Pelicula();
                p.Id_pelicula = Convert.ToInt32(fila["id_pelicula"]);
                p.Titulo = (string)fila["titulo"];
                p.Duracion = Convert.ToDecimal(fila["duracion"]);               
                p.Apto_todo_publico = Convert.ToBoolean(fila["apto_para_todo_publico"]);
                p.Subtitulo = Convert.ToBoolean(fila["subtitulos"]);
                p.Fecha_estreno = Convert.ToDateTime(fila["fecha_de_estreno"]);
                
                p.Genero = gen;
                p.Calificacion = cal; 
                
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
