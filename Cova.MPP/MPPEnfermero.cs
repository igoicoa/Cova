using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPEnfermero
    {
        public IList<BEEnfermero> BuscarEnfermeros(string usuario, string DNI)
        {
            List<BEEnfermero> enfermeros = new List<BEEnfermero>();
            DataSet enfermeroDS;
            DataTable enfermeroT;
            Hashtable datosEnfermero = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarEnfermero";
                datosEnfermero.Add("@Usuario", usuario);
                datosEnfermero.Add("@DNI", DNI);

                enfermeroDS = conexionBDD.ObtenerDataSet(strSQL, datosEnfermero);
                enfermeroT = enfermeroDS.Tables[0];
                if (enfermeroT.Rows.Count > 0)
                {
                    foreach (DataRow fila in enfermeroT.Rows)
                    {
                        BEEnfermero enfermero = new BEEnfermero();
                        enfermero.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        enfermero.Usuario = Convert.ToString(fila["Usuario"]);
                        enfermero.Nombre = Convert.ToString(fila["Nombre"]);
                        enfermero.Apellido = Convert.ToString(fila["Apellido"]);
                        enfermero.DNI = Convert.ToInt32(fila["DNI"]);
                        enfermero.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                        enfermero.Sexo = Convert.ToString(fila["Sexo"]);
                        enfermero.EstadoCivil = Convert.ToString(fila["EstadoCivil"]);
                        enfermero.Telefono = Convert.ToString(fila["Telefono"]);
                        enfermero.Email = Convert.ToString(fila["Email"]);

                        BEDomicilio domicilio = new BEDomicilio();
                        domicilio.Calle = Convert.ToString(fila["Calle"]);
                        domicilio.Numero = Convert.ToInt32(fila["Numero"]);
                        domicilio.Piso = Convert.ToString(fila["Piso"]);
                        domicilio.Localidad = Convert.ToString(fila["Localidad"]);
                        domicilio.Provincia = Convert.ToString(fila["Provincia"]);
                        domicilio.Pais = Convert.ToString(fila["Pais"]);

                        enfermero.Domicilio = domicilio;
                        enfermero.MatriculaEnfermero = Convert.ToInt32(fila["MatriculaEnfermero"]);
                        enfermero.Activo = Convert.ToBoolean(fila["Activo"]);

                        enfermeros.Add(enfermero);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return enfermeros;
        }

        public bool CrearProfesionalEnfermero(BEEnfermero enfermero)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearProfesionalEnfermero";
                datosUsuario.Add("@Apellido", enfermero.Apellido);
                datosUsuario.Add("@Nombre", enfermero.Nombre);
                datosUsuario.Add("@DNI", enfermero.DNI);
                datosUsuario.Add("@FechaNacimiento", enfermero.FechaNacimiento);
                datosUsuario.Add("@Sexo", enfermero.Sexo);
                datosUsuario.Add("@EstadoCivil", enfermero.EstadoCivil);
                datosUsuario.Add("@Telefono", enfermero.Telefono);
                datosUsuario.Add("@Email", enfermero.Email);
                datosUsuario.Add("@Calle", enfermero.Domicilio.Calle);
                datosUsuario.Add("@Numero", enfermero.Domicilio.Numero);
                datosUsuario.Add("@Piso", enfermero.Domicilio.Piso);
                datosUsuario.Add("@Localidad", enfermero.Domicilio.Localidad);
                datosUsuario.Add("@Provincia", enfermero.Domicilio.Provincia);
                datosUsuario.Add("@Pais", enfermero.Domicilio.Pais);
                datosUsuario.Add("@MatriculaEnfermero", enfermero.MatriculaEnfermero);
                datosUsuario.Add("@Password", enfermero.Password);
                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarProfesionalEnfermero(BEEnfermero enfermero)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarProfesionalEnfermero";
                datosUsuario.Add("@UsuarioId", enfermero.UsuarioID);
                datosUsuario.Add("@Apellido", enfermero.Apellido);
                datosUsuario.Add("@Nombre", enfermero.Nombre);
                datosUsuario.Add("@DNI", enfermero.DNI);
                datosUsuario.Add("@FechaNacimiento", enfermero.FechaNacimiento);
                datosUsuario.Add("@Sexo", enfermero.Sexo);
                datosUsuario.Add("@EstadoCivil", enfermero.EstadoCivil);
                datosUsuario.Add("@Telefono", enfermero.Telefono);
                datosUsuario.Add("@Email", enfermero.Email);
                datosUsuario.Add("@Calle", enfermero.Domicilio.Calle);
                datosUsuario.Add("@Numero", enfermero.Domicilio.Numero);
                datosUsuario.Add("@Piso", enfermero.Domicilio.Piso);
                datosUsuario.Add("@Localidad", enfermero.Domicilio.Localidad);
                datosUsuario.Add("@Provincia", enfermero.Domicilio.Provincia);
                datosUsuario.Add("@Pais", enfermero.Domicilio.Pais);
                datosUsuario.Add("@MatriculaEnfermero", enfermero.MatriculaEnfermero);
                datosUsuario.Add("@Activo", enfermero.Activo);
                if (!string.IsNullOrEmpty(enfermero.Password))
                {
                    datosUsuario.Add("@Password", enfermero.Password);
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
