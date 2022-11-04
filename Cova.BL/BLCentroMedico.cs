using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLCentroMedico
    {
        public IList<BECentroMedico> ObtenerCentrosMedicos()
        {
            IList<BECentroMedico> centromedico;
            MPPCentroMedico mPPCentroMedico = new MPPCentroMedico();
            try
            {
                centromedico = mPPCentroMedico.ObtenerCentrosMedicos();
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda del centro medico", "Buscar Centro Medico"));
            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el centro medico: " + ex.Message, "Buscar Centro Medico"));
                throw new ErrorAlObtenerCentrosMedicosException();
            }
            return centromedico;
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
