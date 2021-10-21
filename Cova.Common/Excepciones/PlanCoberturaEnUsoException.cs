using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class PlanCoberturaEnUsoException : Exception
    {
        public PlanCoberturaEnUsoException() : base("El plan de la cobertura medica a eliminar esta siendo usada por algun paciente.")
        {

        }
    }
}
