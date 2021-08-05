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
using Cova.Servicios.Sesion;
using Cova.BE.Enum;

namespace Cova.UI
{
    public partial class CalendarioDeVacunaciónForm : Form, IFormCargarUsuarios
    {
        public CalendarioDeVacunaciónForm()
        {
            InitializeComponent();
            CargarDatosPaciente();
        }

        public void CargarDatosPaciente()
        {
            if (Sesion.GetInstance != null)
            {
                if(Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Paciente)
                {
                    //TODO Cargar datos del paciente logueado y cargar sus vacunas
                    this.btn_BuscarPacientes_CalendarioVacunacion.Visible = false;
                }
            }
        }
        private void btnCancelar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            txt_apellido_CalendarioVacunacion.Clear();
            txt_DNI_CalendarioVacunacion.Clear();
            txt_edad_CalendarioVacunacion.Clear();
            txt_nombre_CalendarioVacunacion.Clear();
        }

        private void btn_BuscarPacientes_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente paciente)
        {
            this.txt_apellido_CalendarioVacunacion.Text = paciente.Apellido;
            this.txt_nombre_CalendarioVacunacion.Text = paciente.Nombre;
            this.txt_edad_CalendarioVacunacion.Text = paciente.Edad.ToString();
            this.txt_DNI_CalendarioVacunacion.Text = paciente.DNI.ToString();
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }
    
        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }
    }
}
