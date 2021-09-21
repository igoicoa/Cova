using Cova.UI.Administrar_Receta_y_Certificado;
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
    public partial class ModificarRecetas_CertificadosForm : Form
    {
        public ModificarRecetas_CertificadosForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_CrearRecetayCertificado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_Receta_CrearRecetayCertificado_CheckedChanged(object sender, EventArgs e)
        {
            ModificarRecetasForm frmModificarRecetas = new ModificarRecetasForm();
            frmModificarRecetas.Show();
            this.Close();
        }

        private void rb_Certificado_CrearRecetayCertificado_CheckedChanged(object sender, EventArgs e)
        {
            ModificarCertificadoForm frmModificarCertificado = new ModificarCertificadoForm();
            frmModificarCertificado.Show();
            this.Close();
        }
    }
}
