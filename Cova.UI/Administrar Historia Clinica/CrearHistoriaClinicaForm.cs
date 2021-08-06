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
    public partial class CrearHistoriaClinicaForm : Form, IFormCargarUsuarios
    {
        public CrearHistoriaClinicaForm()
        {
            InitializeComponent();
        }

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
            frmBuscarUsuarios.Show();
        }

        private void btnCancelar_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            txt_NumeroDocumento_CrearHistoriaClinica.Clear();
            txt_apellido_CrearHistoriaClinica.Clear();
            txt_nombre_CrearHistoriaClinica.Clear();
            txt_Edad_CrearHistoriaClinica.Clear();
            txt_MotivoConsulta.Clear();
            txt_Medicacion_CrearHistoriaClinica.Clear();
            txt_Observacion_CrearHistoriaClinica.Clear();
            txt_PesoActual_CrearHistoriaClinica.Clear();
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
    }
}
