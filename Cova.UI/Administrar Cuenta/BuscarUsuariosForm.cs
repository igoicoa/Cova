﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cova.BL;
using Cova.BE;
using Cova.UI.Administrar_Receta_y_Certificado;

namespace Cova.UI
{
    public partial class BuscarUsuariosForm : Form
    {
        private bool _buscarSoloPacientes;
        private IFormCargarUsuarios _formPadre;
        public List<BEMedico> Medicos;
        public List<BEEnfermero> Enfermeros;
        public List<BEPaciente> Pacientes;
        public List<BEAdministrador> Administradores;


        public BuscarUsuariosForm(bool buscarSoloPacientes, IFormCargarUsuarios formPadre = null)
        {
            InitializeComponent();
            this._formPadre = formPadre;
            if(formPadre == null)
            {
                this.btn_SeleccionarUsuario_BuscarUsuarios.Visible = false;
            }
            this._buscarSoloPacientes = buscarSoloPacientes;
            ActualizarForm();
        }


        public void ActualizarForm()
        {
            if(this._buscarSoloPacientes)
            {
                gb_TipoUsuario_BuscarUsuarios.Visible = false;
                rb_paciente_BuscarUsuarios.Checked = true;
                lbl_BuscarUsuarios.Text = "Buscar pacientes";
                this.Text = "Buscar pacientes";
            }
        }

        public DataView TraerInformacionFiltrada(DataView dv)
        {
            dv.RowFilter = $"Nombre like '%{txt_nombre.Text}%' and UsuarioID like '%{txt_Usuario_BuscarUsuario.Text}%' and " +
                           $"Apellido like '%{txt_apellido.Text}%' and DNI like '%{txt_DNI_BuscarUsuario.Text}%'";
            return dv;
        }

        private void bttn_Buscar_BuscarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_Usuario_BuscarUsuario.Text;
            string DNI = txt_DNI_BuscarUsuario.Text;

            if (rb_medico_BuscarUsuarios.Checked)
            {
                this.BuscarMedico(usuario, DNI);
            }
            else if(rb_enfermero_BuscarUsuarios.Checked)
            {
                this.BuscarEnfermero(usuario, DNI);
            }
            else if(rb_paciente_BuscarUsuarios.Checked)
            {
                this.BuscarPaciente(usuario, DNI);
            }
            else if(rb_administrador_BuscarUsuarios.Checked)
            {
                this.BuscarAdministrador(usuario, DNI);
            }
        }

        public void BuscarMedico(string usuario, string DNI)
        {
            BLMedico bLMedico = new BLMedico();
            try
            {
                this.Medicos = bLMedico.BuscarMedicos(usuario, DNI).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable tableMedicos = new DataTable();
            tableMedicos.Columns.Add("UsuarioID");
            tableMedicos.Columns.Add("Nombre");
            tableMedicos.Columns.Add("Apellido");
            tableMedicos.Columns.Add("DNI");
            tableMedicos.Columns.Add("Fecha Nacimiento");
            tableMedicos.Columns.Add("Sexo");
            tableMedicos.Columns.Add("Estado Civil");
            tableMedicos.Columns.Add("Telefono");
            tableMedicos.Columns.Add("Email");
            tableMedicos.Columns.Add("Calle");
            tableMedicos.Columns.Add("Numero");
            tableMedicos.Columns.Add("Piso");
            tableMedicos.Columns.Add("Localidad");
            tableMedicos.Columns.Add("Provincia");
            tableMedicos.Columns.Add("Pais");
            tableMedicos.Columns.Add("Especialidad");
            tableMedicos.Columns.Add("Matricula Nacional");
            tableMedicos.Columns.Add("Matricula Provincial");

            foreach (BEMedico medico in this.Medicos)
            {
                DataRow filaMedico = tableMedicos.NewRow();
                filaMedico["UsuarioID"] = medico.UsuarioID;
                filaMedico["Nombre"] = medico.Nombre;
                filaMedico["Apellido"] = medico.Apellido;
                filaMedico["DNI"] = medico.DNI;
                filaMedico["Fecha Nacimiento"] = medico.FechaNacimiento;
                filaMedico["Sexo"] = medico.Sexo;
                filaMedico["Estado Civil"] = medico.EstadoCivil;
                filaMedico["Telefono"] = medico.Telefono;
                filaMedico["Email"] = medico.Email;
                filaMedico["Calle"] = medico.Domicilio.Calle;
                filaMedico["Numero"] = medico.Domicilio.Numero;
                filaMedico["Piso"] = medico.Domicilio.Piso;
                filaMedico["Localidad"] = medico.Domicilio.Localidad;
                filaMedico["Provincia"] = medico.Domicilio.Provincia;
                filaMedico["Pais"] = medico.Domicilio.Pais;
                filaMedico["Especialidad"] = medico.Especialidad;
                filaMedico["Matricula Nacional"] = medico.MatriculaNacional;
                filaMedico["Matricula Provincial"] = medico.MatriculaProvincial;
                tableMedicos.Rows.Add(filaMedico);
            }
            DataView dataviewMedicos = new DataView(tableMedicos);
            dgv_usuario.DataSource = TraerInformacionFiltrada(dataviewMedicos);
            dgv_usuario.Columns[0].Visible = false;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void BuscarEnfermero(string usuario, string DNI)
        {
            BLEnfermero bLEnfermero = new BLEnfermero();
            try
            {
                this.Enfermeros = bLEnfermero.BuscarEnfermeros(usuario, DNI).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            DataTable tableEnfermeros = new DataTable();
            tableEnfermeros.Columns.Add("UsuarioID");
            tableEnfermeros.Columns.Add("Nombre");
            tableEnfermeros.Columns.Add("Apellido");
            tableEnfermeros.Columns.Add("DNI");
            tableEnfermeros.Columns.Add("Fecha Nacimiento");
            tableEnfermeros.Columns.Add("Sexo");
            tableEnfermeros.Columns.Add("Estado Civil");
            tableEnfermeros.Columns.Add("Telefono");
            tableEnfermeros.Columns.Add("Email");
            tableEnfermeros.Columns.Add("Calle");
            tableEnfermeros.Columns.Add("Numero");
            tableEnfermeros.Columns.Add("Piso");
            tableEnfermeros.Columns.Add("Localidad");
            tableEnfermeros.Columns.Add("Provincia");
            tableEnfermeros.Columns.Add("Pais");
            tableEnfermeros.Columns.Add("Matricula Enfermero");
            foreach (BEEnfermero enfermero in this.Enfermeros)
            {
                DataRow filaEnfermero = tableEnfermeros.NewRow();
                filaEnfermero["UsuarioID"] = enfermero.UsuarioID;
                filaEnfermero["Nombre"] = enfermero.Nombre;
                filaEnfermero["Apellido"] = enfermero.Apellido;
                filaEnfermero["DNI"] = enfermero.DNI;
                filaEnfermero["Fecha Nacimiento"] = enfermero.FechaNacimiento;
                filaEnfermero["Sexo"] = enfermero.Sexo;
                filaEnfermero["Estado Civil"] = enfermero.EstadoCivil;
                filaEnfermero["Telefono"] = enfermero.Telefono;
                filaEnfermero["Email"] = enfermero.Email;
                filaEnfermero["Calle"] = enfermero.Domicilio.Calle;
                filaEnfermero["Numero"] = enfermero.Domicilio.Numero;
                filaEnfermero["Piso"] = enfermero.Domicilio.Piso;
                filaEnfermero["Localidad"] = enfermero.Domicilio.Localidad;
                filaEnfermero["Provincia"] = enfermero.Domicilio.Provincia;
                filaEnfermero["Pais"] = enfermero.Domicilio.Pais;
                filaEnfermero["Matricula Enfermero"] = enfermero.MatriculaEnfermero;
                tableEnfermeros.Rows.Add(filaEnfermero);
            }
            DataView dataviewEnfermeros = new DataView(tableEnfermeros);
            dgv_usuario.DataSource = TraerInformacionFiltrada(dataviewEnfermeros);
            dgv_usuario.Columns[0].Visible = false;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void BuscarPaciente(string usuario, string DNI)
        {
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                this.Pacientes = bLPaciente.BuscarPacientes(usuario, DNI).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable tablePaciente = new DataTable();
            tablePaciente.Columns.Add("UsuarioID");
            tablePaciente.Columns.Add("Nombre");
            tablePaciente.Columns.Add("Apellido");
            tablePaciente.Columns.Add("DNI");
            tablePaciente.Columns.Add("Fecha Nacimiento");
            tablePaciente.Columns.Add("Sexo");
            tablePaciente.Columns.Add("Estado Civil");
            tablePaciente.Columns.Add("Telefono");
            tablePaciente.Columns.Add("Email");
            tablePaciente.Columns.Add("Calle");
            tablePaciente.Columns.Add("Numero");
            tablePaciente.Columns.Add("Piso");
            tablePaciente.Columns.Add("Localidad");
            tablePaciente.Columns.Add("Provincia");
            tablePaciente.Columns.Add("Pais");
            tablePaciente.Columns.Add("Cobertura Medica");
            tablePaciente.Columns.Add("Plan");
            tablePaciente.Columns.Add("Numero Afiliado");
            tablePaciente.Columns.Add("Fecha Vencimiento");

            foreach (BEPaciente paciente in this.Pacientes)
            {
                DataRow filaPacientes = tablePaciente.NewRow();
                filaPacientes["UsuarioID"] = paciente.UsuarioID;
                filaPacientes["Nombre"] = paciente.Nombre;
                filaPacientes["Apellido"] = paciente.Apellido;
                filaPacientes["DNI"] = paciente.DNI;
                filaPacientes["Fecha Nacimiento"] = paciente.FechaNacimiento;
                filaPacientes["Sexo"] = paciente.Sexo;
                filaPacientes["Estado Civil"] = paciente.EstadoCivil;
                filaPacientes["Telefono"] = paciente.Telefono;
                filaPacientes["Email"] = paciente.Email;
                filaPacientes["Calle"] = paciente.Domicilio.Calle;
                filaPacientes["Numero"] = paciente.Domicilio.Numero;
                filaPacientes["Piso"] = paciente.Domicilio.Piso;
                filaPacientes["Localidad"] = paciente.Domicilio.Localidad;
                filaPacientes["Provincia"] = paciente.Domicilio.Provincia;
                filaPacientes["Pais"] = paciente.Domicilio.Pais;
                if(paciente.CoberturaMedica != null)
                {
                    filaPacientes["Cobertura Medica"] = paciente.CoberturaMedica.Nombre;
                    filaPacientes["Plan"] = paciente.CoberturaMedica.Plan.Nombre;
                    filaPacientes["Numero Afiliado"] = paciente.CoberturaMedica.NumeroAfiliado;
                    filaPacientes["Fecha Vencimiento"] = paciente.CoberturaMedica.FechaVencimiento;
                }
                else
                {
                    filaPacientes["Cobertura Medica"] = "-";
                    filaPacientes["Plan"] = "-";
                    filaPacientes["Numero Afiliado"] = "-";
                    filaPacientes["Fecha Vencimiento"] = "-";
                }
                tablePaciente.Rows.Add(filaPacientes);
            }
            DataView dataviewPacientes = new DataView(tablePaciente);
            dgv_usuario.DataSource = TraerInformacionFiltrada(dataviewPacientes);
            dgv_usuario.Columns[0].Visible = false;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void BuscarAdministrador(string usuario, string DNI)
        {
             BLAdministrador bLAdministrador = new BLAdministrador();
            try
            {
                this.Administradores = bLAdministrador.BuscarAdministrador(usuario, DNI).ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable tableAdministrador = new DataTable();
            tableAdministrador.Columns.Add("UsuarioID");
            tableAdministrador.Columns.Add("Nombre");
            tableAdministrador.Columns.Add("Apellido");
            tableAdministrador.Columns.Add("DNI");
            tableAdministrador.Columns.Add("Fecha Nacimiento");
            tableAdministrador.Columns.Add("Sexo");
            tableAdministrador.Columns.Add("Estado Civil");
            tableAdministrador.Columns.Add("Telefono");
            tableAdministrador.Columns.Add("Email");
            tableAdministrador.Columns.Add("Calle");
            tableAdministrador.Columns.Add("Numero");
            tableAdministrador.Columns.Add("Piso");
            tableAdministrador.Columns.Add("Localidad");
            tableAdministrador.Columns.Add("Provincia");
            tableAdministrador.Columns.Add("Pais");

            foreach (BEAdministrador administrador in this.Administradores)
            {
                DataRow filaAdministrador = tableAdministrador.NewRow();
                filaAdministrador["UsuarioID"] = administrador.UsuarioID;
                filaAdministrador["Nombre"] = administrador.Nombre;
                filaAdministrador["Apellido"] = administrador.Apellido;
                filaAdministrador["DNI"] = administrador.DNI;
                filaAdministrador["Fecha Nacimiento"] = administrador.FechaNacimiento;
                filaAdministrador["Sexo"] = administrador.Sexo;
                filaAdministrador["Estado Civil"] = administrador.EstadoCivil;
                filaAdministrador["Telefono"] = administrador.Telefono;
                filaAdministrador["Email"] = administrador.Email;
                filaAdministrador["Calle"] = administrador.Domicilio.Calle;
                filaAdministrador["Numero"] = administrador.Domicilio.Numero;
                filaAdministrador["Piso"] = administrador.Domicilio.Piso;
                filaAdministrador["Localidad"] = administrador.Domicilio.Localidad;
                filaAdministrador["Provincia"] = administrador.Domicilio.Provincia;
                filaAdministrador["Pais"] = administrador.Domicilio.Pais;

                tableAdministrador.Rows.Add(filaAdministrador);
            }
            DataView dataviewAdministrador = new DataView(tableAdministrador);
            dgv_usuario.DataSource = TraerInformacionFiltrada(dataviewAdministrador);
            dgv_usuario.Columns[0].Visible = false;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btn_Cancelar_BuscarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_BuscarUsuario_Click(object sender, EventArgs e)
        {
            txt_Usuario_BuscarUsuario.Clear();
            txt_DNI_BuscarUsuario.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
        }

        private void btn_SeleccionarUsuario_BuscarUsuarios_Click(object sender, EventArgs e)
        {
            if(this._formPadre != null)
            {
                if (dgv_usuario.SelectedRows.Count != 0)
                {
                    long usuarioID = Convert.ToInt64(dgv_usuario.SelectedRows[0].Cells["UsuarioID"].Value);
                    if (this.rb_medico_BuscarUsuarios.Checked)
                    {
                        this._formPadre.CargarUsuarioMedico(this.Medicos.Where(x => x.UsuarioID == usuarioID).FirstOrDefault());
                        this.Close();
                    }
                    else if (this.rb_enfermero_BuscarUsuarios.Checked)
                    {
                        this._formPadre.CargarUsuarioEnfermero(this.Enfermeros.Where(x => x.UsuarioID == usuarioID).FirstOrDefault());
                        this.Close();
                    }
                    else if (this.rb_paciente_BuscarUsuarios.Checked)
                    {
                        this._formPadre.CargarUsuarioPaciente(this.Pacientes.Where(x => x.UsuarioID == usuarioID).FirstOrDefault());
                        this.Close();
                    }
                    else if (this.rb_administrador_BuscarUsuarios.Checked)
                    {
                        this._formPadre.CargarUsuarioAdministrador(this.Administradores.Where(x => x.UsuarioID == usuarioID).FirstOrDefault());
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario para administrar sus permisos");
                }
            }
        }

    }
}
