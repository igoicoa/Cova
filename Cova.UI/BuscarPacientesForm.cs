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
    public partial class BuscarPacientesForm : Form
    {
        public BuscarPacientesForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_BuscarPacientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_BuscarPacientes_Click(object sender, EventArgs e)
        {
            txt_apellido_BuscarPacientes.Clear();
            txt_Edad_BuscarPacientes.Clear();
            txt_nombre_BuscarPacientes.Clear();
            txt_NumeroDocumento_BuscarPacientes.Clear();
        }
    }
}
