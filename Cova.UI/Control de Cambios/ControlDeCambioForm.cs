using Cova.BE.ControlCambios;
using Cova.BE;
using Cova.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cova.Servicios.ControlDeCambio;

namespace Cova.UI.Control_de_Cambios
{
    public partial class ControlDeCambioForm : Form
    {
        public ControlDeCambioForm()
        {
            InitializeComponent();
            BLUsuario bLUsuario = new BLUsuario();
            cmb_Usuarios_ControlCambios.DataSource = bLUsuario.BuscarUsuarios("", "");
        }

        private void btn_Cancelar_ControlCambios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Filtrar_ControlCambios_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = new DateTime(dtp_FechaDesde_ControlCambios.Value.Year, dtp_FechaDesde_ControlCambios.Value.Month, dtp_FechaDesde_ControlCambios.Value.Day, 00, 00, 00);
            DateTime fechaHasta = new DateTime(dtp_FechaHasta_ControlCambios.Value.Year, dtp_FechaHasta_ControlCambios.Value.Month, dtp_FechaHasta_ControlCambios.Value.Day, 23, 59, 59);

            ControlDeCambio controlDeCambio = new ControlDeCambio();
            
            try
            {
                //TODO Completar todas las filas
                List<BEControlDeCambioPaciente> pacientes = controlDeCambio.ObtenerControlDeCambioPaciente().ToList();
                DataTable tableControlDeCambios = new DataTable();
                tableControlDeCambios.Columns.Add("BitacoraID");
                tableControlDeCambios.Columns.Add("Fecha");

                foreach (BEControlDeCambioPaciente paciente in pacientes)
                {
                    DataRow filaControlDeCambios = tableControlDeCambios.NewRow();
                    filaControlDeCambios["Apellido"] = paciente.Paciente.Apellido;
                    filaControlDeCambios["Nombre"] = paciente.Paciente.Nombre;

                    tableControlDeCambios.Rows.Add(filaControlDeCambios);
                }
                DataView dataviewControlDeCambios = new DataView(tableControlDeCambios);
                dgv_ControlCambios.DataSource = dataviewControlDeCambios;
                dgv_ControlCambios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmb_Usuarios_ControlCambios_SelectedIndexChanged(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem == null) return;
            BEUsuario usuario = (BEUsuario)e.ListItem;
            e.Value = $"{usuario.UsuarioID} (- {usuario.Usuario})";
        }
    }
}
