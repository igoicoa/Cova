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
    public partial class CrearVacunasForm : Form
    {
        private List<BELaboratorio> laboraorio;

        public CrearVacunasForm()
        {
            InitializeComponent();
            CargarLaboratorios();
        }

        private void btn_Cancelar_CrearVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearVacunas_Click(object sender, EventArgs e)
        {
            rtb_Descripcion_CrearVacunas.Clear();
            txtBox_Nombre_CrearVacuna.Clear();
            rtb_Contraindicaciones_CrearVacunas.Clear();
            rtb_Prospecto_CrearVacunas.Clear();
            cmb_Laboratorio_CrearVacunas.Items.Clear();
        }

        public void CargarLaboratorios()
        {
            BLLaboratorio bLLaboratorio = new BLLaboratorio();
            this.laboraorio = bLLaboratorio.ObtenerLaboratorios().ToList();

            this.cmb_Laboratorio_CrearVacunas.DataSource = laboraorio;
            this.cmb_Laboratorio_CrearVacunas.DisplayMember = "Nombre";
            this.cmb_Laboratorio_CrearVacunas.ValueMember = "LaboratorioId";
            this.cmb_Laboratorio_CrearVacunas.SelectedIndex = 0;
        }

        public bool ValidarTodosLosCamposVacuna()
        {
            if (string.IsNullOrEmpty(txtBox_Nombre_CrearVacuna.Text) || (string.IsNullOrEmpty(rtb_Descripcion_CrearVacunas.Text))
                || (string.IsNullOrEmpty(rtb_Prospecto_CrearVacunas.Text)) || string.IsNullOrEmpty(rtb_Contraindicaciones_CrearVacunas.Text)
                || string.IsNullOrEmpty(cb_cantidadDosis_CrearVacunas.Text) || string.IsNullOrEmpty(cb_Stock_CrearVacunas.Text)
                || string.IsNullOrEmpty(cmb_Laboratorio_CrearVacunas.Text) || string.IsNullOrEmpty(dtp_FechaElaboracion_CrearVacunas.Value.ToString())
                || string.IsNullOrEmpty(dtp_FechaVecnimiento_CrearVacunas.Value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Crear_CrearVacunas_Click(object sender, EventArgs e)
        {
            if (ValidarTodosLosCamposVacuna())
            {
                CrearVacuna();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }
        }

        public void CrearVacuna()
        {

        }
    }
}
