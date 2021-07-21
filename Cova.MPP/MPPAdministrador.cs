using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPAdministrador
    {
        //public IList<BEAdministrador> BuscarAdministrador(string usuario, string DNI)
        //{
        //    List<BEAdministrador> administradores = new List<BEAdministrador>();
        //    DataSet administradorDS;
        //    DataTable administradorT;
        //    Hashtable datosAdministrador = new Hashtable();
        //    try
        //    {
        //        ConexionDB conexionBDD = new ConexionDB();
        //        string strSQL = @"s_BuscarMedico";
        //        datosAdministrador.Add("@Usuario", usuario);
        //        datosAdministrador.Add("@DNI", DNI);
        //        administradorDS = conexionBDD.ObtenerDataSet(strSQL, datosAdministrador);
        //        administradorT = administradorDS.Tables[0];
        //        if (administradorT.Rows.Count > 0)
        //        {
        //            foreach (DataRow fila in administradorT.Rows)
        //            {
        //                BEAdministrador administrador = new BEAdministrador();
        //                administrador.UsuarioID = Convert.ToInt64(fila["UsuarioID"]);
        //                administrador.Nombre = Convert.ToString(fila["Nombre"]);
        //                administrador.Apellido = Convert.ToString(fila["Apellido"]);
        //                administrador.DNI = Convert.ToInt32(fila["DNI"]);
        //                administrador.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
        //                administrador.Sexo = Convert.ToString(fila["Sexo"]);
        //                administrador.EstadoCivil = Convert.ToString(fila["EstadoCivil"]);
        //                administrador.Telefono = Convert.ToString(fila["Telefono"]);
        //                administrador.Email = Convert.ToString(fila["Email"]);

        //                BEDomicilio domicilio = new BEDomicilio();
        //                domicilio.Calle = Convert.ToString(fila["Calle"]);
        //                domicilio.Numero = Convert.ToInt32(fila["Numero"]);
        //                domicilio.Piso = Convert.ToString(fila["Piso"]);
        //                domicilio.Localidad = Convert.ToString(fila["Localidad"]);
        //                domicilio.Provincia = Convert.ToString(fila["Provincia"]);
        //                domicilio.Pais = Convert.ToString(fila["Pais"]);

        //                administrador.Domicilio = domicilio;
        //                administrador.Activo = Convert.ToBoolean(fila["Activo"]);

        //                administradores.Add(administrador);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return administradores;
        //}
    }
}
