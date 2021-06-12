using System;
using Cova.BE.Permisos;

namespace Cova.BE
{
    public class BEUsuario
    {
        public long UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public DateTime? UltimoLogin { get; set; }
        public ComponentePermiso Permisos { get; set; }
    }
}
