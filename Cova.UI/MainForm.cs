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



            //Menu Seguridad

            //Menu Informacion

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
    }
}
