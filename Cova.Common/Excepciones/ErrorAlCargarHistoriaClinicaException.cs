using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
  public class ErrorAlCargarHistoriaClinicaException : Exception
    {
        public ErrorAlCargarHistoriaClinicaException() : base("Hubo un error al cargar Historia Clinica")
        {

        }
    }
}
