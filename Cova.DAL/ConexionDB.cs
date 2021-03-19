using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Cova.DAL
{
    public class ConexionDB
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Cova;Integrated Security=True");
        private SqlTransaction transaccion;

        public string obtenerStringConexion()
        {
            return this.connection.ConnectionString;
        }

        public string TestConnection()
        {
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                return "Conexion a la BD OK";
            }
            else
            {
                connection.Close();
                return "Huno un error al conectarse a la BD";
            }
        }

        //Leo un escalar
        public int leerEscalar(string consulta)
        {
            int respuesta;
            connection.Open();
            SqlCommand command = new SqlCommand(consulta, connection);
            command.CommandType = CommandType.Text;
            try
            {
                using (connection)
                {
                    respuesta = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return respuesta;
        }

        public DataSet obtenerDataSet(string Consulta_SQL)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (connection)
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Consulta_SQL, connection);
                    dataAdapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return dataSet;
        }

        public bool Escribir(string Consulta_SQL, Hashtable hdatos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                connection.Open();
                transaccion = connection.BeginTransaction();
                cmd.Connection = connection;
                cmd.CommandText = Consulta_SQL;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaccion;

                if ((hdatos != null))
                {
                    foreach (string dato in hdatos.Keys)
                    {
                        //cargo los parametros del Stored Procedure que le estoy pasando con la Hash
                        cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
                transaccion.Commit();
                return true;
            }

            catch (SqlException ex)
            {
                transaccion.Rollback();
                throw ex;
            }

            finally
            { connection.Close(); }
        }
    }
}
