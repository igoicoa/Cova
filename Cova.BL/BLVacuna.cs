using System;
using System.Collections.Generic;
using System.Linq;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.BE;
using Cova.Servicios.Bitacora;
using Cova.BE.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
    public class BLVacuna
    {
        public IList<BEVacuna> ObtenerVacunas()
        {
            IList<BEVacuna> vacunas;
            MPPVacuna mPPVacuna = new MPPVacuna();
            try
            {
                vacunas = mPPVacuna.ObtenerVacunas();
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se Obtuvo las vacunas: ", "Obtener Vacunas"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener las vacunas: " + ex.Message, "Obtener Vacunas"));
                throw new ErrorAlObtenerVacunasException();
            }
            return vacunas;
        }

        public IList<BEVacunaDosis> ObtenerVacunasDeCentroMedicoAAplicar(BEVacunaDosis vacunaABuscar)
        {
            IList<BEVacunaDosis> Obtenervacunas;
            MPPVacuna mPPVacuna = new MPPVacuna();
            try
            {
                Obtenervacunas = mPPVacuna.ObtenerVacunasDeCentroMedicoAAplicar(vacunaABuscar);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se obtuvo las vacunas del centro medico a aplicar: " + vacunaABuscar.Vacuna.VacunaID, "Obtener Vacunas del centro medico a aplicar"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al obtener las vacunas del centro medico a aplicar: " + ex.Message, "Obtener Vacunas del centro medico a aplicar"));
                throw new ErrorAlObtenerVacunasDeCentroMedicoAAplicarException();
            }
            return Obtenervacunas;
        }

        public bool CrearVacuna(BEVacuna vacunaNueva)
        {
            bool VacunaCreada = false;
            try
            {
                List<BEVacuna> vacunasExistentes = this.ObtenerVacunas().ToList();
                foreach (BEVacuna vacuna in vacunasExistentes)
                {
                    if (vacuna.Nombre == vacunaNueva.Nombre && vacuna.Laboratorio.LaboratorioId == vacunaNueva.Laboratorio.LaboratorioId)
                    {
                        throw new VacunaYaExistenteException();
                    }
                }
                MPPVacuna mPPVacuna = new MPPVacuna();
                VacunaCreada = mPPVacuna.CrearVacuna(vacunaNueva);
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "La vacuna: " + vacunaNueva.VacunaID + "fue creada con exito", "Crear Vacuna"));

            }
            catch (Exception ex)
            {
                Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear la vacuna: " + ex.Message, "Crear Vacuna"));
                throw new ErrorAlCrearVacunasException();
            }
            return VacunaCreada;
        }
    }
}
