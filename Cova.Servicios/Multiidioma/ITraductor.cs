using System;
using System.Collections.Generic;
using Cova.Common.Multiidioma;

namespace Cova.Servicios.Multiidioma
{
    public interface ITraductor
    {
        IDictionary<string, Traduccion> ObtenerTraducciones(Idioma idoma);
    }
}
