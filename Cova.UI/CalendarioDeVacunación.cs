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
    public partial class CalendarioDeVacunación : Form
    {
        public CalendarioDeVacunación()
        {
            InitializeComponent();
        }

        private void btnCancelar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            txtBoxUsuario_CalendarioVacunacion.Clear();
        }
    }
}
