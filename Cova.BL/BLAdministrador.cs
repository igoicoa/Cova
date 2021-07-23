using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;

namespace Cova.BL
{
    public class BLAdministrador
    {
        public bool CrearAdministrador(BEAdministrador administrador)
        {
            MPPAdministrador mPPAdministrador = new MPPAdministrador();
            return mPPAdministrador.CrearAdministrador(administrador);
        }

        public IList<BEAdministrador> BuscarAdministrador(string Usuario, string DNI)
        {
            MPPAdministrador mPPAdministrador = new MPPAdministrador();
            return mPPAdministrador.BuscarAdministrador(Usuario, DNI);
        }

        public bool ActualizarAdministrador(BEAdministrador administrador)
        {
            MPPAdministrador mPPAdministrador = new MPPAdministrador();
            return mPPAdministrador.ActualizarAdministrador(administrador);
        }
    }
}
