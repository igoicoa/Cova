using System;


namespace Cova.Common.Excepciones
{
    public class ErrorAlBuscarDatosMedicos: Exception
    {
        public ErrorAlBuscarDatosMedicos() : base("Hubo un error al buscar datos del Medico")
        {

        }
    }
}
