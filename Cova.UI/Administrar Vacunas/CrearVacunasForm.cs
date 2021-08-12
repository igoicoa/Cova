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
                || string.IsNullOrEmpty(cb_cantidadDosis_CrearVacunas.Text) || string.IsNullOrEmpty(txt_EdadMaxima.Text) || string.IsNullOrEmpty(txt_EdadMaxima.Text)
                || string.IsNullOrEmpty(cmb_Laboratorio_CrearVacunas.Text) )
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
            BLVacuna bLVacuna = new BLVacuna();
            BEVacuna vacunaNueva = new BEVacuna();
            vacunaNueva.Nombre = txtBox_Nombre_CrearVacuna.Text;
            vacunaNueva.Prospecto = rtb_Prospecto_CrearVacunas.Text;
            vacunaNueva.EdadMinimaAplicacion = Convert.ToInt32(txt_EdadMinima.Text);
            vacunaNueva.EdadMaximaAplicacion = Convert.ToInt32(txt_EdadMaxima.Text);
            vacunaNueva.Contraindicaciones = rtb_Contraindicaciones_CrearVacunas.Text;
            vacunaNueva.Descripcion = rtb_Descripcion_CrearVacunas.Text;
            vacunaNueva.CantidadDosis = Convert.ToInt32(cb_cantidadDosis_CrearVacunas.Text);
            vacunaNueva.Laboratorio = (BELaboratorio)cmb_Laboratorio_CrearVacunas.SelectedItem;
            try
            {
                if(bLVacuna.CrearVacuna(vacunaNueva))
                {
                    MessageBox.Show("Vacuna creada con exito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear la vacuna");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
