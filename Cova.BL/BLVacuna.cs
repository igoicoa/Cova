using System;
using System.Collections.Generic;
using System.Linq;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.BE;

namespace Cova.BL
{
    public class BLVacuna
    {
        public IList<BEVacuna> ObtenerVacunas()
        {
            MPPVacuna mPPVacuna = new MPPVacuna();
            return mPPVacuna.ObtenerVacunas();
        }

        public IList<BEVacunaDosis> ObtenerVacunasDeCentroMedicoAAplicar(BEVacunaDosis vacunaABuscar)
        {
            MPPVacuna mPPVacuna = new MPPVacuna();
            return mPPVacuna.ObtenerVacunasDeCentroMedicoAAplicar(vacunaABuscar);
        }

        public bool CrearVacuna(BEVacuna vacunaNueva)
        {
            List<BEVacuna> vacunasExistentes = this.ObtenerVacunas().ToList();
            foreach(BEVacuna vacuna in vacunasExistentes)
            {
                if(vacuna.Nombre == vacunaNueva.Nombre && vacuna.Laboratorio.LaboratorioId == vacunaNueva.Laboratorio.LaboratorioId)
                {
                    throw new VacunaYaExistenteException();
                }
            }
            MPPVacuna mPPVacuna = new MPPVacuna();
            return mPPVacuna.CrearVacuna(vacunaNueva);
        }
    }
}
