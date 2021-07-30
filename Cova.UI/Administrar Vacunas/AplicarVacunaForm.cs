using Cova.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cova.UI.Interfaces;

namespace Cova.UI
{
    public partial class AplicarVacunaForm : Form, IFormCargarUsuarios, IFormCargarVacunas
    {
        public AplicarVacunaForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
            CargarCentrosMedicos();
            CargarVacunas();
        }

        public void CargarCentrosMedicos()
        {

        }

        public void CargarVacunas()
        {

        }

        private void btn_Limpiar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            txt_apellido_AplicarVacunas.Clear();
            txt_Observacion_AplicarVacunas.Clear();
            txt_Edad_AplicarVacunas.Clear();
            txt_nombre_AplicarVacunas.Clear();
        }

        private void btn_BuscarPacientes_AplicarVacunas_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente usuarioAModificar)
        {
            txt_apellido_AplicarVacunas.Text = usuarioAModificar.Apellido;
            txt_nombre_AplicarVacunas.Text = usuarioAModificar.Nombre;
            txt_NumeroDocumento_AplicarVacunas.Text = Convert.ToString(usuarioAModificar.DNI);
            txt_Edad_AplicarVacunas.Text = Convert.ToString(usuarioAModificar.Edad);
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        private void btn_BuscarPacientes_AplicarVacunas_Click_1(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void CargarVacunasDosis(BEVacunaDosis Vacuna)
        {
            txt_vacuna.Text = Vacuna.Vacuna.Nombre;
            txt_laboratorio.Text = Vacuna.Vacuna.Laboratorio.Nombre;
            txt_lote.Text = Vacuna.Lote;
            dtp_fechaElaboracion.Value = Vacuna.FechaElaboracion;
            dtp_fechaVencimiento.Value = Vacuna.FechaVencimiento;
        }

        private void btn_Aplicar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se realizó la aplicación de la vacuna");
        }

        private void btn_buscarVacuna_Click(object sender, EventArgs e)
        {
            BuscarVacunasForm buscarVacunasForm = new BuscarVacunasForm();
            buscarVacunasForm.Show();
        }
    }
}
