using System;
using System.Collections.Generic;
using Cova.Common.Excepciones;
using Cova.BE.Bitacora;
using Cova.MPP;

namespace Cova.Servicios.Bitacora
{
    public class Bitacora : IBitacora
    {
        private static Bitacora _bitacora;

        public static Bitacora GetInstance
        {
            get
            {
                return _bitacora;
            }
        }

        public static void CrearBitacora()
        {
            if (_bitacora == null)
            {
                _bitacora = new Bitacora();
            }
            else
            {
                throw new BitacoraYaCreadaException();
            }
        }

        public void RegistrarBitacora(BEBitacora bitacora)
        {
            MPPBicatora mPPBicatora = new MPPBicatora();
            mPPBicatora.CrearRegistroBitacora(bitacora);
        }

        public IList<BEBitacora> ConsultarBitacora(BEBitacora bitacoraABuscar, DateTime fechaDesde, DateTime fechaHasta)
        {
            MPPBicatora mPPBicatora = new MPPBicatora();
            return mPPBicatora.BuscarBitacora(bitacoraABuscar, fechaDesde, fechaHasta);
        }

    }
}
