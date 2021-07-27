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
    public partial class CrearRecetas_CertificadosForm : Form
    {
        public CrearRecetas_CertificadosForm()
        {
            InitializeComponent();
        }

        private void btn_BuscarPacientes_CrearRecetasyCertificados_Click(object sender, EventArgs e)
        {
            //BuscarPacientesForm frmBuscarPacientes = new BuscarPacientesForm();
            //frmBuscarPacientes.Show();
        }

        private void rb_Receta_CrearRecetayCertificado_CheckedChanged(object sender, EventArgs e)
        {
            CrearRecetasForm frmCrearRecetas = new CrearRecetasForm();
            frmCrearRecetas.Show();
        }

        private void btnCancelar_CrearRecetayCertificado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_Certificado_CrearRecetayCertificado_CheckedChanged(object sender, EventArgs e)
        {
            CrearCertificadoForm frmCrearCertificado = new CrearCertificadoForm();
            frmCrearCertificado.Show();
        }
    }
}
