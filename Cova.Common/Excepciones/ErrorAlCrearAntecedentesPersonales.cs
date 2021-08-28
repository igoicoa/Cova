using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCrearAntecedentesPersonales : Exception
    {
        public ErrorAlCrearAntecedentesPersonales() : base("Hubo un error crear los antecedentes personales")
        {

        }
    }
}
