
namespace Cova.UI
{
    partial class CambiarIdiomaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_idiomas_CambiarIdioma = new System.Windows.Forms.ComboBox();
            this.lbl_Idioma_CambiarIdioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_idiomas_CambiarIdioma
            // 
            this.cmb_idiomas_CambiarIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_idiomas_CambiarIdioma.FormattingEnabled = true;
            this.cmb_idiomas_CambiarIdioma.Location = new System.Drawing.Point(105, 34);
            this.cmb_idiomas_CambiarIdioma.Name = "cmb_idiomas_CambiarIdioma";
            this.cmb_idiomas_CambiarIdioma.Size = new System.Drawing.Size(148, 21);
            this.cmb_idiomas_CambiarIdioma.TabIndex = 12;
            this.cmb_idiomas_CambiarIdioma.SelectedIndexChanged += new System.EventHandler(this.cmb_idiomas_CambiarIdioma_SelectedIndexChanged);
            // 
            // lbl_Idioma_CambiarIdioma
            // 
            this.lbl_Idioma_CambiarIdioma.AutoSize = true;
            this.lbl_Idioma_CambiarIdioma.Location = new System.Drawing.Point(34, 37);
            this.lbl_Idioma_CambiarIdioma.Name = "lbl_Idioma_CambiarIdioma";
            this.lbl_Idioma_CambiarIdioma.Size = new System.Drawing.Size(38, 13);
            this.lbl_Idioma_CambiarIdioma.TabIndex = 11;
            this.lbl_Idioma_CambiarIdioma.Text = "Idioma";
            // 
            // CambiarIdiomaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 98);
            this.Controls.Add(this.cmb_idiomas_CambiarIdioma);
            this.Controls.Add(this.lbl_Idioma_CambiarIdioma);
            this.Name = "CambiarIdiomaForm";
            this.Text = "CambiarIdiomaForm";
            this.Load += new System.EventHandler(this.CambiarIdiomaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_idiomas_CambiarIdioma;
        private System.Windows.Forms.Label lbl_Idioma_CambiarIdioma;
    }
}