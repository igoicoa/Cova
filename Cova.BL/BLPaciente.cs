using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.Servicios.Bitacora;
using Cova.MPP;
using Cova.Common.Excepciones;
using Cova.Servicios.Sesion;
using Cova.Servicios.DigitoVerificador;
using Cova.BE.Enum;

namespace Cova.BL
{
    public class BLPaciente
    {
        public bool CrearPaciene(BEPaciente pacienteNuevo) 
        {
            bool pacienteCreado = false;
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                pacienteCreado = mPPPaciente.CrearPaciente(pacienteNuevo, Sesion.GetInstance.Usuario.UsuarioID);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "El paciente fue creado: " + pacienteNuevo.Apellido + "," + pacienteNuevo.Nombre, "Crear Paciente"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear el paciente" + ex.Message, "Crear Paciente"));
                throw new ErrorAlCrearPacienteException();
            }
            return pacienteCreado;
        }

        public IList<BEPaciente> BuscarPacientes(string Usuario, string DNI)
        {
            IList<BEPaciente> paciente;
            MPPPaciente mPPPaciente = new MPPPaciente();
            try
            {
                paciente= mPPPaciente.BuscarPacientes(Usuario, DNI);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se busco el Paciente", "Buscar Paciente"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el paciente" + ex.Message, "Buscar Paciente"));
                throw new ErrorAlBuscarPacienteException();
            }
            return paciente;
        }

        public bool ActualizarPaciente(BEPaciente pacienteNuevo)
        {
            bool PacienteActualizado = false;
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                PacienteActualizado= mPPPaciente.ActualizarPaciente(pacienteNuevo, Sesion.GetInstance.Usuario.UsuarioID);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizo el Paciente: " + pacienteNuevo.PacienteId + " - " + pacienteNuevo.Apellido, "Actualizar Paciente"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Actualizar Paciente: " + pacienteNuevo.PacienteId + " - " + pacienteNuevo.ApellidoNombre + " - " + ex.Message, "Actualizar Paciente"));
                throw new ErrorAlActualizarPacienteException();
            }
            return PacienteActualizado;

        }

        public IDictionary<bool, List<string>> EstaEnCondicionesDeRecibirVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            Dictionary<bool, List<string>> condicionesPaciente = new Dictionary<bool, List<string>>();
            List<string> razones = new List<string>();
            bool estaEnCondicionesDeVacunarse = true;

            if (!this.TieneRecetaMedicaParaAplicarVacuna(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("El paciente no tiene receta para la vacuna");
                estaEnCondicionesDeVacunarse = false;

            }
            if(!this.CorrespondeRecibirDosis(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("Al paciente no le corresponde recibir la dosis: " + Convert.ToString(vacunaAAplicar.Dosis));
                estaEnCondicionesDeVacunarse = false;
            }
            if (!this.EstaDentroRangoEtarioVacunacion(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("El paciente no se encuentra dentro del rango etario de vacunacion");
                estaEnCondicionesDeVacunarse = false;
            }

            if (estaEnCondicionesDeVacunarse)
            {
                razones.Add("El paciente esta en condiciones de vacunarse");
                condicionesPaciente.Add(true, razones);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "El paciente esta en condiciones de vacunarse: " + pacienteAVacunarse.PacienteId + " - " + pacienteAVacunarse.ApellidoNombre, "Vacunacion Paciente"));

            }
            else
            {
                condicionesPaciente.Add(false, razones);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "El paciente no esta en condiciones de Vacunarse: " + pacienteAVacunarse.PacienteId + " - " + pacienteAVacunarse.ApellidoNombre, "Vacunacion Paciente"));
            }
            return condicionesPaciente;
        }

        private bool TieneRecetaMedicaParaAplicarVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        { 
            BLReceta bLReceta = new BLReceta();
            BEReceta recetaVacuna = new BEReceta();
            try
            {
                recetaVacuna = bLReceta.ObtenerRecetaParaVacunaYPaciente(vacunaAAplicar.Vacuna, pacienteAVacunarse);
            }
            catch(Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al consultar receta de vacunacion Paciente: " + pacienteAVacunarse.PacienteId + " - " + pacienteAVacunarse.ApellidoNombre + " - " + ex.Message, "Vacunacion Paciente"));
                throw new ErrorAlActualizarPacienteException();//TODO Modificar excepcion
            }

            return recetaVacuna.RecetaId == 0 ? false : true;
        }

        private bool CorrespondeRecibirDosis(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            int cantidadDosisAplicadas;
            MPPPaciente mPPPaciente = new MPPPaciente();
            cantidadDosisAplicadas = mPPPaciente.ObtenerCantidadDosisAplicadasDeVacunaAPaciente(pacienteAVacunarse, vacunaAAplicar.Vacuna);
            if(vacunaAAplicar.Dosis != (cantidadDosisAplicadas + 1) || vacunaAAplicar.Vacuna.CantidadDosis < vacunaAAplicar.Dosis)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Al paciente le corresponde recibir la dosis de la vacuna: " + pacienteAVacunarse.PacienteId + " - "+ pacienteAVacunarse.ApellidoNombre, "Corresponde Recibir Dosis"));
                return false;
            }
            else
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al recibir la dosis de la vacuna: " + pacienteAVacunarse.PacienteId + " - " + pacienteAVacunarse.ApellidoNombre, "Corresponde Recibir Dosis"));
            }
            return true;
        }

        private bool EstaDentroRangoEtarioVacunacion(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return (pacienteAVacunarse.Edad >= vacunaAAplicar.Vacuna.EdadMinimaAplicacion && pacienteAVacunarse.Edad <= vacunaAAplicar.Vacuna.EdadMaximaAplicacion);
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacunaDosis vacunaAAplicar)
        {
            bool vacunaPaciente = false;
            try
            {
                MPPVacuna mPPVacuna = new MPPVacuna();
                int DVH = DigitoVerificador.CalcularDVH(vacunaAAplicar.Lote + vacunaAAplicar.Vacuna.VacunaID.ToString() + vacunaAAplicar.FechaElaboracion.ToString() + vacunaAAplicar.FechaVencimiento.ToString() + vacunaAAplicar.CentroMedico.CentroMedicoId.ToString() + pacienteAVacunar.PacienteId.ToString() + vacunaAAplicar.FechaAplicacion.ToString() + vacunaAAplicar.Dosis.ToString() + vacunaAAplicar.ObservacionPaciente + vacunaAAplicar.IndicacionMedico);
                vacunaPaciente = mPPVacuna.VacunarPaciente(pacienteAVacunar, vacunaAAplicar, DVH);
                DigitoVerificador.ActualizarDVV("VacunaDosis");
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Vacuno el Paciente: " + pacienteAVacunar.PacienteId + " - " + pacienteAVacunar.Nombre , "Vacunar Paciente"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Vacunar el Paciente: " + vacunaAAplicar.Paciente.Apellido + " - " + vacunaAAplicar.Paciente.Nombre + " - " + ex.Message, "Vacunar Paciente"));
                throw new ErrorAlVacunarPacienteException();
            }
            return vacunaPaciente;
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaCompleto(BEPaciente paciente)
        {
            IList<BEVacunaDosis> VacunasDosis;
            MPPPaciente mPPPaciente = new MPPPaciente();
            try
            {
                VacunasDosis= mPPPaciente.ObtenerVacunasAplicadasEsquemaCompleto(paciente);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo vacunas aplicadas esquema completo para el Paciente: " + paciente.PacienteId + paciente.Nombre, "Obtener Vacunas Aplicadas Esquema Completo"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Obtener Vacunas Aplicadas Esquema Completo: " + paciente.PacienteId + " - " + paciente.ApellidoNombre + " - " + ex.Message, "Obtener Vacunas Aplicadas Esquema Completo"));
                throw new ErrorAlObtenerVacunasAplicadasEsquemaCompletoException();
            }
            return VacunasDosis;
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaIncompleto(BEPaciente paciente)
        {
            IList<BEVacunaDosis> vacunaDosis;
            MPPPaciente mPPPaciente = new MPPPaciente();

            try
            {
                vacunaDosis= mPPPaciente.ObtenerVacunasAplicadasEsquemaIncompleto(paciente);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda de vacunas aplicadas esquema incompleto", "Obtener Vacunas Aplicadas Esquema Incompleto"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Obtener Vacunas Aplicadas Esquema incompleto" + ex.Message, "Obtener Vacunas Aplicadas Esquema Incompleto"));
                throw new ErrorAlObtenerVacunasAplicadasEsquemaInCompletoException();
            }
            return vacunaDosis;
        }

        public bool CargarAntecedentesPersonalesPaciente(BEPaciente paciente, IList<AntecedentesPersonales> antecedentes)
        {
            bool antecedentesCargados = true;
            MPPPaciente mPPPaciente = new MPPPaciente();
            try
            {
                foreach (AntecedentesPersonales antecedente in antecedentes)
                {
                    antecedentesCargados = mPPPaciente.CargarAntecedentesPersonalesPaciente(paciente, antecedente);
                    if (!antecedentesCargados)
                    {
                        throw new ErrorAlCrearAntecedentesPersonales();
                    }
                }
            }
            catch(Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al cargar antecedentes personales: " + ex.Message, "Crear Antecedentes personales"));
                throw new ErrorAlCrearAntecedentesPersonales();
            }
            Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Antecedentes personales cargados con exito para el paciente: " + paciente.PacienteId, "Crear Antecedentes personales"));
            return antecedentesCargados;
        }

        public bool CargarHistoriaClinicaPaciente(BEPaciente paciente, BEHistoriaClinica historiaClinica)
        {
            bool historiaClinicaCargada = false;
            MPPPaciente mPPPaciente = new MPPPaciente();
            try
            {
                historiaClinicaCargada = mPPPaciente.CargarHistoriaClinicaPaciente(paciente, historiaClinica);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al cargar antecedentes personales: " + paciente.PacienteId + " - " + paciente.ApellidoNombre + " - " + ex.Message, "Crear Antecedentes personales"));
                throw new ErrorAlCrearAntecedentesPersonales();
            }
            Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Historia clinica cargada con exito para el paciente: " + paciente.PacienteId, "Cargar historia clinica paciente"));
            return historiaClinicaCargada;
        }

        public void ObtenerAntecedentesPersonalesPaciente(BEPaciente paciente)
        {
            MPPPaciente mPPPaciente = new MPPPaciente();
            BEHistoriaClinica historiaClinica = new BEHistoriaClinica();
            try
            {
                historiaClinica.Peso = mPPPaciente.ObtenerPesoPaciente(paciente);
                paciente.AntecedentesPersonales = mPPPaciente.ObtenerAntecedentesPersonalesPaciente(paciente);
                paciente.HistoriaClinica = new List<BEHistoriaClinica>();
                paciente.HistoriaClinica.Add(historiaClinica);
            }
            catch(Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener antecedentes personales y peso del paciente: " + paciente.PacienteId + " - "  + ex.Message, "Obtener Antecedentes personales"));
                throw new ErrorAlCargarAntecedentesPersonalesException();
            }
            
        }

        public IList<BEVacuna> ObtenerVacunasRecetadas()
        {
            throw new NotImplementedException();
        }

        public bool AgregarCoberturaMedica(BEPaciente paciente, BECoberturaMedica coberturaMedica)
        {
            throw new NotImplementedException();
        }

        public bool EliminarCoberturaMedica(BEPaciente paciente)
        {
            throw new NotImplementedException();
        }

        public bool AgregarTurno(BEPaciente paciente, BETurno turnoNuevo)
        {
            throw new NotImplementedException();
        }

        public bool CancelarTurno(BEPaciente paciente, BETurno turnoACancelar)
        {
            throw new NotImplementedException();
        }

    }

}
