using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cova.UI.Interfaces;
using Cova.BE;
using Cova.BL;

namespace Cova.UI
{
    public partial class AplicarVacunaForm : Form, IFormCargarUsuarios, IFormCargarVacunas
    {
        private BEVacunaDosis _vacunaAAplicar;
        private BEPaciente _pacienteAVacunar;

        public AplicarVacunaForm()
        {
            InitializeComponent();
            CargarCentrosMedicos();
            CargarCantidadDosis();
        }

        private void btn_Cancelar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarCentrosMedicos()
        {
            BLCentroMedico bLCentroMedico = new BLCentroMedico();
            this.cmb_centroMedico.DataSource = bLCentroMedico.ObtenerCentrosMedicos();
            this.cmb_centroMedico.DisplayMember = "Nombre";
            this.cmb_centroMedico.ValueMember = "CentroMedicoId";
            this.cmb_centroMedico.SelectedIndex = -1;
        }

        public void CargarCantidadDosis()
        {
            List<int> cantidadDosis = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                cantidadDosis.Add(i);
            }
            cmb_dosis.DataSource = cantidadDosis;
        }

        private void btn_Limpiar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            txt_apellido_AplicarVacunas.Clear();
            txt_Observacion_AplicarVacunas.Clear();
            txt_Edad_AplicarVacunas.Clear();
            txt_nombre_AplicarVacunas.Clear();
            this.cmb_centroMedico.SelectedIndex = -1;
        }

        private void btn_BuscarPacientes_AplicarVacunas_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente pacienteAVacunar)
        {
            _pacienteAVacunar = pacienteAVacunar;
            txt_apellido_AplicarVacunas.Text = pacienteAVacunar.Apellido;
            txt_nombre_AplicarVacunas.Text = pacienteAVacunar.Nombre;
            txt_NumeroDocumento_AplicarVacunas.Text = Convert.ToString(pacienteAVacunar.DNI);
            txt_Edad_AplicarVacunas.Text = Convert.ToString(pacienteAVacunar.Edad);
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        private void btn_BuscarPacientes_AplicarVacunas_Click_1(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void CargarVacunasDosis(BEVacunaDosis Vacuna)
        {
            this._vacunaAAplicar = Vacuna;
            txt_vacuna.Text = Vacuna.Vacuna.Nombre;
            txt_laboratorio.Text = Vacuna.Vacuna.Laboratorio.Nombre;
            txt_lote.Text = Vacuna.Lote;
            dtp_fechaElaboracion.Value = Vacuna.FechaElaboracion;
            dtp_fechaVencimiento.Value = Vacuna.FechaVencimiento;
        }

        private void btn_Aplicar_AplicarVacunas_Click(object sender, EventArgs e)
        {
            BLPaciente blPaciente = new BLPaciente();
            this._vacunaAAplicar.FechaAplicacion = dtp_fechaAplicacion_AplicarVacunas.Value;
            this._vacunaAAplicar.Dosis = Convert.ToInt32(cmb_dosis.Text);
            Dictionary<bool, List<string>> correspondeRecibirDosis = (Dictionary<bool, List<string>>)blPaciente.EstaEnCondicionesDeRecibirVacuna(this._pacienteAVacunar, this._vacunaAAplicar);
            if(correspondeRecibirDosis.ContainsKey(false))
            {
                string razones = "";
                foreach(string razon in correspondeRecibirDosis[false])
                {
                    razones += razon + "\n";
                }
                MessageBox.Show(razones);
                return;
            }
            else
            {
                if(blPaciente.VacunarPaciente(this._pacienteAVacunar, this._vacunaAAplicar))
                {
                    MessageBox.Show("Se realizó la aplicación de la vacuna");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al registrar la aplicacion de la vacuna");
                }
            }
            
        }

        private void btn_buscarVacuna_Click(object sender, EventArgs e)
        {
            int centroMedicoId;
            if(cmb_centroMedico.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un centro medico para buscar una dosis de vacuna");
                return;
            }
            centroMedicoId = ((BECentroMedico)cmb_centroMedico.SelectedItem).CentroMedicoId;
            BuscarVacunasForm buscarVacunasForm = new BuscarVacunasForm(centroMedicoId, this);
            buscarVacunasForm.Show();
        }
    }
}
