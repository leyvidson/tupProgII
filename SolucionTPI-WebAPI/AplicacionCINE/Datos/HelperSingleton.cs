using System;
using System.Data.Sql;
using System.Data;
using AplicacionCINE.Entidades;
using System.Data.SqlClient;

namespace AplicacionCINE.Datos
{
    internal class HelperSingleton
    {
        private SqlConnection cnn;
        private static HelperSingleton Instancia;

        private HelperSingleton()
        {
            string cadenaConexion = @"Data Source=DESKTOP-0L0DMBQ\SQLEXPRESS;Initial Catalog=CINE10;Integrated Security=True";
            cnn = new SqlConnection(cadenaConexion);
        }

        public static HelperSingleton ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new HelperSingleton();
            }
            return Instancia;
        }

        public bool EliminarCliente(int id, string sql)
        {
            bool aux = false;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cnn.Close();
                aux = true;
            }
            catch
            {
                aux = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return aux;
        }

        public DataTable ConsultarDB(string SP)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand(SP, cnn);
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
                return tabla;
            }
            catch(Exception)
            {
                throw;
            }
               
        }

        public DataTable ConsultarDBVista(string vista)//ejecutar vista
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = vista;
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool EjecutarInsert(Cliente cliente)
        {
            bool ok = true;            
            try
            {   
                cnn.Open();               
                SqlCommand Cmd = new SqlCommand("SP_NUEVO_CLIENTE", cnn);
                Cmd.CommandType = CommandType.StoredProcedure;
                //Cmd.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente); ESTE NO VA PORQUE ES IDENTITY
                Cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                Cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                Cmd.Parameters.AddWithValue("@fec_nac", cliente.Fecha_nacimiento);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return ok;
        }



        public bool EjecutarInsert(string SPMaestro, string SPDetalle, Reserva reserva)
        {
            bool ok = true;
            SqlTransaction T = null;
            try
            {   //Maestro Insert
                cnn.Open();
                T = cnn.BeginTransaction();
                SqlCommand Cmd = new SqlCommand(SPMaestro, cnn, T);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id_funcion", reserva.FuncionIns.Id_funcion);
                Cmd.Parameters.AddWithValue("@id_cliente", reserva.ClienteIns.Id_cliente);
                Cmd.Parameters.AddWithValue("@id_pelicula", reserva.PeliculaIns.Id_pelicula); //proximo a resolver
                Cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
                Cmd.Parameters.AddWithValue("@cantidad", reserva.Cantidad);

                SqlParameter Pout = new SqlParameter("@IdOut", DbType.Int32);
                Pout.Direction = ParameterDirection.Output;
                Cmd.Parameters.Add(Pout);
                Cmd.ExecuteNonQuery();
                int IdOut = (int)Pout.Value;

                //Detalles Insert
                SqlCommand Cmddet = new SqlCommand(SPDetalle, cnn, T);
                foreach (Detalle_Reservas detalle in reserva.Ldetalle)
                {
                    Cmddet.CommandType = CommandType.StoredProcedure;
                    Cmddet.Parameters.Clear();                   
                    Cmddet.Parameters.AddWithValue("@id_ticket", detalle.Id_ticket );
                    Cmddet.Parameters.AddWithValue("@id_pelicula", detalle.Pelicula/*.Id_pelicula*/); //Proximo a resolver
                    Cmddet.Parameters.AddWithValue("@id_promocion", detalle.Promocion.Id_promocion);
                    Cmddet.Parameters.AddWithValue("@id_funcion", detalle.Funcion.Id_funcion);
                    Cmddet.Parameters.AddWithValue("@id_reserva", IdOut);
                    Cmddet.ExecuteNonQuery();
                }
                T.Commit();
                ok = true;
            }
            catch(Exception)
            {
                T.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return ok;
            
        }
        public bool EjecutarInsert(Pelicula pelicula)
        {
            bool ok = true;
            try
            {   

                SqlCommand Cmd = new SqlCommand("SP_NUEVA_PELICULA", cnn);
                cnn.Open();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id_genero", pelicula.GeneroInst.Id_genero);
                Cmd.Parameters.AddWithValue("@id_calificacion", pelicula.CalificacionInst.Id_calificacion);
                Cmd.Parameters.AddWithValue("@duracion", pelicula.Duracion);
                Cmd.Parameters.AddWithValue("@subtitulos", pelicula.Subtitulo);
                Cmd.Parameters.AddWithValue("@fecha_de_estreno", pelicula.Fecha_estreno);
                Cmd.Parameters.AddWithValue("@apto_para_todo_publico", pelicula.Apto_toto_publico);
                Cmd.Parameters.AddWithValue("@id_actor", pelicula.Actor_principalInst.Id_actor_principal);
                Cmd.Parameters.AddWithValue("@id_origen", pelicula.OrigenInst.Id_origen);
                Cmd.Parameters.AddWithValue("@sinopsis", pelicula.Sinopsis);
                Cmd.Parameters.AddWithValue("@titulo", pelicula.Titulo);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return ok;
        }
    }
}
