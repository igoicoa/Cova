﻿using System;
using Cova.BE;

namespace Cova.BL
{
    public class Sesion
    {
        private static Sesion _sesion;

        public BEUsuario Usuario { get; set; }
        public DateTime FechaLogueo { get; set; }

        public static Sesion GetInstance
        {
            get
            {
                if (_sesion == null)
                    throw new Exception("No hay sesion inicializada");
                return _sesion;
            }
        }

        public static void Login(BEUsuario usuario)
        {
            if (_sesion == null)
            {
                _sesion = new Sesion();
                _sesion.Usuario = usuario;
                _sesion.FechaLogueo = DateTime.Now;
            }
            else
            {
                throw new Exception("Ya hay una sesion iniciada");
            }
        }

        public static void Logout(BEUsuario usuario)
        {
            if (_sesion != null)
            {
                _sesion = null;
            }
            else
            {
                throw new Exception("No hay sesion inicializada");
            }
        }

    }
}
