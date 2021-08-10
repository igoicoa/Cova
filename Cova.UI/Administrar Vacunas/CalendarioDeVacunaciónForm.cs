using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Cova.BE;
using Cova.Servicios.Sesion;
using Cova.BE.Enum;
using Cova.BL;

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
            long usuarioId = Sesion.GetInstance.Usuario.UsuarioID;
            string usuario = Sesion.GetInstance.Usuario.Usuario;
            this._paciente = bLPaciente.BuscarPacientes(usuario, "").ToList().Where(x => x.UsuarioID == usuarioId).FirstOrDefault();
            CargarDatosPaciente();
        }

        public void CargarVacunasPaciente()
        {
            CargarVacunasEsquemaCompletoPaciente();
            CargarVacunasEsquemaIncompletoPaciente();
        }

        public void CargarVacunasEsquemaCompletoPaciente()
        {
            BLPaciente bLPaciente = new BLPaciente();
            this._vacunasEsquemaCompleto = bLPaciente.ObtenerVacunasAplicadasEsquemaCompleto(this._paciente).ToList();

        }

        public void CargarVacunasEsquemaIncompletoPaciente()
        {
            BLPaciente bLPaciente = new BLPaciente();
            this._vacunasEsquemaCompleto = bLPaciente.ObtenerVacunasAplicadasEsquemaIncompleto(this._paciente).ToList();
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
            BEVacunaDosis vacunaDosis = new BEVacunaDosis();
            BEVacuna vacuna = new BEVacuna();
            BELaboratorio laboratorio = new BELaboratorio();
            BECentroMedico centroMedico = new BECentroMedico();
            BLVacuna bLVacuna = new BLVacuna();

            if ( cmb_Estado_CalendarioVacunacion.SelectedItem.ToString() == "Aplicada")
            {

            }
            
            //DataTable tableVacunas = new DataTable();
            //tableVacunas.Columns.Add("Lote");
            //tableVacunas.Columns.Add("Fecha Elaboracion");
            //tableVacunas.Columns.Add("Fecha Vencimiento");
            //tableVacunas.Columns.Add("VacunaId");
            //tableVacunas.Columns.Add("Nombre Vacuna");
            //tableVacunas.Columns.Add("Descripcion");
            //tableVacunas.Columns.Add("Prospecto");
            //tableVacunas.Columns.Add("Contraindicaciones");
            //tableVacunas.Columns.Add("Cantidad Dosis");
            //tableVacunas.Columns.Add("Edad Minima");
            //tableVacunas.Columns.Add("Edad Maxima");
            //tableVacunas.Columns.Add("LaboratorioId");
            //tableVacunas.Columns.Add("Nombre Laboratorio");


            //foreach (BEVacunaDosis vacunaDosis in this.VacunasDosis)
            //{
            //    DataRow filaVacunas = tableVacunas.NewRow();
            //    filaVacunas["Lote"] = vacunaDosis.Lote;
            //    filaVacunas["Fecha Elaboracion"] = vacunaDosis.FechaElaboracion;
            //    filaVacunas["Fecha Vencimiento"] = vacunaDosis.FechaVencimiento;
            //    filaVacunas["VacunaId"] = vacunaDosis.Vacuna.VacunaID;
            //    filaVacunas["Nombre Vacuna"] = vacunaDosis.Vacuna.Nombre;
            //    filaVacunas["Descripcion"] = vacunaDosis.Vacuna.Descripcion;
            //    filaVacunas["Prospecto"] = vacunaDosis.Vacuna.Prospecto;
            //    filaVacunas["Contraindicaciones"] = vacunaDosis.Vacuna.Contraindicaciones;
            //    filaVacunas["Cantidad Dosis"] = vacunaDosis.Vacuna.CantidadDosis;
            //    filaVacunas["Edad Minima"] = vacunaDosis.Vacuna.EdadMinimaAplicacion;
            //    filaVacunas["Edad Maxima"] = vacunaDosis.Vacuna.EdadMaximaAplicacion;
            //    filaVacunas["LaboratorioId"] = vacunaDosis.Vacuna.Laboratorio.LaboratorioId;
            //    filaVacunas["Nombre Laboratorio"] = vacunaDosis.Vacuna.Laboratorio.Nombre;
            //    tableVacunas.Rows.Add(filaVacunas);
            //}

            //DataView dataviewVacunas = new DataView(tableVacunas);
            //dtg_ListaVacunas_VerVacunas.DataSource = dataviewVacunas;
            //dtg_ListaVacunas_VerVacunas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[3].Visible = false;
            //dtg_ListaVacunas_VerVacunas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dtg_ListaVacunas_VerVacunas.Columns[11].Visible = false;
            //dtg_ListaVacunas_VerVacunas.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
