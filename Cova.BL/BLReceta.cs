using System;
using System.Collections.Generic;
using Cova.BE;
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
            MPPReceta mPPReceta = new MPPReceta();
            return mPPReceta.CrearReceta(receta);
        }
    }
}
