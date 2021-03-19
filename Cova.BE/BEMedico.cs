using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE
{
    public class BEMedico : BEProfesional
    {
        public int MatriculaNacional { get; set; }
        public int MatriculaProvincial { get; set; }
        public Especialidad Especialidad { get; set; }

    }
}
