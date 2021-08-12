using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCargarDatosPacienteException: Exception
    {
        public ErrorAlCargarDatosPacienteException() : base("Hubo un error al cargar datos del Paciente")
        {

        }
    }
}
