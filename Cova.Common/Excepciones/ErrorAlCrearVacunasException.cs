using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCrearVacunasException: Exception
    {
        public ErrorAlCrearVacunasException() : base("Hubo un error al crear la vacuna")
        {

        }
    }
}
