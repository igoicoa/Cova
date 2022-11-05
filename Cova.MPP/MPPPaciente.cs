using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.BE.Enum;
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
                        paciente.PacienteId = Convert.ToInt64(fila["PacienteId"]);
                        paciente.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
                        paciente.Usuario = Convert.ToString(fila["Usuario"]);
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
                            coberturaMedicaPaciente.CoberturaMedicaId = Convert.ToInt64(fila["CoberturaMedicaId"]);
                            coberturaMedicaPaciente.Plan.PlanId = (int)Convert.ToInt64(fila["CoberturaMedicaPlanId"]);

                            paciente.CoberturaMedica = coberturaMedicaPaciente;
                        }

                        paciente.Activo = Convert.ToBoolean(fila["Activo"]);

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
                if (paciente.CoberturaMedica != null)
                {
                    datosUsuario.Add("@CoberturaMedicaId", paciente.CoberturaMedica.CoberturaMedicaId);
                    datosUsuario.Add("@CoberturaMedicaPlanId", paciente.CoberturaMedica.Plan.PlanId);
                    datosUsuario.Add("@CoberturaMedicaNumeroAfiliado", paciente.CoberturaMedica.NumeroAfiliado);
                    datosUsuario.Add("@CoberturaMedicaFechaVencimiento", paciente.CoberturaMedica.FechaVencimiento);
                }
                datosUsuario.Add("@Password", paciente.Password);
                //datosUsuario.Add("@UsuarioModificadorId", usuarioModificadorId);

                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActualizarPaciente(BEPaciente paciente)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ActualizarPaciente";
                datosUsuario.Add("@UsuarioId", paciente.UsuarioID);
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
                if (paciente.CoberturaMedica != null)
                {
                    datosUsuario.Add("@CoberturaMedicaId", paciente.CoberturaMedica.CoberturaMedicaId);
                    datosUsuario.Add("@CoberturaMedicaPlanId", paciente.CoberturaMedica.Plan.PlanId);
                    datosUsuario.Add("@CoberturaMedicaNumeroAfiliado", paciente.CoberturaMedica.NumeroAfiliado);
                    datosUsuario.Add("@CoberturaMedicaFechaVencimiento", paciente.CoberturaMedica.FechaVencimiento);
                }
                datosUsuario.Add("@Activo", paciente.Activo);
                if (!string.IsNullOrEmpty(paciente.Password))
                {
                    datosUsuario.Add("@Password", paciente.Password);
                }
                //datosUsuario.Add("@UsuarioModificadorId", usuarioModificadorId);

                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InactivarPaciente(BEPaciente paciente)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_InactivarUsuario";
                datosUsuario.Add("@UsuarioId", paciente.UsuarioID);

                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ObtenerCantidadDosisAplicadasDeVacunaAPaciente(BEPaciente paciente, BEVacuna vacuna)
        {
            int cantidadDosisAplicadas = 0;
            DataSet vacunaDosisDS;
            DataTable vacunaDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerCantidadDosisAplicadasDeVacunaAPaciente";
                datosVacunaDosis.Add("@PacienteId", paciente.PacienteId);
                datosVacunaDosis.Add("@VacunaId", vacuna.VacunaID);
                vacunaDosisDS = conexionBDD.ObtenerDataSet(strSQL, datosVacunaDosis);
                vacunaDosisT = vacunaDosisDS.Tables[0];
                if (vacunaDosisT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunaDosisT.Rows)
                    {
                        cantidadDosisAplicadas = Convert.ToInt32(fila["CantidadDosisAplicadas"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cantidadDosisAplicadas;
        }

        public BEVacunaDosis ObtenerVacunaDosisPaciente(BEPaciente paciente, BEVacuna vacuna)
        {
            BEVacunaDosis vacunaDosis = new BEVacunaDosis();
            DataSet vacunaDosisDS;
            DataTable vacunaDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerVacunaDosisPaciente";
                datosVacunaDosis.Add("@PacienteId", paciente.PacienteId);
                datosVacunaDosis.Add("@VacunaId", vacuna.VacunaID);
                vacunaDosisDS = conexionBDD.ObtenerDataSet(strSQL, datosVacunaDosis);
                vacunaDosisT = vacunaDosisDS.Tables[0];
                if (vacunaDosisT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunaDosisT.Rows)
                    {
                        vacunaDosis.Vacuna = vacuna;
                        vacunaDosis.Paciente = paciente;
                        vacunaDosis.Lote = Convert.ToString(fila["Lote"]);
                        vacunaDosis.FechaAplicacion = Convert.ToDateTime(fila["FechaAplicacion"]);
                        vacunaDosis.FechaElaboracion = Convert.ToDateTime(fila["FechaElaboracion"]);
                        vacunaDosis.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vacunaDosis;
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaCompleto(BEPaciente paciente)
        {
            IList<BEVacunaDosis> vacunasDosis = new List<BEVacunaDosis>();
            DataSet vacunaDosisDS;
            DataTable vacunaDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerVacunasAplicadasEsquemaCompleto";
                datosVacunaDosis.Add("@PacienteId", paciente.PacienteId);
                vacunaDosisDS = conexionBDD.ObtenerDataSet(strSQL, datosVacunaDosis);
                vacunaDosisT = vacunaDosisDS.Tables[0];
                if (vacunaDosisT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunaDosisT.Rows)
                    {
                        BEVacunaDosis vacunaDosis = new BEVacunaDosis();
                        BEVacuna vacuna = new BEVacuna();
                        BELaboratorio laboratorio = new BELaboratorio();

                        laboratorio.Nombre = Convert.ToString(fila["LaboratorioNombre"]);
                        laboratorio.LaboratorioId = Convert.ToInt32(fila["LaboratorioId"]);

                        vacuna.Laboratorio = laboratorio;
                        vacuna.Nombre = Convert.ToString(fila["VacunaNombre"]);
                        vacuna.VacunaID = Convert.ToInt32(fila["VacunaId"]);
                        vacuna.CantidadDosis = Convert.ToInt32(fila["CantidadDosis"]);
                        vacuna.Descripcion = Convert.ToString(fila["Descripcion"]);
                        vacuna.Contraindicaciones = Convert.ToString(fila["Contraindicaciones"]);

                        vacunaDosis.Vacuna = vacuna;
                        vacunaDosis.Paciente = paciente;
                        vacunaDosis.Lote = Convert.ToString(fila["Lote"]);
                        vacunaDosis.Dosis = Convert.ToInt32(fila["Dosis"]);
                        vacunaDosis.FechaAplicacion = Convert.ToDateTime(fila["FechaAplicacion"]);
                        vacunaDosis.FechaElaboracion = Convert.ToDateTime(fila["FechaElaboracion"]);
                        vacunaDosis.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);
                        vacunaDosis.ObservacionPaciente = Convert.ToString(fila["ObservacionPaciente"]);
                        vacunaDosis.IndicacionMedico = Convert.ToString(fila["IndicacionMedico"]);

                        vacunasDosis.Add(vacunaDosis);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vacunasDosis;
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaIncompleto(BEPaciente paciente)
        {
            IList<BEVacunaDosis> vacunasDosis = new List<BEVacunaDosis>();
            DataSet vacunaDosisDS;
            DataTable vacunaDosisT;
            Hashtable datosVacunaDosis = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerVacunasAplicadasEsquemaIncompleto";
                datosVacunaDosis.Add("@PacienteId", paciente.PacienteId);
                vacunaDosisDS = conexionBDD.ObtenerDataSet(strSQL, datosVacunaDosis);
                vacunaDosisT = vacunaDosisDS.Tables[0];
                if (vacunaDosisT.Rows.Count > 0)
                {
                    foreach (DataRow fila in vacunaDosisT.Rows)
                    {
                        BEVacunaDosis vacunaDosis = new BEVacunaDosis();
                        BEVacuna vacuna = new BEVacuna();
                        BELaboratorio laboratorio = new BELaboratorio();

                        laboratorio.Nombre = Convert.ToString(fila["LaboratorioNombre"]);
                        laboratorio.LaboratorioId = Convert.ToInt32(fila["LaboratorioId"]);

                        vacuna.Laboratorio = laboratorio;
                        vacuna.Nombre = Convert.ToString(fila["VacunaNombre"]);
                        vacuna.VacunaID = Convert.ToInt32(fila["VacunaId"]);
                        vacuna.CantidadDosis = Convert.ToInt32(fila["CantidadDosis"]);
                        vacuna.Descripcion = Convert.ToString(fila["Descripcion"]);
                        vacuna.Contraindicaciones = Convert.ToString(fila["Contraindicaciones"]);

                        vacunaDosis.Vacuna = vacuna;
                        vacunaDosis.Paciente = paciente;
                        vacunaDosis.Lote = Convert.ToString(fila["Lote"]);
                        vacunaDosis.Dosis = Convert.ToInt32(fila["Dosis"]);
                        vacunaDosis.FechaAplicacion = Convert.ToDateTime(fila["FechaAplicacion"]);
                        vacunaDosis.FechaElaboracion = Convert.ToDateTime(fila["FechaElaboracion"]);
                        vacunaDosis.FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]);
                        vacunaDosis.ObservacionPaciente = Convert.ToString(fila["ObservacionPaciente"]);
                        vacunaDosis.IndicacionMedico = Convert.ToString(fila["IndicacionMedico"]);

                        vacunasDosis.Add(vacunaDosis);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vacunasDosis;
        }

        public bool CargarAntecedentesPersonalesPaciente(BEPaciente paciente, AntecedentesPersonales antecedente)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_CargarAntecedentesPersonales";
                datosUsuario.Add("@AntecedentesPersonalesId", antecedente);
                datosUsuario.Add("@PacienteId", paciente.PacienteId);

                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CargarHistoriaClinicaPaciente(BEPaciente paciente, BEHistoriaClinica historiaClinica)
        {
            Hashtable datosUsuario = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_AgregarHistoriaClinicaAPaciente";
                datosUsuario.Add("@PacienteId", paciente.PacienteId);
                datosUsuario.Add("@ProfesionalId", historiaClinica.Medico.ProfesionalId);
                datosUsuario.Add("@PFecha", historiaClinica.Fecha);
                datosUsuario.Add("@Observacion", historiaClinica.Observacion);
                datosUsuario.Add("@Peso", historiaClinica.Peso);

                return conexionBDD.Escribir(strSQL, datosUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal ObtenerPesoPaciente(BEPaciente paciente)
        {
            decimal peso = 0;
            DataSet pacienteDS;
            DataTable pacienteT;
            Hashtable datosPaciente = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerPesoPaciete";
                datosPaciente.Add("@PacienteId", paciente.PacienteId);
                pacienteDS = conexionBDD.ObtenerDataSet(strSQL, datosPaciente);
                pacienteT = pacienteDS.Tables[0];
                if (pacienteT.Rows.Count > 0)
                {
                    foreach (DataRow fila in pacienteT.Rows)
                    {
                        peso = Convert.ToDecimal(fila["Peso"]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return peso;
        }

        public IList<AntecedentesPersonales> ObtenerAntecedentesPersonalesPaciente(BEPaciente paciente)
        {
            List<AntecedentesPersonales> antecedentesPersonales = new List<AntecedentesPersonales>();
            DataSet pacienteDS;
            DataTable pacienteT;
            Hashtable datosPaciente = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerAntecedentesPersonalesPaciente";
                datosPaciente.Add("@PacienteId", paciente.PacienteId);
                pacienteDS = conexionBDD.ObtenerDataSet(strSQL, datosPaciente);
                pacienteT = pacienteDS.Tables[0];
                if (pacienteT.Rows.Count > 0)
                {
                    foreach (DataRow fila in pacienteT.Rows)
                    {
                        antecedentesPersonales.Add((AntecedentesPersonales)Convert.ToInt32(fila["AntecedentesPersonalesId"]));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return antecedentesPersonales;
        }

        public IList<BEHistoriaClinica> ObtenerHistoriaClinicaPaciente(BEPaciente paciente)
        {
            List<BEHistoriaClinica> historiasClinica = new List<BEHistoriaClinica>();
            DataSet pacienteDS;
            DataTable pacienteT;
            Hashtable datosPaciente = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_ObtenerHistoriaClinicaPaciente";
                datosPaciente.Add("@PacienteId", paciente.PacienteId);
                pacienteDS = conexionBDD.ObtenerDataSet(strSQL, datosPaciente);
                pacienteT = pacienteDS.Tables[0];
                if (pacienteT.Rows.Count > 0)
                {
                    foreach (DataRow fila in pacienteT.Rows)
                    {
                        BEHistoriaClinica historiaClinica = new BEHistoriaClinica();
                        historiaClinica.HistoriaClinicaId= Convert.ToInt32(fila["HistoriaClinicaId"]);
                        historiaClinica.Fecha = Convert.ToDateTime(fila["Fecha"]);
                        BEMedico medico = new BEMedico();
                        medico.ProfesionalId = Convert.ToInt32(fila["ProfesionalId"]);
                        historiaClinica.Medico= medico;
                        BEPaciente Paciente = new BEPaciente();
                        Paciente.PacienteId = Convert.ToInt32(fila["PacienteId"]);
                        historiaClinica.Observacion = Convert.ToString(fila["Observacion"]);
                        historiaClinica.Peso = Convert.ToInt32(fila["Peso"]);
                        historiasClinica.Add(historiaClinica);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return historiasClinica;
        }
    }
}
