using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlObtenerVacunasException: Exception
    {
        public ErrorAlObtenerVacunasException() : base("Hubo un error al obtener las vacunas")
        {

        }
    }
}
