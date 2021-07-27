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
    public partial class CrearCertificadoForm : Form
    {
        public CrearCertificadoForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_CrearCertificado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearCertificado_Click(object sender, EventArgs e)
        {
            txt_Edad_CrearCertificado.Clear();
            txt_NumeroDocumento_CrearCertificado.Clear();
            txt_apellido_CrearCertificado.Clear();
            lb_Detalle_CrearCertificado.Items.Clear();
        }

        private void btn_BuscarPacientes_CrearCertificado_Click(object sender, EventArgs e)
        {
            //BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            //buscarUsuariosForm.Show();
        }
    }
}
