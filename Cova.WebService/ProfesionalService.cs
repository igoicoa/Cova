using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BL;
using Cova.BE;
using Cova.WebService.Dtos;

namespace Cova.WebService
{
    public class ProfesionalService
    {
        private BLProfesional bLProfesional = new BLProfesional();
        private BLMedico blMedico = new BLMedico();
        private BLEnfermero bLEnfermero = new BLEnfermero();

        public IList<MedicoDto> GetProfesionalesMedicos() 
        {
            return new List<MedicoDto>();
        }

        public IList<EnfermeroDto> GetProfesionalesEnfermeros()
        {
            return new List<EnfermeroDto>();
        }

    }
}
