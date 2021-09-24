using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE.Bitacora;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPControlDeCambio
    {
        //public bool CrearRegistroControl(BEAdministrador administrador)
        //{
        //    Hashtable datosControlCambio = new Hashtable();
        //    try
        //    {
        //        ConexionDB conexionBDD = new ConexionDB();
        //        string strSQL = @"s_ObtenerControlCambios";

        //        datosControlCambio.Add("@ControlCambioId");
        //        datosControlCambio.Add("@Nombre", administrador.Nombre);
        //        datosControlCambio.Add("@Apellido", administrador.Apellido);
        //        datosControlCambio.Add("@DNI", administrador.DNI);
        //        datosControlCambio.Add("@FechaNacimiento", administrador.FechaNacimiento);
        //        datosControlCambio.Add("@Sexo", administrador.Sexo);
        //        datosControlCambio.Add("@EstadoCivil", administrador.EstadoCivil);
        //        datosControlCambio.Add("@Telefono", administrador.Telefono);
        //        datosControlCambio.Add("@Email", administrador.Email);
        //        BEDomicilio domicilio = new BEDomicilio();
        //        datosControlCambio.Add("@Calle", domicilio.Calle);
        //        datosControlCambio.Add("@Numero", domicilio.Numero);
        //        datosControlCambio.Add("@Piso", domicilio.Piso);
        //        datosControlCambio.Add("@Localidad", domicilio.Localidad);
        //        datosControlCambio.Add("@Provincia", domicilio.Provincia);
        //        datosControlCambio.Add("@Pais", domicilio.Pais);
        //        BECoberturaMedica CMedica = new BECoberturaMedica();
        //        datosControlCambio.Add("@CoberturaMedicaId", CMedica.CoberturaMedicaId);
        //        BECoberturaMedicaPlan coberturaMedicaPlan = BECoberturaMedicaPlan();
        //        datosControlCambio.Add("@CoberturaMedicaPlanId", coberturaMedicaPlan.PlanId);

        //        datosControlCambio.Add("@NumeroAfiliado", coberturaMedicaPlanCriticidad);
        //        datosControlCambio.Add("@FechaVencimiento", bitacora.Mensaje);
        //        datosControlCambio.Add("@UsuarioModificadorId", bitacora.Funcionalidad);
        //        datosControlCambio.Add("@FechaModificacion", bitacora.Funcionalidad);
        //        datosControlCambio.Add("@TipoCambio", bitacora.Fecha);
        //        return conexionBDD.Escribir(strSQL, datosControlCambio);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
