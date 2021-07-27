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

namespace Cova.UI
{
    public partial class AplicarVacunaForm : Form, IFormCargarUsuarios
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
    }
}
