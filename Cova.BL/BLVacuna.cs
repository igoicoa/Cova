using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.MPP;
using Cova.BE;

namespace Cova.BL
{
    public class BLVacuna
    {
        public IList<BEVacunaDosis> ObtenerVacunasDeCentroMedico(BEVacunaDosis vacunaABuscar)
        {
            MPPVacuna mPPVacuna = new MPPVacuna();
            return mPPVacuna.ObtenerVacunasDeCentroMedico(vacunaABuscar);
        }
    }
}
