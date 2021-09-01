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
            bool RecetaCreada = false;
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                RecetaCreada= mPPReceta.CrearReceta(receta);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo la Receta: ", "Crear Receta"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear la Receta: " + ex.Message, "Crear Receta"));
                throw new ErrorAlCrearRecetasException();
            }
            return RecetaCreada;

        }

        public bool ActualizarReceta(BEReceta receta)
        {
            bool RecetaActualizada = false;
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                RecetaActualizada = mPPReceta.ActualizarReceta(receta);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizó la Receta: ", "Actualizar Receta"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al actualizar la Receta: " + ex.Message, "Actualizar Receta"));
                throw new ErrorAlActualizarRecetasException();
            }
            return RecetaActualizada;
        }

        public IList<BEReceta> BuscarRecetas(BEPaciente paciente)
        {
            IList<BEReceta> recetas;
            MPPReceta mPPReceta = new MPPReceta();
            try
            {
                recetas=  mPPReceta.BuscarRecetas(paciente);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se busco la Receta: ", "Buscar Receta"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar la Receta: " + ex.Message, "Buscar Receta"));
                throw new ErrorAlBuscarRecetasException();
            }
            return recetas;
        }
    }
}
