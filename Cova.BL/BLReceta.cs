using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.BE.Bitacora;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.Servicios;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLReceta
    {
        public BEReceta ObtenerRecetaParaVacunaYPaciente(BEVacuna vacunaAAplicar, BEPaciente pacienteAVacunar)
        {
            MPPReceta mPPReceta = new MPPReceta();
            return mPPReceta.ObtenerRecetaParaVacunaYPaciente(vacunaAAplicar, pacienteAVacunar);
        }

        public bool CrearReceta(BEReceta receta)
        {
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                return mPPReceta.CrearReceta(receta);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear la Receta: " + ex.Message, "Crear Receta"));
                throw new ErrorAlCrearRecetasException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo la Receta: ", "Crear Receta"));
            }

        }

        public bool ActualizarReceta(BEReceta receta)
        {
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                return mPPReceta.ActualizarReceta(receta);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al actualizar la Receta: " + ex.Message, "Actualizar Receta"));
                throw new ErrorAlActualizarRecetasException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizó la Receta: ", "Actualizar Receta"));
            }
        }

        public IList<BEReceta> BuscarRecetas(BEPaciente paciente)
        {
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                return mPPReceta.BuscarRecetas(paciente);
            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar la Receta: " + ex.Message, "Buscar Receta"));
                throw new ErrorAlBuscarRecetasException();
            }
            finally
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se busco la Receta: ", "Buscar Receta"));
            }
        }
    }
}
