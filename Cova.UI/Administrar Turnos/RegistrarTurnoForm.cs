using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;
using Cova.UI.Administrar_Turnos;
using Cova.UI.Interfaces;

namespace Cova.UI
{
    public partial class RegistrarTurnoForm : Form, IFormCargarMedicos
    {
        private BEProfesional _profesional;
        public RegistrarTurnoForm()
        {
            InitializeComponent();
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtp_FechaDesde.Value;
            DateTime fechaHasta = dtp_FechaHasta.Value;
            if(this._profesional == null)
            {
                MessageBox.Show("Debe buscar un profesional para ver los turnos disponibles");
                return;
            }
            try
            {
                BLProfesional bLProfesional = new BLProfesional();
                List<BETurno> turnos = bLProfesional.ObtenerTurnosLibres(this._profesional, fechaDesde, fechaHasta).ToList();

                DataTable tableTurnos = new DataTable();
                tableTurnos.Columns.Add("Profesional");
                tableTurnos.Columns.Add("FechaTurno");
                tableTurnos.Columns.Add("Dia Turno");
                tableTurnos.Columns.Add("Hora Turno");
                
                foreach (BETurno turno in turnos)
                {
                    DataRow filaTurno = tableTurnos.NewRow();
                    filaTurno["Profesional"] = turno.Profesional.ApellidoNombre;
                    filaTurno["FechaTurno"] = turno.FechaTurno;
                    filaTurno["Dia Turno"] = turno.FechaTurno.DayOfWeek + " " + turno.FechaTurno.Day;
                    filaTurno["Hora Turno"] = turno.FechaTurno.Hour + ":" + turno.FechaTurno.Minute;

                    tableTurnos.Rows.Add(filaTurno);
                }

                DataView dataviewTurnos = new DataView(tableTurnos);
                dgv_RegistrarTurnos.DataSource = dataviewTurnos;
                dgv_RegistrarTurnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_RegistrarTurnos.Columns[1].Visible = false;
                dgv_RegistrarTurnos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_RegistrarTurnos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarUsuarioMedico(BEMedico medico)
        {
            this._profesional = medico;
            this.txt_profesional.Text = medico.ApellidoNombre;
        }

        private void btn_BuscarProfesional_Click(object sender, EventArgs e)
        {
            BuscarProfesionalForm frmBuscarProfesional = new BuscarProfesionalForm(this);
            frmBuscarProfesional.Show();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            if (dgv_RegistrarTurnos.SelectedRows.Count != 0)
            {
                BETurno turnoNuevo = new BETurno();
                BLTurno bLTurno = new BLTurno();
                DateTime fechaTurno = (DateTime)(dgv_RegistrarTurnos.SelectedRows[0].Cells["FechaTurno"].Value);
                turnoNuevo.Profesional = this._profesional;
                turnoNuevo.FechaTurno = fechaTurno;
                BECentroMedico bECentroMedico = new BECentroMedico();
                bECentroMedico.CentroMedicoId = 1;
                turnoNuevo.CentroMedico = bECentroMedico;
                bLTurno.GenerarTurno(turnoNuevo);
                this.Close();
            }
        }
    }
}
