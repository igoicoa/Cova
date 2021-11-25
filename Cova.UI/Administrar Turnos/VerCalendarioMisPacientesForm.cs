using Cova.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cova.BL;
using Cova.Servicios.Sesion;
using Cova.BE.Enum;

namespace Cova.UI
{
    public partial class VerCalendarioMisPacientesForm : Form, IFormCargarUsuarios
    {
        private BEMedico _usuarioMedico;
        private BEPaciente _usuarioPaciente;
        private List<BETurno> _turnos;
        public VerCalendarioMisPacientesForm()
        {
            InitializeComponent();
            if(Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Medico)
            {
                CargarDatosMedico();
                lbl_VerCalendarioTurnos.Text = "Ver calendario de Pacientes";
            }
            else if(Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Paciente)
            {
                CargarDatosPaciente();
                lbl_VerCalendarioTurnos.Text = "Ver mis turnos";
            }
            
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

        public void CargarDatosPaciente()
        {
            string usuario = Sesion.GetInstance.Usuario.Usuario;
            long usuarioID = Sesion.GetInstance.Usuario.UsuarioID;
            BLPaciente bLPaciente = new BLPaciente();
            try
            {
                this._usuarioPaciente = bLPaciente.BuscarPacientes(usuario, "").ToList().Where(x => x.UsuarioID == usuarioID).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancelar_VerCalendariodePacientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarPacientes_VerCalendariodePacientes_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm frmBuscarUsuarios = new BuscarUsuariosForm(false, this);
            frmBuscarUsuarios.Show();
        }

        void IFormCargarUsuarios.CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioPaciente(BEPaciente usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        void IFormCargarUsuarios.CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        private void BuscarTurnos()
        {
            try
            {
                BLTurno bLTurno = new BLTurno();
                DateTime fechaDesde = dtp_fechaDesde.Value;
                DateTime fechaHasta = dtp_FechaHasta.Value;
                if (Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Medico)
                {
                    this._turnos = bLTurno.ObtenerTurnos(null, this._usuarioMedico, null, fechaDesde, fechaHasta).ToList();
                }
                else if (Sesion.GetInstance.Usuario.TipoUsuario == TipoUsuario.Paciente)
                {
                    this._turnos = bLTurno.ObtenerTurnos(this._usuarioPaciente, null, null, fechaDesde, fechaHasta).ToList();
                }

                DataTable tableTurnos = new DataTable();
                tableTurnos.Columns.Add("TurnoId");
                tableTurnos.Columns.Add("Profesional");
                tableTurnos.Columns.Add("Paciente");
                tableTurnos.Columns.Add("Dia Turno");
                tableTurnos.Columns.Add("Hora Turno");

                foreach (BETurno turno in this._turnos)
                {
                    DataRow filaTurno = tableTurnos.NewRow();
                    filaTurno["TurnoId"] = turno.TurnoId;
                    filaTurno["Profesional"] = turno.Profesional.ApellidoNombre;
                    filaTurno["Paciente"] = turno.Paciente.ApellidoNombre;
                    filaTurno["Dia Turno"] = turno.FechaTurno.DayOfWeek + " " + turno.FechaTurno.Day;
                    filaTurno["Hora Turno"] = turno.FechaTurno.Hour + ":" + turno.FechaTurno.Minute;

                    tableTurnos.Rows.Add(filaTurno);
                }

                DataView dataviewTurnos = new DataView(tableTurnos);
                dtg_VerCalendarioPacientes.DataSource = dataviewTurnos;
                dtg_VerCalendarioPacientes.Columns[0].Visible = false;
                dtg_VerCalendarioPacientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_VerCalendarioPacientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_VerCalendarioPacientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dtg_VerCalendarioPacientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Buscar_VerCalendariodePacientes_Click(object sender, EventArgs e)
        {
            this.BuscarTurnos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_VerCalendarioPacientes.SelectedRows.Count != 0)
                {
                    long turnoIdACancelar = Convert.ToInt64(dtg_VerCalendarioPacientes.SelectedRows[0].Cells["TurnoId"].Value);
                    BETurno turnoACancelar = this._turnos.Where(x => x.TurnoId == turnoIdACancelar).FirstOrDefault();
                    BLTurno bLTurno = new BLTurno();

                    if (bLTurno.CancelarTurno(turnoACancelar))
                    {
                        MessageBox.Show("Turno cancelado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al cancelar el turno");
                    }
                    this.BuscarTurnos();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un turno para cancelar");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
