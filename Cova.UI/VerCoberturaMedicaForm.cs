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
    public partial class VerCoberturaMedicaForm : Form
    {
        public VerCoberturaMedicaForm()
        {
            InitializeComponent();
        }

        private void btn_Limpiar_VerCoberturaMedica_Click(object sender, EventArgs e)
        {
            txt_IDCobertura_VerCoberturaMedica.Clear();
            cmb_Plan_VerCoberturaMedica.Items.Clear();
            txt_Telefono_VerCoberturaMedica.Clear();
            txt_Nombre_VerCoberturaMedica.Clear();
        }

        private void btn_Cancelar_VerCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
