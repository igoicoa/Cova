using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;

namespace Cova.BL
{
    public class BLPaciente
    {
        public bool crearPaciene(BEPaciente pacienteNuevo) 
        {
            throw new NotImplementedException();
        }
        public IList<BEPaciente> obtenerPacientes()
        {
            throw new NotImplementedException();
        }

        public IList<BEVacuna> obtenerVacunasAplicadas()
        {
            throw new NotImplementedException();
        }

        public IList<BEVacuna> obtenerVacunasRecetadas()
        {
            throw new NotImplementedException();
        }

        public bool VacunarPaciente(BEPaciente pacienteAVacunar, BEVacuna vacunaAAplicar)
        {
            throw new NotImplementedException();
        }

        public bool agregarCoberturaMedica(BEPaciente paciente, BECoberturaMedica coberturaMedica)
        {
            throw new NotImplementedException();
        }

        public bool eliminarCoberturaMedica(BEPaciente paciente)
        {
            throw new NotImplementedException();
        }

        public bool agregarTurno(BEPaciente paciente, BETurno turnoNuevo)
        {
            throw new NotImplementedException();
        }

        public bool cancelarTurno(BEPaciente paciente, BETurno turnoACancelar)
        {
            throw new NotImplementedException();
        }

    }

}
