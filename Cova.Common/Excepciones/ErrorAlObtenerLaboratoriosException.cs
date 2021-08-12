using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlObtenerLaboratoriosException: Exception
    {
        public ErrorAlObtenerLaboratoriosException() : base("Hubo un error al obtener o cargar los laboratorios")
        {

        }
    }
}
