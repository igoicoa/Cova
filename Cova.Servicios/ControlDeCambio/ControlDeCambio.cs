using System;
using System.Collections.Generic;
using Cova.Common.Excepciones;
using Cova.BE.ControlCambios;
using Cova.MPP;

namespace Cova.Servicios.ControlDeCambio
{
    public class ControlDeCambio
    {
        public IList<BEControlDeCambioPaciente> ObtenerControlDeCambioPaciente()
        {
            try
            {
                MPPControlDeCambio mPPControlCambio = new MPPControlDeCambio();
                return mPPControlCambio.ObtenerControlDeCambioPaciente();
            }
            catch(Exception ex)
            {
                throw new ErrorAlObteneControlDeCambioPacienteException(); 
            }
        }

        public bool RestaurarPaciente(long controlDeCambioId)
        {
            try
            {
                MPPControlDeCambio mPPControlCambio = new MPPControlDeCambio();
                return mPPControlCambio.RestaurarPaciente(controlDeCambioId, Sesion.Sesion.GetInstance.Usuario.UsuarioID);
            }
            catch (Exception ex)
            {
                throw new ErrorAlObteneControlDeCambioPacienteException();
            }
        }
    }
}
