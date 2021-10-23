using Cova.BE;
using Cova.UI.Interfaces;
using System;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using Cova.BL;

namespace Cova.UI
{
    public partial class ModificarCoberturaMedicaForm : Form, IFormCargarCoberturas
    {
        private DataView _dataviewPlanes;
        private BECoberturaMedica _coberturaAModificar;

        public ModificarCoberturaMedicaForm()
        {
            InitializeComponent();
            CargarTablaPlanes();
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

        private void btn_Cancelar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            txt_Nombre_ModificarCoberturaMedica.Clear();
        }

        private void btn_BuscarCoberturaMedica_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            BuscarCoberturaMedicaForm frmBuscarCoberturaMedica = new BuscarCoberturaMedicaForm(this);
            frmBuscarCoberturaMedica.Show();
        }

        public void CargarCobertura(BECoberturaMedica cobertura)
        {
            this._dataviewPlanes.Table.Clear();
            this._coberturaAModificar = cobertura;
            this.txt_Nombre_ModificarCoberturaMedica.Text = cobertura.Nombre;
            foreach(BECoberturaMedicaPlan plan in cobertura.Plan)
            {
                DataRow filaPlan = this._dataviewPlanes.Table.NewRow();
                filaPlan["Nombre Plan"] = plan.Nombre;
                this._dataviewPlanes.Table.Rows.Add(filaPlan);
            }
            this.dgv_planes.Visible = true;
        }

        private void btn_Agregar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this._coberturaAModificar.Plan.Add(new BECoberturaMedicaPlan(this.txt_NombrePlan__ModificarCoberturaMedica.Text));
            DataRow filaPlan = this._dataviewPlanes.Table.NewRow();
            filaPlan["Nombre Plan"] = this.txt_NombrePlan__ModificarCoberturaMedica.Text;
            this._dataviewPlanes.Table.Rows.Add(filaPlan);
            this.txt_NombrePlan__ModificarCoberturaMedica.Text = string.Empty;
            if (this._coberturaAModificar.Plan.Count != 0)
            {
                this.dgv_planes.Visible = true;
            }
        }

        private void btn_Quitar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            if (dgv_planes.SelectedRows.Count != 0)
            {
                string plan = Convert.ToString(dgv_planes.SelectedRows[0].Cells["Nombre Plan"].Value);
                this._coberturaAModificar.Plan = this._coberturaAModificar.Plan.Where(x => x.Nombre != plan).ToList();
                dgv_planes.Rows.Remove(dgv_planes.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan para quitar");
            }
            if (this._coberturaAModificar.Plan.Count == 0)
            {
                this.dgv_planes.Visible = false;
            }
        }

        private void btn_Modificar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            BLCoberturaMedica bLCoberturaMedica = new BLCoberturaMedica();
            try
            {
                if (ValidarCamposCobertura())
                {
                    this._coberturaAModificar.Nombre = this.txt_Nombre_ModificarCoberturaMedica.Text;
                    if (bLCoberturaMedica.ModificarCoberturaMedica(this._coberturaAModificar))
                    {
                        MessageBox.Show("Cobertura Medica modificada con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al modificar la cobertura medica");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el nombre de la cobertura y agregar al menos 1 plan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidarCamposCobertura()
        {
            if (string.IsNullOrEmpty(txt_Nombre_ModificarCoberturaMedica.Text) || this._coberturaAModificar.Plan.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
