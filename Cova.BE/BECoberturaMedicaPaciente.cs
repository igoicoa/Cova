using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BECoberturaMedicaPaciente
    {
        public long CoberturaMedicaId { get; set; }
        public string Nombre { get; set; }
        public BECoberturaMedicaPlan Plan { get; set; }
        public string NumeroAfiliado { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }
}
