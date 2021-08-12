using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlObtenerCentrosMedicosException: Exception
    {
        public ErrorAlObtenerCentrosMedicosException() : base("Hubo un error al obtener o cargar centros medicos")
        {

        }
    }
}
