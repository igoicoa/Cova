using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.Common.Excepciones;
using Cova.MPP;

namespace Cova.BL
{
    public class BLCentroMedico
    {
        public IList<BECentroMedico> ObtenerCentrosMedicos()
        {
            try
            {
                MPPCentroMedico mPPCentroMedico = new MPPCentroMedico();
                return mPPCentroMedico.ObtenerCentrosMedicos();
            }
            catch
            {
                throw new ErrorAlObtenerCentrosMedicosException();
            }

        }

        public bool crearCentroMedico(BERangoHorario rangosHorarios, string nombre)
        {
            throw new NotImplementedException();
        }

        public bool AsignarTurno(BETurno turno)
        {
            throw new NotImplementedException();
        }

        public bool CancelarTurno(BETurno turno)
        {
            throw new NotImplementedException();
        }

        public bool ActualizarHorariosAtencion(BERangoHorario rangosHorarios)
        {
            throw new NotImplementedException();
        }
    }
}
