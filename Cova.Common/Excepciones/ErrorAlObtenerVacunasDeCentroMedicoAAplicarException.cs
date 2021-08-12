using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlObtenerVacunasDeCentroMedicoAAplicarException: Exception
    {
        public ErrorAlObtenerVacunasDeCentroMedicoAAplicarException() : base("Hubo un error al obtener vacunas de los centros medicos a aplicar")
        {

        }
    }
}
