using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLEnfermero
    {
        public bool CrearProfesionalEnfermero(BEEnfermero enfermero)
        {
            MPPEnfermero mPPEnfermero = new MPPEnfermero();
            return mPPEnfermero.CrearProfesionalEnfermero(enfermero);
        }

        public IList<BEEnfermero> BuscarEnfermeros(string Usuario, string DNI)
        {
            MPPEnfermero mPPEnfermero = new MPPEnfermero();
            return mPPEnfermero.BuscarEnfermeros(Usuario, DNI);
        }

        public bool ActualizarProfesionalEnfermero(BEEnfermero enfermero)
        {
            MPPEnfermero mPPEnfermero = new MPPEnfermero();
            return mPPEnfermero.ActualizarProfesionalEnfermero(enfermero);
        }
    }
}
