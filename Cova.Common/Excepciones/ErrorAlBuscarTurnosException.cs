﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.Common.Excepciones
{
    public class ErrorAlBuscarTurnosException : Exception
    {
        public ErrorAlBuscarTurnosException() : base("Hubo un error al obtener los turnos")
        {

        }
    }
}