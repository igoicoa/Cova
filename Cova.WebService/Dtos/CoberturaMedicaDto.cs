using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class CoberturaMedicaDto
    {
        public int CoberturaMedicaId { get; set; }
        public string Nombre { get; set; }
        public IList<CoberturaMedicaPlanDto> Plan { get; set; }
    }
}
