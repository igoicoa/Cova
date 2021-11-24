using Cova.BE;
using Cova.BL;
using System;
using System.Linq;
using System.Windows.Forms;
using Cova.Servicios.Sesion;
using Aspose.Pdf;
using Microsoft.Win32;

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

        private void bttn_Exportar_Click(object sender, EventArgs e)
        {
            BLPaciente bLPaciente = new BLPaciente();
            var historiaclinica= bLPaciente.ObtenerHistoriaClinicaPaciente(_paciente);
            string descargas = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
            var document = new Document()
            {
                PageInfo = new PageInfo()
                {
                    Margin = new MarginInfo(28, 28, 28, 28)
                }
            };

            var table = new Table()
            {
                ColumnWidths = "15% 15% 15% 15% 15% 15%",
                DefaultCellPadding = new MarginInfo(10, 5, 5, 5),
                Border = new BorderInfo(BorderSide.All),
                DefaultCellBorder = new BorderInfo(BorderSide.All, .2f, Color.Black)
            };

            Row row1 = table.Rows.Add();
            row1.Cells.Add("HistoriaClinicaId");
            row1.Cells.Add("Fecha");
            row1.Cells.Add("Profesional");
            row1.Cells.Add("Paciente");
            row1.Cells.Add("Observacion");
            row1.Cells.Add("Peso");

            foreach (BEHistoriaClinica registrohclinica in historiaclinica)
            {
                Row row2 = table.Rows.Add();
                row2.Cells.Add(registrohclinica.HistoriaClinicaId.ToString());
                row2.Cells.Add(registrohclinica.Fecha.ToString());
                row2.Cells.Add(registrohclinica.Medico.ProfesionalId.ToString());
                row2.Cells.Add(_paciente.ApellidoNombre.ToString());
                row2.Cells.Add(registrohclinica.Observacion.ToString());
                row2.Cells.Add(registrohclinica.Peso.ToString());
            }
            document.Pages.Add();
            //fitTableToPageWidth(table);
            document.Pages[1].Paragraphs.Add(table); //aspose.pdf indexes start at 1
            document.Pages[1].Rect = new Rectangle(0, 0, 421, 595); // A5 size
            document.Save(descargas + $"\\reporte.pdf");
            MessageBox.Show("Se realizó la descarga del Reporte de forma correcta");
        }
    }
}
