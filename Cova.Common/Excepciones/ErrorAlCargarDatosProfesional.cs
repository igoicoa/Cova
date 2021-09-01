using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCargarDatosProfesional : Exception
    {
        public ErrorAlCargarDatosProfesional() : base("Hubo un error al cargar datos del Profesional")
        {

        }
    }
}
