﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cova.UI.Realizar_Backup
{
    public partial class RealizarBackupForm : Form
    {
        public RealizarBackupForm()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_RealizarBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
