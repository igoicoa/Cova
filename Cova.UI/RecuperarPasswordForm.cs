using System;
using System.Windows.Forms;
using Cova.BL;

namespace Cova.UI
{
    public partial class RecuperarPasswordForm : Form
    {
        public RecuperarPasswordForm()
        {
            InitializeComponent();
        }

        private void btn_recuperarPwd_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string email = txt_email.Text;
            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Debe completar su nombre de usuario y email");
                return;
            }
            try
            {
                BLUsuario bLUsuario = new BLUsuario();
                string emailUsuario = bLUsuario.ObtenerEmailUsuario(usuario, email);
                if (string.IsNullOrEmpty(emailUsuario))
                {
                    MessageBox.Show("Los datos ingresados no son correctos");
                }
                else
                {
                    if(bLUsuario.RecuperarPassword(usuario, emailUsuario))
                    {
                        MessageBox.Show("Se ha enviado una contraseña provisoria a " + emailUsuario);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al recuperar el usuario");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
