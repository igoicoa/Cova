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
    public partial class ModificarCoberturaMedica : Form
    {
        public ModificarCoberturaMedica()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            txt_Nombre_ModificarCoberturaMedica.Clear();
            cmb_Plan_ModificarCoberturaMedica.Items.Clear();
            txt_Telefono_ModificarCoberturaMedica.Clear();
        }

        private void btn_BuscarCoberturaMedica_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            BuscarCoberturaMedica frmBuscarCoberturaMedica = new BuscarCoberturaMedica();
            frmBuscarCoberturaMedica.Show();
        }
    }
}
