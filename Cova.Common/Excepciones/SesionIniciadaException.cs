using System;

namespace Cova.Common.Excepciones
{
    public class SesionIniciadaException : Exception
    {
        public SesionIniciadaException() : base("Ya hay una sesion iniciada") 
        {

        }
    }
}
