using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cova.UI.Control_de_Cambios
{
    public partial class ControlDeCambioForm : Form
    {
        public ControlDeCambioForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_ControlCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
