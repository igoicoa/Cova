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
    public partial class AplicarVacunaForm : Form
    {
        public AplicarVacunaForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            txt_Dosis_AplicarVacunas.Clear();
            txt_Paciente_AplicarVacunas.Clear();
            txt_Observacion_AplicarVacunas.Clear();
            txt_CentrodeVacunacion_AplicarVacunas.Clear();
        }
    }
}
