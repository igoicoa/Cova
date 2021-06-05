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

namespace Cova.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MostrarComponentes();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
        }

        private void MostrarComponentes()
        {
            //Menu Administrar
            this.administrarToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.Administrar);
            this.administrarCuentaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AdministrarCuenta);
            this.crearCuentaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CrearCuenta);
            this.modificarCuentaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarCuenta);
            this.verUsuariosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.VerUsuarios);

            this.administrarVacunasToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AdministrarVacunas);
            this.calendarioDeVacunaciónToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CalendarioVacunacion);
            this.crearVacunasToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CrearVacunas);
            this.modificarVacunasToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarVacunas);
            this.verVacunasToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.VerVacunas);

            this.administrarTurnosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AdministrarTurnos);
            this.calendarioDeTurnosToolStripMenuItem1.Enabled = Sesion.TienePermiso(TipoPermiso.CalendarioDeTurnos);
            this.verCalendarioDePacientesToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.VerCalendarioMisPacientes);
            this.registrarTurnoToolStripMenuItem1.Enabled = Sesion.TienePermiso(TipoPermiso.RegistrarTurno);
            this.cancelarTurnoToolStripMenuItem1.Enabled = Sesion.TienePermiso(TipoPermiso.CancelarTurno);
            this.verMisTurnosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.VerMisTurnos);
            this.historialDeTurnosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.HistorialTurnos);
            
            this.administrarCoberturaMedicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AdministrarCoberturaMedica);
            this.crearCoberturaMedicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CrearCoberturaMedica);
            this.modificarCoberturaMedicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarCoberturaMedica);
            
            this.administrarHistoriaClinicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AdministrarHistoriaClinica);
            this.crearHistoriaClinicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CrearHistoriaClinica);
            this.modificarHistoriaClinicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarHistoriaClinica);
            this.verHistoriaClinicaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.VerHistoriaClinica);

            this.administrarRecetaCertificadoToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AdministrarReceta_Certificado);

            this.crearRecetaCertificadoToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CrearReceta_Certificado);
            this.modificarRecetaCertificadoToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarReceta_Certificado);
            this.verRecetasCertificadosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.VerReceta_Certificado);

            //Menu Seguridad
            this.realizarBackupToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.RealizarBackup);
            this.bitacoraToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.Bitacora);
            this.realizarRestoreToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.RealizarRestore);
            this.bloquerarPaswordToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.BloquearPassword);
            this.cambiarContraseñaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CambiarPassword);
            this.cambiarIdiomaToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CambiarIdioma);
            this.misDatosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.MisDatos);
            this.modificarDatosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarDatos);
            this.permisosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.Permisos);
            this.crearPermisosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.CrearPermisos);
            this.modificarPermisosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.ModificarPermisos);
            this.asignarPermisosToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.AsignarPermisos);


            //Menu Informacion
            this.contactoToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.Contacto);
            this.novedadesToolStripMenuItem.Enabled = Sesion.TienePermiso(TipoPermiso.Novedades);
        }

        private void profesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bloquerarPaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
