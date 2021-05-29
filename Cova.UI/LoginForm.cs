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
using Cova.BL;
using Cova.Servicios.Sesion;

namespace Cova.UI
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nombreUsuario = this.txt_usuario.Text;
            string password = this.txt_password.Text;
            BEUsuario usuario = new BEUsuario();
            BLUsuario usuarioBL = new BLUsuario();

            usuario.Usuario = nombreUsuario;
            usuario.Password = password;
            if(usuarioBL.Login(usuario))
            {
                Sesion.Login(usuario);
                MessageBox.Show("Usuario logueado correctamente");
                this.Close();
            } else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }
    }
}
