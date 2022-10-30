using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class CentroMedicoDto
    {
        public int CentroMedicoId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DomicilioDto Domicilio { get; set; }
    }
}
