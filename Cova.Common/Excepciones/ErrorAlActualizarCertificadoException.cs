using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
   public class ErrorAlActualizarCertificadoException: Exception
    {
        public ErrorAlActualizarCertificadoException() : base("Hubo un error al actualizar el Certificado")
        {

        }
    }
}
