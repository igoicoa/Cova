using System;

namespace Cova.Common.Excepciones
{
   public class ErrorAlBuscarPacienteException : Exception
    {
        public ErrorAlBuscarPacienteException() : base("Hubo un error al buscar el Paciente")
        {

        }
    }
}
