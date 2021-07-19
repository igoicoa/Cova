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
    public partial class CargarCoberturaMedica : Form
    {
        public CargarCoberturaMedica()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_CargarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CargarCoberturaMedica_Click(object sender, EventArgs e)
        {
            txt_Nombre_CargarCoberturaMedica.Clear();
            cmb_Plan_CargarCoberturaMedica.Items.Clear();
            txt_Telefono_CargarCoberturaMedica.Clear();
        }
    }
}
