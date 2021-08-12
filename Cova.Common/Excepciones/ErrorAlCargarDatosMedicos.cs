using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCargarDatosMedicos: Exception
    {
        public ErrorAlCargarDatosMedicos() : base("Hubo un error al cargar datos del Medico")
        {

        }
    }
}
