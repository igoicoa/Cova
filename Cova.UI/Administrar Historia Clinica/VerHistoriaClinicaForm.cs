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
    public partial class VerHistoriaClinicaForm : Form, IFormCargarUsuarios
    {
        public VerHistoriaClinicaForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_VerHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarPacientes_VerHistoriaClinica_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
            frmBuscarUsuarios.Show();
        }

        void IFormCargarUsuarios.CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioPaciente(BEPaciente usuarioAModificar)
        {
            throw new NotImplementedException();
        }
    }
}
