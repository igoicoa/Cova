using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE.ControlCambios;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPControlDeCambio
    {
        public IList<BEControlDeCambioPaciente> ObtenerControlDeCambioPaciente()
        {
            List<BEControlDeCambioPaciente> pacientes = new List<BEControlDeCambioPaciente>();
            DataSet pacientesDS;
            DataTable pacientesT;
            Hashtable datosPaciente = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerControlCambios";
                pacientesDS = conexionBDD.ObtenerDataSet(strSQL, datosPaciente);
                pacientesT = pacientesDS.Tables[0];
                if (pacientesT.Rows.Count > 0)
                {
                    foreach (DataRow fila in pacientesT.Rows)
                    {
                        BEControlDeCambioPaciente bEControlDeCambioPaciente = new BEControlDeCambioPaciente();

                        bEControlDeCambioPaciente.ControlCambioId = Convert.ToInt64(fila["ControlCambioId"]);

                        BEPaciente paciente = new BEPaciente();
                        paciente.PacienteId = Convert.ToInt64(fila["PacienteId"]);
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

                        if (!string.IsNullOrEmpty(Convert.ToString(fila["CoberturaMedica"])))
                        {
                            BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
                            coberturaMedicaPaciente.Nombre = Convert.ToString(fila["CoberturaMedica"]);
                            BECoberturaMedicaPlan plan = new BECoberturaMedicaPlan();
                            plan.Nombre = Convert.ToString(fila["Plan"]);
                            coberturaMedicaPaciente.Plan = plan;
                            coberturaMedicaPaciente.NumeroAfiliado = Convert.ToString(fila["NumeroAfiliado"]);
                            coberturaMedicaPaciente.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);

                            paciente.CoberturaMedica = coberturaMedicaPaciente;
                        }

                        bEControlDeCambioPaciente.Paciente = paciente;

                        BEUsuario usuarioModificador = new BEUsuario();
                        usuarioModificador.Usuario = Convert.ToString(fila["UsuarioModificador"]);
                        bEControlDeCambioPaciente.UsuarioModificador = usuarioModificador;
                        bEControlDeCambioPaciente.FechaModificacion = Convert.ToDateTime(fila["FechaModificacion"]);
                        bEControlDeCambioPaciente.TipoCambio = Convert.ToString(fila["TipoCambio"]);

                        pacientes.Add(bEControlDeCambioPaciente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pacientes;
        }

        public bool RestaurarPaciente(long controlDeCambioId, long usuarioModificador)
        {
            Hashtable datosControlDeCambio = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_RestaurarPaciente"; 
                datosControlDeCambio.Add("@ControlDeCambioId", controlDeCambioId);
                datosControlDeCambio.Add("@UsuarioModificador", usuarioModificador);
                return conexionBDD.Escribir(strSQL, datosControlDeCambio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
