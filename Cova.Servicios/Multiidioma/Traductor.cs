using System;
using System.Collections.Generic;
using Cova.MPP;
using Cova.Common.Multiidioma;

namespace Cova.Servicios.Multiidioma
{
    public class Traductor : ITraductor
    {
        public IDictionary<string, Traduccion> ObtenerTraducciones(Idioma idioma = null)
        {
            MPPTraductor mPPTraductor = new MPPTraductor();
            return mPPTraductor.ObtenerTraducciones(idioma);
        }

        public Idioma ObtenerIdiomaDefault()
        {
            MPPTraductor mPPTraductor = new MPPTraductor();
            return mPPTraductor.ObtenerIdiomaDefault();
        }
    }
}
