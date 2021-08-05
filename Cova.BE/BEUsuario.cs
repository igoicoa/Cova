using System;
using Cova.Common.Permisos;
using Cova.BE.Enum;

namespace Cova.BE
{
    public class BEUsuario
    {
        public long UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public DateTime? UltimoLogin { get; set; }
        public ComponentePermiso Permisos { get; set; }
        public bool Activo { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
