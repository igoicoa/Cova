﻿using System;
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

        public bool ActualizarPaciene(BEPaciente pacienteNuevo)
        {
            MPPPaciente mPPPaciente = new MPPPaciente();
            return mPPPaciente.ActualizarPaciente(pacienteNuevo);
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
