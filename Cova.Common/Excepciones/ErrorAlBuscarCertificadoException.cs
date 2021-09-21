using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
  public class ErrorAlBuscarCertificadoException: Exception
    {
        public ErrorAlBuscarCertificadoException() : base("Hubo un error al buscar el Certificado")
        {

        }
    }
}
