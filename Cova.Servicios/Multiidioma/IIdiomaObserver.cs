using System;
using Cova.Common.Multiidioma;

namespace Cova.Servicios.Multiidioma
{
    public interface IIdiomaObserver
    {
        void UpdateLanguage(Idioma idioma);
    }
}
