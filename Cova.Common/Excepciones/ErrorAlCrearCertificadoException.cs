using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCrearCertificadoException: Exception
    {
        public ErrorAlCrearCertificadoException() : base("Hubo un error al crear el Certificado")
        {

        }
    }
}
