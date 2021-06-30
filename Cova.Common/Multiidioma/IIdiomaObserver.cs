using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE.Multiidioma;

namespace Cova.Servicios.Multiidioma
{
    public interface IIdiomaObserver
    {
        void UpdateLanguage(Idioma idioma);
    }
}
