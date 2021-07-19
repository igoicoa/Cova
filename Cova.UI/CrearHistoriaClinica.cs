﻿using System;
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
    public partial class CrearHistoriaClinica : Form
    {
        public CrearHistoriaClinica()
        {
            InitializeComponent();
        }

        private void btn_BuscarUsuarios_ModificarUsuarios_Click(object sender, EventArgs e)
        {
            BuscarUsuarios frmBuscarUsuarios = new BuscarUsuarios();
            frmBuscarUsuarios.Show();
        }

        private void btnCancelar_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_CrearHistoriaClinica_Click(object sender, EventArgs e)
        {
            txt_NumeroDocumento_CrearHistoriaClinica.Clear();
            txt_Usuario_CrearHistoriaClinica.Clear();
            txt_MotivoConsulta.Clear();
            txt_Medicacion_CrearHistoriaClinica.Clear();
            txt_Observacion_CrearHistoriaClinica.Clear();
            txt_PesoActual_CrearHistoriaClinica.Clear();
        }
    }
}