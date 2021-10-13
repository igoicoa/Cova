using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Cova.BE;
using Cova.UI.Interfaces;

namespace Cova.UI
{
    public partial class BuscarCoberturaMedicaForm : Form
    {
        private IFormCargarCoberturas _formPadre;
        private List<BECoberturaMedica> _coberturasMedicas;

        public BuscarCoberturaMedicaForm(IFormCargarCoberturas formPadre = null)
        {
            InitializeComponent();
            this._formPadre = formPadre;
            if(formPadre == null)
            {
                btn_SeleccionarCobertura_BuscarCoberturaMedica.Visible = false;
            }
        }

        private void btn_Cancelar_BuscarCoberturaMedica_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_BuscarCoberturaMedica_Click(object sender, EventArgs e)
        {
        }

        private void btn_SeleccionarCobertura_BuscarCoberturaMedica_Click(object sender, EventArgs e)
        {
            if (this._formPadre != null)
            {
                if (dtg_ListarCoberturasMedicas_BuscarCoberturaMedica.SelectedRows.Count != 0)
                {
                    long coberturaMedicaId = Convert.ToInt64(dtg_ListarCoberturasMedicas_BuscarCoberturaMedica.SelectedRows[0].Cells["CoberturaMedicaId"].Value);
                    this._formPadre.CargarCobertura(this._coberturasMedicas.Where(x => x.CoberturaMedicaId == coberturaMedicaId).FirstOrDefault());
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cobertura medica");
            }
        }

    }
}
