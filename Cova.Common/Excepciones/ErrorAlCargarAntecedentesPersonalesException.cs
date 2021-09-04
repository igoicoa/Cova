using System;

namespace Cova.Common.Excepciones
{
    public class ErrorAlCargarAntecedentesPersonalesException : Exception
    {
        public ErrorAlCargarAntecedentesPersonalesException() : base("Hubo un error al cargar los antecedentes personales")
        {

        }
    }
}
