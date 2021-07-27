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
    public partial class BuscarVacunasForm : Form
    {
        public BuscarVacunasForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_BuscarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_BuscarVacunas_Click(object sender, EventArgs e)
        {
            txt_IDVacuna_BuscarVacunas.Clear();
            txt_Nombre_BuscarVacunas.Clear();
        }
    }
}
