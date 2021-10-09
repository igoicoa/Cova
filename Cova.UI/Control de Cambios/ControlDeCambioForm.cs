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
                List<BEControlDeCambioPaciente> pacientes = controlDeCambio.ObtenerControlDeCambioPaciente().ToList();
                DataTable tableControlDeCambios = new DataTable();
                tableControlDeCambios.Columns.Add("Fecha Modificacion");
                tableControlDeCambios.Columns.Add("Tipo Cambio");
                tableControlDeCambios.Columns.Add("Usuario Modificador");
                tableControlDeCambios.Columns.Add("Nombre");
                tableControlDeCambios.Columns.Add("Apellido");
                tableControlDeCambios.Columns.Add("DNI");
                tableControlDeCambios.Columns.Add("Fecha Nacimiento");
                tableControlDeCambios.Columns.Add("Sexo");
                tableControlDeCambios.Columns.Add("Estado Civil");
                tableControlDeCambios.Columns.Add("Telefono");
                tableControlDeCambios.Columns.Add("Email");
                tableControlDeCambios.Columns.Add("Calle");
                tableControlDeCambios.Columns.Add("Numero");
                tableControlDeCambios.Columns.Add("Piso");
                tableControlDeCambios.Columns.Add("Localidad");
                tableControlDeCambios.Columns.Add("Provincia");
                tableControlDeCambios.Columns.Add("Pais");
                tableControlDeCambios.Columns.Add("Cobertura Medica");
                tableControlDeCambios.Columns.Add("Plan");
                tableControlDeCambios.Columns.Add("Numero Afiliado");
                tableControlDeCambios.Columns.Add("Fecha Vencimiento");

                foreach (BEControlDeCambioPaciente paciente in pacientes)
                {
                    DataRow filaControlDeCambios = tableControlDeCambios.NewRow();
                    filaControlDeCambios["Fecha Modificacion"] = paciente.FechaModificacion;
                    filaControlDeCambios["Tipo Cambio"] = paciente.TipoCambio;
                    filaControlDeCambios["Usuario Modificador"] = paciente.UsuarioModificador.Usuario;
                    filaControlDeCambios["Nombre"] = paciente.Paciente.Nombre;
                    filaControlDeCambios["Apellido"] = paciente.Paciente.Apellido;
                    filaControlDeCambios["DNI"] = paciente.Paciente.DNI;
                    filaControlDeCambios["Fecha Nacimiento"] = paciente.Paciente.FechaNacimiento;
                    filaControlDeCambios["Sexo"] = paciente.Paciente.Sexo;
                    filaControlDeCambios["Estado Civil"] = paciente.Paciente.EstadoCivil;
                    filaControlDeCambios["Telefono"] = paciente.Paciente.Telefono;
                    filaControlDeCambios["Email"] = paciente.Paciente.Email;
                    filaControlDeCambios["Calle"] = paciente.Paciente.Domicilio.Calle;
                    filaControlDeCambios["Numero"] = paciente.Paciente.Domicilio.Numero;
                    filaControlDeCambios["Piso"] = paciente.Paciente.Domicilio.Piso;
                    filaControlDeCambios["Localidad"] = paciente.Paciente.Domicilio.Localidad;
                    filaControlDeCambios["Provincia"] = paciente.Paciente.Domicilio.Provincia;
                    filaControlDeCambios["Pais"] = paciente.Paciente.Domicilio.Pais;
                    if (paciente.Paciente.CoberturaMedica != null)
                    {
                        filaControlDeCambios["Cobertura Medica"] = paciente.Paciente.CoberturaMedica.Nombre;
                        filaControlDeCambios["Plan"] = paciente.Paciente.CoberturaMedica.Plan.Nombre;
                        filaControlDeCambios["Numero Afiliado"] = paciente.Paciente.CoberturaMedica.NumeroAfiliado;
                        filaControlDeCambios["Fecha Vencimiento"] = paciente.Paciente.CoberturaMedica.FechaVencimiento;
                    }
                    else
                    {
                        filaControlDeCambios["Cobertura Medica"] = "-";
                        filaControlDeCambios["Plan"] = "-";
                        filaControlDeCambios["Numero Afiliado"] = "-";
                        filaControlDeCambios["Fecha Vencimiento"] = "-";
                    }
                    tableControlDeCambios.Rows.Add(filaControlDeCambios);
                }

                DataView dataviewControlDeCambios = new DataView(tableControlDeCambios);
                dgv_ControlCambios.DataSource = dataviewControlDeCambios;
                dgv_ControlCambios.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[15].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[16].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[17].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[18].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[19].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv_ControlCambios.Columns[20].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmb_Usuarios_ControlCambios_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem == null) return;
            BEUsuario usuario = (BEUsuario)e.ListItem;
            e.Value = $"{usuario.UsuarioID} (- {usuario.Usuario})";
        }
    }
}
