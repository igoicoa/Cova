﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cova.BE;
using Cova.BL;

namespace Cova.UI
{
    public partial class RegistrarTurnoForm : Form
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
            try
            {
                BLProfesional bLProfesional = new BLProfesional();
                List<BETurno> turnos = bLProfesional.ObtenerTurnosLibres(this._profesional, fechaDesde, fechaHasta).ToList();

                DataTable tableTurnos = new DataTable();
                tableTurnos.Columns.Add("Profesional");
                tableTurnos.Columns.Add("Dia Turno");
                tableTurnos.Columns.Add("Hora Turno");
                
                foreach (BETurno turno in turnos)
                {
                    DataRow filaTurno = tableTurnos.NewRow();
                    filaTurno["Profesional"] = turno.Profesional.ApellidoNombre;
                    filaTurno["Dia Turno"] = turno.FechaTurno.Day;
                    filaTurno["Hora Turno"] = turno.FechaTurno.Hour;

                    tableTurnos.Rows.Add(filaTurno);
                }

                DataView dataviewTurnos = new DataView(tableTurnos);
                dgv_RegistrarTurnos.DataSource = dataviewTurnos;
                dgv_RegistrarTurnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_RegistrarTurnos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_RegistrarTurnos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
