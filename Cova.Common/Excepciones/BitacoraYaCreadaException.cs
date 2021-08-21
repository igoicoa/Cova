using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class BitacoraYaCreadaException : Exception
    {
        public BitacoraYaCreadaException() : base("La bitacora ya fue creada")
        {

        }
    }
}
