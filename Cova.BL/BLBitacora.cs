using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE.Bitacora;
using Cova.MPP;
using Cova.Common.Excepciones;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;

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
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar la bitacora: " + ex.Message, "Actualizar Paciente"));
                throw new ErrorAlBuscarBitacoraException();
            }
        }
    }
}
