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
    public partial class ModificarCoberturaMedicaForm : Form
    {
        public ModificarCoberturaMedicaForm()
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
        }

        private void btn_BuscarCoberturaMedica_ModificarCoberturaMedica_Click(object sender, EventArgs e)
        {
            BuscarCoberturaMedicaForm frmBuscarCoberturaMedica = new BuscarCoberturaMedicaForm();
            frmBuscarCoberturaMedica.Show();
        }
    }
}
