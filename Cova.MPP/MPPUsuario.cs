using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;
using Cova.BE.Enum;

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
                datosUsuario.Add("@Usuario", usuarioALoguearse.Usuario);
                usuarioDS = conexionBDD.ObtenerDataSet(strSQL, datosUsuario);
                usuarioT = usuarioDS.Tables[0];
                if (usuarioT.Rows.Count > 0)
                {
                    foreach (DataRow fila in usuarioT.Rows)
                    {
                        usuario.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        usuario.Usuario = Convert.ToString(fila["Usuario"]);
                        usuario.Password = Convert.ToString(fila["Password"]);
                        usuario.Activo = Convert.ToBoolean(fila["Activo"]);
                        usuario.TipoUsuario = (TipoUsuario) int.Parse (fila["TipoUsuario"].ToString());
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
                usuariosDS = conexionBDD.ObtenerDataSet(strSQL, datosUsuario);
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
                        else if(Convert.ToString(fila["TipoUsuario"]) == "Profesional")
                        {
                            BEProfesional profesional = new BEProfesional();
                            profesional.Apellido = Convert.ToString(fila["Apellido"]);
                            profesional.Nombre = Convert.ToString(fila["Nombre"]);
                            profesional.Email = Convert.ToString(fila["Email"]);
                            profesional.Usuario = Convert.ToString(fila["Usuario"]);
                            profesional.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);

                            usuarios.Add(profesional);
                        }
                        else if (Convert.ToString(fila["TipoUsuario"]) == "Administrador")
                        {
                            BEAdministrador administrador = new BEAdministrador();
                            administrador.Apellido = Convert.ToString(fila["Apellido"]);
                            administrador.Nombre = Convert.ToString(fila["Nombre"]);
                            administrador.Email = Convert.ToString(fila["Email"]);
                            administrador.Usuario = Convert.ToString(fila["Usuario"]);
                            administrador.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);

                            usuarios.Add(administrador);
                        }
                        else if (Convert.ToString(fila["TipoUsuario"]) == "Medico")
                        {
                            BEMedico medico = new BEMedico();
                            medico.Apellido = Convert.ToString(fila["Apellido"]);
                            medico.Nombre = Convert.ToString(fila["Nombre"]);
                            medico.Email = Convert.ToString(fila["Email"]);
                            medico.Usuario = Convert.ToString(fila["Usuario"]);
                            medico.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);

                            usuarios.Add(medico);
                        }
                        else if (Convert.ToString(fila["TipoUsuario"]) == "Enfermero")
                        {
                            BEEnfermero enfermero = new BEEnfermero();
                            enfermero.Apellido = Convert.ToString(fila["Apellido"]);
                            enfermero.Nombre = Convert.ToString(fila["Nombre"]);
                            enfermero.Email = Convert.ToString(fila["Email"]);
                            enfermero.Usuario = Convert.ToString(fila["Usuario"]);
                            enfermero.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);

                            usuarios.Add(enfermero);
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

        public string ObtenerEmailUsuario(string usuario, string email)
        {
            string emailUsuario = "";
            DataSet usuarioDS;
            DataTable usuarioT;
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerEmailUsuario";
                datosUsuario.Add("@Usuario", usuario);
                datosUsuario.Add("@Email", email);
                usuarioDS = conexionBDD.ObtenerDataSet(strSQL, datosUsuario);
                usuarioT = usuarioDS.Tables[0];
                if (usuarioT.Rows.Count > 0)
                {
                    foreach (DataRow fila in usuarioT.Rows)
                    {
                        emailUsuario = Convert.ToString(fila["ReturnEmail"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return emailUsuario;
        }

        public bool ActualizarPassword(string usuario, string claveNuevaEncriptada)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarPasswordUsuario";
                datosUsuario.Add("@Usuario", usuario);
                datosUsuario.Add("@NuevoPassword", claveNuevaEncriptada);
                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
