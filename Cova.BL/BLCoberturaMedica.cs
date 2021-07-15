using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLCoberturaMedica
    {
        public IList<BECoberturaMedica> ObtenerCoberturasMedicas()
        {
            MPPCoberturaMedica mPPCoberturaMedica = new MPPCoberturaMedica();
            return mPPCoberturaMedica.ObtenerCoberturasMedicas();
        }
    }
    
}
