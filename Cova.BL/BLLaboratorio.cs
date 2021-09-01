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
    public class BLLaboratorio
    {
        public IList<BELaboratorio> ObtenerLaboratorios()
        {
            IList<BELaboratorio> laboratorios;
            MPPLaboratorio mPPLaboratorio = new MPPLaboratorio();
            try
            {
                laboratorios= mPPLaboratorio.ObtenerLaboratorios();
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo los laboratorios: ", "Obtener Laboratorios"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Obtener Laboratorios: " + ex.Message, "Obtener Laboratorios"));
                throw new ErrorAlObtenerLaboratoriosException();
            }
            return laboratorios;
        }
    }
}
