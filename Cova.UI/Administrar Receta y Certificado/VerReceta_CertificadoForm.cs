using Cova.BE;
using Cova.BL;
using Cova.UI.Interfaces;
using Cova.Servicios.Sesion;
using Cova.BE.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cova.UI.Administrar_Receta_y_Certificado
{
    public partial class VerReceta_CertificadoForm : Form, IFormCargarUsuarios
    {
        private IFormCargarRecetas _formPadre;
        private BEPaciente _paciente;
        private List<BEReceta> _recetasPaciente;

        public VerReceta_CertificadoForm(IFormCargarRecetas formPadre = null)
        {
            InitializeComponent();
            this._formPadre = formPadre;
            if (this._formPadre == null)
            {
                this.btn_SeleccionarReceta.Visible = false;
            }
            if(Sesion.GetInstance != null)
            {
                if(Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Paciente)
                {
                    btn_BuscarPacientes__VerRecetasyCertificados.Visible = false;
                    BLPaciente bLPaciente = new BLPaciente();
                    long usuarioId = Sesion.GetInstance.Usuario.UsuarioID;
                    string usuario = Sesion.GetInstance.Usuario.Usuario;
                    this._paciente = bLPaciente.BuscarPacientes(usuario, "").ToList().Where(x => x.UsuarioID == usuarioId).FirstOrDefault();
                    CargarUsuarioPaciente(this._paciente);
                }
            }
        }

        public void CargarUsuarioPaciente(BEPaciente verRecetaPaciente)
        {
            this._paciente = verRecetaPaciente;
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
            this._recetasPaciente = bLReceta.BuscarRecetas(this._paciente).ToList();

            DataTable tableReceta = new DataTable();
            tableReceta.Columns.Add("RecetaId");
            tableReceta.Columns.Add("FechaPrescripcion");
            tableReceta.Columns.Add("Observacion");
            tableReceta.Columns.Add("Vacuna");
            tableReceta.Columns.Add("Medico Nombre");
            tableReceta.Columns.Add("Medico Apellido");
            tableReceta.Columns.Add("Medico MN");
            tableReceta.Columns.Add("Medico MP");

            foreach (BEReceta receta in this._recetasPaciente)
            {
                DataRow filaReceta = tableReceta.NewRow();
                filaReceta["RecetaId"] = receta.RecetaId;
                filaReceta["FechaPrescripcion"] = receta.FechaPrescripcion;
                filaReceta["Observacion"] = receta.Observacion;
                filaReceta["Vacuna"] = receta.Vacuna != null ? receta.Vacuna.Nombre : "-";
                filaReceta["Medico Nombre"] = receta.Medico.Nombre;
                filaReceta["Medico Apellido"] = receta.Medico.Apellido;
                filaReceta["Medico MN"] = receta.Medico.MatriculaNacional;
                filaReceta["Medico MP"] = receta.Medico.MatriculaProvincial;

                tableReceta.Rows.Add(filaReceta);
            }
            DataView dataviewRecetas = new DataView(tableReceta);
            dtg_Recetas_VerRecetasyCertificados.DataSource = dataviewRecetas;
            dtg_Recetas_VerRecetasyCertificados.Columns[0].Visible = false;
            dtg_Recetas_VerRecetasyCertificados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_Recetas_VerRecetasyCertificados.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void BuscarCertificado()
        {

        }

        private void btn_SeleccionarUsuario_BuscarUsuarios_Click(object sender, EventArgs e)
        {
            if (dtg_Recetas_VerRecetasyCertificados.SelectedRows.Count != 0)
            {
                long recetaId = Convert.ToInt64(dtg_Recetas_VerRecetasyCertificados.SelectedRows[0].Cells["RecetaId"].Value);
                this._formPadre.CargarRecetaPaciente(this._recetasPaciente.Where(x => x.RecetaId == recetaId).FirstOrDefault(), this._paciente);
                this.Close();
            }
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
