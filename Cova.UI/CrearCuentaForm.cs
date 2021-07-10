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
    public partial class CrearCuentaForm : Form
    {
        public CrearCuentaForm()
        {
            InitializeComponent();
        }

        public void CrearPaciente()
        {
            BEPaciente paciente = new BEPaciente();
            BLPaciente blPaciente = new BLPaciente();
            paciente.Nombre = "";
            paciente.Apellido = "";
            //TODO

            blPaciente.CrearPaciene(paciente);

        }

        public void CrearProfesionalMedico()
        {
            BEMedico medico = new BEMedico();
            BLProfesional bLProfesional = new BLProfesional();
            medico.Nombre = "";
            medico.Apellido = "";
            //TODO

            bLProfesional.CrearProfesionalMedico(medico);
        }

        public void CrearProfesionalEnfermero()
        {
            BEEnfermero enfermero = new BEEnfermero();
            BLProfesional bLProfesional = new BLProfesional();
            enfermero.Nombre = "";
            enfermero.Apellido = "";
            //TODO

            bLProfesional.CrearProfesionalEnfermero(enfermero);
        }
    }
}
