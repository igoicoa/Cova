using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BECoberturaMedica
    {
        public long CoberturaMedicaId { get; set; }
        public long CoberturaMedicaPlanId { get; set; }
        public string Nombre { get; set; }
        public string Plan { get; set; }
        public string NumeroAfiliado { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }
}
