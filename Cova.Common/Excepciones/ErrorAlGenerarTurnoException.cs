using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlGenerarTurnoException : Exception
    {
        public ErrorAlGenerarTurnoException() : base("Hubo un error al generar el turno")
        {

        }
    }
}
