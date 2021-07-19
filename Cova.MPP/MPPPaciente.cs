using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPPaciente
    {
        public IList<BEPaciente> BuscarPacientes(string usuario, string DNI)
        {
            List<BEPaciente> pacientes = new List<BEPaciente>();
            DataSet pacientesDS;
            DataTable pacientesT;
            Hashtable datosPaciente = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarPaciente";
                datosPaciente.Add("@Usuario", usuario);
                datosPaciente.Add("@DNI", DNI);
                pacientesDS = conexionBDD.ObtenerDataSet(strSQL, datosPaciente);
                pacientesT = pacientesDS.Tables[0];
                if (pacientesT.Rows.Count > 0)
                {
                    foreach (DataRow fila in pacientesT.Rows)
                    {
                        BEPaciente paciente = new BEPaciente();
                        paciente.Nombre = Convert.ToString(fila["Nombre"]);
                        paciente.Apellido = Convert.ToString(fila["Apellido"]);
                        paciente.DNI = Convert.ToInt32(fila["DNI"]);
                        paciente.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                        paciente.Sexo = Convert.ToString(fila["Sexo"]);
                        paciente.EstadoCivil = Convert.ToString(fila["EstadoCivil"]);
                        paciente.Telefono = Convert.ToString(fila["Telefono"]);
                        paciente.Email = Convert.ToString(fila["Email"]);

                        BEDomicilio domicilio = new BEDomicilio();
                        domicilio.Calle = Convert.ToString(fila["Calle"]);
                        domicilio.Numero = Convert.ToInt32(fila["Numero"]);
                        domicilio.Piso = Convert.ToString(fila["Piso"]);
                        domicilio.Localidad = Convert.ToString(fila["Localidad"]);
                        domicilio.Provincia = Convert.ToString(fila["Provincia"]);
                        domicilio.Pais = Convert.ToString(fila["Pais"]);

                        paciente.Domicilio = domicilio;

                        BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
                        coberturaMedicaPaciente.Nombre = Convert.ToString(fila["CoberturaMedica"]);
                        BECoberturaMedicaPlan plan = new BECoberturaMedicaPlan();
                        plan.Nombre = Convert.ToString(fila["Plan"]);
                        coberturaMedicaPaciente.Plan = plan;
                        coberturaMedicaPaciente.NumeroAfiliado = Convert.ToString(fila["NumeroAfiliado"]);
                        coberturaMedicaPaciente.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);

                        paciente.CoberturaMedica = coberturaMedicaPaciente;

                        pacientes.Add(paciente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pacientes;
        }
    }
}
