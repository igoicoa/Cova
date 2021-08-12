using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCrearRecetasException: Exception
    {
        public ErrorAlCrearRecetasException() : base("Hubo un error al crear la Receta")
        {

        }
    }
}
