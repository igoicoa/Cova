using Cova.BE;
using Cova.BL;
using Cova.Servicios.Sesion;
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
    public partial class CrearCertificadoForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _pacienteACertificar;
        private BEMedico _usuarioMedico;
        public CrearCertificadoForm()
        {
            InitializeComponent();
            CargarDatosMedico();
        }
        public void CargarDatosMedico()
        {
            string usuario = Sesion.GetInstance.Usuario.Usuario;
            long usuarioID = Sesion.GetInstance.Usuario.UsuarioID;
            BLMedico bLMedico = new BLMedico();
            try
            {
                this._usuarioMedico = bLMedico.BuscarMedicos(usuario, "").ToList().Where(x => x.UsuarioID == usuarioID).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ValidarTodosLosCamposReceta()
        {
            if (string.IsNullOrEmpty(txt_apellido_CrearCertificado.Text) || (string.IsNullOrEmpty(txt_nombre_CrearCertificado.Text))
                || (string.IsNullOrEmpty(txt_Edad_CrearCertificado.Text)) || string.IsNullOrEmpty(txt_NumeroDocumento_CrearCertificado.Text)
                || string.IsNullOrEmpty(richTextBox1.Text) || string.IsNullOrEmpty(dtp_fecha_CrearCertificado.Value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Cancelar_CrearCertificado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearCertificado_Click(object sender, EventArgs e)
        {
            txt_Edad_CrearCertificado.Clear();
            txt_NumeroDocumento_CrearCertificado.Clear();
            txt_apellido_CrearCertificado.Clear();
            txt_nombre_CrearCertificado.Clear();
        }

        private void btn_BuscarPacientes_CrearCertificado_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
            frmBuscarUsuarios.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente pacienteACertificar)
        {
            this._pacienteACertificar = pacienteACertificar;
            txt_apellido_CrearCertificado.Text = pacienteACertificar.Apellido;
            txt_nombre_CrearCertificado.Text = pacienteACertificar.Nombre;
            txt_Edad_CrearCertificado.Text = pacienteACertificar.Edad.ToString();
            txt_NumeroDocumento_CrearCertificado.Text = pacienteACertificar.DNI.ToString();
        }
        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }
        private void btnCrearReceta_CrearCertificado_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTodosLosCamposReceta())
                {
                    BLCertificado blCertificado = new BLCertificado();
                    BECertificado certificado = new BECertificado();
                    certificado.FechaPrescripcion = dtp_fecha_CrearCertificado.Value;
                    certificado.Paciente = this._pacienteACertificar;
                    certificado.Medico = this._usuarioMedico;
                    certificado.Observacion = richTextBox1.Text;
                    if (blCertificado.CrearReceta(certificado))
                    {
                        MessageBox.Show("El certificado fue creado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al crear el certificado");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
