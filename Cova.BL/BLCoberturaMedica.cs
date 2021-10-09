using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLCoberturaMedica
    {
        public IList<BECoberturaMedica> ObtenerCoberturasMedicas()
        {
            IList<BECoberturaMedica> coberturamedica;
            MPPCoberturaMedica mPPCoberturaMedica = new MPPCoberturaMedica();
            try
            {
                coberturamedica = mPPCoberturaMedica.ObtenerCoberturasMedicas();
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la cobertura medica", "Buscar Cobertura Medica"));
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener la cobertura medica " + ex.Message, "Buscar Cobertura Medica"));
                throw new ErrorAlCargarCoberturasMedicasException();
            }
            return coberturamedica;
        }

        public bool CrearCoberturaMedica(BECoberturaMedica coberturaMedica)
        {
            bool coberturaCreada = false;
            try
            {
                MPPCoberturaMedica mPPCoberturaMedica = new MPPCoberturaMedica();
                coberturaCreada = mPPCoberturaMedica.AgregarCoberturaMedica(coberturaMedica);
                if(!coberturaCreada)
                {
                    return false;
                }
                foreach(BECoberturaMedicaPlan plan in coberturaMedica.Plan)
                {
                    coberturaCreada = mPPCoberturaMedica.AgregarPlan(coberturaMedica.Nombre, plan.Nombre);
                    if (!coberturaCreada)
                    {
                        return false;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return coberturaCreada;
        }
    }
    
}
