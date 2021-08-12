using System;

namespace Cova.Common.Excepciones
{
   public class ErrorAlCrearPacienteException: Exception
    {
        public ErrorAlCrearPacienteException() : base("Hubo un error al crear el paciente")
        {

        }
    }
}
