using Cova.Common.Multiidioma;
using Cova.Servicios.Multiidioma;
using System;
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
    public partial class CambiarIdiomaForm : Form, IIdiomaObserver
    {
        public CambiarIdiomaForm()
        {
            InitializeComponent();
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

        }

        private void CambiarIdiomaForm_Load(object sender, EventArgs e)
        {
            //cmb_idiomas_CambiarIdioma.DataSource = null;
            //idioma = _idiomaBL.GetAllHabilitados();
            //idiomasTraducidos.Clear();
            //cmb_idiomas_CambiarIdioma.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            //foreach (Entities.Idioma idioma in idiomas)
            //{
            //    idioma.Nombre = Program.LanguageManager.Traducir(idioma.Nombre);
            //    idiomasTraducidos.Add(idioma);
            //}

            //cmb_idiomas_CambiarIdioma.DisplayMember = "Nombre";
            //cmb_idiomas_CambiarIdioma.DataSource = idiomasTraducidos.AsReadOnly();
            //cmb_idiomas_CambiarIdioma.SelectedIndex = idiomasTraducidos.FindIndex(item => item.ID == Program.LanguageManager.Idioma.ID);
            //cmb_idiomas_CambiarIdioma.SelectedIndexChanged += cmb_idiomas_CambiarIdioma_SelectedIndexChanged;
        }
    }
}
