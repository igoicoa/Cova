using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLProfesional
    {
        public IList<BEProfesional> obtenerProfesionales()
        {
            throw new NotImplementedException();
        }

        public bool CrearProfesionalMedico(BEMedico medico)
        {
            MPPUsuario mPPUsuario = new MPPUsuario();
            return mPPUsuario.CrearProfesionalMedico(medico);
        }

        public bool CrearProfesionalEnfermero(BEEnfermero enfermero)
        {
            MPPUsuario mPPUsuario = new MPPUsuario();
            return mPPUsuario.CrearProfesionalEnfermero(enfermero);
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
