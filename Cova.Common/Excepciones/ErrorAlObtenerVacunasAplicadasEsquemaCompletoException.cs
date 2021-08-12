using System;

namespace Cova.Common.Excepciones
{
   public class ErrorAlObtenerVacunasAplicadasEsquemaCompletoException : Exception
    {
        public ErrorAlObtenerVacunasAplicadasEsquemaCompletoException() : base("Hubo un error al obtener vacunas aplicadas del esquema completo")
        {

        }
    }
}
