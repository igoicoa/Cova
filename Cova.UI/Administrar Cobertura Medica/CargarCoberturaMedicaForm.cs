using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Cova.BL;
using Cova.BE;

namespace Cova.UI
{
    public partial class CargarCoberturaMedicaForm : Form
    {
        private DataView _dataviewPlanes;
        private List<string> _planes;

        public CargarCoberturaMedicaForm()
        {
            InitializeComponent();
            CargarTablaPlanes();
            this._planes = new List<string>();
        }

        public void CargarTablaPlanes()
        {
            DataTable tableplanes = new DataTable();
            tableplanes.Columns.Add("Nombre Plan");
            this._dataviewPlanes = new DataView(tableplanes);
            dgv_planes.DataSource = this._dataviewPlanes;
            dgv_planes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_planes.Visible = false;
        }
        
        private void btn_Cancelar_CargarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CargarCoberturaMedica_Click(object sender, EventArgs e)
        {
            txt_Nombre_CargarCoberturaMedica.Clear();
        }

        private void btn_Crear_CargarCoberturaMedica_Click(object sender, EventArgs e)
        {
            BLCoberturaMedica bLCoberturaMedica = new BLCoberturaMedica();
            BECoberturaMedica coberturaMedica = new BECoberturaMedica();
            try
            {
                if(ValidarCamposCobertura())
                {
                    coberturaMedica.Nombre = this.txt_Nombre_CargarCoberturaMedica.Text;
                    foreach (string plan in this._planes)
                    {
                        BECoberturaMedicaPlan coberturaPlan = new BECoberturaMedicaPlan();
                        coberturaPlan.Nombre = plan;
                        coberturaMedica.Plan.Add(coberturaPlan);
                    }
                    if(bLCoberturaMedica.CrearCoberturaMedica(coberturaMedica))
                    {
                        MessageBox.Show("Cobertura Medica creada con exito");
                        this.Close();
                    } 
                    else
                    {
                        MessageBox.Show("Hubo un error al crear la cobertura medica");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre de la cobertura y agregar al menos 1 plan");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidarCamposCobertura()
        {
            if(string.IsNullOrEmpty(txt_Nombre_CargarCoberturaMedica.Text) || this._planes.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this._planes.Add(this.txt_NombrePlan.Text);
            DataRow filaPlan = this._dataviewPlanes.Table.NewRow();
            filaPlan["Nombre Plan"] = this.txt_NombrePlan.Text;
            this._dataviewPlanes.Table.Rows.Add(filaPlan);
            this.txt_NombrePlan.Text = string.Empty;
            if (this._planes.Count != 0)
            {
                this.dgv_planes.Visible = true;
            }
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            if (dgv_planes.SelectedRows.Count != 0)
            {
                string plan = Convert.ToString(dgv_planes.SelectedRows[0].Cells["Nombre Plan"].Value);
                this._planes.Remove(plan);
                dgv_planes.Rows.Remove(dgv_planes.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan para quitar");
            }
            if (this._planes.Count == 0)
            {
                this.dgv_planes.Visible = false;
            }
        }
    }
}
