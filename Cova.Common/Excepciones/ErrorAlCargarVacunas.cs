using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCargarVacunas: Exception
    {
        public ErrorAlCargarVacunas() : base("Hubo un error al cargar las vacunas")
        {

        }
    }
}
