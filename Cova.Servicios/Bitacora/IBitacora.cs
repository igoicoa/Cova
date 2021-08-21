using System;
using System.Collections.Generic;
using Cova.BE.Bitacora;

namespace Cova.Servicios.Bitacora
{
    public interface IBitacora
    {
        void RegistrarBitacora(BEBitacora bitacora);
        IList<BEBitacora> ConsultarBitacora(BEBitacora bitacoraABuscar, DateTime fechaDesde, DateTime fechaHasta);
    }
}
