﻿namespace Cova.UI
{
    partial class AgregarIdiomaForm
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
            this.dgv_etiquetas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdiomaNuevo = new System.Windows.Forms.TextBox();
            this.btn_AgregarIdioma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_etiquetas
            // 
            this.dgv_etiquetas.AllowUserToAddRows = false;
            this.dgv_etiquetas.AllowUserToDeleteRows = false;
            this.dgv_etiquetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_etiquetas.Location = new System.Drawing.Point(12, 99);
            this.dgv_etiquetas.Name = "dgv_etiquetas";
            this.dgv_etiquetas.Size = new System.Drawing.Size(619, 339);
            this.dgv_etiquetas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Idioma nuevo:";
            // 
            // txt_IdiomaNuevo
            // 
            this.txt_IdiomaNuevo.Location = new System.Drawing.Point(104, 25);
            this.txt_IdiomaNuevo.MaxLength = 50;
            this.txt_IdiomaNuevo.Name = "txt_IdiomaNuevo";
            this.txt_IdiomaNuevo.Size = new System.Drawing.Size(160, 20);
            this.txt_IdiomaNuevo.TabIndex = 2;
            // 
            // btn_AgregarIdioma
            // 
            this.btn_AgregarIdioma.Location = new System.Drawing.Point(27, 67);
            this.btn_AgregarIdioma.Name = "btn_AgregarIdioma";
            this.btn_AgregarIdioma.Size = new System.Drawing.Size(109, 23);
            this.btn_AgregarIdioma.TabIndex = 3;
            this.btn_AgregarIdioma.Text = "Agregar Idioma";
            this.btn_AgregarIdioma.UseVisualStyleBackColor = true;
            this.btn_AgregarIdioma.Click += new System.EventHandler(this.btn_AgregarIdioma_Click);
            // 
            // AgregarIdiomaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AgregarIdioma);
            this.Controls.Add(this.txt_IdiomaNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_etiquetas);
            this.Name = "AgregarIdiomaForm";
            this.Text = "Agregar Idioma";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_etiquetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdiomaNuevo;
        private System.Windows.Forms.Button btn_AgregarIdioma;
    }
}