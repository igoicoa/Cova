using System;

namespace Cova.Common.Excepciones
{
   public class ErrorAlObtenerVacunasAplicadasEsquemaInCompletoException : Exception
    {
        public ErrorAlObtenerVacunasAplicadasEsquemaInCompletoException() : base("Hubo un error al obtener vacunas aplicadas del esquema incompleto")
        {

        }
    }
}
