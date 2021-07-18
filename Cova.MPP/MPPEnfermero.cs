﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Cova.BE;
using Cova.DAL;

namespace Cova.MPP
{
    public class MPPEnfermero
    {
        public IList<BEEnfermero> BuscarEnfermeros(string usuario, int DNI)
        {
            List<BEEnfermero> enfermeros = new List<BEEnfermero>();
            DataSet enfermeroDS;
            DataTable enfermeroT;
            Hashtable datosEnfermero = new Hashtable();
            try
            {
                ConexionDB conexionBDD = new ConexionDB();
                string strSQL = @"s_BuscarEnfermero";
                if(!string.IsNullOrEmpty(usuario))
                    datosEnfermero.Add("@Usuario", usuario);
                if(DNI != 0)
                    datosEnfermero.Add("@DNI", DNI);

                enfermeroDS = conexionBDD.ObtenerDataSet(strSQL, datosEnfermero);
                enfermeroT = enfermeroDS.Tables[0];
                if (enfermeroT.Rows.Count > 0)
                {
                    foreach (DataRow fila in enfermeroT.Rows)
                    {
                        BEEnfermero enfermero = new BEEnfermero();
                        enfermero.Nombre = Convert.ToString(fila["Nombre"]);
                        enfermero.Apellido = Convert.ToString(fila["Apellido"]);
                        enfermero.DNI = Convert.ToInt32(fila["DNI"]);
                        enfermero.FechaNacimiento = Convert.ToDateTime(fila["FechaNacimiento"]);
                        enfermero.Sexo = Convert.ToString(fila["Sexo"]);
                        enfermero.EstadoCivil = Convert.ToString(fila["EstadoCivil"]);
                        enfermero.Telefono = Convert.ToString(fila["Telefono"]);
                        enfermero.Email = Convert.ToString(fila["Email"]);

                        BEDomicilio domicilio = new BEDomicilio();
                        domicilio.Calle = Convert.ToString(fila["Calle"]);
                        domicilio.Numero = Convert.ToInt32(fila["Numero"]);
                        domicilio.Piso = Convert.ToString(fila["Piso"]);
                        domicilio.Localidad = Convert.ToString(fila["Localidad"]);
                        domicilio.Provincia = Convert.ToString(fila["Provincia"]);
                        domicilio.Pais = Convert.ToString(fila["Pais"]);

                        enfermero.Domicilio = domicilio;
                        enfermero.MatriculaEnfermero = Convert.ToInt32(fila["MatriculaEnfermero"]);

                        enfermeros.Add(enfermero);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return enfermeros;
        }
    }
}