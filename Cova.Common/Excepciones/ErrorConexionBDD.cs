using System;

namespace Cova.Common.Excepciones
{
    public class ErrorConexionBDD : Exception
    {
        public ErrorConexionBDD() : base("Hubo un error de conexion con la Base de Datos")
        {

        }
    }
}
