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

namespace Cova.UI.Administrar_Receta_y_Certificado
{
    public partial class ModificarRecetasForm : Form, IFormCargarUsuarios
    {
        private BEMedico _usuarioMedico;
        private BEPaciente _pacienteAModificarRecetar;

        public ModificarRecetasForm()
        {
            InitializeComponent();
            CargarVacunas();
        }

        public void CargarDatosMedico()
        {
            string usuario = Sesion.GetInstance.Usuario.Usuario;
            long usuarioID = Sesion.GetInstance.Usuario.UsuarioID;
            BLMedico bLMedico = new BLMedico();
            this._usuarioMedico = bLMedico.BuscarMedicos(usuario, "").ToList().Where(x => x.UsuarioID == usuarioID).FirstOrDefault();
        }

        public void CargarVacunas()
        {
            BLVacuna bLVacuna = new BLVacuna();
            this.cmb_vacuna_ModificarReceta.DataSource = bLVacuna.ObtenerVacunas();
            this.cmb_vacuna_ModificarReceta.DisplayMember = "Nombre";
            this.cmb_vacuna_ModificarReceta.ValueMember = "VacunaId";
            this.cmb_vacuna_ModificarReceta.SelectedIndex = -1;
        }
        public bool ValidarTodosLosCamposRecetaAModificar()
        {
            if (string.IsNullOrEmpty(txt_NumeroDocumento_ModificarReceta.Text) || (string.IsNullOrEmpty(txt_Edad_ModificarReceta.Text))
                || (string.IsNullOrEmpty(txt_nombre_ModificarReceta.Text)) || string.IsNullOrEmpty(txt_apellido_ModificarReceta.Text)
                || string.IsNullOrEmpty(cmb_vacuna_ModificarReceta.Text) || string.IsNullOrEmpty(dtp_fecha_ModificarReceta.Value.ToString())
                || string.IsNullOrEmpty(rtxt_Diagnostico_ModificarReceta.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_BuscarPacientes_ModificarReceta_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente pacienteARecetar)
        {
            this._pacienteAModificarRecetar = pacienteARecetar;
            txt_apellido_ModificarReceta.Text = pacienteARecetar.Apellido;
            txt_nombre_ModificarReceta.Text = pacienteARecetar.Nombre;
            txt_Edad_ModificarReceta.Text = pacienteARecetar.Edad.ToString();
            txt_NumeroDocumento_ModificarReceta.Text = pacienteARecetar.DNI.ToString();
        }

        private void btn_Cancelar_ModificarReceta_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_Limpiar_ModificarReceta_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ModificarReceta_ModificarReceta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTodosLosCamposRecetaAModificar())
                {
                    ActualizarReceta();
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

        public void ActualizarReceta()
        {
            BEReceta RecetaActualizada = new BEReceta();

            RecetaActualizada.FechaPrescripcion = dtp_fecha_ModificarReceta.Value;
            RecetaActualizada.Observacion = rtxt_Diagnostico_ModificarReceta.Text;
            RecetaActualizada.Vacuna = (BEVacuna)cmb_vacuna_ModificarReceta.SelectedItem;

            BLReceta bLReceta = new BLReceta();
            if (bLReceta.ActualizarReceta(RecetaActualizada))
            {
                MessageBox.Show("Receta actualizada con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar la Receta");
            }
        }

        private void btn_BuscarPacientes_ModificarReceta_Click_1(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        private void btn_Cancelar_ModificarReceta_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_ModificarReceta_Click_1(object sender, EventArgs e)
        {
            txt_Edad_ModificarReceta.Clear();
            txt_NumeroDocumento_ModificarReceta.Clear();
            txt_apellido_ModificarReceta.Clear();
            txt_Edad_ModificarReceta.Clear();
            txt_nombre_ModificarReceta.Clear();
            rtxt_Diagnostico_ModificarReceta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerReceta_CertificadoForm frmVerReceta_Certificado = new VerReceta_CertificadoForm();
            frmVerReceta_Certificado.Show();
        }
    }
}
