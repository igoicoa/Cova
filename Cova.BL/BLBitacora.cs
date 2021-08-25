using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE.Bitacora;
using Cova.MPP;
using Cova.Common.Excepciones;

namespace Cova.BL
{
    public class BLBitacora
    {
        public IList<BEBitacora> BuscarBitacora(BEBitacora bitacoraABuscar, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                MPPBicatora mPPBitacora = new MPPBicatora();
                return mPPBitacora.BuscarBitacora(bitacoraABuscar, fechaDesde, fechaHasta);
            }
            catch
            {
                //todo: Cargar excepcion
                throw new Exception();
            }

        }
    }
}
