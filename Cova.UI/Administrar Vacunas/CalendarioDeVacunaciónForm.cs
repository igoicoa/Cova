using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Cova.BE;
using Cova.Servicios.Sesion;
using Cova.BE.Enum;
using Cova.BL;
using System.Data;

namespace Cova.UI
{
    public partial class CalendarioDeVacunaciónForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _paciente;
        private List<BEVacunaDosis> _vacunasEsquemaCompleto;
        private List<BEVacunaDosis> _vacunasEsquemaIncompleto;

        public CalendarioDeVacunaciónForm()
        {
            InitializeComponent();
            CargarPaciente();
        }

        public void CargarPaciente()
        {
            if (Sesion.GetInstance != null)
            {
                if(Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Paciente)
                {
                    CargarDatosPacienteLogueado();
                    CargarVacunasPaciente();
                    this.btn_BuscarPacientes_CalendarioVacunacion.Visible = false;
                }
            }
        }

        public void CargarDatosPacienteLogueado()
        {
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                long usuarioId = Sesion.GetInstance.Usuario.UsuarioID;
                string usuario = Sesion.GetInstance.Usuario.Usuario;
                this._paciente = bLPaciente.BuscarPacientes(usuario, "").ToList().Where(x => x.UsuarioID == usuarioId).FirstOrDefault();
                CargarDatosPaciente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarVacunasPaciente()
        {
            CargarVacunasEsquemaCompletoPaciente();
            CargarVacunasEsquemaIncompletoPaciente();
        }

        public void CargarVacunasEsquemaCompletoPaciente()
        {
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                this._vacunasEsquemaCompleto = bLPaciente.ObtenerVacunasAplicadasEsquemaCompleto(this._paciente).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarVacunasEsquemaIncompletoPaciente()
        {
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                this._vacunasEsquemaIncompleto = bLPaciente.ObtenerVacunasAplicadasEsquemaIncompleto(this._paciente).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarDatosPaciente()
        {
            this.txt_apellido_CalendarioVacunacion.Text = this._paciente.Apellido;
            this.txt_nombre_CalendarioVacunacion.Text = this._paciente.Nombre;
            this.txt_DNI_CalendarioVacunacion.Text = this._paciente.DNI.ToString();
            this.txt_edad_CalendarioVacunacion.Text = this._paciente.Edad.ToString();
        }
        public bool ValidarTodosLosCamposCalendarioVacuna()
        {
            if (string.IsNullOrEmpty(txt_apellido_CalendarioVacunacion.Text) || (string.IsNullOrEmpty(txt_nombre_CalendarioVacunacion.Text))
                || (string.IsNullOrEmpty(txt_edad_CalendarioVacunacion.Text)) || string.IsNullOrEmpty(txt_DNI_CalendarioVacunacion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancelar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            txt_apellido_CalendarioVacunacion.Clear();
            txt_DNI_CalendarioVacunacion.Clear();
            txt_edad_CalendarioVacunacion.Clear();
            txt_nombre_CalendarioVacunacion.Clear();
        }

        private void btn_BuscarPacientes_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente paciente)
        {
            this._paciente = paciente;
            this.CargarDatosPaciente();
            this.CargarVacunasPaciente();
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }
    
        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        private void bttn_Mostrar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            List<BEVacunaDosis> vacunasAMostrar = new List<BEVacunaDosis>();
            if (string.IsNullOrEmpty(cmb_Estado_CalendarioVacunacion.Text))
            {
                MessageBox.Show("Completar el estado por el cual desee informarse");
                return;
            }else if ( cmb_Estado_CalendarioVacunacion.SelectedItem.ToString() == "Completo")
                    {
                        vacunasAMostrar = this._vacunasEsquemaCompleto;
                    } 
            else
                {
                    vacunasAMostrar = this._vacunasEsquemaIncompleto;
                }
            DataTable tableVacunas = new DataTable();
            tableVacunas.Columns.Add("Vacuna");
            tableVacunas.Columns.Add("Laboratorio");
            tableVacunas.Columns.Add("Cantidad Dosis");
            tableVacunas.Columns.Add("Lote");
            tableVacunas.Columns.Add("Dosis Aplicadas");
            tableVacunas.Columns.Add("Fecha Aplicacion");
            tableVacunas.Columns.Add("Fecha Elaboracion");
            tableVacunas.Columns.Add("Fecha Vencimiento");
            tableVacunas.Columns.Add("Observacion Paciente");
            tableVacunas.Columns.Add("Indicacion Medico");
            tableVacunas.Columns.Add("Descripcion");
            tableVacunas.Columns.Add("Contraindicaciones");

            foreach (BEVacunaDosis vacunaDosis in vacunasAMostrar)
            {
                DataRow filaVacunas = tableVacunas.NewRow();
                filaVacunas["Vacuna"] = vacunaDosis.Vacuna.Nombre;
                filaVacunas["Laboratorio"] = vacunaDosis.Vacuna.Laboratorio.Nombre;
                filaVacunas["Cantidad Dosis"] = vacunaDosis.Vacuna.CantidadDosis;
                filaVacunas["Lote"] = vacunaDosis.Lote;
                filaVacunas["Dosis Aplicadas"] = vacunaDosis.Dosis;
                filaVacunas["Fecha Aplicacion"] = vacunaDosis.FechaAplicacion;
                filaVacunas["Fecha Elaboracion"] = vacunaDosis.FechaElaboracion;
                filaVacunas["Fecha Vencimiento"] = vacunaDosis.FechaVencimiento;
                filaVacunas["Observacion Paciente"] = vacunaDosis.ObservacionPaciente;
                filaVacunas["Indicacion Medico"] = vacunaDosis.IndicacionMedico;
                filaVacunas["Descripcion"] = vacunaDosis.Vacuna.Descripcion;
                filaVacunas["Contraindicaciones"] = vacunaDosis.Vacuna.Contraindicaciones;
                tableVacunas.Rows.Add(filaVacunas);
            }

            DataView dataviewVacunas = new DataView(tableVacunas);
            dtgv_CalendarioVacunacion.DataSource = dataviewVacunas;
            dtgv_CalendarioVacunacion.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv_CalendarioVacunacion.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
