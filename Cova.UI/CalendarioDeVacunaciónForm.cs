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
    public partial class CalendarioDeVacunaciónForm : Form
    {
        public CalendarioDeVacunaciónForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_CalendarioVacunacion_Click(object sender, EventArgs e)
        {
            txt_apellido_CalendarioVacunacion.Clear();
            txt_DNI_CalendarioVacunacion.Clear();
            txt_edad_CalendarioVacunacion.Clear();
            txt_nombre_CalendarioVacunacion.Clear();
        }
    }
}
