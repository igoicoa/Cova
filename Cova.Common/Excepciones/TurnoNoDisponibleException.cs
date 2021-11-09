using System;

namespace Cova.Common.Excepciones
{
    public class TurnoNoDisponibleException : Exception
    {
        public TurnoNoDisponibleException() : base("El turno solicitado no esta disponible")
        {

        }
    }
}
