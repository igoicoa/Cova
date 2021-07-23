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
            cmb_EstadoModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";
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
            cmb_EstadoModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

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
            cmb_EstadoModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

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
            cmb_EstadoModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

            gb_pacienteModificarCuenta.Visible = false;
            gb_ProfesionalModificarCuenta.Visible = false;
        }

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(this);
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
            BEMedico medicoActualizado = new BEMedico();
            BEDomicilio domicilio = new BEDomicilio();

            medicoActualizado.Nombre = txt_nombre.Text;
            medicoActualizado.Apellido = txt_apellido.Text;
            medicoActualizado.DNI = Convert.ToInt32 (txt_DNI.Text);
            medicoActualizado.Usuario = txt_usuario.Text;
            medicoActualizado.Password = txt_clave.Text;
            medicoActualizado.Telefono = txt_telefono.Text;
            medicoActualizado.Email = txt_email.Text;
            medicoActualizado.EstadoCivil = txt_estadoCivil.Text;
            medicoActualizado.Domicilio.Calle = txt_calle.Text;
            medicoActualizado.Domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            medicoActualizado.Domicilio.Piso = txt_piso.Text;
            medicoActualizado.Domicilio.Localidad = txt_localidad.Text;
            medicoActualizado.Domicilio.Provincia = txt_provincia.Text;
            medicoActualizado.MatriculaNacional = Convert.ToInt32(txt_matriculaNacional.Text);
            medicoActualizado.MatriculaProvincial = Convert.ToInt32(txt_matriculaProvincial.Text);
            medicoActualizado.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cmb_especialidad.SelectedItem.ToString());
            medicoActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            medicoActualizado.Activo = Convert.ToBoolean (cmb_EstadoModificarCuenta.Text);

            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                medicoActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }

            if (rb_sexoFemenino.Checked)
            {
                medicoActualizado.Sexo = rb_sexoFemenino.Text;
            }
            else
            {
                medicoActualizado.Sexo = rb_sexoMasulino.Text;
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
            BEEnfermero enfermeroActualizado = new BEEnfermero();
            BEDomicilio domicilio = new BEDomicilio();

            enfermeroActualizado.Nombre = txt_nombre.Text;
            enfermeroActualizado.Apellido = txt_apellido.Text;
            enfermeroActualizado.DNI = Convert.ToInt32(txt_DNI.Text);
            enfermeroActualizado.Usuario = txt_usuario.Text;
            enfermeroActualizado.Password = txt_clave.Text;
            enfermeroActualizado.Telefono = txt_telefono.Text;
            enfermeroActualizado.Email = txt_email.Text;
            enfermeroActualizado.EstadoCivil = txt_estadoCivil.Text;
            enfermeroActualizado.MatriculaEnfermero = Convert.ToInt32(txt_matriculaNacional.Text);
            enfermeroActualizado.MatriculaEnfermero = Convert.ToInt32(txt_matriculaProvincial.Text);
            enfermeroActualizado.Domicilio.Calle = txt_calle.Text;
            enfermeroActualizado.Domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            enfermeroActualizado.Domicilio.Piso = txt_piso.Text;
            enfermeroActualizado.Domicilio.Localidad = txt_localidad.Text;
            enfermeroActualizado.Domicilio.Provincia = txt_provincia.Text;
            enfermeroActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            enfermeroActualizado.Activo = Convert.ToBoolean(cmb_EstadoModificarCuenta.Text);

            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                enfermeroActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }

            if (rb_sexoFemenino.Checked)
            {
                enfermeroActualizado.Sexo = rb_sexoFemenino.Text;
            } else
            {
                enfermeroActualizado.Sexo = rb_sexoMasulino.Text;
            }

            //BEEnfermero bLEnfermero = new BEEnfermero();
            //if (bLEnfermero.ActualizarProfesionalEnfermero(enfermeroActualizado))
            //{
            //    MessageBox.Show("Profesional actualizado con exito");
            //}
            //else
            //{
            //    MessageBox.Show("Hubo un error al actualizar el profesional");
            //}
        }

        public void ActualizarPaciente()
        {
            //TODO Terminar
            BEPaciente pacienteActualizado = new BEPaciente();
            BEDomicilio domicilio = new BEDomicilio();

            pacienteActualizado.Nombre = txt_nombre.Text;
            pacienteActualizado.Apellido = txt_apellido.Text;
            pacienteActualizado.DNI = Convert.ToInt32(txt_DNI.Text);
            pacienteActualizado.Usuario = txt_usuario.Text;
            pacienteActualizado.Password = txt_clave.Text;
            pacienteActualizado.Telefono = txt_telefono.Text;
            pacienteActualizado.Email = txt_email.Text;
            pacienteActualizado.EstadoCivil = txt_estadoCivil.Text;
            pacienteActualizado.Sexo = rb_sexoFemenino.Text;
            pacienteActualizado.Sexo = rb_sexoMasulino.Text;
            pacienteActualizado.Domicilio.Calle = txt_calle.Text;
            pacienteActualizado.Domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            pacienteActualizado.Domicilio.Piso = txt_piso.Text;
            pacienteActualizado.Domicilio.Localidad = txt_localidad.Text;
            pacienteActualizado.Domicilio.Provincia = txt_provincia.Text;
            pacienteActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            pacienteActualizado.Activo = Convert.ToBoolean(cmb_EstadoModificarCuenta.Text);

            if (ch_particular.Checked)
            {
                lblCoberturaMedica_ModificarCuenta.Visible = false;
                cmb_coberturaMedica.Visible = false;
                lbl_Plan_ModificarCuenta.Visible = false;
                cmb_plan.Visible = false;
                lbl_numeroAfiliado_ModificarCuenta.Visible = false;
                txt_numeroAfiliado.Visible = false;
                lbl_FechaVencimiento_ModificarCuenta.Visible = false;
                dtp_fechaVencimiento.Visible = false;
            }
            else
            {
                lblCoberturaMedica_ModificarCuenta.Visible = true;
                cmb_coberturaMedica.Visible = true;
                lbl_Plan_ModificarCuenta.Visible = true;
                cmb_plan.Visible = true;
                lbl_numeroAfiliado_ModificarCuenta.Visible = true;
                txt_numeroAfiliado.Visible = true;
                lbl_FechaVencimiento_ModificarCuenta.Visible = true;
                dtp_fechaVencimiento.Visible = true;
            }

            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                pacienteActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }

            BLPaciente bLPaciente = new BLPaciente();
            if (bLPaciente.ActualizarPaciente(pacienteActualizado))
            {
                MessageBox.Show("Paciente actualizado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el Paciente");
            }
        }

        public void ActualizarAdministrador()
        {
            //TODO Terminar
            BEAdministrador administradorActualizado = new BEAdministrador();
            BEDomicilio domicilio = new BEDomicilio();

            administradorActualizado.Nombre = txt_nombre.Text;
            administradorActualizado.Apellido = txt_apellido.Text;
            administradorActualizado.DNI = Convert.ToInt32(txt_DNI.Text);
            administradorActualizado.Usuario = txt_usuario.Text;
            administradorActualizado.Password = txt_clave.Text;
            administradorActualizado.Telefono = txt_telefono.Text;
            administradorActualizado.Email = txt_email.Text;
            administradorActualizado.EstadoCivil = txt_estadoCivil.Text;
            administradorActualizado.Domicilio.Calle = txt_calle.Text;
            administradorActualizado.Domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            administradorActualizado.Domicilio.Piso = txt_piso.Text;
            administradorActualizado.Domicilio.Localidad = txt_localidad.Text;
            administradorActualizado.Domicilio.Provincia = txt_provincia.Text;
            administradorActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            administradorActualizado.Activo = Convert.ToBoolean(cmb_EstadoModificarCuenta.Text);

            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                administradorActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }

            if (rb_sexoFemenino.Checked)
            {
                administradorActualizado.Sexo = rb_sexoFemenino.Text;
            }
            else
            {
                administradorActualizado.Sexo = rb_sexoMasulino.Text;
            }

            BLAdministrador bLAdministrador = new BLAdministrador();
            if (bLAdministrador.ActualizarAdministrador(administradorActualizado))
            {
                MessageBox.Show("Administrador actualizado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el Administrador");
            }
        }
    }
}
