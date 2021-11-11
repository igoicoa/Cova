using System;

namespace Cova.Common.Excepciones
{
    public class AdministradorYaExisteException : Exception
    {
        public AdministradorYaExisteException() : base("Ya existe un administrador registrado con ese DNI")
        {

        }
    }
}
