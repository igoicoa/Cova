using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cova.Servicios.Sesion;
using Cova.BE.Permisos;
using Cova.BE.Multiidioma;
using Cova.Servicios.Multiidioma;

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
            
            if (inicioToolStripMenuItem.Tag != null && traducciones.ContainsKey(inicioToolStripMenuItem.Tag.ToString()))
                inicioToolStripMenuItem.Text = traducciones[inicioToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (loginToolStripMenuItem.Tag != null && traducciones.ContainsKey(loginToolStripMenuItem.Tag.ToString()))
                loginToolStripMenuItem.Text = traducciones[loginToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (logoutToolStripMenuItem.Tag != null && traducciones.ContainsKey(logoutToolStripMenuItem.Tag.ToString()))
                logoutToolStripMenuItem.Text = traducciones[logoutToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (inicioToolStripMenuItem.Tag != null && traducciones.ContainsKey(inicioToolStripMenuItem.Tag.ToString()))
                inicioToolStripMenuItem.Text = traducciones[inicioToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (administrarToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarToolStripMenuItem.Tag.ToString()))
                administrarToolStripMenuItem.Text = traducciones[administrarToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (administrarCuentaToolStripMenuItem.Tag != null && traducciones.ContainsKey(administrarCuentaToolStripMenuItem.Tag.ToString()))
                administrarCuentaToolStripMenuItem.Text = traducciones[administrarCuentaToolStripMenuItem.Tag.ToString()].PalabraTraducida;

            if (crearCuentaToolStripMenuItem.Tag != null && traducciones.ContainsKey(crearCuentaToolStripMenuItem.Tag.ToString()))
                crearCuentaToolStripMenuItem.Text = traducciones[crearCuentaToolStripMenuItem.Tag.ToString()].PalabraTraducida;
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
            catch(Exception ex)
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
    }
}
