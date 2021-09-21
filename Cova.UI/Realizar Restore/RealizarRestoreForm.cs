using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cova.UI.Realizar_Restore
{
    public partial class RealizarRestoreForm : Form
    {
        public RealizarRestoreForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_RealizarRestore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
