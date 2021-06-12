using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cova.BE.Permisos
{
    public enum TipoPermiso
    {
        //Permiso root
        Raiz,

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
        HistorialTurnos,

        AdministrarCoberturaMedica,
        CrearCoberturaMedica,
        ModificarCoberturaMedica,

        AdministrarHistoriaClinica,
        CrearHistoriaClinica,
        ModificarHistoriaClinica,
        VerHistoriaClinica,

        AdministrarReceta_Certificado,
        CrearReceta_Certificado,
        ModificarReceta_Certificado,
        VerReceta_Certificado,

        //Seguridad
        RealizarBackup,
        Bitacora,
        RealizarRestore,
        BloquearPassword,
        CambiarPassword,
        CambiarIdioma,
        MisDatos,
        ModificarDatos,
        Permisos,
        CrearPermisos,
        ModificarPermisos,
        AsignarPermisos,

        //Informacion
        Contacto,
        Novedades
    }
}
