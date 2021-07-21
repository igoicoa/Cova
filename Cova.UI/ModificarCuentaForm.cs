using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;

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

            gb_pacienteModificarCuenta.Visible = false;
            gb_ProfesionalModificarCuenta.Visible = true;
            txt_matriculaProvincial.Visible = true;
            cmb_especialidad.Visible = true;
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
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

            gb_pacienteModificarCuenta.Visible = false;
            gb_ProfesionalModificarCuenta.Visible = true;
            txt_matriculaProvincial.Visible = false;
            cmb_especialidad.Visible = false;
        }

        public void CargarUsuarioPaciente(BEPaciente usuarioAModificar)
        {
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

            gb_pacienteModificarCuenta.Visible = true;
            gb_ProfesionalModificarCuenta.Visible = false;

        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
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
    }
}
