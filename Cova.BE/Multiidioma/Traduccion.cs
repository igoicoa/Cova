using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Multiidioma
{
    public class Traduccion
    {
        public Etiqueta Etiqueta { get; set; }
        public Idioma Idioma { get; set; }
        public string PalabraTraducida { get; set; }
    }
}
