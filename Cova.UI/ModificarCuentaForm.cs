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
            this.textBoxApellidoModificarCuenta.Text = usuarioAModificar.ToString();
            this.comboBoxTipoDocumento_ModificarCuenta.Text = usuarioAModificar.ToString();
            this.txt_documentoNumeroModificarCuenta.Text = _usuarioAModificar.ToString();
            this.textBoxUsuario_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txt_Clave_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.textBoxTelefono_ModifCuenta.Text = _usuarioAModificar.ToString();
            this.txtBox_ModificarCuentaNombre.Text = _usuarioAModificar.ToString();
            this.txtEmail_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.textBoxApellidoModificarCuenta.Text = _usuarioAModificar.ToString();
            this.textBoxEstadoCivil_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.radioButtonMasculino_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.radioButtonFemenino_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.cmb_EstadoModificarCuenta.Text = _usuarioAModificar.ToString();
            this.textBoxCalle_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txt_NumeroModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txt_pisoModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txtLocalidad_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txtProvincia_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txtEmail_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.textBoxEstadoCivil_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.cmb_EstadoModificarCuenta.Text = _usuarioAModificar.ToString();
            this.chk_particular_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.cmb_coberturaMedica_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.cmb_Plan_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txt_numeroAfiliado_ModificarCuenta.Text = _usuarioAModificar.ToString();
            //this.dtp_fechaVencimiento_ModificarCuenta.Text = _usuarioAModificar.ToString();
            this.gb_pacienteModificarCuenta.Text = _usuarioAModificar.ToString();
            this.gb_ProfesionalModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txt_matriculaNacionalModificarCuenta.Text = _usuarioAModificar.ToString();
            this.txt_matriculaProvincialModificarCuenta.Text = _usuarioAModificar.ToString();
            this.cmb_especialidadModificarCuenta.Text = _usuarioAModificar.ToString();
        }

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(this);
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
