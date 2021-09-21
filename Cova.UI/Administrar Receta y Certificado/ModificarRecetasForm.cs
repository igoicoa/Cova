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
    public partial class ModificarRecetasForm : Form, IFormCargarRecetas
    {
        private BEMedico _usuarioMedico;
        private BEPaciente _pacienteAModificarRecetar;
        private BEReceta _recetaAModificar;

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
            try
            {
                this._usuarioMedico = bLMedico.BuscarMedicos(usuario, "").ToList().Where(x => x.UsuarioID == usuarioID).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarVacunas()
        {
            BLVacuna bLVacuna = new BLVacuna();
            try
            {
                this.cmb_vacuna_ModificarReceta.DataSource = bLVacuna.ObtenerVacunas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public void CargarRecetaPaciente(BEReceta receta, BEPaciente paciente)
        {
            this._pacienteAModificarRecetar = paciente;
            this._recetaAModificar = receta;
            txt_apellido_ModificarReceta.Text = paciente.Apellido;
            txt_nombre_ModificarReceta.Text = paciente.Nombre;
            txt_Edad_ModificarReceta.Text = paciente.Edad.ToString();
            txt_NumeroDocumento_ModificarReceta.Text = paciente.DNI.ToString();
            if(receta.Vacuna != null)
            {
                cmb_vacuna_ModificarReceta.Text = receta.Vacuna.Nombre;
            }
            rtxt_Diagnostico_ModificarReceta.Text = receta.Observacion;
            dtp_fecha_ModificarReceta.Value = receta.FechaPrescripcion;
        }

        private void btn_Cancelar_ModificarReceta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_ModificarReceta_Click(object sender, EventArgs e)
        {
            txt_apellido_ModificarReceta.Clear();
            txt_Edad_ModificarReceta.Clear();
            txt_nombre_ModificarReceta.Clear();
            txt_NumeroDocumento_ModificarReceta.Clear();
            rtxt_Diagnostico_ModificarReceta.Clear();
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
            try
            {
                if (bLReceta.ActualizarReceta(RecetaActualizada))
                {
                    MessageBox.Show("Receta actualizada con exito");
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar la Receta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            VerReceta_CertificadoForm frmVerReceta_Certificado = new VerReceta_CertificadoForm(this);
            frmVerReceta_Certificado.Show();
        }

        public bool ValidarTodosLosCamposReceta()
        {
            if (string.IsNullOrEmpty(txt_apellido_ModificarReceta.Text) || (string.IsNullOrEmpty(txt_nombre_ModificarReceta.Text))
                || (string.IsNullOrEmpty(txt_Edad_ModificarReceta.Text)) || string.IsNullOrEmpty(txt_NumeroDocumento_ModificarReceta.Text)
                || string.IsNullOrEmpty(rtxt_Diagnostico_ModificarReceta.Text) || string.IsNullOrEmpty(dtp_fecha_ModificarReceta.Value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_ModificarReceta_ModificarReceta_Click_1(object sender, EventArgs e)
        {
            BLReceta bLReceta = new BLReceta();
            try
            {
                this._recetaAModificar.FechaPrescripcion = dtp_fecha_ModificarReceta.Value;
                this._recetaAModificar.Observacion = rtxt_Diagnostico_ModificarReceta.Text;
                this._recetaAModificar.Vacuna = (BEVacuna)cmb_vacuna_ModificarReceta.SelectedItem;
                if (ValidarTodosLosCamposReceta())
                {
                    if (bLReceta.ActualizarReceta(this._recetaAModificar))
                    {
                        MessageBox.Show("Receta modificada con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al modificar la receta");
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
