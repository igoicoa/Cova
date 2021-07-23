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
    public partial class CrearRecetasForm : Form
    {
        public CrearRecetasForm()
        {
            InitializeComponent();
        }

        private void btn_BuscarPacientes_CrearReceta_Click(object sender, EventArgs e)
        {
            BuscarPacientesForm frmBuscarPacientes = new BuscarPacientesForm();
            frmBuscarPacientes.Show();
        }

        private void btn_Cancelar_CrearReceta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearReceta_Click(object sender, EventArgs e)
        {
            txt_Edad_CrearReceta.Clear();
            txt_NumeroDocumento_CrearReceta.Clear();
            txt_apellido_CrearReceta.Clear();
            txt_Edad_CrearReceta.Clear();
            txt_nombre_CrearReceta.Clear();
            lb_DetalleDiagnostico_CrearReceta.Items.Clear();
        }
    }
}
