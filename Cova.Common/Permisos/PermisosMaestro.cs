using System;

namespace Cova.Common.Permisos
{
    public class PermisosMaestro
    {
        public FamiliaPermisos PermisoMaestro { get; set; }

        public PermisosMaestro()
        {
            this.ConstruirArbolPermisos();
        }

        public void ConstruirArbolPermisos()
        {
            this.PermisoMaestro = new FamiliaPermisos(TipoPermiso.Raiz);

            //Administrar

            //Administrar Cuenta
            Permiso crearCuenta = new Permiso(TipoPermiso.CrearCuenta);
            Permiso modificarCuenta = new Permiso(TipoPermiso.ModificarCuenta);
            Permiso verUsuarios = new Permiso(TipoPermiso.VerUsuarios);

            FamiliaPermisos administrarCuenta = new FamiliaPermisos(TipoPermiso.AdministrarCuenta);
            administrarCuenta.AgregarPermiso(crearCuenta);
            administrarCuenta.AgregarPermiso(modificarCuenta);
            administrarCuenta.AgregarPermiso(verUsuarios);

            //Administrar Vacunas
            Permiso calendarioVacunacion = new Permiso(TipoPermiso.CalendarioVacunacion);
            Permiso crearVacuna = new Permiso(TipoPermiso.CrearVacunas);
            Permiso modificarVacunas = new Permiso(TipoPermiso.ModificarVacunas);
            Permiso verVacunas = new Permiso(TipoPermiso.VerVacunas);
            Permiso AplicarVacuna = new Permiso(TipoPermiso.AplicarVacuna);

            FamiliaPermisos administrarVacunas = new FamiliaPermisos(TipoPermiso.AdministrarVacunas);
            administrarVacunas.AgregarPermiso(calendarioVacunacion);
            administrarVacunas.AgregarPermiso(crearVacuna);
            administrarVacunas.AgregarPermiso(modificarVacunas);
            administrarVacunas.AgregarPermiso(verVacunas);
            administrarVacunas.AgregarPermiso(AplicarVacuna);

            //Administrar Turnos
            Permiso calendarioTurnos = new Permiso(TipoPermiso.CalendarioDeTurnos);
            Permiso verCalendarioMisPacientes = new Permiso(TipoPermiso.VerCalendarioMisPacientes);
            Permiso registrarTurno = new Permiso(TipoPermiso.RegistrarTurno);
            Permiso cancelarTurno = new Permiso(TipoPermiso.CancelarTurno);
            Permiso verMisTurnos = new Permiso(TipoPermiso.VerMisTurnos);
            Permiso historialTurnos = new Permiso(TipoPermiso.HistorialTurnos);

            FamiliaPermisos administrarTurnos = new FamiliaPermisos(TipoPermiso.AdministrarTurnos);
            administrarTurnos.AgregarPermiso(calendarioTurnos);
            administrarTurnos.AgregarPermiso(verCalendarioMisPacientes);
            administrarTurnos.AgregarPermiso(registrarTurno);
            administrarTurnos.AgregarPermiso(cancelarTurno);
            administrarTurnos.AgregarPermiso(verMisTurnos);
            administrarTurnos.AgregarPermiso(historialTurnos);

            //Administrar Cobertura Medica
            Permiso crearCoberturaMedica = new Permiso(TipoPermiso.CrearCoberturaMedica);
            Permiso modificarCoberturaMedica = new Permiso(TipoPermiso.ModificarCoberturaMedica);
            Permiso VerCoberturaMedica = new Permiso(TipoPermiso.VerCoberturaMedica);

            FamiliaPermisos administrarCoberturaMedica = new FamiliaPermisos(TipoPermiso.AdministrarCoberturaMedica);
            administrarCoberturaMedica.AgregarPermiso(crearCoberturaMedica);
            administrarCoberturaMedica.AgregarPermiso(modificarCoberturaMedica);
            administrarCoberturaMedica.AgregarPermiso(VerCoberturaMedica);

            //Administrar Historia Clinica
            Permiso crearHistoriaClinica = new Permiso(TipoPermiso.CrearHistoriaClinica);
            Permiso modificarHistoriaClinica = new Permiso(TipoPermiso.ModificarHistoriaClinica);
            Permiso verHistoriaClinica = new Permiso(TipoPermiso.VerHistoriaClinica);

            FamiliaPermisos administrarHistoriaClinica = new FamiliaPermisos(TipoPermiso.AdministrarHistoriaClinica);
            administrarHistoriaClinica.AgregarPermiso(crearHistoriaClinica);
            administrarHistoriaClinica.AgregarPermiso(modificarHistoriaClinica);
            administrarHistoriaClinica.AgregarPermiso(verHistoriaClinica);

            //Administrar Receta/Certificado
            Permiso crearReceta_Certificado = new Permiso(TipoPermiso.CrearReceta_Certificado);
            Permiso modificarReceta_Certificado = new Permiso(TipoPermiso.ModificarReceta_Certificado);
            Permiso verReceta_Certificado = new Permiso(TipoPermiso.VerReceta_Certificado);

            FamiliaPermisos administrarReceta_Certificado = new FamiliaPermisos(TipoPermiso.AdministrarReceta_Certificado);
            administrarReceta_Certificado.AgregarPermiso(crearReceta_Certificado);
            administrarReceta_Certificado.AgregarPermiso(modificarReceta_Certificado);
            administrarReceta_Certificado.AgregarPermiso(verReceta_Certificado);


            FamiliaPermisos administrar = new FamiliaPermisos(TipoPermiso.Administrar);
            administrar.AgregarPermiso(administrarCuenta);
            administrar.AgregarPermiso(administrarVacunas);
            administrar.AgregarPermiso(administrarTurnos);
            administrar.AgregarPermiso(administrarCoberturaMedica);
            administrar.AgregarPermiso(administrarHistoriaClinica);
            administrar.AgregarPermiso(administrarReceta_Certificado);

            //Seguridad
            //Realizar Backup
            Permiso realizarBackup = new Permiso(TipoPermiso.RealizarBackup);

            //Bitacora
            Permiso bitacora = new Permiso(TipoPermiso.Bitacora);

            //Realizar Restore
            Permiso realizarRestore = new Permiso(TipoPermiso.RealizarRestore);

            //Permisos
            Permiso Permisos = new Permiso(TipoPermiso.Permisos);
            Permiso AsignarPermisos = new Permiso(TipoPermiso.AsignarPermisos);

            FamiliaPermisos familiaPermisos = new FamiliaPermisos(TipoPermiso.AdministrarIdioma);
            familiaPermisos.AgregarPermiso(Permisos);
            familiaPermisos.AgregarPermiso(AsignarPermisos);

            //Administrar Idioma
            Permiso cambiarIdioma = new Permiso(TipoPermiso.CambiarIdioma);
            Permiso crearIdioma = new Permiso(TipoPermiso.CambiarIdioma);

            FamiliaPermisos AdministrarIdioma = new FamiliaPermisos(TipoPermiso.AdministrarIdioma);
            AdministrarIdioma.AgregarPermiso(cambiarIdioma);
            AdministrarIdioma.AgregarPermiso(crearIdioma);

            FamiliaPermisos seguridad = new FamiliaPermisos(TipoPermiso.Seguridad);
            seguridad.AgregarPermiso(realizarBackup);
            seguridad.AgregarPermiso(bitacora);
            seguridad.AgregarPermiso(realizarRestore);
            seguridad.AgregarPermiso(Permisos);
            seguridad.AgregarPermiso(AsignarPermisos);
            seguridad.AgregarPermiso(AdministrarIdioma);

            //Informacion
            //Contacto
            Permiso contacto = new Permiso(TipoPermiso.Contacto);

            //Novedades
            Permiso novedades = new Permiso(TipoPermiso.Novedades);

            FamiliaPermisos informacion = new FamiliaPermisos(TipoPermiso.Informacion);
            informacion.AgregarPermiso(contacto);
            informacion.AgregarPermiso(novedades);

            //Permiso maestro
            //this.PermisoMaestro.AgregarPermiso(inicio);
            this.PermisoMaestro.AgregarPermiso(administrar);
            this.PermisoMaestro.AgregarPermiso(seguridad);
            this.PermisoMaestro.AgregarPermiso(informacion);
        }
    }
}
