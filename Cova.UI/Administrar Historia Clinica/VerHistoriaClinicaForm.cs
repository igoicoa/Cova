using Cova.BE;
using Cova.BL;
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
        private BEPaciente _paciente;
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

        void IFormCargarUsuarios.CargarUsuarioPaciente(BEPaciente paciente)
        {
            this._paciente = paciente;
            this.txt_apellido_VerHistoriaClinica.Text = paciente.Apellido;
            this.txt_nombre_VerHistoriaClinica.Text = paciente.Nombre;
            this.txt_Edad_VerHistoriaClinica.Text = paciente.Edad.ToString();
            this.txt_NumeroDocumento_VerHistoriaClinica.Text = paciente.DNI.ToString();
        }

        private void btn_Mostrar_VerHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                if (_paciente== null)
                {
                    MessageBox.Show("Seleccionar un Paciente");
                    return;
                }
                BLPaciente bLPaciente = new BLPaciente();
                dgv_Mostrar_VerHistoriaClinica.DataSource = bLPaciente.ObtenerHistoriaClinicaPaciente(_paciente);
                MessageBox.Show("Historia clinica mostrada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_Mostrar_VerHistoriaClinica_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var historiaclinica = (BEHistoriaClinica)dgv_Mostrar_VerHistoriaClinica.Rows[e.RowIndex].DataBoundItem;
            if (dgv_Mostrar_VerHistoriaClinica.Columns[e.ColumnIndex].HeaderText.ToString() == "Medico")
            {
                e.Value = historiaclinica.Medico.ProfesionalId;
            }
        }
    }
}
