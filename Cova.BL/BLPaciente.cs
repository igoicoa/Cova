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

        public IDictionary<bool, List<string>> EstaEnCondicionesDeRecibirVacuna(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar, int dosisAAplicar)
        {
            Dictionary<bool, List<string>> condicionesPaciente = new Dictionary<bool, List<string>>();
            List<string> razones = new List<string>();
            bool estaEnCondicionesDeVacunarse = true;
            if (!this.TieneRecetaMedicaParaAplicarVacuna(pacienteAVacunarse, vacunaAAplicar))
            {
                razones.Add("El paciente no tiene receta para la vacuna");
                estaEnCondicionesDeVacunarse = false;
            }
            if(!this.CorrespondeRecibirDosis(pacienteAVacunarse, vacunaAAplicar, dosisAAplicar))
            {
                razones.Add("Al paciente no le corresponde recibir la dosis: " + Convert.ToString(dosisAAplicar));
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

        private bool CorrespondeRecibirDosis(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar, int dosisAAplicar)
        {
            int cantidadDosisAplicadas;
            MPPPaciente mPPPaciente = new MPPPaciente();
            cantidadDosisAplicadas = mPPPaciente.ObtenerCantidadDosisAplicadasDeVacunaAPaciente(pacienteAVacunarse, vacunaAAplicar.Vacuna);
            if(dosisAAplicar != (cantidadDosisAplicadas + 1) || vacunaAAplicar.Vacuna.CantidadDosis < dosisAAplicar)
            {
                return false;
            }
            return true;
        }

        private bool EstaDentroRangoEtarioVacunacion(BEPaciente pacienteAVacunarse, BEVacunaDosis vacunaAAplicar)
        {
            return (pacienteAVacunarse.Edad >= vacunaAAplicar.Vacuna.EdadMinimaAplicacion && pacienteAVacunarse.Edad <= vacunaAAplicar.Vacuna.EdadMaximaAplicacion);
        }

        public IList<BEVacuna> ObtenerVacunasAplicadas()
        {
            throw new NotImplementedException();
        }

        public IList<BEVacuna> ObtenerVacunasRecetadas()
        {
            throw new NotImplementedException();
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacunaDosis vacunaAAplicar)
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
