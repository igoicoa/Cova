using System;

namespace Cova.Common.Permisos
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
        AplicarVacuna,

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
        VerCoberturaMedica,

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
        VerDatos,

        Permisos,
        AsignarPermisos,

        AdministrarIdioma,
        CambiarIdioma,
        CrearIdioma,

        //Informacion
        Contacto,
        Novedades
    }
}
