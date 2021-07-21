using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;
using Cova.Servicios.Encriptacion;

namespace Cova.UI
{
    public partial class ModificarCuentaForm : Form
    {
        private List<BECoberturaMedica> coberturasMedicas;

        public ModificarCuentaForm()
        {
            InitializeComponent();
            CargarCoberturasMedicas();
            CargarEspecialidades();
            InhabilitarRb();
        }

        public void InhabilitarRb()
        {
            rb_administrador_ModificarCuenta.Enabled = false;
            rb_enfermero_ModificarCuenta.Enabled = false;
            rb_medico_ModificarCuenta.Enabled = false;
            rb_paciente_ModificarCuenta.Enabled = false;
        }

        public void CargarCoberturasMedicas()
        {
            BLCoberturaMedica bLCoberturaMedica = new BLCoberturaMedica();
            this.coberturasMedicas = bLCoberturaMedica.ObtenerCoberturasMedicas().ToList();

            this.cmb_coberturaMedica.DataSource = coberturasMedicas;
            this.cmb_coberturaMedica.DisplayMember = "Nombre";
            this.cmb_coberturaMedica.ValueMember = "CoberturaMedicaId";
        }

        public void CargarPlanesCobertura()
        {
            BECoberturaMedica coberturaMedica = (BECoberturaMedica)cmb_coberturaMedica.SelectedItem;

            if (!string.IsNullOrEmpty(coberturaMedica.Nombre))
            {
                List<BECoberturaMedicaPlan> planes = coberturaMedica.Plan.ToList();
                this.cmb_plan.DataSource = planes;
                this.cmb_plan.DisplayMember = "Nombre";
                this.cmb_plan.ValueMember = "PlanId";
            }
        }

        public void CargarEspecialidades()
        {
            this.cmb_especialidad.DataSource = Enum.GetNames(typeof(Especialidad));
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            rb_medico_ModificarCuenta.Checked = true;
            txt_DNI.Text = usuarioAModificar.DNI.ToString();
            txt_usuario.Text = usuarioAModificar.Usuario.ToString();
            txt_telefono.Text = usuarioAModificar.Telefono;
            txt_email.Text = usuarioAModificar.Email;
            txt_estadoCivil.Text = usuarioAModificar.EstadoCivil;
            txt_apellido.Text = usuarioAModificar.Apellido;
            txt_nombre.Text = usuarioAModificar.Nombre;
            rb_sexoMasulino.Checked = usuarioAModificar.Sexo == "M" ? true : false;
            rb_sexoFemenino.Checked = usuarioAModificar.Sexo == "F" ? true : false;
            txt_calle.Text = usuarioAModificar.Domicilio.Calle;
            txt_numero.Text = usuarioAModificar.Domicilio.Numero.ToString();
            txt_piso.Text = usuarioAModificar.Domicilio.Piso;
            txt_localidad.Text = usuarioAModificar.Domicilio.Localidad;
            txt_provincia.Text = usuarioAModificar.Domicilio.Provincia;
            calendar_fechaNacimiento.SelectionStart = usuarioAModificar.FechaNacimiento;
            txt_matriculaNacional.Text = usuarioAModificar.MatriculaNacional.ToString();
            txt_matriculaProvincial.Text = usuarioAModificar.MatriculaProvincial.ToString();
            cmb_especialidad.Text = usuarioAModificar.Especialidad.ToString();
            cmb_InhabilitarModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";
            gb_pacienteModificarCuenta.Visible = false;
            gb_ProfesionalModificarCuenta.Visible = true;
            txt_matriculaProvincial.Visible = true;
            cmb_especialidad.Visible = true;
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            rb_enfermero_ModificarCuenta.Checked = true;
            txt_DNI.Text = usuarioAModificar.DNI.ToString();
            txt_usuario.Text = usuarioAModificar.Usuario.ToString();
            txt_telefono.Text = usuarioAModificar.Telefono;
            txt_email.Text = usuarioAModificar.Email;
            txt_estadoCivil.Text = usuarioAModificar.EstadoCivil;
            txt_apellido.Text = usuarioAModificar.Apellido;
            txt_nombre.Text = usuarioAModificar.Nombre;
            rb_sexoMasulino.Checked = usuarioAModificar.Sexo == "M" ? true : false;
            rb_sexoFemenino.Checked = usuarioAModificar.Sexo == "F" ? true : false;
            txt_calle.Text = usuarioAModificar.Domicilio.Calle;
            txt_numero.Text = usuarioAModificar.Domicilio.Numero.ToString();
            txt_piso.Text = usuarioAModificar.Domicilio.Piso;
            txt_localidad.Text = usuarioAModificar.Domicilio.Localidad;
            txt_provincia.Text = usuarioAModificar.Domicilio.Provincia;
            calendar_fechaNacimiento.SelectionStart = usuarioAModificar.FechaNacimiento;
            txt_matriculaNacional.Text = usuarioAModificar.MatriculaEnfermero.ToString();
            cmb_InhabilitarModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

            gb_pacienteModificarCuenta.Visible = false;
            gb_ProfesionalModificarCuenta.Visible = true;
            txt_matriculaProvincial.Visible = false;
            cmb_especialidad.Visible = false;
        }

        public void CargarUsuarioPaciente(BEPaciente usuarioAModificar)
        {
            rb_paciente_ModificarCuenta.Checked = true;
            txt_DNI.Text = usuarioAModificar.DNI.ToString();
            txt_usuario.Text = usuarioAModificar.Usuario.ToString();
            txt_telefono.Text = usuarioAModificar.Telefono;
            txt_email.Text = usuarioAModificar.Email;
            txt_estadoCivil.Text = usuarioAModificar.EstadoCivil;
            txt_apellido.Text = usuarioAModificar.Apellido;
            txt_nombre.Text = usuarioAModificar.Nombre;
            rb_sexoMasulino.Checked = usuarioAModificar.Sexo == "M" ? true : false;
            rb_sexoFemenino.Checked = usuarioAModificar.Sexo == "F" ? true : false;
            txt_calle.Text = usuarioAModificar.Domicilio.Calle;
            txt_numero.Text = usuarioAModificar.Domicilio.Numero.ToString();
            txt_piso.Text = usuarioAModificar.Domicilio.Piso;
            txt_localidad.Text = usuarioAModificar.Domicilio.Localidad;
            txt_provincia.Text = usuarioAModificar.Domicilio.Provincia;
            calendar_fechaNacimiento.SelectionStart = usuarioAModificar.FechaNacimiento;
            if(string.IsNullOrEmpty(usuarioAModificar.CoberturaMedica.Nombre))
            {
                ch_particular.Checked = true;
            }
            else
            {
                cmb_coberturaMedica.Text = usuarioAModificar.CoberturaMedica.Nombre;
                CargarPlanesCobertura();
                cmb_plan.Text = usuarioAModificar.CoberturaMedica.Plan.Nombre;
                txt_numeroAfiliado.Text = usuarioAModificar.CoberturaMedica.NumeroAfiliado;
                dtp_fechaVencimiento.Value = usuarioAModificar.CoberturaMedica.FechaVencimiento;
            }
            cmb_InhabilitarModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

            gb_pacienteModificarCuenta.Visible = true;
            gb_ProfesionalModificarCuenta.Visible = false;

        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            rb_administrador_ModificarCuenta.Checked = true;
            txt_DNI.Text = usuarioAModificar.DNI.ToString();
            txt_usuario.Text = usuarioAModificar.Usuario.ToString();
            txt_telefono.Text = usuarioAModificar.Telefono;
            txt_email.Text = usuarioAModificar.Email;
            txt_estadoCivil.Text = usuarioAModificar.EstadoCivil;
            txt_apellido.Text = usuarioAModificar.Apellido;
            txt_nombre.Text = usuarioAModificar.Nombre;
            rb_sexoMasulino.Checked = usuarioAModificar.Sexo == "M" ? true : false;
            rb_sexoFemenino.Checked = usuarioAModificar.Sexo == "F" ? true : false;
            txt_calle.Text = usuarioAModificar.Domicilio.Calle;
            txt_numero.Text = usuarioAModificar.Domicilio.Numero.ToString();
            txt_piso.Text = usuarioAModificar.Domicilio.Piso;
            txt_localidad.Text = usuarioAModificar.Domicilio.Localidad;
            txt_provincia.Text = usuarioAModificar.Domicilio.Provincia;
            calendar_fechaNacimiento.SelectionStart = usuarioAModificar.FechaNacimiento;
            cmb_InhabilitarModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

            gb_pacienteModificarCuenta.Visible = false;
            gb_ProfesionalModificarCuenta.Visible = false;
        }

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuarios frmBuscarUsuarios = new BuscarUsuarios(this);
            frmBuscarUsuarios.Show();
        }

        private void btnCancelar_ModificarCuenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_ModificarCuenta_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_DNI.Clear();
            txt_usuario.Clear();
            txt_clave.Clear();
            txt_telefono.Clear();
            /*pictureBoxImagen_CrearCuenta.Clear();*/
            txt_email.Clear();
            txt_apellido.Clear();
            txt_estadoCivil.Clear();
            txt_calle.Clear();
            txt_numero.Clear();
            txt_piso.Clear();
            txt_localidad.Clear();
            txt_provincia.Clear();
            txt_matriculaProvincial.Clear();
            txt_matriculaNacional.Clear();
            txt_numeroAfiliado.Clear();
        }

        private void textBoxUsuario_ModificarCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxUsuario_ModificarCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_ModificarCuenta_Click(object sender, EventArgs e)
        {
            //TODO
            if(rb_medico_ModificarCuenta.Checked)
            {
                ActualizarProfesionalMedico();
            }
            else if(rb_enfermero_ModificarCuenta.Checked)
            {
                ActualizarProfesionalEnfermero();
            } 
            else if(rb_paciente_ModificarCuenta.Checked)
            {
                ActualizarPaciente();
            } 
            else if(rb_administrador_ModificarCuenta.Checked)
            {
                ActualizarAdministrador();
            }

        }

        public void ActualizarProfesionalMedico()
        {
            //TODO Terminar
            BEMedico medicoActualizado = new BEMedico();
            BEDomicilio domicilio = new BEDomicilio();

            medicoActualizado.Nombre = txt_nombre.Text;
            medicoActualizado.Apellido = txt_apellido.Text;
            //medicoActualizado.Activo = CARGAR DEL COMBOBOX
            if(!string.IsNullOrEmpty(txt_clave.Text))
            {
                medicoActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }

            BLMedico bLMedico = new BLMedico();
            if(bLMedico.ActualizarProfesionalMedico(medicoActualizado))
            {
                MessageBox.Show("Profesional actualizado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el profesional");
            }
        }

        public void ActualizarProfesionalEnfermero()
        {
            //TODO Terminar
        }

        public void ActualizarPaciente()
        {
            //TODO Terminar
        }

        public void ActualizarAdministrador()
        {
            //TODO Terminar
        }
    }
}
