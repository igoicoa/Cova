using System;
using System.Collections.Generic;
using Cova.BE;
using Cova.MPP;
using Cova.Servicios;

namespace Cova.BL
{
    public class BLReceta
    {
        public BEReceta ObtenerRecetaParaVacunaYPaciente(BEVacuna vacunaAAplicar, BEPaciente pacienteAVacunar)
        {
            MPPReceta mPPReceta = new MPPReceta();
            return mPPReceta.ObtenerRecetaParaVacunaYPaciente(vacunaAAplicar, pacienteAVacunar);
        }

        public bool CrearReceta(BEReceta receta)
        {
            if (Servicios.Sesion.Sesion.GetInstance.Usuario.TipoUsuario== BE.Enum.TipoUsuario.Administrador ||
                Servicios.Sesion.Sesion.GetInstance.Usuario.TipoUsuario == BE.Enum.TipoUsuario.Paciente)
            {
                throw new Exception("Operacion invalida ya que no posee permisos de Profesional");
            }
            else
            {
                MPPReceta mPPReceta = new MPPReceta();
                return mPPReceta.CrearReceta(receta);
            }
        }
    }
}
