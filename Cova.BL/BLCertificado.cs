using Cova.BE;
using System;
using System.Collections.Generic;
using Cova.BE.Bitacora;
using Cova.Common.Excepciones;
using Cova.MPP;
using Cova.Servicios.Bitacora;
using Cova.Servicios.Sesion;

namespace Cova.BL
{
   public class BLCertificado
    {
        public bool CrearCertificado(BECertificado certificado)
        {
            bool CertificadoCreada = false;
            try
            {
                MPPCertificado mPPCertificado = new MPPCertificado();
                CertificadoCreada = mPPCertificado.CrearCertificado(certificado);
                // Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se creo el Certificado: " + certificado.CertificadoId + "," + certificado.Paciente.ApellidoNombre, "Crear Certificado"));

            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al crear el Certificado para: " + certificado.Paciente.Apellido + " - " + certificado.Paciente.Nombre + " - " + ex.Message, "Crear Certificado"));
                throw new ErrorAlCrearCertificadoException();
            }
            return CertificadoCreada;

        }

        public bool ActualizarCertificado(BECertificado certificado)
        {
            bool CertificadoActualizada = false;
            try
            {
                MPPCertificado mPPCertificado = new MPPCertificado();
                CertificadoActualizada = mPPCertificado.ActualizarCertificado(certificado);
                // Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se actualizó el Certificado: " + certificado.CertificadoId + "," + certificado.Paciente.ApellidoNombre, "Actualizar Certificado"));

            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al actualizar el Certificado de: " + certificado.Paciente.Apellido + " - " + certificado.Paciente.Nombre + " - "  + ex.Message, "Actualizar Certificado"));
                throw new ErrorAlActualizarCertificadoException();
            }
            return CertificadoActualizada;
        }

        public IList<BECertificado> BuscarCertificados(BEPaciente paciente)
        {
            IList<BECertificado> certificados;
            MPPCertificado mPPCertificado = new MPPCertificado();
            try
            {
                certificados = mPPCertificado.BuscarCertificados(paciente);
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Info, "Se busco el Certificado de: " + paciente.PacienteId, "Buscar el Certificado"));

            }
            catch (Exception ex)
            {
                //Bitacora.GetInstance.RegistrarBitacora(new BEBitacora(DateTime.Now, Sesion.GetInstance.Usuario, TipoCriticidad.Error, "Hubo un error al buscar el Certificado de: " + paciente.Apellido + " - " + paciente.Nombre + " - " + ex.Message, "Buscar el Certificado"));
                throw new ErrorAlBuscarCertificadoException();
            }
            return certificados;
        }
    }
}