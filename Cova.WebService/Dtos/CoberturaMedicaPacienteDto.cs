using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class CoberturaMedicaPacienteDto
    {
        public long CoberturaMedicaId { get; set; }
        public string Nombre { get; set; }
        public CoberturaMedicaPlanDto Plan { get; set; }
        public string NumeroAfiliado { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
