using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cova.BL;
using Cova.BE;
using Cova.BE.Enum;
using Cova.Servicios.Sesion;
using System.Linq;

namespace Cova.UI
{
    public partial class CrearHistoriaClinicaForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _paciente;
        private BEMedico _usuarioMedico;
        public CrearHistoriaClinicaForm()
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

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
            frmBuscarUsuarios.Show();
        }

        private void btnCancelar_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            txt_NumeroDocumento_CrearHistoriaClinica.Clear();
            txt_apellido_CrearHistoriaClinica.Clear();
            txt_nombre_CrearHistoriaClinica.Clear();
            txt_Edad_CrearHistoriaClinica.Clear();
            txt_Medicacion_CrearHistoriaClinica.Clear();
            txt_PesoActual_CrearHistoriaClinica.Clear();
        }

        private void btnCrear_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActualizarAntecedentesPersonales();
                this.CrearHistoriaClinica();
                MessageBox.Show("Historia clinica cargada con exito");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ObtenerAntecedentesPersonales()
        {
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                bLPaciente.ObtenerAntecedentesPersonalesPaciente(this._paciente);
                txt_PesoActual_CrearHistoriaClinica.Text = this._paciente.HistoriaClinica.First().Peso != 0 ? this._paciente.HistoriaClinica.First().Peso.ToString() : "";

                cb_ProblemasCardiacos_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.ProblemasCardiacos) ? true : false;
                cb_TerapiaPsicologica_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.TerapiaPsicologica) ? true : false;
                cb_EnfSangre_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.EnfermedadDeLaSangre) ? true : false;
                cb_RadioTerapia_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.RadioTerapia) ? true : false;
                cb_Obesidad_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Obesidad) ? true : false;
                cb_Diabetes_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Diabetes) ? true : false;
                cb_Dermatitis_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Dermatitis) ? true : false;
                cb_EnfermedadRespiratoria_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.EnfermedadRespiratoria) ? true : false;
                cb_Epilepsia_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Epilepsia) ? true : false;
                cb_PerdidadePeso_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.PerdidaDePeso) ? true : false;

                cb_DolordeCabeza_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.DolorDeCabeza) ? true : false;
                cb_Hepatitis_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Hepatitis) ? true : false;
                cb_EnfermedadRenal_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.EnfermedadRenal) ? true : false;
                cb_FiebreReumatica_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.FiebreReumatica) ? true : false;
                cb_AlergiasGenerales_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.AlergiasGenerales) ? true : false;
                cb_AlergiasAMedicina_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.AlergiasAMedicina) ? true : false;
                cb_AlergiasaAnestesia.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.AlergiasAAnestesia) ? true : false;
                cb_Sarampion_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Sarampion) ? true : false;
                cb_Varicela_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Varicela) ? true : false;
                cb_AftasRepetidas_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.AftasRepetidas) ? true : false;
                cb_EnfermedadMotriz_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.EnfermedadMotriz) ? true : false;
                cb_Convulsiones_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Convulsiones) ? true : false;
                cb_EnferPsicologicas_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.EnfermedadPsicologica) ? true : false;
                cb_InfeccionesdeGarganta_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.InfeccionesDeGarganta) ? true : false;
                cb_Cirugias_CrearHistoriaClinica.Checked = this._paciente.AntecedentesPersonales.Contains(AntecedentesPersonales.Cirugias) ? true : false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ActualizarAntecedentesPersonales()
        {
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                List<AntecedentesPersonales> antecedentes = new List<AntecedentesPersonales>();
                if (cb_ProblemasCardiacos_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.ProblemasCardiacos);
                }
                if (cb_TerapiaPsicologica_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.TerapiaPsicologica);
                }
                if (cb_EnfSangre_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.EnfermedadDeLaSangre);
                }
                if (cb_RadioTerapia_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.RadioTerapia);
                }
                if (cb_Obesidad_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Obesidad);
                }
                if (cb_Diabetes_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Diabetes);
                }
                if (cb_Dermatitis_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Dermatitis);
                }
                if (cb_EnfermedadRespiratoria_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.EnfermedadRespiratoria);
                }
                if (cb_Epilepsia_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Epilepsia);
                }
                if (cb_PerdidadePeso_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.PerdidaDePeso);
                }
                if (cb_DolordeCabeza_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.DolorDeCabeza);
                }
                if (cb_Hepatitis_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Hepatitis);
                }
                if (cb_EnfermedadRenal_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.EnfermedadRenal);
                }
                if (cb_FiebreReumatica_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.FiebreReumatica);
                }
                if (cb_AlergiasGenerales_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.AlergiasGenerales);
                }
                if (cb_AlergiasAMedicina_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.AlergiasAMedicina);
                }
                if (cb_AlergiasaAnestesia.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.AlergiasAAnestesia);
                }
                if (cb_Sarampion_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Sarampion);
                }
                if (cb_Varicela_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Varicela);
                }
                if (cb_AftasRepetidas_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.AftasRepetidas);
                }
                if (cb_EnfermedadMotriz_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.EnfermedadMotriz);
                }
                if (cb_Convulsiones_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Convulsiones);
                }
                if (cb_EnferPsicologicas_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.EnfermedadPsicologica);
                }
                if (cb_InfeccionesdeGarganta_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.InfeccionesDeGarganta);
                }
                if (cb_Cirugias_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.Cirugias);
                }

                bLPaciente.CargarAntecedentesPersonalesPaciente(this._paciente, antecedentes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CrearHistoriaClinica()
        {
            BLPaciente bLPaciente = new BLPaciente();
            if (string.IsNullOrEmpty(txt_PesoActual_CrearHistoriaClinica.Text) || string.IsNullOrEmpty(rtb_obervacion.Text))
            {
                throw new Exception("Debe completar el peso del paciente y la observacion de la consulta");
            }
            try
            {
                BEHistoriaClinica historiaClinica = new BEHistoriaClinica();
                historiaClinica.Fecha = dtp_fechaAlta_CrearHistoriaClinica.Value;
                historiaClinica.Observacion = rtb_obervacion.Text;
                historiaClinica.Peso = Convert.ToDecimal(txt_PesoActual_CrearHistoriaClinica.Text);
                historiaClinica.Medico = this._usuarioMedico;
                bLPaciente.CargarHistoriaClinicaPaciente(this._paciente, historiaClinica);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void IFormCargarUsuarios.CargarUsuarioPaciente(BEPaciente paciente)
        {
            this._paciente = paciente;
            this.txt_apellido_CrearHistoriaClinica.Text = paciente.Apellido;
            this.txt_nombre_CrearHistoriaClinica.Text = paciente.Nombre;
            this.txt_Edad_CrearHistoriaClinica.Text = paciente.Edad.ToString();
            this.txt_NumeroDocumento_CrearHistoriaClinica.Text = paciente.DNI.ToString();
            ObtenerAntecedentesPersonales();
        }

        void IFormCargarUsuarios.CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }
    }
}
