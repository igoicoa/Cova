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
    public partial class VerCalendarioMisPacientes : Form
    {
        public VerCalendarioMisPacientes()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_VerCalendariodePacientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
