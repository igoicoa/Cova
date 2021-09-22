using Cova.BE;
using Cova.BL;
using Cova.Servicios.Sesion;
using Cova.UI.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cova.UI.Administrar_Receta_y_Certificado
{
    public partial class ModificarCertificadoForm : Form, IFormCargarRecetasCertificados
    {
        private BEMedico _usuarioMedico;
        private BEPaciente _pacienteAModificarCertificado;
        private BECertificado _certificadoAModificar;
        public ModificarCertificadoForm()
        {
            InitializeComponent();
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
        public bool ValidarTodosLosCamposCertificadoAModificar()
        {
            if (string.IsNullOrEmpty(txt_NumeroDocumento_ModificarCertificado.Text) || (string.IsNullOrEmpty(txt_Edad_ModificarCertificado.Text))
                || (string.IsNullOrEmpty(txt_nombre_ModificarCertificado.Text)) || string.IsNullOrEmpty(txt_apellido_ModificarCertificado.Text)
                || string.IsNullOrEmpty(dtp_fecha__ModificarCertificado.Value.ToString())
                || string.IsNullOrEmpty(rtxt_Diagnostico_ModificarCertificado.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CargarCertificadoPaciente(BECertificado certificado, BEPaciente paciente)
        {
            this._pacienteAModificarCertificado = paciente;
            this._certificadoAModificar = certificado;
            txt_apellido_ModificarCertificado.Text = paciente.Apellido;
            txt_nombre_ModificarCertificado.Text = paciente.Nombre;
            txt_Edad_ModificarCertificado.Text = paciente.Edad.ToString();
            txt_NumeroDocumento_ModificarCertificado.Text = paciente.DNI.ToString();
            rtxt_Diagnostico_ModificarCertificado.Text = certificado.Observacion;
            dtp_fecha__ModificarCertificado.Value = certificado.FechaPrescripcion;
        }

        private void btn_Cancelar_ModificarCertificado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_ModificarCertificado_Click(object sender, EventArgs e)
        {
            txt_Edad_ModificarCertificado.Clear();
            txt_NumeroDocumento_ModificarCertificado.Clear();
            txt_apellido_ModificarCertificado.Clear();
            txt_Edad_ModificarCertificado.Clear();
            txt_nombre_ModificarCertificado.Clear();
            rtxt_Diagnostico_ModificarCertificado.Clear();
        }

        private void btn__ModificarCertificado_Click(object sender, EventArgs e)
        {
            VerReceta_CertificadoForm frmVerReceta_Certificado = new VerReceta_CertificadoForm(this, false);
            frmVerReceta_Certificado.Show();
        }

        private void btn_ModificarCertificado_Click(object sender, EventArgs e)
        {
            BLCertificado bLCertificado = new BLCertificado();
            try
            {
                this._certificadoAModificar.FechaPrescripcion = dtp_fecha__ModificarCertificado.Value;
                this._certificadoAModificar.Observacion = rtxt_Diagnostico_ModificarCertificado.Text;
                if (ValidarTodosLosCamposCertificado())
                {
                    if (bLCertificado.ActualizarCertificado(this._certificadoAModificar))
                    {
                        MessageBox.Show("Certificado modificada con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al modificar el certificado");
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
        public void ActualizarCertificado()
        {
            BECertificado CertificadoActualizada = new BECertificado();

            CertificadoActualizada.FechaPrescripcion = dtp_fecha__ModificarCertificado.Value;
            CertificadoActualizada.Observacion = rtxt_Diagnostico_ModificarCertificado.Text;

            BLCertificado bLReceta = new BLCertificado();
            try
            {
                if (bLReceta.ActualizarCertificado(CertificadoActualizada))
                {
                    MessageBox.Show("Certificado actualizado con exito");
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el Certificado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool ValidarTodosLosCamposCertificado()
        {
            if (string.IsNullOrEmpty(txt_apellido_ModificarCertificado.Text) || (string.IsNullOrEmpty(txt_nombre_ModificarCertificado.Text))
                || (string.IsNullOrEmpty(txt_Edad_ModificarCertificado.Text)) || string.IsNullOrEmpty(txt_NumeroDocumento_ModificarCertificado.Text)
                || string.IsNullOrEmpty(rtxt_Diagnostico_ModificarCertificado.Text) || string.IsNullOrEmpty(dtp_fecha__ModificarCertificado.Value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void CargarRecetaPaciente(BEReceta receta, BEPaciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
