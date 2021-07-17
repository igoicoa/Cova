using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Cova.Servicios.Sesion;
using Cova.Common.Multiidioma;

namespace Cova.UI
{
    public partial class AgregarIdiomaForm : Form
    {
        public AgregarIdiomaForm()
        {
            InitializeComponent();
            CargarEtiquetas();
        }

        public void CargarEtiquetas()
        {
            Dictionary<string, Traduccion> traduccionesDefault = (Dictionary<string, Traduccion>)Sesion.GetInstance.ManejadorIdioma.ObtenerEtiquetasIdiomaDefault();
            DataTable tableEtiquetas = new DataTable();
            tableEtiquetas.Columns.Add("Etiqueta Nombre");
            tableEtiquetas.Columns.Add("Idioma Default");
            tableEtiquetas.Columns.Add("Palabra Traducida");
            tableEtiquetas.Columns.Add("Palabra Nuevo Idioma");
            foreach (string etiqueta in traduccionesDefault.Keys)
            {
                DataRow filaEtiquetas = tableEtiquetas.NewRow();
                filaEtiquetas["Etiqueta Nombre"] = traduccionesDefault[etiqueta].Etiqueta.Nombre;
                filaEtiquetas["Idioma Default"] = traduccionesDefault[etiqueta].Idioma.Nombre;
                filaEtiquetas["Palabra Traducida"] = traduccionesDefault[etiqueta].PalabraTraducida;
                filaEtiquetas["Palabra Nuevo Idioma"] = "";
                tableEtiquetas.Rows.Add(filaEtiquetas);
            }
            DataView dataviewEtiquetas = new DataView(tableEtiquetas);
            dgv_etiquetas.DataSource = dataviewEtiquetas;
            dgv_etiquetas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_etiquetas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_etiquetas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_etiquetas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btn_AgregarIdioma_Click(object sender, EventArgs e)
        {
            Idioma idiomaNuevo = new Idioma();
            if(string.IsNullOrEmpty(txt_IdiomaNuevo.Text))
            {
                MessageBox.Show("Debe completar el nombre del idioma");
                return;
            }
            idiomaNuevo.Nombre = txt_IdiomaNuevo.Text;
            
            List<Traduccion> traducciones = new List<Traduccion>();
            foreach(DataGridViewRow row in dgv_etiquetas.Rows)
            {
                Traduccion traduccion = new Traduccion();
                traduccion.Idioma = idiomaNuevo;
                traduccion.Etiqueta = new Etiqueta();
                traduccion.Etiqueta.Nombre = row.Cells[0].Value.ToString();
                traduccion.PalabraTraducida = row.Cells[3].Value.ToString();

                if(string.IsNullOrEmpty(traduccion.PalabraTraducida))
                {
                    MessageBox.Show("Debe completar todas las etiquetas del nuevo idioma");
                    return;
                }

                traducciones.Add(traduccion);
            }
            bool idiomaCreado = Sesion.GetInstance.ManejadorIdioma.CrearIdioma(idiomaNuevo);
            if(idiomaCreado)
            {
                bool crearTraducciones = Sesion.GetInstance.ManejadorIdioma.AgregarTraducciones(traducciones);
                if (crearTraducciones)
                {
                    MessageBox.Show("Idioma agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el idioma");
                }
            }
            else
            {
                MessageBox.Show("Hubo un error al crear el idioma nuevo. Asegurese que el mismo no exista");
            }
        }
    }
}
