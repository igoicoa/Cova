using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPMedico
    {
        public IList<BEMedico> BuscarMedicos(string usuario, string DNI)
        {
            List<BEMedico> medicos = new List<BEMedico>();
            DataSet medicosDS;
            DataTable medicoT;
            Hashtable datosMedico = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarMedico";
                datosMedico.Add("@Usuario", usuario);
                datosMedico.Add("@DNI", DNI);
                medicosDS = conexionBDD.ObtenerDataSet(strSQL, datosMedico);
                medicoT = medicosDS.Tables[0];
                if (medicoT.Rows.Count > 0)
                {
                    foreach (DataRow fila in medicoT.Rows)
                    {
                        BEMedico medico = new BEMedico();
                        medico.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        medico.Usuario = Convert.ToString(fila["Usuario"]);
                        medico.Nombre = Convert.ToString(fila["Nombre"]);
                        medico.Apellido = Convert.ToString(fila["Apellido"]);
                        medico.DNI = Convert.ToInt32(fila["DNI"]);
                        medico.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                        medico.Sexo = Convert.ToString(fila["Sexo"]);
                        medico.EstadoCivil = Convert.ToString(fila["EstadoCivil"]);
                        medico.Telefono = Convert.ToString(fila["Telefono"]);
                        medico.Email = Convert.ToString(fila["Email"]);

                        BEDomicilio domicilio = new BEDomicilio();
                        domicilio.Calle = Convert.ToString(fila["Calle"]);
                        domicilio.Numero = Convert.ToInt32(fila["Numero"]);
                        domicilio.Piso = Convert.ToString(fila["Piso"]);
                        domicilio.Localidad = Convert.ToString(fila["Localidad"]);
                        domicilio.Provincia = Convert.ToString(fila["Provincia"]);
                        domicilio.Pais = Convert.ToString(fila["Pais"]);

                        medico.Domicilio = domicilio;
                        medico.MatriculaNacional = Convert.ToInt32(fila["MatriculaNacional"]);
                        medico.MatriculaProvincial = Convert.ToInt32(fila["MatriculaProvincial"]);
                        medico.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), Convert.ToString(fila["Especialidad"]));
                        medico.Activo = Convert.ToBoolean(fila["Activo"]);

                        medicos.Add(medico);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return medicos;
        }
    }
}
