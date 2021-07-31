using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLLaboratorio
    {
        public IList<BELaboratorio> ObtenerLaboratorios()
        {
            MPPLaboratorio mPPLaboratorio = new MPPLaboratorio();
            return mPPLaboratorio.ObtenerLaboratorios();
        }
    }
}
