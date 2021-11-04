using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;

namespace Cova.UI
{
    public partial class ModificarVacunasForm : Form
    {
        private BEVacuna _vacunaAModificar;

        public ModificarVacunasForm()
        {
            InitializeComponent();
            CargarLaboratorios();
            CargarVacunas();
        }

        public void CargarLaboratorios()
        {
            BLLaboratorio bLLaboratorio = new BLLaboratorio();
            try
            {
                List<BELaboratorio> laboratorios = (List<BELaboratorio>)bLLaboratorio.ObtenerLaboratorios();
                this.cmb_Laboratorio_ModificarVacunas.DataSource = laboratorios;
                this.cmb_Laboratorio_ModificarVacunas.DisplayMember = "Nombre";
                this.cmb_Laboratorio_ModificarVacunas.ValueMember = "LaboratorioId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarVacunas()
        {
            BLVacuna bLVacuna = new BLVacuna();
            try
            {
                this.cmb_Vacunas.DataSource = bLVacuna.ObtenerVacunas();
                this.cmb_Vacunas.DisplayMember = "Nombre";
                this.cmb_Vacunas.ValueMember = "VacunaId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_Vacunas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._vacunaAModificar = (BEVacuna)this.cmb_Vacunas.SelectedItem;
            if(this._vacunaAModificar != null)
            {
                this.CargarDatosVacunaAModificar();
            }
        }

        public void CargarDatosVacunaAModificar()
        {
            this.txt_Nombre_ModificarVacunas.Text = this._vacunaAModificar.Nombre;
            this.txt_EdadMinima.Text = this._vacunaAModificar.EdadMinimaAplicacion.ToString();
            this.txt_EdadMaxima.Text = this._vacunaAModificar.EdadMaximaAplicacion.ToString();
            this.rtb_Prospecto_ModificarVacunas.Text = this._vacunaAModificar.Prospecto;
            this.rtb_Descripcion_ModificarVacunas.Text = this._vacunaAModificar.Descripcion;
            this.rtb_Contraindicaciones_ModificarVacunas.Text = this._vacunaAModificar.Contraindicaciones;
            this.cmb_CantidadDosis_ModificarVacunas.Text = this._vacunaAModificar.CantidadDosis.ToString();
            this.cmb_Laboratorio_ModificarVacunas.Text = this._vacunaAModificar.Laboratorio.Nombre;
        }

        private void btn_Cancelar_ModificarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_ModificarVacunas_Click(object sender, EventArgs e)
        {
            rtb_Descripcion_ModificarVacunas.Clear();
            txt_Nombre_ModificarVacunas.Clear();
            rtb_Contraindicaciones_ModificarVacunas.Clear();
            rtb_Prospecto_ModificarVacunas.Clear();
        }

        private void btn_Modificar_ModificarVacunas_Click(object sender, EventArgs e)
        {
            BLVacuna bLVacuna = new BLVacuna();
            try
            {
                this._vacunaAModificar.Nombre = txt_Nombre_ModificarVacunas.Text;
                this._vacunaAModificar.EdadMinimaAplicacion = Convert.ToInt32(txt_EdadMinima.Text);
                this._vacunaAModificar.EdadMaximaAplicacion = Convert.ToInt32(txt_EdadMaxima.Text);
                this._vacunaAModificar.Descripcion = rtb_Descripcion_ModificarVacunas.Text;
                this._vacunaAModificar.Contraindicaciones = rtb_Contraindicaciones_ModificarVacunas.Text;
                this._vacunaAModificar.Prospecto = rtb_Prospecto_ModificarVacunas.Text;
                this._vacunaAModificar.Laboratorio = (BELaboratorio)cmb_Laboratorio_ModificarVacunas.SelectedItem;
                this._vacunaAModificar.CantidadDosis = Convert.ToInt32(cmb_CantidadDosis_ModificarVacunas.Text);
                if(bLVacuna.ModificarVacuna(this._vacunaAModificar))
                {
                    MessageBox.Show("Vacuna modificada con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al modificar la vacuna");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
