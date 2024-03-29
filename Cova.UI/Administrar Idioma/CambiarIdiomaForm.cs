﻿using Cova.Common.Multiidioma;
using Cova.Servicios.Multiidioma;
using Cova.Servicios.Sesion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cova.UI
{
    public partial class CambiarIdiomaForm : Form, IIdiomaObserver
    {
        public CambiarIdiomaForm()
        {
            InitializeComponent();
            CargarIdiomas();
        }

        public void CargarIdiomas()
        {
            Idioma idiomaDefault = new Idioma();
            ManejadorIdioma manejadorIdioma = new ManejadorIdioma(idiomaDefault);
            cmb_idiomas_CambiarIdioma.DataSource = manejadorIdioma.ObtenerIdiomas();
            cmb_idiomas_CambiarIdioma.DisplayMember = "Nombre";
            cmb_idiomas_CambiarIdioma.ValueMember = "Nombre";
        }

        public void UpdateLanguage(Idioma idioma)
        {
            this.Traducir(idioma);
        }

        private void Traducir(Idioma idioma)
        {
            Traductor traductor = new Traductor();
            IDictionary<string, Traduccion> traducciones = traductor.ObtenerTraducciones(idioma);

        }

        private void cmb_idiomas_CambiarIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            Idioma idiomaElegido = new Idioma();
            idiomaElegido.Nombre = cmb_idiomas_CambiarIdioma.SelectedValue.ToString();
            Sesion.GetInstance.ManejadorIdioma.CambiarIdioma(idiomaElegido);
        }

        private void CambiarIdiomaForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
