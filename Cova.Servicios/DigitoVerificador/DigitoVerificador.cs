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

        public static bool ValidarDVH(string entidad)
        {
            switch (entidad)
            {
                case "VacunaDosis":
                    return ValidarDVHVacunaDosis();
                default:
                    return true;
            }
        }

        private static bool ValidarDVHVacunaDosis()
        {
            MPPVacuna mPPVacuna = new MPPVacuna();
            IList<BEVacunaDosis> vacunasDosis = mPPVacuna.ObtenerVacunasDosis();
            foreach(BEVacunaDosis vacunaDosis in vacunasDosis)
            {
                int DVH = CalcularDVH(vacunaDosis.Lote + vacunaDosis.Vacuna.VacunaID + vacunaDosis.FechaElaboracion.ToString() + vacunaDosis.FechaVencimiento.ToString() + vacunaDosis.CentroMedico.CentroMedicoId.ToString() + (vacunaDosis.Paciente.PacienteId == -1 ? string.Empty : vacunaDosis.Paciente.PacienteId.ToString()) + (vacunaDosis.FechaAplicacion is null ? string.Empty : vacunaDosis.FechaAplicacion.ToString()) + (vacunaDosis.Dosis == null ? string.Empty : vacunaDosis.Dosis.ToString()) + vacunaDosis.ObservacionPaciente + vacunaDosis.IndicacionMedico);
                if(DVH != vacunaDosis.DVH)
                {
                    return false;
                }
            }
            return true;
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
