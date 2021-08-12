using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.Common.Excepciones;
using Cova.MPP;

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
            catch
            {
                throw new ErrorAlObtenerLaboratoriosException();
            }

        }
    }
}
