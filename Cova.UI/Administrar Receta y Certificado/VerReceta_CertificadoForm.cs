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

namespace Cova.UI.Administrar_Receta_y_Certificado
{
    public partial class VerReceta_CertificadoForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _VerRecetaPaciente;
        public List<BEReceta> Receta;

        public VerReceta_CertificadoForm()
        {
            InitializeComponent();
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

        public void CargarUsuarioPaciente(BEPaciente verRecetaPaciente)
        {
            this._VerRecetaPaciente = verRecetaPaciente;
            txt_apellido__VerRecetasyCertificados.Text = verRecetaPaciente.Apellido;
            txt_nombre__VerRecetasyCertificados.Text = verRecetaPaciente.Nombre;
            txt_Edad__VerRecetasyCertificados.Text = verRecetaPaciente.Edad.ToString();
            txt_NumeroDocumento__VerRecetasyCertificados.Text = verRecetaPaciente.DNI.ToString();
        }

        private void btn_BuscarPacientes__VerRecetasyCertificados_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        private void btn_Cancelar__VerRecetasyCertificados_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar__VerRecetasyCertificados_Click(object sender, EventArgs e)
        {
            txt_Edad__VerRecetasyCertificados.Clear();
            txt_NumeroDocumento__VerRecetasyCertificados.Clear();
            txt_apellido__VerRecetasyCertificados.Clear();
            txt_nombre__VerRecetasyCertificados.Clear();
        }

        public bool ValidarTodosLosCamposReceta_Certificado()
        {
            if (string.IsNullOrEmpty(txt_NumeroDocumento__VerRecetasyCertificados.Text) || (string.IsNullOrEmpty(txt_Edad__VerRecetasyCertificados.Text))
                || (string.IsNullOrEmpty(txt_nombre__VerRecetasyCertificados.Text)) || string.IsNullOrEmpty(txt_apellido__VerRecetasyCertificados.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_Mostrar__VerRecetasyCertificados_Click(object sender, EventArgs e)
        {
            if (chb_Receta_VerRecetasyCertificados.Checked)
            {
                if (ValidarTodosLosCamposReceta_Certificado())
                {
                    this.BuscarRecetas();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            else if (chb_Certificado_VerRecetayCertificado.Checked)
            {
                if (ValidarTodosLosCamposReceta_Certificado())
                {
                    this.BuscarCertificado();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
        }

        public void BuscarRecetas()
        {
            BLReceta bLReceta = new BLReceta();
            //this.Receta = bLReceta.BuscarRecetas().ToList();

            DataTable tableReceta = new DataTable();
            tableReceta.Columns.Add("RecetaId");
            tableReceta.Columns.Add("FechaPrescripcion");
            tableReceta.Columns.Add("PacienteId");
            tableReceta.Columns.Add("ProfesionalId");
            tableReceta.Columns.Add("VacunaId");
            tableReceta.Columns.Add("Observacion");

            foreach (BEReceta receta in this.Receta)
            {
                DataRow filaReceta = tableReceta.NewRow();
                filaReceta["RecetaId"] = receta.RecetaId;
                filaReceta["FechaPrescripcion"] = receta.FechaPrescripcion;
                filaReceta["PacienteId"] = receta.Paciente.PacienteId;
                filaReceta["ProfesionalId"] = receta.Medico.ProfesionalId;
                filaReceta["VacunaId"] = receta.Vacuna.VacunaID;
                filaReceta["Observacion"] = receta.Observacion;

                tableReceta.Rows.Add(filaReceta);
            }
            DataView dataviewRecetas = new DataView(tableReceta);
            //dtg_Recetas_VerRecetasyCertificados.DataSource = TraerInformacionFiltrada(dataviewRecetas);
            //dgv_usuario.DataSource = dataviewMedicos;
            dtg_Recetas_VerRecetasyCertificados.Columns[0].Visible = false;
            dtg_Recetas_VerRecetasyCertificados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void BuscarCertificado()
        {

        }
    }
}
