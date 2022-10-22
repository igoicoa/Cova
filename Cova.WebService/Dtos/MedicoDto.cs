using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.WebService.Dtos
{
    public class MedicoDto : ProfesionalDto
    {
        public int MatriculaNacional { get; set; }
        public int MatriculaProvincial { get; set; }
        public string Especialidad { get; set; }
    }
}
