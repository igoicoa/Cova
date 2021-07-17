using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Cova.DAL
{
    public class ConexionDB
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cova;Integrated Security=True");
        private SqlTransaction transaccion;

        public string obtenerStringConexion()
        {
            return this.connection.ConnectionString;
        }

        public string TestearConexion()
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

        public int LeerEscalar(string consulta)
        {
            int respuesta;
            connection.Open();
            SqlCommand command = new SqlCommand(consulta, connection);
            command.CommandType = CommandType.StoredProcedure;
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

        public DataSet ObtenerDataSet(string Consulta_SQL, Hashtable hdatos)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (connection)
                {
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        connection.Open();
                        cmd.CommandText = Consulta_SQL;
                        cmd.CommandType = CommandType.StoredProcedure;
                        if ((hdatos != null))
                        {
                            foreach (string dato in hdatos.Keys)
                            {
                                cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                            }
                        }
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dataSet);
                        }
                    }
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
                        cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
                transaccion.Commit();
                if (respuesta == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            catch (SqlException ex)
            {
                transaccion.Rollback();
                throw ex;
            }

            finally
            { 
                connection.Close(); 
            }
        }

    }
}
