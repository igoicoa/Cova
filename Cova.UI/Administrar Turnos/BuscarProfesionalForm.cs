using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;
using Cova.UI.Interfaces;

namespace Cova.UI.Administrar_Turnos
{
    public partial class BuscarProfesionalForm : Form
    {
        private IFormCargarMedicos _formPadre;
        private List<BEMedico> _medicos;
        public BuscarProfesionalForm(IFormCargarMedicos formPadre = null)
        {
            this._formPadre = formPadre;
            InitializeComponent();
            CargarEspecialidades();
        }

        public void CargarEspecialidades()
        {
            this.cmb_especialidad.DataSource = Enum.GetNames(typeof(Especialidad));
            this.cmb_especialidad.SelectedIndex = -1;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BLMedico bLProfesional = new BLMedico();
            try
            {
                string profesionalApellido = txt_profesionalApellido.Text;
                string profesionalNombre = txt_profesionalNombre.Text;
                Especialidad? profesionalEspecialidad = null;
                if (this.cmb_especialidad.SelectedIndex != -1)
                {
                    profesionalEspecialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cmb_especialidad.SelectedItem.ToString());
                }
                    
                if (string.IsNullOrEmpty(profesionalApellido) && string.IsNullOrEmpty(profesionalNombre) && cmb_especialidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe escribir al menos 1 criterio de busqueda");
                    return;
                }
                this._medicos = (List<BEMedico>)bLProfesional.BuscarMedicos(profesionalApellido, profesionalNombre, profesionalEspecialidad);
                DataTable tableMedicos = new DataTable();
                tableMedicos.Columns.Add("ProfesionalId");
                tableMedicos.Columns.Add("Nombre");
                tableMedicos.Columns.Add("Apellido");
                tableMedicos.Columns.Add("Fecha Nacimiento");
                tableMedicos.Columns.Add("Sexo");
                tableMedicos.Columns.Add("Especialidad");
                tableMedicos.Columns.Add("Matricula Nacional");
                tableMedicos.Columns.Add("Matricula Provincial");

                foreach (BEMedico medico in this._medicos)
                {
                    DataRow filaMedico = tableMedicos.NewRow();
                    filaMedico["ProfesionalId"] = medico.ProfesionalId;
                    filaMedico["Nombre"] = medico.Nombre;
                    filaMedico["Apellido"] = medico.Apellido;
                    filaMedico["Fecha Nacimiento"] = medico.FechaNacimiento;
                    filaMedico["Sexo"] = medico.Sexo;
                    filaMedico["Especialidad"] = medico.Especialidad;
                    filaMedico["Matricula Nacional"] = medico.MatriculaNacional;
                    filaMedico["Matricula Provincial"] = medico.MatriculaProvincial;
                    tableMedicos.Rows.Add(filaMedico);
                }
                DataView dataviewMedicos = new DataView(tableMedicos);
                dgv_medicos.DataSource = dataviewMedicos;
                dgv_medicos.Columns[0].Visible = false;
                dgv_medicos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_medicos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_medicos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_medicos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_medicos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_medicos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_medicos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if (this._formPadre != null)
            {
                if (dgv_medicos.SelectedRows.Count != 0)
                {
                    long profesionalId = Convert.ToInt64(dgv_medicos.SelectedRows[0].Cells["ProfesionalId"].Value);
                    this._formPadre.CargarUsuarioMedico(this._medicos.Where(x => x.ProfesionalId == profesionalId).FirstOrDefault());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un medico");
                }
            }
        }
    }
}
