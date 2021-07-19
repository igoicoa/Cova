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
    public partial class CrearVacunas : Form
    {
        public CrearVacunas()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_CrearVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearVacunas_Click(object sender, EventArgs e)
        {
            txtBox_Descripcion_CrearVacunas.Clear();
            txtBox_Nombre_CrearVacuna.Clear();
            txt_cantidadDosis_CrearVacunas.Clear();
            txt_Contraindicaciones_CrearVacunas.Clear();
            txt_Lote_CrearVacunas.Clear();
            txt_Prospecto_CrearVacunas.Clear();
            txt_stock_CrearVacunas.Clear();
            cmb_Laboratorio_CrearVacunas.Items.Clear();
        }
    }
}
