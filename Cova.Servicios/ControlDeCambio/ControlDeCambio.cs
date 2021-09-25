﻿using System;
using System.Collections.Generic;
using Cova.Common.Excepciones;
using Cova.BE.ControlCambios;
using Cova.MPP;

namespace Cova.Servicios.ControlDeCambio
{
    public class ControlDeCambio
    {
        public IList<BEControlDeCambioPaciente> ObtenerControlDeCambioPaciente()
        {
            try
            {
                MPPControlDeCambio mPPControlCambio = new MPPControlDeCambio();
                return mPPControlCambio.ObtenerControlDeCambioPaciente();
            }
            catch(Exception ex)
            {
                //TODO agrega excepcion y loguear error
                throw ex;
            }
        }
    }
}
