using System;
using System.Collections;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPReceta
    {
        public BEReceta ObtenerRecetaParaVacunaYPaciente(BEVacuna vacunaAAplicar, BEPaciente pacienteAVacunar)
        {
            BEReceta receta = new BEReceta();
            DataSet recetaDS;
            DataTable recetaT;
            Hashtable datosReceta = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerRecetaParaVacunaYPaciente";
                datosReceta.Add("@PacienteId", pacienteAVacunar.PacienteId);
                datosReceta.Add("@VacunaId", vacunaAAplicar.VacunaID);
                recetaDS = conexionBDD.ObtenerDataSet(strSQL, datosReceta);
                recetaT = recetaDS.Tables[0];
                if (recetaT.Rows.Count > 0)
                {
                    foreach (DataRow fila in recetaT.Rows)
                    {
                        receta.RecetaId = Convert.ToInt64(fila["RecetaId"]);
                        receta.FechaPrescripcion = Convert.ToDateTime(fila["FechaPrescripcion"]);
                        receta.Paciente = pacienteAVacunar;
                        receta.Vacuna = vacunaAAplicar;

                        BEMedico medicoPrescribio = new BEMedico();
                        medicoPrescribio.ProfesionalId = Convert.ToInt32(fila["ProfesionalId"]);
                        medicoPrescribio.Apellido = Convert.ToString(fila["MedicoApellido"]);
                        medicoPrescribio.Nombre = Convert.ToString(fila["MedicoNombre"]);

                        receta.Medico = medicoPrescribio;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return receta;
        }

        public bool CrearReceta(BEReceta receta)
        {
            Hashtable datosReceta = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CrearReceta";
                datosReceta.Add("@FechaPrescripcion", receta.FechaPrescripcion);
                datosReceta.Add("@PacienteId", receta.Paciente.PacienteId);
                datosReceta.Add("@ProfesionalId", receta.Medico.ProfesionalId);
                datosReceta.Add("@Observacion", receta.Observacion);
                if (receta.Vacuna != null)
                {
                    datosReceta.Add("@VacunaId", receta.Vacuna.VacunaID);
                }
                return conexionBDD.Escribir(strSQL, datosReceta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
