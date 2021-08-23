using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cova.UI.Bitacora
{
    public partial class BitacoraForm : Form
    {
        public BitacoraForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Bitacora_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Bitacora_Click(object sender, EventArgs e)
        {
            txt_Usuario_Bitacora.Clear();
        }

        private void btn_Filtrar_Bitacora_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = new DateTime(dtp_FechaDesde.Value.Year, dtp_FechaDesde.Value.Month, dtp_FechaDesde.Value.Day, 00, 00, 00);
            DateTime fechaHasta = new DateTime(dtp_FechaHasta.Value.Year, dtp_FechaHasta.Value.Month, dtp_FechaHasta.Value.Day, 23, 59, 59);
            

            string s = "";
        }
    }
}
