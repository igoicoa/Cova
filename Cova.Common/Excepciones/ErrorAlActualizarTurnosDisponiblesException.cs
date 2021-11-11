using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlActualizarTurnosDisponiblesException : Exception
    {
        public ErrorAlActualizarTurnosDisponiblesException() : base("Hubo un error al actualizar los turnos disponibles del profesional")
        {

        }
    }
}
