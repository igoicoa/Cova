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
            if(this.ActualizarAntecedentesPersonales() && this.CrearHistoriaClinica())
            {
                MessageBox.Show("Antecedentes cargados con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al cargar los antecedentes");
            }
        }

        public void ObtenerAntecedentesPersonales()
        {
            //TODO
        }

        private bool ActualizarAntecedentesPersonales()
        {
            BLPaciente bLPaciente = new BLPaciente();
            bool antecedentesCargados = false;
            try
            {
                List<AntecedentesPersonales> antecedentes = new List<AntecedentesPersonales>();
                if (rb_AftasRepetidas_CrearHistoriaClinica.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.AftasRepetidas);
                }
                if (rb_AlergiasaAnestesia.Checked)
                {
                    antecedentes.Add(AntecedentesPersonales.AlergiasAAnestesia);
                }
               //TODO Agregar todos antecedentes
                antecedentesCargados = bLPaciente.CargarAntecedentesPersonalesPaciente(this._paciente, antecedentes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return antecedentesCargados;
        }

        private bool CrearHistoriaClinica()
        {
            BLPaciente bLPaciente = new BLPaciente();
            bool historiaClinicaCargada = false;
            try
            {
                BEHistoriaClinica historiaClinica = new BEHistoriaClinica();
                historiaClinica.Fecha = dtp_fechaAlta_CrearHistoriaClinica.Value;
                historiaClinica.Observacion = rtb_obervacion.Text;
                historiaClinica.Peso = Convert.ToDecimal(txt_PesoActual_CrearHistoriaClinica.Text);
                historiaClinica.Medico = this._usuarioMedico;
                historiaClinicaCargada = bLPaciente.CargarHistoriaClinicaPaciente(this._paciente, historiaClinica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return historiaClinicaCargada;
        }

        void IFormCargarUsuarios.CargarUsuarioPaciente(BEPaciente paciente)
        {
            this._paciente = paciente;
            this.txt_apellido_CrearHistoriaClinica.Text = paciente.Apellido;
            this.txt_nombre_CrearHistoriaClinica.Text = paciente.Nombre;
            this.txt_Edad_CrearHistoriaClinica.Text = paciente.Edad.ToString();
            this.txt_NumeroDocumento_CrearHistoriaClinica.Text = paciente.DNI.ToString();
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
