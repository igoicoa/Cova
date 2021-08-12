using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.Servicios;

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
            catch
            {
                throw new ErrorAlCrearRecetasException();
            }
            
        }

        public bool ActualizarReceta(BEReceta receta)
        {
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                return mPPReceta.ActualizarReceta(receta);
            }
            catch
            {
                throw new ErrorAlActualizarRecetasException();
            }
        }

        public IList<BEReceta> BuscarRecetas(BEPaciente paciente)
        {
            try
            {
                MPPReceta mPPReceta = new MPPReceta();
                return mPPReceta.BuscarRecetas(paciente);
            }
            catch
            {
                throw new ErrorAlBuscarRecetasException();
            }

        }
    }
}
