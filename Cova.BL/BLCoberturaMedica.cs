using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.Common.Excepciones;
using Cova.MPP;

namespace Cova.BL
{
    public class BLCoberturaMedica
    {
        public IList<BECoberturaMedica> ObtenerCoberturasMedicas()
        {
            try
            {
                MPPCoberturaMedica mPPCoberturaMedica = new MPPCoberturaMedica();
                return mPPCoberturaMedica.ObtenerCoberturasMedicas();
            }
            catch
            {
                throw new ErrorAlCargarCoberturasMedicasException();
            }
        }
    }
    
}
