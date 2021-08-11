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
    public partial class ModificarVacunasForm : Form
    {
        public ModificarVacunasForm()
        {
            InitializeComponent();
        }

        private void btn_Buscar_ModificarVacunas_Click(object sender, EventArgs e)
        {
            BuscarVacunasForm frmBuscarVacunas = new BuscarVacunasForm();
            frmBuscarVacunas.Show();
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
            cmb_Laboratorio_ModificarVacunas.Items.Clear();
        }
    }
}
