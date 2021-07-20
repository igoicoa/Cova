using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cova.BE;

namespace Cova.UI
{
    public partial class ModificarCuentaForm : Form
    {
        private BEUsuario _usuarioAModificar;
        public ModificarCuentaForm()
        {
            InitializeComponent();
        }

        public void CargarUsuario(BEUsuario usuarioAModificar)
        {
            this._usuarioAModificar = usuarioAModificar;
            //TODO Cargar datos en los textbox
        }

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuarios frmBuscarUsuarios = new BuscarUsuarios(this);
            frmBuscarUsuarios.Show();
        }

        private void btnCancelar_ModificarCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_ModificarCuenta_Click(object sender, EventArgs e)
        {
            txtBox_ModificarCuentaNombre.Clear();
            txt_documentoNumeroModificarCuenta.Clear();
            textBoxUsuario_ModificarCuenta.Clear();
            txt_Clave_ModificarCuenta.Clear();
            textBoxTelefono_ModifCuenta.Clear();
            /*pictureBoxImagen_CrearCuenta.Clear();*/
            txtEmail_ModificarCuenta.Clear();
            textBoxApellidoModificarCuenta.Clear();
            textBoxEstadoCivil_ModificarCuenta.Clear();
            textBoxCalle_ModificarCuenta.Clear();
            txt_NumeroModificarCuenta.Clear();
            txt_pisoModificarCuenta.Clear();
            txtLocalidad_ModificarCuenta.Clear();
            txtProvincia_ModificarCuenta.Clear();
            txt_matriculaProvincialModificarCuenta.Clear();
            txt_matriculaNacionalModificarCuenta.Clear();
            txt_numeroAfiliado_ModificarCuenta.Clear();
        }

        private void textBoxUsuario_ModificarCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxUsuario_ModificarCuenta_Click(object sender, EventArgs e)
        {

        }
    }
}
