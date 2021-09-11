using System;
using System.Collections.Generic;
using System.Linq;
using Cova.MPP;
using Cova.BE;

namespace Cova.Servicios.DigitoVerificador
{
    public static class DigitoVerificador
    {
        public static int CalcularDVH(string atributos)
        {
            int valorFinal = 0;
            int valorAscPosicion;
            char[] atrbutosArray = atributos.ToCharArray();
            for (int i = 0; i < atrbutosArray.Length; i++)
            {
                valorAscPosicion = (atrbutosArray[i] * (i + 1));
                valorFinal = valorFinal + valorAscPosicion;
            }
            return valorFinal;
        }

        public static bool ActualizarDVV(string entidad)
        {
            MPPDigitoVerificador mPPDigitoVerificador = new MPPDigitoVerificador();
            try
            {
                long sumaDVH = mPPDigitoVerificador.ObtenerSumaDVH(entidad).DVV;
                if (sumaDVH > -1)
                {
                    return mPPDigitoVerificador.ActualizarDVV(entidad, sumaDVH);
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool ValidarDVH(string atributos, string entidad)
        {
            MPPDigitoVerificador mPPDigitoVerificador = new MPPDigitoVerificador();
            int DVH = mPPDigitoVerificador.ObtenerDVH(entidad);
            return CalcularDVH(atributos) != DVH;
        }

        public static bool ValidarDVV(string entidad)
        {
            MPPDigitoVerificador mPPDigitoVerificador = new MPPDigitoVerificador();
            long sumaDVH = mPPDigitoVerificador.ObtenerSumaDVH(entidad).DVV;
            long DVV = mPPDigitoVerificador.ObtenerDVV(entidad).DVV;
            return sumaDVH == DVV;
        }

    }
}
