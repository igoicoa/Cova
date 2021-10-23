using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class CoberturaMedicaYaExisteException : Exception
    {
        public CoberturaMedicaYaExisteException() : base("Ya existe una cobertura medica con ese nombre")
        {

        }
    }
}
