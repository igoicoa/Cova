using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
   public class MPPCertificado
    {
        public bool CrearCertificado(BECertificado certificado)
        {
            Hashtable datosCertificado = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearCertificado";
                datosCertificado.Add("@FechaPrescripcion", certificado.FechaPrescripcion);
                datosCertificado.Add("@PacienteId", certificado.Paciente.PacienteId);
                datosCertificado.Add("@ProfesionalId", certificado.Medico.ProfesionalId);
                datosCertificado.Add("@Observacion", certificado.Observacion);
               
                return conexionBDD.Escribir(strSQL, datosCertificado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarCertificado(BECertificado certificado)
        {
            Hashtable datosCertificado = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarCertificado";
                datosCertificado.Add("@CertificadoId", certificado.CertificadoId);
                datosCertificado.Add("@FechaPrescripcion", certificado.FechaPrescripcion);
                datosCertificado.Add("@Observacion", certificado.Observacion);

                return conexionBDD.Escribir(strSQL, datosCertificado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<BECertificado> BuscarCertificados(BEPaciente paciente)
        {
            List<BECertificado> certificados = new List<BECertificado>();
            DataSet certificadosDS;
            DataTable certificadosT;
            Hashtable datoscertificados = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarCertificadoPaciente";
                datoscertificados.Add("@PacienteID", paciente.PacienteId);
                certificadosDS = conexionBDD.ObtenerDataSet(strSQL, datoscertificados);
                certificadosT = certificadosDS.Tables[0];
                if (certificadosT.Rows.Count > 0)
                {
                    foreach (DataRow fila in certificadosT.Rows)
                    {
                        BECertificado certificado = new BECertificado();
                        certificado.Paciente = paciente;
                        certificado.CertificadoId = Convert.ToInt32(fila["CertificadoId"]);

                        BEMedico medico = new BEMedico();
                        medico.ProfesionalId = Convert.ToInt32(fila["ProfesionalId"]);
                        medico.Apellido = Convert.ToString(fila["MedicoApellido"]);
                        medico.Nombre = Convert.ToString(fila["MedicoNombre"]);
                        medico.MatriculaNacional = Convert.ToInt32(fila["MatriculaNacional"]);
                        medico.MatriculaProvincial = Convert.ToInt32(fila["MatriculaProvincial"]);

                        certificado.Medico = medico;
                        certificado.FechaPrescripcion = Convert.ToDateTime(fila["FechaPrescripcion"]);
                        certificado.Observacion = Convert.ToString(fila["Observacion"]);

                        certificados.Add(certificado);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return certificados;
        }
    }
}
