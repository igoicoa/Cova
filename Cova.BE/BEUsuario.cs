using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEUsuario
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
