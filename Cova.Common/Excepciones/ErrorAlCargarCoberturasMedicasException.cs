using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCargarCoberturasMedicasException : Exception
    {
        public ErrorAlCargarCoberturasMedicasException() : base("Hubo un error al cargar las coberturas médicas")
        {

        }
    }
}
