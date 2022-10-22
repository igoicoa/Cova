using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class UsuarioDto
    {
        public long UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public DateTime? UltimoLogin { get; set; }
        public bool Activo { get; set; }
        public string TipoUsuario { get; set; }
    }
}
