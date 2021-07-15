using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPUsuario
    {
        public BEUsuario ObtenerUsuario(BEUsuario usuarioALoguearse)
        {
            BEUsuario usuario = new BEUsuario();
            DataSet usuarioDS;
            DataTable usuarioT;
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerUsuario";
                datosUsuario.Add("@NombreUsuario", usuarioALoguearse.Usuario);
                usuarioDS = conexionBDD.obtenerDataSet(strSQL, datosUsuario);
                usuarioT = usuarioDS.Tables[0];
                if (usuarioT.Rows.Count > 0)
                {
                    foreach (DataRow fila in usuarioT.Rows)
                    {
                        usuario.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        usuario.Usuario = Convert.ToString(fila["Usuario"]);
                        usuario.Password = Convert.ToString(fila["Password"]);
                        //usuario.UltimoLogin = Convert.ToDateTime(fila["UltimoLogin"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuario;
        }

        public IList<BEUsuario> BuscarUsuarios(string nombreABuscar, string apellidoABuscar)
        {
            List<BEUsuario> usuarios = new List<BEUsuario>();
            DataSet usuariosDS;
            DataTable usuariosT;
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarUsuario";
                datosUsuario.Add("@NombreABuscar", nombreABuscar);
                datosUsuario.Add("@ApellidoABuscar", apellidoABuscar);
                usuariosDS = conexionBDD.obtenerDataSet(strSQL, datosUsuario);
                usuariosT = usuariosDS.Tables[0];
                if (usuariosT.Rows.Count > 0)
                {
                    foreach (DataRow fila in usuariosT.Rows)
                    {
                        if(Convert.ToString(fila["TipoUsuario"]) == "Paciente")
                        {
                            BEPaciente paciente = new BEPaciente();
                            paciente.Apellido = Convert.ToString(fila["Apellido"]);
                            paciente.Nombre = Convert.ToString(fila["Nombre"]);
                            paciente.Email = Convert.ToString(fila["Email"]);
                            paciente.Usuario = Convert.ToString(fila["Usuario"]);
                            paciente.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);

                            usuarios.Add(paciente);
                        } 
                        else if(Convert.ToString(fila["TipoUsuario"]) == "Medico")
                        {
                            BEProfesional profesional = new BEProfesional();
                            profesional.Apellido = Convert.ToString(fila["Apellido"]);
                            profesional.Nombre = Convert.ToString(fila["Nombre"]);
                            profesional.Email = Convert.ToString(fila["Email"]);
                            profesional.Usuario = Convert.ToString(fila["Usuario"]);
                            profesional.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);

                            usuarios.Add(profesional);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuarios;
        }

        public bool CrearProfesionalMedico(BEMedico medico)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearProfesionalMedico";
                datosUsuario.Add("@Apellido", medico.Apellido);
                datosUsuario.Add("@Nombre", medico.Nombre);
                datosUsuario.Add("@DNI", medico.DNI);
                datosUsuario.Add("@FechaNacimiento", medico.FechaNacimiento);
                datosUsuario.Add("@Sexo", medico.Sexo);
                datosUsuario.Add("@EstadoCivil", medico.EstadoCivil);
                datosUsuario.Add("@Telefono", medico.Telefono);
                datosUsuario.Add("@Email", medico.Email);
                datosUsuario.Add("@Calle", medico.Domicilio.Calle);
                datosUsuario.Add("@Numero", medico.Domicilio.Numero);
                datosUsuario.Add("@Piso", medico.Domicilio.Piso);
                datosUsuario.Add("@Localidad", medico.Domicilio.Localidad);
                datosUsuario.Add("@Provincia", medico.Domicilio.Provincia);
                datosUsuario.Add("@Pais", medico.Domicilio.Pais);
                datosUsuario.Add("@MatriculaNacional", medico.MatriculaNacional);
                datosUsuario.Add("@MatriculaProvincial", medico.MatriculaProvincial);
                datosUsuario.Add("@Especialidad", medico.Especialidad);
                datosUsuario.Add("@Password", medico.Password);
                return conexionBDD.escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                return conexionBDD.escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CrearPaciente(BEPaciente paciente)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearPaciente";
                datosUsuario.Add("@Apellido", paciente.Apellido);
                datosUsuario.Add("@Nombre", paciente.Nombre);
                datosUsuario.Add("@DNI", paciente.DNI);
                datosUsuario.Add("@FechaNacimiento", paciente.FechaNacimiento);
                datosUsuario.Add("@Sexo", paciente.Sexo);
                datosUsuario.Add("@EstadoCivil", paciente.EstadoCivil);
                datosUsuario.Add("@Telefono", paciente.Telefono);
                datosUsuario.Add("@Email", paciente.Email);
                datosUsuario.Add("@Calle", paciente.Domicilio.Calle);
                datosUsuario.Add("@Numero", paciente.Domicilio.Numero);
                datosUsuario.Add("@Piso", paciente.Domicilio.Piso);
                datosUsuario.Add("@Localidad", paciente.Domicilio.Localidad);
                datosUsuario.Add("@Provincia", paciente.Domicilio.Provincia);
                datosUsuario.Add("@Pais", paciente.Domicilio.Pais);
                if(paciente.CoberturaMedica != null)
                {
                    datosUsuario.Add("@CoberturaMedicaId", paciente.CoberturaMedica.CoberturaMedicaId);
                    datosUsuario.Add("@CoberturaMedicaPlanId", paciente.CoberturaMedica.Plan.PlanId);
                    datosUsuario.Add("@CoberturaMedicaNumeroAfiliado", paciente.CoberturaMedica.NumeroAfiliado);
                    datosUsuario.Add("@CoberturaMedicaFechaVencimiento", paciente.CoberturaMedica.FechaVencimiento);
                }
                datosUsuario.Add("@Password", paciente.Password);
                return conexionBDD.escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarPassword(string usuario, string claveNuevaEncriptada)
        {
            return true;
        }
    }
}
