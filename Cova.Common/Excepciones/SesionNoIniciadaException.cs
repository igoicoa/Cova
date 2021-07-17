using System;

namespace Cova.Common.Excepciones
{
    public class SesionNoIniciadaException : Exception
    {
        public SesionNoIniciadaException() : base("No hay una sesion iniciada")
        {

        }
    }
}
