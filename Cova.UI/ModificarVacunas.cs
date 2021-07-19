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
    public partial class ModificarVacunas : Form
    {
        public ModificarVacunas()
        {
            InitializeComponent();
        }

        private void btn_Buscar_ModificarVacunas_Click(object sender, EventArgs e)
        {
            BuscarVacunas frmBuscarVacunas = new BuscarVacunas();
            frmBuscarVacunas.Show();
        }

        private void btn_Cancelar_ModificarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
