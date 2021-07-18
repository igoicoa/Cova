﻿using System;
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
            this.coberturasMedicas = bLCoberturaMedica.ObtenerCoberturasMedicas().ToList();

            this.cmb_coberturaMedica.DataSource = coberturasMedicas;
            this.cmb_coberturaMedica.DisplayMember = "Nombre";
            this.cmb_coberturaMedica.ValueMember = "CoberturaMedicaId";
        }

        public void CargarPlanesCobertura()
        {
            BECoberturaMedica coberturaMedica = (BECoberturaMedica)cmb_coberturaMedica.SelectedItem;

            if(!string.IsNullOrEmpty(coberturaMedica.Nombre))
            {
                List<BECoberturaMedicaPlan> planes = coberturaMedica.Plan.ToList();
                this.cmb_Plan.DataSource = planes;
                this.cmb_Plan.DisplayMember = "Nombre";
                this.cmb_Plan.ValueMember = "PlanId";
            }
        }

        public void CargarEspecialidades()
        {
            this.cmb_especialidad.DataSource = Enum.GetNames(typeof(Especialidad));
        }

        public void CrearPaciente()
        {
            try
            {
            BEPaciente pacienteNuevo = new BEPaciente();
            BLPaciente bLPaciente = new BLPaciente();
            pacienteNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
            pacienteNuevo.Nombre = txtBox_CrearCuentaNombre.Text;
            pacienteNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
            pacienteNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
            pacienteNuevo.Email = txt_Email.Text;
            pacienteNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
            pacienteNuevo.DNI = Convert.ToInt32(txt_documentoNumero.Text);
            pacienteNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
            pacienteNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
            BEDomicilio domicilioPaciente = new BEDomicilio();
            domicilioPaciente.Calle = textBoxCalle_CrearCuenta.Text;
            domicilioPaciente.Numero = Convert.ToInt32(txt_calleNumero.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show("Por favor debe completar todos los campos obligatorios");
            }
        }

        public void CrearProfesionalMedico()
        {
            try
            {
            BEMedico medicoNuevo = new BEMedico();
            BLProfesional bLProfesional = new BLProfesional();
            medicoNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
            medicoNuevo.Nombre = txtBox_CrearCuentaNombre.Text;
            medicoNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
            medicoNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
            medicoNuevo.Email = txt_Email.Text;
            medicoNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
            medicoNuevo.DNI = Convert.ToInt32(txt_documentoNumero.Text);
            medicoNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
            medicoNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
            BEDomicilio domicilioProfesional = new BEDomicilio();
            domicilioProfesional.Calle = textBoxCalle_CrearCuenta.Text;
            domicilioProfesional.Numero = Convert.ToInt32(txt_calleNumero.Text);
            domicilioProfesional.Piso = txt_piso.Text;
            domicilioProfesional.Localidad = txt_localidad.Text;
            domicilioProfesional.Provincia = txt_provincia.Text;
            domicilioProfesional.Pais = "Argentina";
            medicoNuevo.Domicilio = domicilioProfesional;
            medicoNuevo.MatriculaNacional = Convert.ToInt32(txt_matriculaNacional.Text);
            medicoNuevo.MatriculaProvincial = Convert.ToInt32(txt_matriculaProvincial.Text);
            medicoNuevo.Especialidad = (Especialidad)Enum.Parse(typeof(Especialidad), cmb_especialidad.SelectedItem.ToString());

            if (bLProfesional.CrearProfesionalMedico(medicoNuevo))
            {
                MessageBox.Show("Profesional Creado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al crear el profesional");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor debe completar todos los campos obligatorios");
            }
        }

        public void CrearProfesionalEnfermero()
        {
            try { 
            BEEnfermero enfermeroNuevo = new BEEnfermero();
            BLProfesional bLProfesional = new BLProfesional();
            enfermeroNuevo.Apellido = textBoxApellidoCrearCuenta.Text;
            enfermeroNuevo.Nombre = txtBox_CrearCuentaNombre.Text;
            enfermeroNuevo.Sexo = radioButtonMasculino_CrearCuenta.Checked ? "M" : "F";
            enfermeroNuevo.Telefono = textBoxTelefono_CrearCuenta.Text;
            enfermeroNuevo.Email = txt_Email.Text;
            enfermeroNuevo.EstadoCivil = textBoxEstadoCivil_CrearCuenta.Text;
            enfermeroNuevo.DNI = Convert.ToInt32(txt_documentoNumero.Text);
            enfermeroNuevo.FechaNacimiento = monthCalendarCrearCuenta.SelectionRange.Start;
            enfermeroNuevo.Password = HashHelper.HashMD5(textBoxClave_CrearCuenta.Text);
            BEDomicilio domicilioProfesional = new BEDomicilio();
            domicilioProfesional.Calle = textBoxCalle_CrearCuenta.Text;
            domicilioProfesional.Numero = Convert.ToInt32(txt_calleNumero.Text);
            domicilioProfesional.Piso = txt_piso.Text;
            domicilioProfesional.Localidad = txt_localidad.Text;
            domicilioProfesional.Provincia = txt_provincia.Text;
            domicilioProfesional.Pais = "Argentina";
            enfermeroNuevo.Domicilio = domicilioProfesional;
            enfermeroNuevo.MatriculaEnfermero = Convert.ToInt32(txt_matriculaNacional.Text);
      
            if (bLProfesional.CrearProfesionalEnfermero(enfermeroNuevo))
            {
                MessageBox.Show("Profesional Creado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al crear el profesional");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor debe completar todos los campos obligatorios");
            }
        }

        public void CrearAdministrador()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSexoCrearCuenta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_paciente.Checked)
            {
                CrearPaciente();
            } 
            else if (rb_medico.Checked)
            {
                CrearProfesionalMedico();
            } 
            else if (rb_enfermero.Checked)
            {
                CrearProfesionalEnfermero();
            }
            else if (rb_administrador.Checked)
            {
                CrearAdministrador();
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
    }
}
