using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;

namespace Cova.UI.Administrar_Turnos
{
    public partial class BuscarProfesionalForm : Form
    {
        public BuscarProfesionalForm()
        {
            InitializeComponent();
            CargarEspecialidades();
        }

        public void CargarEspecialidades()
        {
            this.cmb_especialidad.DataSource = Enum.GetNames(typeof(Especialidad));
            this.cmb_especialidad.SelectedIndex = -1;
            this.cmb_especialidad.SelectedIndex = 0;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            BLMedico bLProfesional = new BLMedico();
            try
            {
                string profesionalApellido = txt_profesionalApellido.Text;
                string profesionalNombre = txt_profesionalNombre.Text;
                Especialidad profesionalEspecialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cmb_especialidad.SelectedItem.ToString());

                if (string.IsNullOrEmpty(profesionalApellido) || string.IsNullOrEmpty(profesionalNombre) || cmb_especialidad.SelectedIndex != 0)
                {
                    MessageBox.Show("Debe escribir al menos 1 criterio de busqueda");
                    return;
                }
                List<BEMedico> medicos = (List<BEMedico>)bLProfesional.BuscarMedicos(profesionalApellido, profesionalNombre, profesionalEspecialidad);
                DataTable tableMedicos = new DataTable();
                tableMedicos.Columns.Add("ProfesionalId");
                tableMedicos.Columns.Add("Nombre");
                tableMedicos.Columns.Add("Apellido");
                tableMedicos.Columns.Add("Fecha Nacimiento");
                tableMedicos.Columns.Add("Sexo");
                tableMedicos.Columns.Add("Especialidad");
                tableMedicos.Columns.Add("Matricula Nacional");
                tableMedicos.Columns.Add("Matricula Provincial");

                foreach (BEMedico medico in medicos)
                {
                    DataRow filaMedico = tableMedicos.NewRow();
                    filaMedico["ProfesionalId"] = medico.UsuarioID;
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
    }
}
