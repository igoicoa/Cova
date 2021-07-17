using System;
using System.Windows.Forms;
using Cova.BE;
using Cova.Common.Multiidioma;
using Cova.BL;
using Cova.Servicios.Sesion;
using Cova.Servicios.Multiidioma;

namespace Cova.UI
{
    public partial class LoginForm : Form
    {
        private MainForm _MainForm;
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            this._MainForm = mainForm;
            CargarIdiomas();
        }

        public void CargarIdiomas()
        {
            Idioma idiomaDefault = new Idioma();
            ManejadorIdioma manejadorIdioma = new ManejadorIdioma(idiomaDefault);
            cmb_idiomasLogin.DataSource = manejadorIdioma.ObtenerIdiomas();
            cmb_idiomasLogin.DisplayMember = "Nombre";
            cmb_idiomasLogin.ValueMember = "Nombre";
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string nombreUsuario = this.txt_usuario.Text;
            string password = this.txt_password.Text;
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();
            Idioma idiomaElegido = new Idioma();
            idiomaElegido.Nombre = cmb_idiomasLogin.SelectedValue.ToString();
            usuario.Usuario = nombreUsuario;
            usuario.Password = password;
            if(usuarioBL.Login(ref usuario))
            {
                Sesion.Login(usuario, idiomaElegido);
                MessageBox.Show("Usuario logueado correctamente");
                this._MainForm.InicializarMainForm();
                this.Close();
            } else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }
    }
}
