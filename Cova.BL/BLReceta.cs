using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLReceta
    {
        public BEReceta ObtenerRecetaParaVacunaYPaciente(BEVacuna vacunaAAplicar, BEPaciente pacienteAVacunar)
        {
            MPPReceta mPPReceta = new MPPReceta();
            return mPPReceta.ObtenerRecetaParaVacunaYPaciente(vacunaAAplicar, pacienteAVacunar);
        }
    }
}
