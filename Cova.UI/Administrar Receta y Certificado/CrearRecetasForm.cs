using System;
using System.Windows.Forms;
using Cova.BL;
using Cova.BE;

namespace Cova.UI
{
    public partial class CrearRecetasForm : Form, IFormCargarUsuarios
    {
        public CrearRecetasForm()
        {
            InitializeComponent();
            CargarVacunas();
        }

        public void CargarVacunas()
        {
            BLVacuna bLVacuna = new BLVacuna();
            this.cmb_vacuna.DataSource = bLVacuna.ObtenerVacunas();
            this.cmb_vacuna.DisplayMember = "Nombre";
            this.cmb_vacuna.ValueMember = "VacunaId";
            this.cmb_vacuna.SelectedIndex = -1;
        }

        private void btn_BuscarPacientes_CrearReceta_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente pacienteARecetar)
        {
            txt_apellido_CrearReceta.Text = pacienteARecetar.Apellido;
            txt_nombre_CrearReceta.Text = pacienteARecetar.Nombre;
            txt_Edad_CrearReceta.Text = pacienteARecetar.Edad.ToString();
            txt_NumeroDocumento_CrearReceta.Text = pacienteARecetar.DNI.ToString();
        }

        private void btn_Cancelar_CrearReceta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearReceta_Click(object sender, EventArgs e)
        {
            txt_Edad_CrearReceta.Clear();
            txt_NumeroDocumento_CrearReceta.Clear();
            txt_apellido_CrearReceta.Clear();
            txt_Edad_CrearReceta.Clear();
            txt_nombre_CrearReceta.Clear();
            lb_DetalleDiagnostico_CrearReceta.Items.Clear();
        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }
    }
}
