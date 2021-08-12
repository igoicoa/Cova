using System;

namespace Cova.Common.Excepciones
{
   public class ErrorAlActualizarProfesionalException: Exception
    {
        public ErrorAlActualizarProfesionalException() : base("Hubo un error al actualizar el Profesional")
        {

        }
    }
}
