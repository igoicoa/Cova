using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cova.BL;
using Cova.BE;

namespace Cova.UI
{
    public partial class BuscarUsuarios : Form
    {
        public BuscarUsuarios()
        {
            InitializeComponent();
        }

        private void bttn_Buscar_BuscarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = this.txt_Usuario_BuscarUsuario.Text;
            string DNI = txt_DNI_BuscarUsuario.Text;

            if (rb_medico_BuscarUsuarios.Checked)
            {
                this.BuscarMedico(usuario, DNI);
            }
            else if(rb_enfermero_BuscarUsuarios.Checked)
            {
                this.BuscarEnfermero(usuario, DNI);
            }
            else if(rb_paciente_BuscarUsuarios.Checked)
            {
                this.BuscarPaciente(usuario, DNI);
            }
            else if(rb_administrador_BuscarUsuarios.Checked)
            {
                this.BuscarAdministrador(usuario, DNI);
            }
        }

        public void BuscarMedico(string usuario, string DNI)
        {
            BLMedico bLMedico = new BLMedico();
            List<BEMedico> medicos = bLMedico.BuscarMedicos(usuario, DNI).ToList();

            DataTable tableMedicos = new DataTable();
            tableMedicos.Columns.Add("Nombre");
            tableMedicos.Columns.Add("Apellido");
            tableMedicos.Columns.Add("DNI");
            tableMedicos.Columns.Add("Fecha Nacimiento");
            foreach (BEMedico medico in medicos)
            {
                DataRow filaMedico = tableMedicos.NewRow();
                filaMedico["Nombre"] = medico.Nombre;
                filaMedico["Apellido"] = medico.Apellido;
                filaMedico["DNI"] = medico.DNI;
                filaMedico["Fecha Nacimiento"] = medico.FechaNacimiento;

                tableMedicos.Rows.Add(filaMedico);
            }
            DataView dataviewMedicos = new DataView(tableMedicos);
            dgv_usuario.DataSource = dataviewMedicos;
            dgv_usuario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        public void BuscarEnfermero(string usuario, string DNI)
        {
            BLEnfermero bLEnfermero = new BLEnfermero();
            List<BEEnfermero> enfermeros = bLEnfermero.BuscarEnfermeros(usuario, DNI).ToList();
            DataTable tableEnfermeros = new DataTable();
            tableEnfermeros.Columns.Add("Nombre");
            tableEnfermeros.Columns.Add("Apellido");
            tableEnfermeros.Columns.Add("DNI");
            tableEnfermeros.Columns.Add("Fecha Nacimiento");
            foreach (BEEnfermero enfermero in enfermeros)
            {
                DataRow filaEnfermero = tableEnfermeros.NewRow();
                filaEnfermero["Nombre"] = enfermero.Nombre;
                filaEnfermero["Apellido"] = enfermero.Apellido;
                filaEnfermero["DNI"] = enfermero.DNI;
                filaEnfermero["Fecha Nacimiento"] = enfermero.FechaNacimiento;

                tableEnfermeros.Rows.Add(filaEnfermero);
            }
            DataView dataviewEnfermeros = new DataView(tableEnfermeros);
            dgv_usuario.DataSource = dataviewEnfermeros;
            dgv_usuario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void BuscarPaciente(string usuario, string DNI)
        {
            BLPaciente bLPaciente = new BLPaciente();
            List<BEPaciente> pacientes = bLPaciente.BuscarPacientes(usuario, DNI).ToList();

            DataTable tablePaciente = new DataTable();
            tablePaciente.Columns.Add("Nombre");
            tablePaciente.Columns.Add("Apellido");
            tablePaciente.Columns.Add("DNI");
            tablePaciente.Columns.Add("Fecha Nacimiento");
            foreach (BEPaciente paciente in pacientes)
            {
                DataRow filaPacientes = tablePaciente.NewRow();
                filaPacientes["Nombre"] = paciente.Nombre;
                filaPacientes["Apellido"] = paciente.Apellido;
                filaPacientes["DNI"] = paciente.DNI;
                filaPacientes["Fecha Nacimiento"] = paciente.FechaNacimiento;

                tablePaciente.Rows.Add(filaPacientes);
            }
            DataView dataviewPacientes = new DataView(tablePaciente);
            dgv_usuario.DataSource = dataviewPacientes;
            dgv_usuario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_usuario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        public void BuscarAdministrador(string usuario, string DNI)
        {

        }
    }
}
