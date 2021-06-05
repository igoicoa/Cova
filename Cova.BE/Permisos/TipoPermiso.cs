using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Permisos
{
    public enum TipoPermiso
    {
        //FamiliaPermisos
        Inicio,
        Administrar,
        Seguridad,
        Informacion,

        //Inicio
        Login,
        Logout,

        //Administrar
        AdministrarCuenta,
        CrearCuenta,
        ModificarCuenta,
        VerUsuarios,

        AdministrarVacunas,
        CalendarioVacunacion,
        CrearVacunas,
        ModificarVacunas,
        VerVacunas,

        AdministrarTurnos,
        CalendarioDeTurnos,
        VerCalendarioMisPacientes,
        RegistrarTurno,
        CancelarTurno,
        VerMisTurnos,
        Historialurnos

        AdministrarCoberturaMedica,
        AdministrarHistoriaClinica,
        AdministrarReceta,

        //Seguridad
        RealizarBackup,
        Bitacora,
        RealizarRestore,
        BloquearPassword,
        CambiarPassword,
        CambiarIdioma,
        MisDatos,
        ModificarDatos,

        //Informacion
        Contacto,
        Novedades
    }
}
