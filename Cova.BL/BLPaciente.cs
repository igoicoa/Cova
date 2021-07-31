using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLPaciente
    {
        public bool CrearPaciene(BEPaciente pacienteNuevo) 
        {
            MPPPaciente mPPPaciente = new MPPPaciente();
            return mPPPaciente.CrearPaciente(pacienteNuevo);
        }

        public IList<BEPaciente> BuscarPacientes(string Usuario, string DNI)
        {
            MPPPaciente mPPPaciente = new MPPPaciente();
            return mPPPaciente.BuscarPacientes(Usuario, DNI);
        }

        public bool ActualizarPaciente(BEPaciente pacienteNuevo)
        {
            MPPPaciente mPPPaciente = new MPPPaciente();
            return mPPPaciente.ActualizarPaciente(pacienteNuevo);
        }

        public IDictionary<bool, string> EstaEnCondicionesDeRecibirVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            Dictionary<bool, string> condicionesPaciente = new Dictionary<bool, string>();
            bool estaEnCondicionesDeVacunarse = true;
            if (!this.TieneRecetaMedicaParaAplicarVacuna(pacienteAVacunarse, vacunaAAplicar))
            {
                condicionesPaciente.Add(false, "El paciente no tiene receta para la vacuna");
                estaEnCondicionesDeVacunarse = false;
            }
            if(this.TieneDosisDeVacunaAplicada(pacienteAVacunarse, vacunaAAplicar))
            {
                condicionesPaciente.Add(false, "El paciente ya recibio la dosis de la vacuna indicada");
                estaEnCondicionesDeVacunarse = false;
            }
            if (this.EstaDentroRangoEtarioVacunacion(pacienteAVacunarse, vacunaAAplicar))
            {
                condicionesPaciente.Add(false, "El paciente no se encuentra dentro del rango etario de vacunacion");
                estaEnCondicionesDeVacunarse = false;
            }

            if (estaEnCondicionesDeVacunarse)
            {
                condicionesPaciente.Add(true, "El paciente esta en condiciones de vacunarse");
            }
            return condicionesPaciente;
        }

        public bool TieneRecetaMedicaParaAplicarVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return true;
        }

        public bool TieneDosisDeVacunaAplicada(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return false;
        }

        public bool EstaDentroRangoEtarioVacunacion(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return true;
        }

        public IList<BEVacuna> ObtenerVacunasAplicadas()
        {
            throw new NotImplementedException();
        }

        public IList<BEVacuna> ObtenerVacunasRecetadas()
        {
            throw new NotImplementedException();
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacuna vacunaAAplicar)
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
