using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlVacunarPacienteException : Exception
    {
        public ErrorAlVacunarPacienteException() : base("Hubo un error al vacunar al Paciente")
        {

        }
    }
}
