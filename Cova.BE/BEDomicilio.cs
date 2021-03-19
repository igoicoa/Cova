using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEDomicilio
    {
        public int IDDomicilio { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Piso { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
    }
}
