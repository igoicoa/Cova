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
            try
            {
                MPPLaboratorio mPPLaboratorio = new MPPLaboratorio();
                return mPPLaboratorio.ObtenerLaboratorios();
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Obtener Laboratorios: " + ex.Message, "Obtener Laboratorios"));
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo los laboratorios: " + ex.Message, "Obtener Laboratorios"));
                throw new ErrorAlObtenerLaboratoriosException();
            }

        }
    }
}
