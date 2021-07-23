using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cova.UI
{
    public partial class ModificarHistoriaClinicaForm : Form
    {
        public ModificarHistoriaClinicaForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_ModificarHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_VerHistoriaClinicaHistorial_ModificarHistoriaClinica_Click(object sender, EventArgs e)
        {
            VerHistorialHistoriaClinicaForm frmVerHistorialHistoriaClinica = new VerHistorialHistoriaClinicaForm();
            frmVerHistorialHistoriaClinica.Show();
        }

        private void btn_BuscarPacientes_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarPacientesForm frmBuscarPacientes = new BuscarPacientesForm();
            frmBuscarPacientes.Show();
        }

        private void btn_Limpiar_ModificarHistoriaClinica_Click(object sender, EventArgs e)
        {
            txt_NumeroDocumento_ModificarHistoriaClinica.Clear();
            txt_PesoActual_ModificarHistoriaClinica.Clear();
            txt_Edad_ModificarHistoriaClinica.Clear();
            txt_Medicacion_ModificarHistoriaClinica.Clear();
            txt_MotivoConsulta_ModificarHistoriaClinica.Clear();
            txt_Observacion_ModificarHistoriaClinica.Clear();
            txt_apellido_ModificarHistoriaClinica.Clear();
            txt_nombre_ModificarHistoriaClinica.Clear();
            txt_NumeroDocumento_ModificarHistoriaClinica.Clear();
        }
    }
}
