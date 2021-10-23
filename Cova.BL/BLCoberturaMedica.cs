using System;
using System.Collections.Generic;
using System.Linq;
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
            MPPCoberturaMedica mPPCoberturaMedica = new MPPCoberturaMedica();
            try
            {
                if(mPPCoberturaMedica.ObtenerCoberturasMedicas().Where(x => x.Nombre == coberturaMedica.Nombre).FirstOrDefault() != null)
                {
                    throw new CoberturaMedicaYaExisteException();
                }
                coberturaCreada = mPPCoberturaMedica.AgregarCoberturaMedica(coberturaMedica);
                coberturaMedica.CoberturaMedicaId = mPPCoberturaMedica.ObtenerCoberturasMedicas().Where(x => x.Nombre == coberturaMedica.Nombre).FirstOrDefault().CoberturaMedicaId;
                if(!coberturaCreada)
                {
                    return false;
                }
                foreach(BECoberturaMedicaPlan plan in coberturaMedica.Plan)
                {
                    coberturaCreada = mPPCoberturaMedica.AgregarPlan(coberturaMedica.CoberturaMedicaId, plan.Nombre);
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

        public bool ModificarCoberturaMedica(BECoberturaMedica coberturaMedica)
        {
            bool coberturaModificada = false;
            MPPCoberturaMedica mPPCoberturaMedica = new MPPCoberturaMedica();
            List<BECoberturaMedicaPlan> planesActuales = mPPCoberturaMedica.ObtenerCoberturasMedicas().Where(x => x.CoberturaMedicaId == coberturaMedica.CoberturaMedicaId).FirstOrDefault().Plan.ToList();
            try
            {
                if (mPPCoberturaMedica.ObtenerCoberturasMedicas().Where(x => x.Nombre == coberturaMedica.Nombre).FirstOrDefault() != null)
                {
                    throw new CoberturaMedicaYaExisteException();
                }

                List<BECoberturaMedicaPlan> planesEnUso = mPPCoberturaMedica.ObtenerPlanesEnUsoDeCoberturaMedica(coberturaMedica);
                foreach (BECoberturaMedicaPlan plan in planesEnUso)
                {
                    if (!coberturaMedica.Plan.Any(c => c.PlanId == plan.PlanId))
                    {
                        throw new PlanCoberturaEnUsoException();
                    }
                }

                foreach (BECoberturaMedicaPlan planActual in planesActuales)
                {
                    if (!planesEnUso.Any(c => c.PlanId == planActual.PlanId))
                    {
                        coberturaModificada = mPPCoberturaMedica.EliminarPlanCoberturaMedica(planActual);
                        if (!coberturaModificada)
                        {
                            return false;
                        }
                    }
                }

                mPPCoberturaMedica.ActualizarCoberturaMedica(coberturaMedica);

                foreach (BECoberturaMedicaPlan plan in coberturaMedica.Plan)
                {
                    if(!planesEnUso.Any(c => c.PlanId == plan.PlanId))
                    {
                        coberturaModificada = mPPCoberturaMedica.AgregarPlan(coberturaMedica.CoberturaMedicaId, plan.Nombre);
                        if (!coberturaModificada)
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return coberturaModificada;
        }

    }
    
}
