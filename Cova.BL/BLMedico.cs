using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;
using Cova.Common.Excepciones;

namespace Cova.BL
{
    public class BLMedico
    {
        public bool CrearProfesionalMedico(BEMedico medico)
        {
            MPPMedico mPPMedico = new MPPMedico();
            try
            {
                return mPPMedico.CrearProfesionalMedico(medico);
            }
            catch
            {
                throw new ErrorAlCrearProfesionalException();
            }
        }

        public IList<BEMedico> BuscarMedicos(string Usuario, string DNI)
        {
            MPPMedico mPPMedico = new MPPMedico();
            try
            {
                return mPPMedico.BuscarMedicos(Usuario, DNI);
            }
            catch
            {
                throw new ErrorAlBuscarDatosMedicos();
            }

        }

        public bool ActualizarProfesionalMedico(BEMedico medico)
        {
            try
            {
                MPPMedico mPPMedico = new MPPMedico();
                return mPPMedico.ActualizarProfesionalMedico(medico);
            } catch
            {
                throw new ErrorAlActualizarProfesionalException();
            }
           
        }
    }
}
