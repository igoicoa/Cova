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
        RegistrarTurno,
        CancelarTurno,
        VerMisTurnos,

        AdministrarCoberturaMedica,
        CrearCoberturaMedica,
        ModificarCoberturaMedica,
        VerCoberturaMedica,

        AdministrarHistoriaClinica,
        CrearHistoriaClinica,
        VerHistoriaClinica,

        AdministrarReceta_Certificado,
        CrearReceta_Certificado,
        ModificarReceta_Certificado,
        VerReceta_Certificado,

        //Seguridad
        RealizarBackup,
        Bitacora,
        RealizarRestore,
        
        Permisos,
        AsignarPermisos,

        AdministrarIdioma,
        CambiarIdioma,
        CrearIdioma,
        Controlde_Cambio,

        //Informacion
        Contacto,
        Novedades
    }
}
