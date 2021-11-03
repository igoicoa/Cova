using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPAdministrador
    {
        public IList<BEAdministrador> BuscarAdministrador(string usuario, string DNI)
        {
            List<BEAdministrador> administradores = new List<BEAdministrador>();
            DataSet administradorDS;
            DataTable administradorT;
            Hashtable datosAdministrador = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarAdministrador";
                datosAdministrador.Add("@Usuario", usuario);
                datosAdministrador.Add("@DNI", DNI);
                administradorDS = conexionBDD.ObtenerDataSet(strSQL, datosAdministrador);
                administradorT = administradorDS.Tables[0];
                if (administradorT.Rows.Count > 0)
                {
                    foreach (DataRow fila in administradorT.Rows)
                    {
                        BEAdministrador administrador = new BEAdministrador();
                        administrador.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        administrador.Nombre = Convert.ToString(fila["Nombre"]);
                        administrador.Apellido = Convert.ToString(fila["Apellido"]);
                        administrador.DNI = Convert.ToInt32(fila["DNI"]);
                        administrador.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                        administrador.Sexo = Convert.ToString(fila["Sexo"]);
                        administrador.EstadoCivil = Convert.ToString(fila["EstadoCivil"]);
                        administrador.Telefono = Convert.ToString(fila["Telefono"]);
                        administrador.Email = Convert.ToString(fila["Email"]);

                        BEDomicilio domicilio = new BEDomicilio();
                        domicilio.Calle = Convert.ToString(fila["Calle"]);
                        domicilio.Numero = Convert.ToInt32(fila["Numero"]);
                        domicilio.Piso = Convert.ToString(fila["Piso"]);
                        domicilio.Localidad = Convert.ToString(fila["Localidad"]);
                        domicilio.Provincia = Convert.ToString(fila["Provincia"]);
                        domicilio.Pais = Convert.ToString(fila["Pais"]);

                        administrador.Domicilio = domicilio;
                        administrador.Activo = Convert.ToBoolean(fila["Activo"]);

                        administradores.Add(administrador);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return administradores;
        }
        public bool CrearAdministrador(BEAdministrador administrador)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearAdministrador";
                datosUsuario.Add("@Apellido", administrador.Apellido);
                datosUsuario.Add("@Nombre", administrador.Nombre);
                datosUsuario.Add("@DNI", administrador.DNI);
                datosUsuario.Add("@FechaNacimiento", administrador.FechaNacimiento);
                datosUsuario.Add("@Sexo", administrador.Sexo);
                datosUsuario.Add("@EstadoCivil", administrador.EstadoCivil);
                datosUsuario.Add("@Telefono", administrador.Telefono);
                datosUsuario.Add("@Email", administrador.Email);
                datosUsuario.Add("@Calle", administrador.Domicilio.Calle);
                datosUsuario.Add("@Numero", administrador.Domicilio.Numero);
                datosUsuario.Add("@Piso", administrador.Domicilio.Piso);
                datosUsuario.Add("@Localidad", administrador.Domicilio.Localidad);
                datosUsuario.Add("@Provincia", administrador.Domicilio.Provincia);
                datosUsuario.Add("@Pais", administrador.Domicilio.Pais);
                datosUsuario.Add("@Password", administrador.Password);
                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarAdministrador(BEAdministrador administrador)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarAdministrador";
                datosUsuario.Add("@UsuarioId", administrador.UsuarioID);
                datosUsuario.Add("@Apellido", administrador.Apellido);
                datosUsuario.Add("@Nombre", administrador.Nombre);
                datosUsuario.Add("@DNI", administrador.DNI);
                datosUsuario.Add("@FechaNacimiento", administrador.FechaNacimiento);
                datosUsuario.Add("@Sexo", administrador.Sexo);
                datosUsuario.Add("@EstadoCivil", administrador.EstadoCivil);
                datosUsuario.Add("@Telefono", administrador.Telefono);
                datosUsuario.Add("@Email", administrador.Email);
                datosUsuario.Add("@Calle", administrador.Domicilio.Calle);
                datosUsuario.Add("@Numero", administrador.Domicilio.Numero);
                datosUsuario.Add("@Piso", administrador.Domicilio.Piso);
                datosUsuario.Add("@Localidad", administrador.Domicilio.Localidad);
                datosUsuario.Add("@Provincia", administrador.Domicilio.Provincia);
                datosUsuario.Add("@Pais", administrador.Domicilio.Pais);
                datosUsuario.Add("@Activo", administrador.Activo);
                if (!string.IsNullOrEmpty(administrador.Password))
                {
                    datosUsuario.Add("@Password", administrador.Password);
                }
                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
