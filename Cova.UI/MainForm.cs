using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cova.Servicios.Sesion;
using Cova.Common.Permisos;
using Cova.Common.Multiidioma;
using Cova.Servicios.Multiidioma;
using Cova.Common.Excepciones;
using Cova.BE;
using Cova.UI.Administrar_Receta_y_Certificado;
using Cova.UI.Bitacora;

namespace Cova.UI
{
    public partial class MainForm : Form, IFormCargarUsuarios, IIdiomaObserver
    {
        public MainForm()
        {
            InitializeComponent();
            InicializarMainForm();
        }

        public void InicializarMainForm()
        {
            if (Sesion.GetInstance != null)
            {
                Sesion.GetInstance.ManejadorIdioma.SuscribirObservador(this);
                this.Traducir(Sesion.GetInstance.ManejadorIdioma.Idioma);
            }
            else
            {
                this.Traducir();
            }
            if (Sesion.GetInstance != null)
                this.MostrarComponentes();
            else
                this.MostrarComponentes(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Sesion.GetInstance != null)
            {
                Sesion.GetInstance.ManejadorIdioma.SuscribirObservador(this);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Sesion.GetInstance != null)
            {
                Sesion.GetInstance.ManejadorIdioma.DesuscribirObservador(this);
            }
        }

        public void UpdateLanguage(Idioma idioma)
        {
            this.Traducir(idioma);
        }

        public void Traducir(Idioma idioma = null)
        {
            Traductor traductor = new Traductor();
            IDictionary<string, Traduccion> traducciones = traductor.ObtenerTraducciones(idioma);
            //Inicio
            if (inicioToolStripMenuItem.Tag != null && traducciones.ContainsKey(inicioToolStripMenuItem.Tag.ToString()))
                inicioToolStripMenuItem.Text = traducciones[inicioToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (loginToolStripMenuItem.Tag != null && traducciones.ContainsKey(loginToolStripMenuItem.Tag.ToString()))
                loginToolStripMenuItem.Text = traducciones[loginToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (logoutToolStripMenuItem.Tag != null && traducciones.ContainsKey(logoutToolStripMenuItem.Tag.ToString()))
                logoutToolStripMenuItem.Text = traducciones[logoutToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (inicioToolStripMenuItem.Tag != null && traducciones.ContainsKey(inicioToolStripMenuItem.Tag.ToString()))
                inicioToolStripMenuItem.Text = traducciones[inicioToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Cuenta
            if (administrarToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarToolStripMenuItem.Tag.ToString()))
                administrarToolStripMenuItem.Text = traducciones[administrarToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (administrarCuentaToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarCuentaToolStripMenuItem.Tag.ToString()))
                administrarCuentaToolStripMenuItem.Text = traducciones[administrarCuentaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearCuentaToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearCuentaToolStripMenuItem.Tag.ToString()))
                crearCuentaToolStripMenuItem.Text = traducciones[crearCuentaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (modificarCuentaToolStripMenuItem.Tag != null && traducciones.ContainsKey(modificarCuentaToolStripMenuItem.Tag.ToString()))
                modificarCuentaToolStripMenuItem.Text = traducciones[modificarCuentaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (verUsuariosToolStripMenuItem.Tag != null && traducciones.ContainsKey(verUsuariosToolStripMenuItem.Tag.ToString()))
                verUsuariosToolStripMenuItem.Text = traducciones[verUsuariosToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Vacunas administrarVacunasToolStripMenuItem
            if (administrarVacunasToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarVacunasToolStripMenuItem.Tag.ToString()))
                administrarVacunasToolStripMenuItem.Text = traducciones[administrarVacunasToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (calendarioDeVacunaciónToolStripMenuItem.Tag != null && traducciones.ContainsKey(calendarioDeVacunaciónToolStripMenuItem.Tag.ToString()))
                calendarioDeVacunaciónToolStripMenuItem.Text = traducciones[calendarioDeVacunaciónToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearVacunasToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearVacunasToolStripMenuItem.Tag.ToString()))
                crearVacunasToolStripMenuItem.Text = traducciones[crearVacunasToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (modificarVacunasToolStripMenuItem.Tag != null && traducciones.ContainsKey(modificarVacunasToolStripMenuItem.Tag.ToString()))
                modificarVacunasToolStripMenuItem.Text = traducciones[modificarVacunasToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (verVacunasToolStripMenuItem.Tag != null && traducciones.ContainsKey(verVacunasToolStripMenuItem.Tag.ToString()))
                verVacunasToolStripMenuItem.Text = traducciones[verVacunasToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (aplicarVacunaToolStripMenuItem.Tag != null && traducciones.ContainsKey(aplicarVacunaToolStripMenuItem.Tag.ToString()))
                aplicarVacunaToolStripMenuItem.Text = traducciones[aplicarVacunaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Turno administrarTurnosToolStripMenuItem
            if (administrarTurnosToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarTurnosToolStripMenuItem.Tag.ToString()))
                administrarTurnosToolStripMenuItem.Text = traducciones[administrarTurnosToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (calendarioDeTurnosToolStripMenuItem1.Tag != null && traducciones.ContainsKey(calendarioDeTurnosToolStripMenuItem1.Tag.ToString()))
                calendarioDeTurnosToolStripMenuItem1.Text = traducciones[calendarioDeTurnosToolStripMenuItem1.Tag.ToString()].PalabraTraducida;

            if (registrarTurnoToolStripMenuItem1.Tag != null && traducciones.ContainsKey(registrarTurnoToolStripMenuItem1.Tag.ToString()))
                registrarTurnoToolStripMenuItem1.Text = traducciones[registrarTurnoToolStripMenuItem1.Tag.ToString()].PalabraTraducida;

            if (cancelarTurnoToolStripMenuItem1.Tag != null && traducciones.ContainsKey(cancelarTurnoToolStripMenuItem1.Tag.ToString()))
                cancelarTurnoToolStripMenuItem1.Text = traducciones[cancelarTurnoToolStripMenuItem1.Tag.ToString()].PalabraTraducida;

            if (verMisTurnosToolStripMenuItem.Tag != null && traducciones.ContainsKey(verMisTurnosToolStripMenuItem.Tag.ToString()))
                verMisTurnosToolStripMenuItem.Text = traducciones[verMisTurnosToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Cobertura medica administrarCoberturaMedicaToolStripMenuItem
            if (administrarCoberturaMedicaToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarCoberturaMedicaToolStripMenuItem.Tag.ToString()))
                administrarCoberturaMedicaToolStripMenuItem.Text = traducciones[administrarCoberturaMedicaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearCoberturaMedicaToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearCoberturaMedicaToolStripMenuItem.Tag.ToString()))
                crearCoberturaMedicaToolStripMenuItem.Text = traducciones[crearCoberturaMedicaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (modificarCoberturaMedicaToolStripMenuItem.Tag != null && traducciones.ContainsKey(modificarCoberturaMedicaToolStripMenuItem.Tag.ToString()))
                modificarCoberturaMedicaToolStripMenuItem.Text = traducciones[modificarCoberturaMedicaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (verCoberturasMedicasToolStripMenuItem.Tag != null && traducciones.ContainsKey(verCoberturasMedicasToolStripMenuItem.Tag.ToString()))
                verCoberturasMedicasToolStripMenuItem.Text = traducciones[verCoberturasMedicasToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Historia Clinica administrarHistoriaClinicaToolStripMenuItem
            if (administrarHistoriaClinicaToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarHistoriaClinicaToolStripMenuItem.Tag.ToString()))
                administrarHistoriaClinicaToolStripMenuItem.Text = traducciones[administrarHistoriaClinicaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearHistoriaClinicaToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearHistoriaClinicaToolStripMenuItem.Tag.ToString()))
                crearHistoriaClinicaToolStripMenuItem.Text = traducciones[crearHistoriaClinicaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (verHistoriaClinicaToolStripMenuItem.Tag != null && traducciones.ContainsKey(verHistoriaClinicaToolStripMenuItem.Tag.ToString()))
                verHistoriaClinicaToolStripMenuItem.Text = traducciones[verHistoriaClinicaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Receta/Certificado administrarReceta/CertificadoToolStripMenuItem
            if (administrarRecetaCertificadoToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarRecetaCertificadoToolStripMenuItem.Tag.ToString()))
                administrarRecetaCertificadoToolStripMenuItem.Text = traducciones[administrarRecetaCertificadoToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearRecetaCertificadoToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearRecetaCertificadoToolStripMenuItem.Tag.ToString()))
                crearRecetaCertificadoToolStripMenuItem.Text = traducciones[crearRecetaCertificadoToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (modificarRecetaCertificadoToolStripMenuItem.Tag != null && traducciones.ContainsKey(modificarRecetaCertificadoToolStripMenuItem.Tag.ToString()))
                modificarRecetaCertificadoToolStripMenuItem.Text = traducciones[modificarRecetaCertificadoToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (verRecetasCertificadosToolStripMenuItem.Tag != null && traducciones.ContainsKey(verRecetasCertificadosToolStripMenuItem.Tag.ToString()))
                verRecetasCertificadosToolStripMenuItem.Text = traducciones[verRecetasCertificadosToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Seguridad
            //Administrar Receta/Certificado administrarReceta/CertificadoToolStripMenuItem
            if (seguridadToolStripMenuItem.Tag != null && traducciones.ContainsKey(seguridadToolStripMenuItem.Tag.ToString()))
                seguridadToolStripMenuItem.Text = traducciones[seguridadToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Realizar Backup realizarBackupToolStripMenuItem
            if (realizarBackupToolStripMenuItem.Tag != null && traducciones.ContainsKey(realizarBackupToolStripMenuItem.Tag.ToString()))
                realizarBackupToolStripMenuItem.Text = traducciones[realizarBackupToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Bitacora bitacoraToolStripMenuItem
            if (bitacoraToolStripMenuItem.Tag != null && traducciones.ContainsKey(bitacoraToolStripMenuItem.Tag.ToString()))
                bitacoraToolStripMenuItem.Text = traducciones[bitacoraToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Realizar Restore realizarRestoreToolStripMenuItem
            if (realizarRestoreToolStripMenuItem.Tag != null && traducciones.ContainsKey(realizarRestoreToolStripMenuItem.Tag.ToString()))
                realizarRestoreToolStripMenuItem.Text = traducciones[realizarRestoreToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Permisos permisosToolStripMenuItem
            if (permisosToolStripMenuItem.Tag != null && traducciones.ContainsKey(permisosToolStripMenuItem.Tag.ToString()))
                permisosToolStripMenuItem.Text = traducciones[permisosToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (asignarPermisosToolStripMenuItem.Tag != null && traducciones.ContainsKey(asignarPermisosToolStripMenuItem.Tag.ToString()))
                asignarPermisosToolStripMenuItem.Text = traducciones[asignarPermisosToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Administrar Idioma administrarIdiomaToolStripMenuItem
            if (administrarIdiomaToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarIdiomaToolStripMenuItem.Tag.ToString()))
                administrarIdiomaToolStripMenuItem.Text = traducciones[administrarIdiomaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (cambiarIdiomaToolStripMenuItem.Tag != null && traducciones.ContainsKey(cambiarIdiomaToolStripMenuItem.Tag.ToString()))
                cambiarIdiomaToolStripMenuItem.Text = traducciones[cambiarIdiomaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearIdiomaToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearIdiomaToolStripMenuItem.Tag.ToString()))
                crearIdiomaToolStripMenuItem.Text = traducciones[crearIdiomaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            //Informacion informaciónToolStripMenuItem
            if (informaciónToolStripMenuItem.Tag != null && traducciones.ContainsKey(informaciónToolStripMenuItem.Tag.ToString()))
                informaciónToolStripMenuItem.Text = traducciones[informaciónToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (contactoToolStripMenuItem.Tag != null && traducciones.ContainsKey(contactoToolStripMenuItem.Tag.ToString()))
                contactoToolStripMenuItem.Text = traducciones[contactoToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (novedadesToolStripMenuItem.Tag != null && traducciones.ContainsKey(novedadesToolStripMenuItem.Tag.ToString()))
                novedadesToolStripMenuItem.Text = traducciones[novedadesToolStripMenuItem.Tag.ToString()].PalabraTraducida;
        }

        private void MostrarComponentes(bool cargarPermisosUsuario = true)
        {
            //Menu Administrar
            this.administrarToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Administrar) : false;
            this.administrarCuentaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarCuenta) : false;
            this.crearCuentaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearCuenta) : false;
            this.modificarCuentaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarCuenta) : false;
            this.verUsuariosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerUsuarios) : false;

            this.administrarVacunasToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarVacunas) : false;
            this.calendarioDeVacunaciónToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CalendarioVacunacion) : false;
            this.crearVacunasToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearVacunas) : false;
            this.modificarVacunasToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarVacunas) : false;
            this.verVacunasToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerVacunas) : false;
            this.aplicarVacunaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerVacunas) : false;

            this.administrarTurnosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarTurnos) : false;
            this.calendarioDeTurnosToolStripMenuItem1.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CalendarioDeTurnos) : false;
            this.registrarTurnoToolStripMenuItem1.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.RegistrarTurno) : false;
            this.cancelarTurnoToolStripMenuItem1.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CancelarTurno) : false;
            this.verMisTurnosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerMisTurnos) : false;

            this.administrarCoberturaMedicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarCoberturaMedica) : false;
            this.crearCoberturaMedicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearCoberturaMedica) : false;
            this.modificarCoberturaMedicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarCoberturaMedica) : false;
            this.verCoberturasMedicasToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerCoberturaMedica) : false;

            this.administrarHistoriaClinicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarHistoriaClinica) : false;
            this.crearHistoriaClinicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearHistoriaClinica) : false;
            this.verHistoriaClinicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerHistoriaClinica) : false;

            this.administrarRecetaCertificadoToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarReceta_Certificado) : false;
            this.crearRecetaCertificadoToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearReceta_Certificado) : false;
            this.modificarRecetaCertificadoToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarReceta_Certificado) : false;
            this.verRecetasCertificadosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerReceta_Certificado) : false;

            //Menu Seguridad
            this.seguridadToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Seguridad) : false;
            this.realizarBackupToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.RealizarBackup) : false;
            this.bitacoraToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Bitacora) : false;
            this.realizarRestoreToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.RealizarRestore) : false;
            this.permisosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Permisos) : false;
            this.asignarPermisosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AsignarPermisos) : false;
            this.administrarIdiomaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarIdioma) : false;
            this.cambiarIdiomaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CambiarIdioma) : false;
            this.crearIdiomaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearIdioma) : false;
            
            //Menu Informacion
            this.informaciónToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Informacion) : false;
            this.contactoToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Contacto) : false;
            this.novedadesToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Novedades) : false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm(this);
            loginfrm.Show();
        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Sesion.Logout();
            }
            catch(SesionNoIniciadaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bloquerarPaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarPermisosForm frmAsignarPermisos = new AsignarPermisosForm();
            frmAsignarPermisos.Show();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCuentaForm frmCrearCuenta = new CrearCuentaForm();
            frmCrearCuenta.Show();
        }

        private void crearIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarIdiomaForm frmAgregarIdioma = new AgregarIdiomaForm();
            frmAgregarIdioma.Show();
        }

        private void modificarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCuentaForm frmModificarCuenta = new ModificarCuentaForm();
            frmModificarCuenta.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false);
            frmBuscarUsuarios.Show();
        }

        private void calendarioDeVacunaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarioDeVacunaciónForm frmCalendarioVacunacion = new CalendarioDeVacunaciónForm();
            frmCalendarioVacunacion.Show();
        }

        private void crearVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearVacunasForm frmCrearVacunas = new CrearVacunasForm();
            frmCrearVacunas.Show();
        }

        private void modificarVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarVacunasForm frmModificarVacunas = new ModificarVacunasForm();
            frmModificarVacunas.Show();
        }

        private void verVacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarVacunasForm frmVerVacunas = new BuscarVacunasForm();
            frmVerVacunas.Show();
        }

        private void aplicarVacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AplicarVacunaForm frmAplicarVacuna = new AplicarVacunaForm();
            frmAplicarVacuna.Show();
        }

        private void verCalendarioDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCalendarioMisPacientesForm frmVerCalendarioMisPacientes = new VerCalendarioMisPacientesForm();
            frmVerCalendarioMisPacientes.Show();
        }

        private void registrarTurnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarTurnoForm frmRegistrarTurno = new RegistrarTurnoForm();
            frmRegistrarTurno.Show();
        }

        private void crearCoberturaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarCoberturaMedicaForm frmCargarCoberturaMedica = new CargarCoberturaMedicaForm();
            frmCargarCoberturaMedica.Show();
        }

        private void modificarCoberturaMedicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCoberturaMedicaForm frmModificarCoberturaMedica = new ModificarCoberturaMedicaForm();
            frmModificarCoberturaMedica.Show();
        }

        private void verCoberturasMedicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCoberturaMedicaForm frmVerCoberturaMedica = new VerCoberturaMedicaForm();
            frmVerCoberturaMedica.Show();
        }

        private void crearHistoriaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearHistoriaClinicaForm frmCrearHistoriaClinica = new CrearHistoriaClinicaForm();
            frmCrearHistoriaClinica.Show();
        }

        private void verHistoriaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerHistoriaClinicaForm frmVerHistoriaClinica = new VerHistoriaClinicaForm();
            frmVerHistoriaClinica.Show();
        }

        private void crearRecetaCertificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearRecetas_CertificadosForm frmCrearRecetas_Certificados = new CrearRecetas_CertificadosForm();
            frmCrearRecetas_Certificados.Show();
        }

        private void modificarRecetaCertificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRecetas_CertificadosForm frmModificarRecetas_Certificados= new ModificarRecetas_CertificadosForm();
            frmModificarRecetas_Certificados.Show();
        }

        void IFormCargarUsuarios.CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioPaciente(BEPaciente usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarIdiomaForm frmCambiarIdiomaForm = new CambiarIdiomaForm();
            frmCambiarIdiomaForm.Show();
        }

        private void verRecetasCertificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerReceta_CertificadoForm frmVerReceta_Certificado = new VerReceta_CertificadoForm();
            frmVerReceta_Certificado.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BitacoraForm frmBitacora = new BitacoraForm();
            frmBitacora.Show();
        }
    }
}
