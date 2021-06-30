using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.MPP;
using Cova.BE.Multiidioma;

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
