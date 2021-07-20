using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class UsuarioPasswordIncorrecto : Exception
    {
        public UsuarioPasswordIncorrecto() : base("Usuario o password incorrecto")
        {

        }
    }
}

