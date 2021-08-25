using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ItemExistenteException : Exception
    {
        public ItemExistenteException() : base("La operación que está queriendo realizar ya está registrada")
        {

        }
    }
}
