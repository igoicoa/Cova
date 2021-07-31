using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;
using Cova.Servicios.Encriptacion;

namespace Cova.UI
{
    public partial class ModificarCuentaForm : Form, IFormCargarUsuarios
    {
        private List<BECoberturaMedica> coberturasMedicas;
        private long _usuarioId;
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
            this.cmb_coberturaMedica.SelectedIndex = -1;
        }

        public void CargarPlanesCobertura()
        {
            BECoberturaMedica coberturaMedica = (BECoberturaMedica)cmb_coberturaMedica.SelectedItem;

            if (coberturaMedica != null)
            {
                List<BECoberturaMedicaPlan> planes = coberturaMedica.Plan.ToList();
                this.cmb_plan.DataSource = planes;
                this.cmb_plan.DisplayMember = "Nombre";
                this.cmb_plan.ValueMember = "PlanId";
                this.cmb_plan.SelectedIndex = -1;
            }
        }

        public void CargarEspecialidades()
        {
            this.cmb_especialidad.DataSource = Enum.GetNames(typeof(Especialidad));
            this.cmb_especialidad.SelectedIndex = -1;
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            this._usuarioId = usuarioAModificar.UsuarioID;
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
            this._usuarioId = usuarioAModificar.UsuarioID;
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
            this._usuarioId = usuarioAModificar.UsuarioID;
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
            if(usuarioAModificar.CoberturaMedica == null)
            {
                ch_particular.Checked = true;
                OcultarCoberturaMedica();
            }
            else
            {
                ch_particular.Checked = false;
                cmb_coberturaMedica.Text = usuarioAModificar.CoberturaMedica.Nombre;
                CargarPlanesCobertura();
                cmb_plan.Text = usuarioAModificar.CoberturaMedica.Plan.Nombre;
                txt_numeroAfiliado.Text = usuarioAModificar.CoberturaMedica.NumeroAfiliado;
                dtp_fechaVencimiento.Value = usuarioAModificar.CoberturaMedica.FechaVencimiento;

                MostrarCoberturaMedica();
            }
            cmb_EstadoModificarCuenta.Text = usuarioAModificar.Activo ? "Activo" : "Inactivo";

            gb_pacienteModificarCuenta.Visible = true;
            gb_ProfesionalModificarCuenta.Visible = false;

        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            this._usuarioId = usuarioAModificar.UsuarioID;
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
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
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
            this.cmb_especialidad.SelectedIndex = -1;
            this.cmb_coberturaMedica.SelectedIndex = -1;
            this.cmb_plan.SelectedIndex = -1;
        }

        private void btnModificar_ModificarCuenta_Click(object sender, EventArgs e)
        {
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

            medicoActualizado.UsuarioID = this._usuarioId;
            medicoActualizado.Nombre = txt_nombre.Text;
            medicoActualizado.Apellido = txt_apellido.Text;
            medicoActualizado.DNI = Convert.ToInt32 (txt_DNI.Text);
            medicoActualizado.Usuario = txt_usuario.Text;
            medicoActualizado.Sexo = rb_sexoMasulino.Checked ? "M" : "F";
            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                medicoActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }
            medicoActualizado.Telefono = txt_telefono.Text;
            medicoActualizado.Email = txt_email.Text;
            medicoActualizado.EstadoCivil = txt_estadoCivil.Text;
            domicilio.Calle = txt_calle.Text;
            domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            domicilio.Piso = txt_piso.Text;
            domicilio.Localidad = txt_localidad.Text;
            domicilio.Provincia = txt_provincia.Text;
            domicilio.Pais = "Argentina";
            medicoActualizado.Domicilio = domicilio;
            medicoActualizado.MatriculaNacional = Convert.ToInt32(txt_matriculaNacional.Text);
            medicoActualizado.MatriculaProvincial = Convert.ToInt32(txt_matriculaProvincial.Text);
            medicoActualizado.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cmb_especialidad.SelectedItem.ToString());
            medicoActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            medicoActualizado.Activo = cmb_EstadoModificarCuenta.Text == "Activo" ? true : false;

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
            BEEnfermero enfermeroActualizado = new BEEnfermero();
            BEDomicilio domicilio = new BEDomicilio();

            enfermeroActualizado.UsuarioID = this._usuarioId;
            enfermeroActualizado.Nombre = txt_nombre.Text;
            enfermeroActualizado.Apellido = txt_apellido.Text;
            enfermeroActualizado.DNI = Convert.ToInt32(txt_DNI.Text);
            enfermeroActualizado.Usuario = txt_usuario.Text;
            enfermeroActualizado.Sexo = rb_sexoMasulino.Checked ? "M" : "F";
            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                enfermeroActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }
            enfermeroActualizado.Telefono = txt_telefono.Text;
            enfermeroActualizado.Email = txt_email.Text;
            enfermeroActualizado.EstadoCivil = txt_estadoCivil.Text;
            enfermeroActualizado.MatriculaEnfermero = Convert.ToInt32(txt_matriculaNacional.Text);
            enfermeroActualizado.MatriculaEnfermero = Convert.ToInt32(txt_matriculaProvincial.Text);
            domicilio.Calle = txt_calle.Text;
            domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            domicilio.Piso = txt_piso.Text;
            domicilio.Localidad = txt_localidad.Text;
            domicilio.Provincia = txt_provincia.Text;
            domicilio.Pais = "Argentina";
            enfermeroActualizado.Domicilio = domicilio;
            enfermeroActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            enfermeroActualizado.Activo = cmb_EstadoModificarCuenta.Text == "Activo" ? true : false;

            BLEnfermero bLEnfermero = new BLEnfermero();
            if (bLEnfermero.ActualizarProfesionalEnfermero(enfermeroActualizado))
            {
                MessageBox.Show("Profesional actualizado con exito");
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el profesional");
            }
        }

        public void ActualizarPaciente()
        {
            BEPaciente pacienteActualizado = new BEPaciente();
            BEDomicilio domicilio = new BEDomicilio();

            pacienteActualizado.UsuarioID = this._usuarioId;
            pacienteActualizado.Nombre = txt_nombre.Text;
            pacienteActualizado.Apellido = txt_apellido.Text;
            pacienteActualizado.DNI = Convert.ToInt32(txt_DNI.Text);
            pacienteActualizado.Usuario = txt_usuario.Text;
            pacienteActualizado.Sexo = rb_sexoMasulino.Checked ? "M" : "F";
            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                pacienteActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }
            pacienteActualizado.Telefono = txt_telefono.Text;
            pacienteActualizado.Email = txt_email.Text;
            pacienteActualizado.EstadoCivil = txt_estadoCivil.Text;
            domicilio.Calle = txt_calle.Text;
            domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            domicilio.Piso = txt_piso.Text;
            domicilio.Localidad = txt_localidad.Text;
            domicilio.Provincia = txt_provincia.Text;
            domicilio.Pais = "Argentina";
            pacienteActualizado.Domicilio = domicilio;
            pacienteActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            pacienteActualizado.Activo = cmb_EstadoModificarCuenta.Text == "Activo" ? true : false;

            if(!ch_particular.Checked)
            {
                BECoberturaMedica coberturaMedicaSeleccionada = (BECoberturaMedica)cmb_coberturaMedica.SelectedItem;
                BECoberturaMedicaPlan coberturaMedicaPlan = (BECoberturaMedicaPlan)cmb_plan.SelectedItem;
                BECoberturaMedicaPaciente coberturaMedicaPaciente = new BECoberturaMedicaPaciente();
                coberturaMedicaPaciente.CoberturaMedicaId = coberturaMedicaSeleccionada.CoberturaMedicaId;
                coberturaMedicaPaciente.Plan = coberturaMedicaPlan;
                coberturaMedicaPaciente.NumeroAfiliado = txt_numeroAfiliado.Text;
                coberturaMedicaPaciente.FechaVencimiento = dtp_fechaVencimiento.Value;

                pacienteActualizado.CoberturaMedica = coberturaMedicaPaciente;
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
            BEAdministrador administradorActualizado = new BEAdministrador();
            BEDomicilio domicilio = new BEDomicilio();

            administradorActualizado.UsuarioID = this._usuarioId;
            administradorActualizado.Nombre = txt_nombre.Text;
            administradorActualizado.Apellido = txt_apellido.Text;
            administradorActualizado.DNI = Convert.ToInt32(txt_DNI.Text);
            administradorActualizado.Usuario = txt_usuario.Text;
            administradorActualizado.Sexo = rb_sexoMasulino.Checked ? "M" : "F";
            if (!string.IsNullOrEmpty(txt_clave.Text))
            {
                administradorActualizado.Password = HashHelper.HashMD5(txt_clave.Text);
            }
            administradorActualizado.Telefono = txt_telefono.Text;
            administradorActualizado.Email = txt_email.Text;
            administradorActualizado.EstadoCivil = txt_estadoCivil.Text;
            domicilio.Calle = txt_calle.Text;
            domicilio.Numero = Convert.ToInt32(txt_numero.Text);
            domicilio.Piso = txt_piso.Text;
            domicilio.Localidad = txt_localidad.Text;
            domicilio.Provincia = txt_provincia.Text;
            domicilio.Pais = "Argentina";
            administradorActualizado.Domicilio = domicilio;
            administradorActualizado.FechaNacimiento = calendar_fechaNacimiento.SelectionRange.Start;
            administradorActualizado.Activo = cmb_EstadoModificarCuenta.Text == "Activo" ? true : false;

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

        public void OcultarCoberturaMedica()
        {
            lbl_coberturaMedica.Visible = false;
            cmb_coberturaMedica.Visible = false;
            lbl_plan.Visible = false;
            cmb_plan.Visible = false;
            lbl_numeroAfiliado.Visible = false;
            txt_numeroAfiliado.Visible = false;
            lbl_FechaVencimiento.Visible = false;
            dtp_fechaVencimiento.Visible = false;
        }

        public void MostrarCoberturaMedica()
        {
            lbl_coberturaMedica.Visible = true;
            cmb_coberturaMedica.Visible = true;
            lbl_plan.Visible = true;
            cmb_plan.Visible = true;
            lbl_numeroAfiliado.Visible = true;
            txt_numeroAfiliado.Visible = true;
            lbl_FechaVencimiento.Visible = true;
            dtp_fechaVencimiento.Visible = true;
        }

        private void ch_particular_CheckedChanged(object sender, EventArgs e)
        {
            if(ch_particular.Checked)
            {
                OcultarCoberturaMedica();
            } 
            else
            {
                MostrarCoberturaMedica();
            }
        }

        private void cmb_coberturaMedica_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPlanesCobertura();
        }
    }
}
