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
    public partial class VerHistoriaClinicaForm : Form
    {
        public VerHistoriaClinicaForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_VerHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
