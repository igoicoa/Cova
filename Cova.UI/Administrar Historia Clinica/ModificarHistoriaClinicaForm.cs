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
    public partial class ModificarHistoriaClinicaForm : Form, IFormCargarUsuarios
    {
        public ModificarHistoriaClinicaForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_ModificarHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerHistoriaClinicaHistorial_ModificarHistoriaClinica_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_BuscarPacientes_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
            frmBuscarUsuarios.Show();
        }

        private void btn_Limpiar_ModificarHistoriaClinica_Click(object sender, EventArgs e)
        {
            txt_NumeroDocumento_ModificarHistoriaClinica.Clear();
            txt_PesoActual_ModificarHistoriaClinica.Clear();
            txt_Edad_ModificarHistoriaClinica.Clear();
            txt_Medicacion_ModificarHistoriaClinica.Clear();
            txt_apellido_ModificarHistoriaClinica.Clear();
            txt_nombre_ModificarHistoriaClinica.Clear();
            txt_NumeroDocumento_ModificarHistoriaClinica.Clear();
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
