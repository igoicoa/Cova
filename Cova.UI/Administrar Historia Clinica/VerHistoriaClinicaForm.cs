using Cova.BE;
using Cova.BL;
using System;
using System.Linq;
using System.Windows.Forms;
using Cova.Servicios.Sesion;

namespace Cova.UI
{
    public partial class VerHistoriaClinicaForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _paciente;
        public VerHistoriaClinicaForm()
        {
            InitializeComponent();
            if(Sesion.GetInstance.Usuario.TipoUsuario == BE.Enum.TipoUsuario.Paciente)
            {
                BLPaciente bLPaciente = new BLPaciente();
                btn_BuscarPacientes_VerHistoriaClinica.Visible = false;
                long usuarioId = Sesion.GetInstance.Usuario.UsuarioID;
                string usuario = Sesion.GetInstance.Usuario.Usuario;
                this._paciente = bLPaciente.BuscarPacientes(usuario, "").ToList().Where(x => x.UsuarioID == usuarioId).FirstOrDefault();
                this.txt_apellido_VerHistoriaClinica.Text = this._paciente.Apellido;
                this.txt_nombre_VerHistoriaClinica.Text = this._paciente.Nombre;
                this.txt_Edad_VerHistoriaClinica.Text = this._paciente.Edad.ToString();
                this.txt_NumeroDocumento_VerHistoriaClinica.Text = this._paciente.DNI.ToString();
            }
        }

        private void btnCancelar_VerHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarPacientes_VerHistoriaClinica_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(true, this);
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
