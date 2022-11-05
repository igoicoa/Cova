using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Cova.Common.Excepciones;

namespace Cova.DAL
{
    public class ConexionDB
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cova;Integrated Security=True");
        private SqlConnection connectionMaster = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        private SqlTransaction transaccion;

        public string ObtenerStringConexion()
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
                throw new ErrorConexionBDD();
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
                throw new ErrorConexionBDD();
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
                return true;
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                throw new ErrorConexionBDD();
            }
            finally
            { 
                connection.Close(); 
            }
        }

        public bool EjecutarSP(string Consulta_SQL, Hashtable hdatos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = Consulta_SQL;
                cmd.CommandType = CommandType.StoredProcedure;
                if ((hdatos != null))
                {
                    foreach (string dato in hdatos.Keys)
                    {
                        cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }

                int respuesta = cmd.ExecuteNonQuery();
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
                throw new ErrorConexionBDD();
            }
            finally
            {
                connection.Close();
            }
        }

        public bool RealizarRestore(string archivo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                connectionMaster.Open();
                cmd.Connection = connectionMaster;
                cmd.CommandText = "ALTER DATABASE COVA SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE COVA FROM DISK = '" + archivo + "' WITH REPLACE";

                int respuesta = cmd.ExecuteNonQuery();
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
                throw new ErrorConexionBDD();
            }
            finally
            {
                connectionMaster.Close();
            }
        }

    }
}
