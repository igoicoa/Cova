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
using Cova.UI.Interfaces;

namespace Cova.UI
{
    public partial class BuscarVacunasForm : Form
    {
        private int? _centroMedicoId;
        public List<BEVacunaDosis> VacunasDosis;
        private IFormCargarVacunas _formPadre;
        public BuscarVacunasForm(int? CentroMedicoId = null, IFormCargarVacunas formPadre = null)
        {
            InitializeComponent();
            this._centroMedicoId = CentroMedicoId;
            this._formPadre = formPadre;
        }

        private void btn_Cancelar_BuscarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_BuscarVacunas_Click(object sender, EventArgs e)
        {
            txt_lote.Clear();
            txt_Nombre_BuscarVacunas.Clear();
        }

        private void btn_Buscar_BuscarVacunas_Click(object sender, EventArgs e)
        {
            BEVacunaDosis vacunaABuscar = new BEVacunaDosis();
            BECentroMedico centroMedico = new BECentroMedico();
            BELaboratorio laboratorio = new BELaboratorio();

            laboratorio.LaboratorioId = (int)cmb_Laboratorio_BuscarVacunas.SelectedValue;
            centroMedico.CentroMedicoId = (int)this._centroMedicoId;
            vacunaABuscar.Vacuna = new BEVacuna();
            vacunaABuscar.Lote = txt_lote.Text;
            vacunaABuscar.Vacuna.Laboratorio = laboratorio;
            vacunaABuscar.Vacuna.Nombre = txt_Nombre_BuscarVacunas.Text;

            BLVacuna bLVacuna = new BLVacuna();
            bLVacuna.ObtenerVacunasDeCentroMedico(vacunaABuscar);
            this.VacunasDosis = bLVacuna.ObtenerVacunasDeCentroMedico(vacunaABuscar).ToList();
            DataTable tableVacunas = new DataTable();
            tableVacunas.Columns.Add("Lote");
            tableVacunas.Columns.Add("Fecha Elaboracion");
            tableVacunas.Columns.Add("Fecha Vencimiento");
            tableVacunas.Columns.Add("VacunaId");
            tableVacunas.Columns.Add("Nombre Vacuna");
            tableVacunas.Columns.Add("Descripcion");
            tableVacunas.Columns.Add("Prospecto");
            tableVacunas.Columns.Add("Contraindicaciones");
            tableVacunas.Columns.Add("Cantidad Dosis");
            tableVacunas.Columns.Add("LaboratorioId");
            tableVacunas.Columns.Add("Nombre Laboratorio");


            foreach (BEVacunaDosis vacunaDosis in this.VacunasDosis)
            {
                DataRow filaVacunas = tableVacunas.NewRow();
                filaVacunas["Lote"] = vacunaDosis.Lote;
                filaVacunas["Fecha Elaboracion"] = vacunaDosis.FechaElaboracion;
                filaVacunas["Fecha Vencimiento"] = vacunaDosis.FechaVencimiento;
                filaVacunas["VacunaId"] = vacunaDosis.Vacuna.VacunaID;
                filaVacunas["Nombre Vacuna"] = vacunaDosis.Vacuna.Nombre;
                filaVacunas["Descripcion"] = vacunaDosis.Vacuna.Descripcion;
                filaVacunas["Prospecto"] = vacunaDosis.Vacuna.Prospecto;
                filaVacunas["Contraindicaciones"] = vacunaDosis.Vacuna.Contraindicaciones;
                filaVacunas["Cantidad Dosis"] = vacunaDosis.Vacuna.CantidadDosis;
                filaVacunas["LaboratorioId"] = vacunaDosis.Vacuna.Laboratorio.LaboratorioId;
                filaVacunas["Nombre Laboratorio"] = vacunaDosis.Vacuna.Laboratorio.Nombre;
                tableVacunas.Rows.Add(filaVacunas);
            }

            DataView dataviewVacunas = new DataView(tableVacunas);
            dtg_ListaVacunas_VerVacunas.DataSource = dataviewVacunas;
            dtg_ListaVacunas_VerVacunas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[3].Visible = false;
            dtg_ListaVacunas_VerVacunas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtg_ListaVacunas_VerVacunas.Columns[9].Visible = false;
            dtg_ListaVacunas_VerVacunas.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void btn_SeleccionarVacunas_BuscarVacunas_Click(object sender, EventArgs e)
        {
            if (this._formPadre != null)
            {
                if (dtg_ListaVacunas_VerVacunas.SelectedRows.Count != 0)
                {
                    string lote = Convert.ToString(dtg_ListaVacunas_VerVacunas.SelectedRows[0].Cells["Lote"].Value);
                    this._formPadre.CargarVacunasDosis(this.VacunasDosis.Where(x => x.Lote == lote).FirstOrDefault());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una vacuna para aplicar");
                }
            }
        }
    }

}
