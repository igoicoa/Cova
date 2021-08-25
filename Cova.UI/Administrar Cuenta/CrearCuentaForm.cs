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
using Cova.BL;
using Cova.Servicios.Encriptacion;

namespace Cova.UI
{
    public partial class CrearCuentaForm : Form
    {
        private List<BECoberturaMedica> coberturasMedicas;
        public CrearCuentaForm()
        {
            InitializeComponent();
            CargarCoberturasMedicas();
            CargarEspecialidades();
        }

        public void CargarCoberturasMedicas()
        {
            BLCoberturaMedica bLCoberturaMedica = new BLCoberturaMedica();
            try
            {
                this.coberturasMedicas = bLCoberturaMedica.ObtenerCoberturasMedicas().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.cmb_coberturaMedica.DataSource = coberturasMedicas;
            this.cmb_coberturaMedica.DisplayMember = "Nombre";
            this.cmb_coberturaMedica.ValueMember = "CoberturaMedicaId";
            this.cmb_coberturaMedica.SelectedIndex = -1;
            this.cmb_coberturaMedica.SelectedIndex = 0;
        }

        public void CargarPlanesCobertura()
        {
            BECoberturaMedica coberturaMedica = (BECoberturaMedica)cmb_coberturaMedica.SelectedItem;

            if(coberturaMedica != null)
            {
                List<BECoberturaMedicaPlan> planes = coberturaMedica.Plan.ToList();
                this.cmb_Plan.DataSource = planes;
                this.cmb_Plan.DisplayMember = "Nombre";
                this.cmb_Plan.ValueMember = "PlanId";
                this.cmb_Plan.SelectedIndex = -1;
                this.cmb_Plan.SelectedIndex = 0;
            }
        }

        public void CargarEspecialidades()
        {
            this.cmb_especialidad.DataSource = Enum.GetNames(typeof(Especialidad));
            this.cmb_especialidad.SelectedIndex = -1;
            this.cmb_especialidad.SelectedIndex = 0;
        }

        public void CrearPaciente()
        {
            int dni, calleNum;
            if (int.TryParse(txt_documentoNumero.Text, out dni) && int.TryParse(txt_calleNumero.Text, out calleNum))
            {
                BEPaciente pacienteNuevo = new BEPaciente();
                BLPaciente bLPaciente = new BLPaciente();

                pacienteNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
                pacienteNuevo.Nombre = txt_CrearCuentaNombre.Text;
                pacienteNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
                pacienteNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
                pacienteNuevo.Email = txt_Email.Text;
                pacienteNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
                pacienteNuevo.DNI = dni;
                pacienteNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
                pacienteNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
                BEDomicilio domicilioPaciente = new BEDomicilio();
                domicilioPaciente.Calle = textBoxCalle_CrearCuenta.Text;
                domicilioPaciente.Numero = calleNum;
                domicilioPaciente.Piso = txt_piso.Text;
                domicilioPaciente.Localidad = txt_localidad.Text;
                domicilioPaciente.Provincia = txt_provincia.Text;
                domicilioPaciente.Pais = "Argentina";
                pacienteNuevo.Domicilio = domicilioPaciente;
                if(!chk_particular.Checked)
                {
                    BECoberturaMedica coberturaMedicaSeleccionada = (BECoberturaMedica)cmb_coberturaMedica.SelectedItem;
                    BECoberturaMedicaPlan coberturaMedicaPlan = (BECoberturaMedicaPlan)cmb_Plan.SelectedItem;
                    BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
                    coberturaMedicaPaciente.CoberturaMedicaId = coberturaMedicaSeleccionada.CoberturaMedicaId;
                    coberturaMedicaPaciente.Plan = coberturaMedicaPlan;
                    coberturaMedicaPaciente.NumeroAfiliado = txt_numeroAfiliado.Text;
                    coberturaMedicaPaciente.FechaVencimiento = dtp_fechaVencimiento.Value;

                    pacienteNuevo.CoberturaMedica = coberturaMedicaPaciente;
                }
                try
                {
                    if (bLPaciente.CrearPaciene(pacienteNuevo))
                    {
                        MessageBox.Show("Paciente Creado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear el paciente");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Completar con valores Correctos");
            }
        }

        public void CrearProfesionalMedico()
        {
            int dni, calleNum, Mnacional, Mprovincial ;
            if (int.TryParse(txt_documentoNumero.Text, out dni) && int.TryParse(txt_calleNumero.Text, out calleNum)
                && int.TryParse(txt_matriculaNacional.Text, out Mnacional) && int.TryParse(txt_matriculaProvincial.Text, out Mprovincial))
            { 
                BEMedico medicoNuevo = new BEMedico();
                BLMedico bLMedico = new BLMedico();
                medicoNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
                medicoNuevo.Nombre = txt_CrearCuentaNombre.Text;
                medicoNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
                medicoNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
                medicoNuevo.Email = txt_Email.Text;
                medicoNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
                medicoNuevo.DNI = dni;
                medicoNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
                medicoNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
                BEDomicilio domicilioProfesional = new BEDomicilio();
                domicilioProfesional.Calle = textBoxCalle_CrearCuenta.Text;
                domicilioProfesional.Numero = calleNum;
                domicilioProfesional.Piso = txt_piso.Text;
                domicilioProfesional.Localidad = txt_localidad.Text;
                domicilioProfesional.Provincia = txt_provincia.Text;
                domicilioProfesional.Pais = "Argentina";
                medicoNuevo.Domicilio = domicilioProfesional;
                medicoNuevo.MatriculaNacional = Mnacional;
                medicoNuevo.MatriculaProvincial = Mprovincial;
                medicoNuevo.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cmb_especialidad.SelectedItem.ToString());

                try
                {
                    bLMedico.CrearProfesionalMedico(medicoNuevo);
                    MessageBox.Show("Profesional Creado con exito");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Completar con valores Correctos");
            }
        }

        public void CrearProfesionalEnfermero()
        {
            int dni, calleNum, Mnacional;
            if (int.TryParse(txt_documentoNumero.Text, out dni) && int.TryParse(txt_calleNumero.Text, out calleNum)
                && int.TryParse(txt_matriculaNacional.Text, out Mnacional))
            {
                BEEnfermero enfermeroNuevo = new BEEnfermero();
                BLEnfermero bLEnfermero = new BLEnfermero();
                enfermeroNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
                enfermeroNuevo.Nombre = txt_CrearCuentaNombre.Text;
                enfermeroNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
                enfermeroNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
                enfermeroNuevo.Email = txt_Email.Text;
                enfermeroNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
                enfermeroNuevo.DNI = dni;
                enfermeroNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
                enfermeroNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
                BEDomicilio domicilioProfesional = new BEDomicilio();
                domicilioProfesional.Calle = textBoxCalle_CrearCuenta.Text;
                domicilioProfesional.Numero = calleNum;
                domicilioProfesional.Piso = txt_piso.Text;
                domicilioProfesional.Localidad = txt_localidad.Text;
                domicilioProfesional.Provincia = txt_provincia.Text;
                domicilioProfesional.Pais = "Argentina";
                enfermeroNuevo.Domicilio = domicilioProfesional;
                enfermeroNuevo.MatriculaEnfermero = Convert.ToInt32(txt_matriculaNacional.Text);

                try
                {
                    if (bLEnfermero.CrearProfesionalEnfermero(enfermeroNuevo))
                    {
                        MessageBox.Show("Profesional Creado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear el profesional");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
             else
            {
                MessageBox.Show("Completar con valores Correctos");
            }
        }

        public void CrearAdministrador()
        {
            int dni, calleNum;
            if (int.TryParse(txt_documentoNumero.Text, out dni) && int.TryParse(txt_calleNumero.Text, out calleNum))
            {
                BEAdministrador administradorNuevo = new BEAdministrador();
                BLAdministrador blAdministrador = new BLAdministrador();
                administradorNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
                administradorNuevo.Nombre = txt_CrearCuentaNombre.Text;
                administradorNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
                administradorNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
                administradorNuevo.Email = txt_Email.Text;
                administradorNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
                administradorNuevo.DNI = dni;
                administradorNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
                administradorNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
                BEDomicilio domicilioAdministrador = new BEDomicilio();
                domicilioAdministrador.Calle = textBoxCalle_CrearCuenta.Text;
                domicilioAdministrador.Numero = calleNum;
                domicilioAdministrador.Piso = txt_piso.Text;
                domicilioAdministrador.Localidad = txt_localidad.Text;
                domicilioAdministrador.Provincia = txt_provincia.Text;
                domicilioAdministrador.Pais = "Argentina";
                administradorNuevo.Domicilio = domicilioAdministrador;
                
                try
                {
                    if (blAdministrador.CrearAdministrador(administradorNuevo))
                    {
                        MessageBox.Show("Administrador Creado con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear el Administrador");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Completar con valores Correctos");
            }
        }

        public bool ValidarTodosLosCamposPaciente()
        {
            if(string.IsNullOrEmpty(textBoxApellidoCrearCuenta.Text) || (string.IsNullOrEmpty(txt_CrearCuentaNombre.Text))
                || (string.IsNullOrEmpty (textBoxClave_CrearCuenta.Text)) || string.IsNullOrEmpty(textBoxCalle_CrearCuenta.Text)
                || string.IsNullOrEmpty(textBoxEstadoCivil_CrearCuenta.Text) || string.IsNullOrEmpty(textBoxTelefono_CrearCuenta.Text)
                || string.IsNullOrEmpty(txt_documentoNumero.Text) || string.IsNullOrEmpty(txt_provincia.Text)
                || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(chk_particular.Text)
                || string.IsNullOrEmpty(txt_localidad.Text) || string.IsNullOrEmpty(txt_calleNumero.Text)
                || string.IsNullOrEmpty(monthCalendarCrearCuenta.SelectionRange.Start.ToString())
                || ((string.IsNullOrEmpty(cmb_coberturaMedica.Text) || string.IsNullOrEmpty(txt_numeroAfiliado.Text) || string.IsNullOrEmpty(cmb_Plan.Text)) && !chk_particular.Checked))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarTodosLosCamposMedico()
        {
            if (string.IsNullOrEmpty(textBoxApellidoCrearCuenta.Text) || (string.IsNullOrEmpty(txt_CrearCuentaNombre.Text))
                || (string.IsNullOrEmpty(textBoxClave_CrearCuenta.Text)) || string.IsNullOrEmpty(textBoxCalle_CrearCuenta.Text)
                || string.IsNullOrEmpty(textBoxEstadoCivil_CrearCuenta.Text) || string.IsNullOrEmpty(textBoxTelefono_CrearCuenta.Text)
                || string.IsNullOrEmpty(txt_documentoNumero.Text) || string.IsNullOrEmpty(cmb_especialidad.Text)
                || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_matriculaProvincial.Text)
                || string.IsNullOrEmpty(txt_localidad.Text) || string.IsNullOrEmpty(txt_calleNumero.Text) || string.IsNullOrEmpty(txt_provincia.Text)
                || string.IsNullOrEmpty(monthCalendarCrearCuenta.SelectionRange.Start.ToString()) || string.IsNullOrEmpty(txt_matriculaNacional.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarTodosLosCamposEnfermero()
        {
            if (string.IsNullOrEmpty(textBoxApellidoCrearCuenta.Text) || (string.IsNullOrEmpty(txt_CrearCuentaNombre.Text))
                || (string.IsNullOrEmpty(textBoxClave_CrearCuenta.Text)) || string.IsNullOrEmpty(textBoxCalle_CrearCuenta.Text)
                || string.IsNullOrEmpty(textBoxEstadoCivil_CrearCuenta.Text) || string.IsNullOrEmpty(textBoxTelefono_CrearCuenta.Text)
                || string.IsNullOrEmpty(txt_documentoNumero.Text) || string.IsNullOrEmpty(txt_matriculaProvincial.Text)
                || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(monthCalendarCrearCuenta.SelectionRange.Start.ToString())
                || string.IsNullOrEmpty(txt_localidad.Text) || string.IsNullOrEmpty(txt_calleNumero.Text)
                || string.IsNullOrEmpty(txt_provincia.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarTodosLosCamposAdministrador()
        {
            if (string.IsNullOrEmpty(textBoxApellidoCrearCuenta.Text) || (string.IsNullOrEmpty(txt_CrearCuentaNombre.Text))
                || (string.IsNullOrEmpty(textBoxClave_CrearCuenta.Text)) || string.IsNullOrEmpty(textBoxCalle_CrearCuenta.Text)
                || string.IsNullOrEmpty(textBoxEstadoCivil_CrearCuenta.Text) || string.IsNullOrEmpty(textBoxTelefono_CrearCuenta.Text)
                || string.IsNullOrEmpty(txt_documentoNumero.Text) || string.IsNullOrEmpty(monthCalendarCrearCuenta.SelectionRange.Start.ToString())
                || string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrEmpty(txt_localidad.Text) || string.IsNullOrEmpty(txt_calleNumero.Text)
                || string.IsNullOrEmpty(txt_provincia.Text))
            {
                return false;
            }
            else
            {

                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_paciente.Checked)
            {
                if(ValidarTodosLosCamposPaciente())
                {
                    CrearPaciente();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            } 
            else if (rb_medico.Checked)
            {
                if (ValidarTodosLosCamposMedico())
                {
                    CrearProfesionalMedico();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            } 
            else if (rb_enfermero.Checked)
            {
                if (ValidarTodosLosCamposEnfermero())
                {
                    CrearProfesionalEnfermero();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            else if (rb_administrador.Checked)
            {
                if (ValidarTodosLosCamposAdministrador())
                {
                    CrearAdministrador();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
        }

        private void rb_paciente_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_paciente.Checked)
            {
                gb_paciente.Visible = true;
                gb_Profesional.Visible = false;
            }
        }

        private void rb_medico_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_medico.Checked)
            {
                gb_paciente.Visible = false;
                gb_Profesional.Visible = true;

                lbl_matriculaProvincial.Visible = true;
                txt_matriculaProvincial.Visible = true;
                lbl_especialidad.Visible = true;
                cmb_especialidad.Visible = true;
            }
        }

        private void rb_enfermero_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_enfermero.Checked)
            {
                gb_paciente.Visible = false;
                gb_Profesional.Visible = true;

                lbl_matriculaProvincial.Visible = false;
                txt_matriculaProvincial.Visible = false;
                lbl_especialidad.Visible = false;
                cmb_especialidad.Visible = false;
            }
        }

        private void rb_administrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_administrador.Checked)
            {
                gb_paciente.Visible = false;
                gb_Profesional.Visible = false;

                lbl_matriculaProvincial.Visible = false;
                txt_matriculaProvincial.Visible = false;
                lbl_especialidad.Visible = false;
                cmb_especialidad.Visible = false;
            }
        }

        private void cmb_coberturaMedica_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPlanesCobertura();
        }

        private void chk_particular_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_particular.Checked)
            {
                lblCoberturaMedica_CrearUsuario.Visible = false;
                cmb_coberturaMedica.Visible = false;
                lbl_Plan.Visible = false;
                cmb_Plan.Visible = false;
                lbl_numeroAfiliado.Visible = false;
                txt_numeroAfiliado.Visible = false;
                lbl_FechaVencimiento.Visible = false;
                dtp_fechaVencimiento.Visible = false;
            }
            else
            {
                lblCoberturaMedica_CrearUsuario.Visible = true;
                cmb_coberturaMedica.Visible = true;
                lbl_Plan.Visible = true;
                cmb_Plan.Visible = true;
                lbl_numeroAfiliado.Visible = true;
                txt_numeroAfiliado.Visible = true;
                lbl_FechaVencimiento.Visible = true;
                dtp_fechaVencimiento.Visible = true;
            }
        }

        private void btnCancelar_CrearCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_CrearCuenta_Click(object sender, EventArgs e)
        {
            txt_CrearCuentaNombre.Clear();
            txt_documentoNumero.Clear();
            textBoxClave_CrearCuenta.Clear();
            textBoxTelefono_CrearCuenta.Clear();
            txt_Email.Clear();
            textBoxApellidoCrearCuenta.Clear();
            textBoxEstadoCivil_CrearCuenta.Clear();
            textBoxCalle_CrearCuenta.Clear();
            txt_calleNumero.Clear();
            txt_piso.Clear();
            txt_localidad.Clear();
            txt_provincia.Clear();
            txt_matriculaNacional.Clear();
            txt_matriculaProvincial.Clear();
            txt_numeroAfiliado.Clear();
            cmb_coberturaMedica.Items.Clear();
            cmb_especialidad.Items.Clear();
            cmb_Plan.Items.Clear();
            comboBox1.Items.Clear();
            this.cmb_especialidad.SelectedIndex = -1;
            this.cmb_coberturaMedica.SelectedIndex = -1;
            this.cmb_Plan.SelectedIndex = -1;
        }

        private void txt_documentoNumero_TextChanged(object sender, KeyPressEventArgs e)
        {
        }
    }
}
