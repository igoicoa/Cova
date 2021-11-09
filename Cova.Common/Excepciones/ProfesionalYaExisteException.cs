using System;

namespace Cova.Common.Excepciones
{
    public class ProfesionalYaExisteException : Exception
    {
        public ProfesionalYaExisteException() : base("Ya existe un profesional creado con ese DNI")
        {

        }
    }
}
