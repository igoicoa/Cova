using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE;
using Cova.MPP;
using Cova.Common.Excepciones;
using Cova.Servicios.Bitacora;
using Cova.BE.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLMedico
    {
        public void CrearProfesionalMedico(BEMedico medico)
        {
            MPPMedico mPPMedico = new MPPMedico();
            mPPMedico.CrearProfesionalMedico(medico);
            try
            {

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al Crear Profesional Medico: " + ex.Message, "Crear Profesional Medico"));
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo el Profesional Medico: " + ex.Message, "Crear Profesional Medico"));
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
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el medico: " + ex.Message, "Buscar Medicos"));
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo la busqueda del medico: " + ex.Message, "Buscar Medicos"));
                throw new ErrorAlBuscarDatosMedicos();
            }

        }

        public bool ActualizarProfesionalMedico(BEMedico medico)
        {
            try
            {
                MPPMedico mPPMedico = new MPPMedico();
                return mPPMedico.ActualizarProfesionalMedico(medico);
            } catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear el Profesional: " + ex.Message, "Actualizar Profesional"));
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "El Profesional fue actualizado: " + ex.Message, "Actualizar Profesional"));
                throw new ErrorAlActualizarProfesionalException();
            }
           
        }
    }
}
