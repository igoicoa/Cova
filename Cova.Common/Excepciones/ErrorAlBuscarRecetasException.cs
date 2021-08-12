using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlBuscarRecetasException: Exception
    {
        public ErrorAlBuscarRecetasException() : base("Hubo un error al buscar las recetas")
        {

        }
    }
}
