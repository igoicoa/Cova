using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cova.BL;

namespace Cova.UI
{
    public partial class CargarCoberturaMedicaForm : Form
    {
        public CargarCoberturaMedicaForm()
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
        }

        private void btn_Crear_CargarCoberturaMedica_Click(object sender, EventArgs e)
        {

        }
    }
}
