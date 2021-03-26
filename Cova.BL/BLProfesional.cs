using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;

namespace Cova.BL
{
    public class BLProfesional
    {
        public IList<BEProfesional> obtenerProfesionales()
        {
            throw new NotImplementedException();
        }

        public bool agregarProfesional(BEProfesional nuevoProfesional)
        {
            throw new NotImplementedException();
        }

        public bool aplicarVacuna(BEProfesional profesional, BEPaciente pacienteAVacunar, BEVacuna vacunaAAplicar)
        {
            throw new NotImplementedException();
        }

        public bool recetarVacuna(BEProfesional profesional, BEPaciente pacienteAVacunar, BEVacuna vacunaAAplicar)
        {
            throw new NotImplementedException();
        }
    }
}
