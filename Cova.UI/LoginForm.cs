using System;
using System.Windows.Forms;
using Cova.BE;
using Cova.Common.Multiidioma;
using Cova.BL;
using Cova.Servicios.Sesion;
using Cova.Servicios.Multiidioma;
using Cova.Servicios.DigitoVerificador;

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
            try
            {
                if (usuarioBL.Login(ref usuario))
                {
                    Sesion.Login(usuario, idiomaElegido);
                    if(ValidarIntegridadBDD())
                    {
                        MessageBox.Show("Usuario logueado correctamente");
                        this._MainForm.InicializarMainForm();
                        this.Close();
                    }
                    else
                    {
                        if(Sesion.GetInstance.Usuario.TipoUsuario == BE.Enum.TipoUsuario.Administrador)
                        {
                            MessageBox.Show("Hay un error de integridad en las tablas de BDD. Realice los arreglos necesarios en la BDD");
                            this._MainForm.InicializarModoRestoreBDD();
                            this.Close();
                        } 
                        else
                        {
                            MessageBox.Show("Hay un error de integridad en las tablas de BDD. Contactese con su administrador");
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ValidarIntegridadBDD()
        {
            return (DigitoVerificador.ValidarDVV("VacunaDosis") && DigitoVerificador.ValidarDVH("VacunaDosis"));
        }
    }
}
