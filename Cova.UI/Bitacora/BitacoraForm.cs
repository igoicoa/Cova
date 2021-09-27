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
using Cova.BE.Bitacora;
using Cova.BL;

namespace Cova.UI.Bitacora
{
    public partial class BitacoraForm : Form
    {
        public List<BEBitacora> Bitacora;

        public BitacoraForm()
        {
            InitializeComponent();
            cmb_Criticidad_Bitacora.DataSource = Enum.GetValues(typeof(TipoCriticidad));
            BLUsuario bLUsuario = new BLUsuario();
            cmb_Usuarios.DataSource = bLUsuario.BuscarUsuarios("", "");
        }
        private void btn_Cancelar_Bitacora_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Bitacora_Click(object sender, EventArgs e)
        {
        }

        private void btn_Filtrar_Bitacora_Click(object sender, EventArgs e)
        {

            DateTime fechaDesde = new DateTime(dtp_FechaDesde.Value.Year, dtp_FechaDesde.Value.Month, dtp_FechaDesde.Value.Day, 00, 00, 00);
            DateTime fechaHasta = new DateTime(dtp_FechaHasta.Value.Year, dtp_FechaHasta.Value.Month, dtp_FechaHasta.Value.Day, 23, 59, 59);
            string s = "";

            BEBitacora bitacoraABuscar = new BEBitacora();
            bitacoraABuscar.Usuario = (BEUsuario)cmb_Usuarios.SelectedItem;
            bitacoraABuscar.Criticidad= (TipoCriticidad)cmb_Criticidad_Bitacora.SelectedItem;
            BLBitacora buscarbitacora = new BLBitacora();

            try
            {
                this.Bitacora = buscarbitacora.BuscarBitacora(bitacoraABuscar, fechaDesde, fechaHasta).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DataTable tableBitacora = new DataTable();
            tableBitacora.Columns.Add("BitacoraID");
            tableBitacora.Columns.Add("Fecha");
            tableBitacora.Columns.Add("Criticidad");
            tableBitacora.Columns.Add("Usuario");
            tableBitacora.Columns.Add("Mensaje");
            tableBitacora.Columns.Add("Funcionalidad");

            foreach (BEBitacora bitacora in this.Bitacora)
            {
                DataRow filaBitacora = tableBitacora.NewRow();
                filaBitacora["BitacoraID"] = bitacora.BitacoraId;
                filaBitacora["Fecha"] = bitacora.Fecha;
                filaBitacora["Criticidad"] = bitacora.Criticidad;
                filaBitacora["Usuario"] = bitacora.Usuario.Usuario;
                filaBitacora["Mensaje"] = bitacora.Mensaje;
                filaBitacora["Funcionalidad"] = bitacora.Funcionalidad;
                tableBitacora.Rows.Add(filaBitacora);
            }
            DataView dataviewBitacora = new DataView(tableBitacora);
            dgv_Bitacora.DataSource = dataviewBitacora;
            dgv_Bitacora.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Bitacora.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Bitacora.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Bitacora.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Bitacora.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Bitacora.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void cmb_Usuarios_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem == null) return;
            BEUsuario usuario = (BEUsuario)e.ListItem;
            e.Value = $"{usuario.UsuarioID} (- {usuario.Usuario})";
        }
    }
}
