using System;

namespace Cova.Common.Excepciones
{
    public class VacunaYaExistenteException : Exception
    {
        public VacunaYaExistenteException() : base("Ya existe una vacuna con ese nombre de ese laboratorio")
        {

        }
    }
}
