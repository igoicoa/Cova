using Cova.BE;
using Cova.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string s = "";

            //BEC bitacoraABuscar = new BEBitacora();
            //bitacoraABuscar.Usuario = (BEUsuario)cmb_Usuarios.SelectedItem;
            //bitacoraABuscar.Criticidad = (TipoCriticidad)cmb_Criticidad_Bitacora.SelectedItem;
            //BLBitacora buscarbitacora = new BLBitacora();

            //try
            //{
            //    this.Bitacora = buscarbitacora.BuscarBitacora(bitacoraABuscar, fechaDesde, fechaHasta).ToList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //DataTable tableBitacora = new DataTable();
            //tableBitacora.Columns.Add("BitacoraID");
            //tableBitacora.Columns.Add("Fecha");
            //tableBitacora.Columns.Add("Criticidad");
            //tableBitacora.Columns.Add("Usuario");
            //tableBitacora.Columns.Add("Mensaje");
            //tableBitacora.Columns.Add("Funcionalidad");

            //foreach (BEBitacora bitacora in this.Bitacora)
            //{
            //    DataRow filaBitacora = tableBitacora.NewRow();
            //    filaBitacora["BitacoraID"] = bitacora.BitacoraId;
            //    filaBitacora["Fecha"] = bitacora.Fecha;
            //    filaBitacora["Criticidad"] = bitacora.Criticidad;
            //    filaBitacora["Usuario"] = bitacora.Usuario.UsuarioID;
            //    filaBitacora["Mensaje"] = bitacora.Mensaje;
            //    filaBitacora["Funcionalidad"] = bitacora.Funcionalidad;
            //    tableBitacora.Rows.Add(filaBitacora);
            //}
            //DataView dataviewBitacora = new DataView(tableBitacora);
            //dgv_Bitacora.DataSource = dataviewBitacora;
            //dgv_Bitacora.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv_Bitacora.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv_Bitacora.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv_Bitacora.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv_Bitacora.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgv_Bitacora.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void cmb_Usuarios_ControlCambios_SelectedIndexChanged(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem == null) return;
            BEUsuario usuario = (BEUsuario)e.ListItem;
            e.Value = $"{usuario.UsuarioID} (- {usuario.Usuario})";
        }
    }
}
