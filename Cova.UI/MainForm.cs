using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cova.Servicios.Sesion;
using Cova.Common.Permisos;
using Cova.Common.Multiidioma;
using Cova.Servicios.Multiidioma;
using Cova.Common.Excepciones;

namespace Cova.UI
{
    public partial class MainForm : Form, IIdiomaObserver
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
            this.verCalendarioDePacientesToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerCalendarioMisPacientes) : false;
            this.registrarTurnoToolStripMenuItem1.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.RegistrarTurno) : false;
            this.cancelarTurnoToolStripMenuItem1.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CancelarTurno) : false;
            this.verMisTurnosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.VerMisTurnos) : false;
            this.historialDeTurnosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.HistorialTurnos) : false;

            this.administrarCoberturaMedicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarCoberturaMedica) : false;
            this.crearCoberturaMedicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearCoberturaMedica) : false;
            this.modificarCoberturaMedicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarCoberturaMedica) : false;

            this.administrarHistoriaClinicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AdministrarHistoriaClinica) : false;
            this.crearHistoriaClinicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearHistoriaClinica) : false;
            this.modificarHistoriaClinicaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarHistoriaClinica) : false;
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
            this.bloquerarPaswordToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.BloquearPassword) : false;
            this.cambiarContraseñaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CambiarPassword) : false;
            this.cambiarIdiomaToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CambiarIdioma) : false;
            this.misDatosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.MisDatos) : false;
            this.modificarDatosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarDatos) : false;
            this.permisosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.Permisos) : false;
            this.crearPermisosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.CrearPermisos) : false;
            this.modificarPermisosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.ModificarPermisos) : false;
            this.asignarPermisosToolStripMenuItem.Enabled = cargarPermisosUsuario ? Sesion.TienePermiso(TipoPermiso.AsignarPermisos) : false;

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
            BuscarUsuariosForm frmVerUsuarios = new BuscarUsuariosForm(false);
            frmVerUsuarios.Show();
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
            VerVacunasForm frmVerVacunas = new VerVacunasForm();
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

        private void modificarHistoriaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarHistoriaClinicaForm frmModificarHistoriaClinica = new ModificarHistoriaClinicaForm();
            frmModificarHistoriaClinica.Show();
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
    }
}
