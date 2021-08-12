using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCrearProfesionalException : Exception
    {
        public ErrorAlCrearProfesionalException() : base("Hubo un error al crear el profesional")
        {

        }
    }
}
