using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLMedico
    {
        public bool CrearProfesionalMedico(BEMedico medico)
        {
            MPPUsuario mPPUsuario = new MPPUsuario();
            return mPPUsuario.CrearProfesionalMedico(medico);
        }

        public IList<BEMedico> BuscarMedicos(string Usuario, string DNI)
        {
            MPPMedico mPPMedico = new MPPMedico();
            return mPPMedico.BuscarMedicos(Usuario, DNI);
        }
    }
}
