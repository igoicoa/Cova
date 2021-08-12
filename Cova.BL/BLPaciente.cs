using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;
using Cova.Common.Excepciones;

namespace Cova.BL
{
    public class BLPaciente
    {
        public bool CrearPaciene(BEPaciente pacienteNuevo) 
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.CrearPaciente(pacienteNuevo);
            }
            catch
            {
                throw new ErrorAlCrearPacienteException();
            }
        }

        public IList<BEPaciente> BuscarPacientes(string Usuario, string DNI)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.BuscarPacientes(Usuario, DNI);
            }
            catch
            {
                throw new ErrorAlBuscarPacienteException();
            }
        }

        public bool ActualizarPaciente(BEPaciente pacienteNuevo)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.ActualizarPaciente(pacienteNuevo);
            }
            catch
            {
                throw new ErrorAlActualizarPacienteException();
            }

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
            }
            else
            {
                condicionesPaciente.Add(false, razones);
            }
            return condicionesPaciente;
        }

        private bool TieneRecetaMedicaParaAplicarVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            BLReceta bLReceta = new BLReceta();
            BEReceta recetaVacuna = bLReceta.ObtenerRecetaParaVacunaYPaciente(vacunaAAplicar.Vacuna, pacienteAVacunarse);

            return recetaVacuna.RecetaId == 0 ? false : true;
        }

        private bool CorrespondeRecibirDosis(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            int cantidadDosisAplicadas;
            MPPPaciente mPPPaciente = new MPPPaciente();
            cantidadDosisAplicadas = mPPPaciente.ObtenerCantidadDosisAplicadasDeVacunaAPaciente(pacienteAVacunarse, vacunaAAplicar.Vacuna);
            if(vacunaAAplicar.Dosis != (cantidadDosisAplicadas + 1) || vacunaAAplicar.Vacuna.CantidadDosis < vacunaAAplicar.Dosis)
            {
                return false;
            }
            return true;
        }

        private bool EstaDentroRangoEtarioVacunacion(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return (pacienteAVacunarse.Edad >= vacunaAAplicar.Vacuna.EdadMinimaAplicacion && pacienteAVacunarse.Edad <= vacunaAAplicar.Vacuna.EdadMaximaAplicacion);
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacunaDosis vacunaAAplicar)
        {
            try
            {
                MPPVacuna mPPVacuna = new MPPVacuna();
                return mPPVacuna.VacunarPaciente(pacienteAVacunar, vacunaAAplicar);
            }
            catch
            {
                throw new ErrorAlVacunarPacienteException();
            }
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaCompleto(BEPaciente paciente)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.ObtenerVacunasAplicadasEsquemaCompleto(paciente);
            }
            catch
            {
                throw new ErrorAlObtenerVacunasAplicadasEsquemaCompletoException();
            }
        }

        public IList<BEVacunaDosis> ObtenerVacunasAplicadasEsquemaIncompleto(BEPaciente paciente)
        {
            try
            {
                MPPPaciente mPPPaciente = new MPPPaciente();
                return mPPPaciente.ObtenerVacunasAplicadasEsquemaIncompleto(paciente);
            }
            catch
            {
                throw new ErrorAlObtenerVacunasAplicadasEsquemaInCompletoException();
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
