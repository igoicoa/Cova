using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cova.UI.Bitacora
{
    public partial class BitacoraForm : Form
    {
        public BitacoraForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Bitacora_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Bitacora_Click(object sender, EventArgs e)
        {
            txt_Usuario_Bitacora.Clear();
        }
    }
}
