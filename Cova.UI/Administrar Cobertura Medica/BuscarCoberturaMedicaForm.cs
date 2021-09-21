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
    public partial class BuscarCoberturaMedicaForm : Form
    {
        public BuscarCoberturaMedicaForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_BuscarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_BuscarCoberturaMedica_Click(object sender, EventArgs e)
        {
            txt_Nombre_BuscarCoberturaMedica.Clear();
            cmb_Plan_BuscarCoberturaMedica.Items.Clear();
            txt_Telefono_BuscarCoberturaMedica.Clear();
        }
    }
}
