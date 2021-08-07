using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Cova.BE;
using Cova.Servicios.Sesion;
using Cova.BE.Enum;
using Cova.BL;

namespace Cova.UI
{
    public partial class CalendarioDeVacunaciónForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _paciente;
        private List<BEVacunaDosis> _vacunasEsquemaCompleto;
        private List<BEVacunaDosis> _vacunasEsquemaIncompleto;

        public CalendarioDeVacunaciónForm()
        {
            InitializeComponent();
            CargarPaciente();
        }

        public void CargarPaciente()
        {
            if (Sesion.GetInstance != null)
            {
                if(Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Paciente)
                {
                    CargarDatosPacienteLogueado();
                    CargarVacunasPaciente();
                    this.btn_BuscarPacientes_CalendarioVacunacion.Visible = false;
                }
            }
        }

        public void CargarDatosPacienteLogueado()
        {
            BLPaciente bLPaciente = new BLPaciente();
            long usuarioId = Sesion.GetInstance.Usuario.UsuarioID;
            string usuario = Sesion.GetInstance.Usuario.Usuario;
            this._paciente = bLPaciente.BuscarPacientes(usuario, "").ToList().Where(x => x.UsuarioID == usuarioId).FirstOrDefault();
            CargarDatosPaciente();
        }

        public void CargarVacunasPaciente()
        {
            CargarVacunasEsquemaCompletoPaciente();
            CargarVacunasEsquemaIncompletoPaciente();
        }

        public void CargarVacunasEsquemaCompletoPaciente()
        {
            BLPaciente bLPaciente = new BLPaciente();
            this._vacunasEsquemaCompleto = bLPaciente.ObtenerVacunasAplicadasEsquemaCompleto(this._paciente).ToList();

        }

        public void CargarVacunasEsquemaIncompletoPaciente()
        {
            BLPaciente bLPaciente = new BLPaciente();
            this._vacunasEsquemaCompleto = bLPaciente.ObtenerVacunasAplicadasEsquemaIncompleto(this._paciente).ToList();
        }

        public void CargarDatosPaciente()
        {
            this.txt_apellido_CalendarioVacunacion.Text = this._paciente.Apellido;
            this.txt_nombre_CalendarioVacunacion.Text = this._paciente.Nombre;
            this.txt_DNI_CalendarioVacunacion.Text = this._paciente.DNI.ToString();
            this.txt_edad_CalendarioVacunacion.Text = this._paciente.Edad.ToString();
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
            this._paciente = paciente;
            this.CargarDatosPaciente();
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
