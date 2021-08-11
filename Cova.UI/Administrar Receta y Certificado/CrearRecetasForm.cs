using System;
using System.Windows.Forms;
using Cova.BL;
using Cova.BE;
using Cova.Servicios.Sesion;
using System.Linq;

namespace Cova.UI
{
    public partial class CrearRecetasForm : Form, IFormCargarUsuarios
    {
        private BEPaciente _pacienteARecetar;
        private BEMedico _usuarioMedico;
        public CrearRecetasForm()
        {
            InitializeComponent();
            CargarVacunas();
            CargarDatosMedico();
        }

        public void CargarDatosMedico()
        {
            string usuario = Sesion.GetInstance.Usuario.Usuario;
            long usuarioID = Sesion.GetInstance.Usuario.UsuarioID;
            BLMedico bLMedico = new BLMedico();
            this._usuarioMedico = bLMedico.BuscarMedicos(usuario, "").ToList().Where(x => x.UsuarioID == usuarioID).FirstOrDefault();
        }

        public void CargarVacunas()
        {
            BLVacuna bLVacuna = new BLVacuna();
            this.cmb_vacuna.DataSource = bLVacuna.ObtenerVacunas();
            this.cmb_vacuna.DisplayMember = "Nombre";
            this.cmb_vacuna.ValueMember = "VacunaId";
            this.cmb_vacuna.SelectedIndex = -1;
        }

        public bool ValidarTodosLosCamposReceta()
        {
            if (string.IsNullOrEmpty(txt_apellido_CrearReceta.Text) || (string.IsNullOrEmpty(txt_nombre_CrearReceta.Text))
                || (string.IsNullOrEmpty(txt_Edad_CrearReceta.Text)) || string.IsNullOrEmpty(txt_NumeroDocumento_CrearReceta.Text)
                || string.IsNullOrEmpty(rtxt_Diagnostico.Text) || string.IsNullOrEmpty(dtp_fecha_CrearReceta.Value.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_BuscarPacientes_CrearReceta_Click(object sender, EventArgs e)
        {
            BuscarUsuariosForm buscarUsuariosForm = new BuscarUsuariosForm(true, this);
            buscarUsuariosForm.Show();
        }

        public void CargarUsuarioPaciente(BEPaciente pacienteARecetar)
        {
            this._pacienteARecetar = pacienteARecetar;
            txt_apellido_CrearReceta.Text = pacienteARecetar.Apellido;
            txt_nombre_CrearReceta.Text = pacienteARecetar.Nombre;
            txt_Edad_CrearReceta.Text = pacienteARecetar.Edad.ToString();
            txt_NumeroDocumento_CrearReceta.Text = pacienteARecetar.DNI.ToString();
        }

        private void btn_Cancelar_CrearReceta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CrearReceta_Click(object sender, EventArgs e)
        {
            txt_Edad_CrearReceta.Clear();
            txt_NumeroDocumento_CrearReceta.Clear();
            txt_apellido_CrearReceta.Clear();
            txt_nombre_CrearReceta.Clear();
            rtxt_Diagnostico.Clear();
        }

        public void CargarUsuarioAdministrador(BEAdministrador usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioEnfermero(BEEnfermero usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        public void CargarUsuarioMedico(BEMedico usuarioAModificar)
        {
            throw new NotImplementedException();
        }

        private void btnCrearReceta_CrearReceta_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarTodosLosCamposReceta())
                {
                    BLReceta blReceta = new BLReceta();
                    BEReceta receta = new BEReceta();
                    BEVacuna vacuna = ((BEVacuna)cmb_vacuna.SelectedItem);
                    receta.Vacuna = vacuna;
                    receta.FechaPrescripcion = dtp_fecha_CrearReceta.Value;
                    receta.Paciente = this._pacienteARecetar;
                    receta.Medico = this._usuarioMedico;
                    receta.Observacion = rtxt_Diagnostico.Text;
                    if (blReceta.CrearReceta(receta))
                    {
                        MessageBox.Show("La Receta fue creada con exito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al crear la receta");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
           
        }
    }
}
