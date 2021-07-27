using System;
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

namespace Cova.UI
{
    public partial class BuscarVacunasForm : Form
    {
        private int? _centroMedicoId;
        public BuscarVacunasForm(int? CentroMedicoId = null)
        {
            InitializeComponent();
            this._centroMedicoId = CentroMedicoId;
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
            //TODO CARGAR TABLA
        }
    }
}
