
namespace Cova.UI
{
    partial class BuscarVacunasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarVacunasForm));
            this.btn_Limpiar_BuscarVacunas = new System.Windows.Forms.Button();
            this.btn_Cancelar_BuscarVacunas = new System.Windows.Forms.Button();
            this.dtg_ListaVacunas_VerVacunas = new System.Windows.Forms.DataGridView();
            this.btn_Buscar_BuscarVacunas = new System.Windows.Forms.Button();
            this.lbl_Nombre_BuscarVacunas = new System.Windows.Forms.Label();
            this.lbl_BuscarVacunas = new System.Windows.Forms.Label();
            this.cmb_Laboratorio_BuscarVacunas = new System.Windows.Forms.ComboBox();
            this.lbl_Laboratorio_BuscarVacunas = new System.Windows.Forms.Label();
            this.btn_SeleccionarVacunas_BuscarVacunas = new System.Windows.Forms.Button();
            this.cmb_vacuna = new System.Windows.Forms.ComboBox();
            this.lbl_Lote = new System.Windows.Forms.Label();
            this.txt_lote = new System.Windows.Forms.TextBox();
            this.cmb_centroMedico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaVacunas_VerVacunas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Limpiar_BuscarVacunas
            // 
            this.btn_Limpiar_BuscarVacunas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar_BuscarVacunas.Location = new System.Drawing.Point(240, 100);
            this.btn_Limpiar_BuscarVacunas.Name = "btn_Limpiar_BuscarVacunas";
            this.btn_Limpiar_BuscarVacunas.Size = new System.Drawing.Size(78, 23);
            this.btn_Limpiar_BuscarVacunas.TabIndex = 149;
            this.btn_Limpiar_BuscarVacunas.Text = "Limpiar";
            this.btn_Limpiar_BuscarVacunas.UseVisualStyleBackColor = true;
            this.btn_Limpiar_BuscarVacunas.Click += new System.EventHandler(this.btn_Limpiar_BuscarVacunas_Click);
            // 
            // btn_Cancelar_BuscarVacunas
            // 
            this.btn_Cancelar_BuscarVacunas.Location = new System.Drawing.Point(324, 100);
            this.btn_Cancelar_BuscarVacunas.Name = "btn_Cancelar_BuscarVacunas";
            this.btn_Cancelar_BuscarVacunas.Size = new System.Drawing.Size(78, 23);
            this.btn_Cancelar_BuscarVacunas.TabIndex = 148;
            this.btn_Cancelar_BuscarVacunas.Text = "Cancelar";
            this.btn_Cancelar_BuscarVacunas.UseVisualStyleBackColor = true;
            this.btn_Cancelar_BuscarVacunas.Click += new System.EventHandler(this.btn_Cancelar_BuscarVacunas_Click);
            // 
            // dtg_ListaVacunas_VerVacunas
            // 
            this.dtg_ListaVacunas_VerVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ListaVacunas_VerVacunas.Location = new System.Drawing.Point(11, 134);
            this.dtg_ListaVacunas_VerVacunas.Name = "dtg_ListaVacunas_VerVacunas";
            this.dtg_ListaVacunas_VerVacunas.Size = new System.Drawing.Size(930, 304);
            this.dtg_ListaVacunas_VerVacunas.TabIndex = 147;
            // 
            // btn_Buscar_BuscarVacunas
            // 
            this.btn_Buscar_BuscarVacunas.Location = new System.Drawing.Point(17, 100);
            this.btn_Buscar_BuscarVacunas.Name = "btn_Buscar_BuscarVacunas";
            this.btn_Buscar_BuscarVacunas.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar_BuscarVacunas.TabIndex = 146;
            this.btn_Buscar_BuscarVacunas.Text = "Buscar";
            this.btn_Buscar_BuscarVacunas.UseVisualStyleBackColor = true;
            this.btn_Buscar_BuscarVacunas.Click += new System.EventHandler(this.btn_Buscar_BuscarVacunas_Click);
            // 
            // lbl_Nombre_BuscarVacunas
            // 
            this.lbl_Nombre_BuscarVacunas.AutoSize = true;
            this.lbl_Nombre_BuscarVacunas.Location = new System.Drawing.Point(14, 44);
            this.lbl_Nombre_BuscarVacunas.Name = "lbl_Nombre_BuscarVacunas";
            this.lbl_Nombre_BuscarVacunas.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre_BuscarVacunas.TabIndex = 144;
            this.lbl_Nombre_BuscarVacunas.Text = "Nombre";
            // 
            // lbl_BuscarVacunas
            // 
            this.lbl_BuscarVacunas.AutoSize = true;
            this.lbl_BuscarVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarVacunas.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_BuscarVacunas.Location = new System.Drawing.Point(12, 1);
            this.lbl_BuscarVacunas.Name = "lbl_BuscarVacunas";
            this.lbl_BuscarVacunas.Size = new System.Drawing.Size(183, 25);
            this.lbl_BuscarVacunas.TabIndex = 143;
            this.lbl_BuscarVacunas.Text = "Buscar Vacunas";
            // 
            // cmb_Laboratorio_BuscarVacunas
            // 
            this.cmb_Laboratorio_BuscarVacunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Laboratorio_BuscarVacunas.FormattingEnabled = true;
            this.cmb_Laboratorio_BuscarVacunas.Location = new System.Drawing.Point(289, 60);
            this.cmb_Laboratorio_BuscarVacunas.Name = "cmb_Laboratorio_BuscarVacunas";
            this.cmb_Laboratorio_BuscarVacunas.Size = new System.Drawing.Size(236, 21);
            this.cmb_Laboratorio_BuscarVacunas.TabIndex = 142;
            // 
            // lbl_Laboratorio_BuscarVacunas
            // 
            this.lbl_Laboratorio_BuscarVacunas.AutoSize = true;
            this.lbl_Laboratorio_BuscarVacunas.Location = new System.Drawing.Point(286, 38);
            this.lbl_Laboratorio_BuscarVacunas.Name = "lbl_Laboratorio_BuscarVacunas";
            this.lbl_Laboratorio_BuscarVacunas.Size = new System.Drawing.Size(60, 13);
            this.lbl_Laboratorio_BuscarVacunas.TabIndex = 141;
            this.lbl_Laboratorio_BuscarVacunas.Text = "Laboratorio";
            // 
            // btn_SeleccionarVacunas_BuscarVacunas
            // 
            this.btn_SeleccionarVacunas_BuscarVacunas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SeleccionarVacunas_BuscarVacunas.Location = new System.Drawing.Point(98, 100);
            this.btn_SeleccionarVacunas_BuscarVacunas.Name = "btn_SeleccionarVacunas_BuscarVacunas";
            this.btn_SeleccionarVacunas_BuscarVacunas.Size = new System.Drawing.Size(136, 23);
            this.btn_SeleccionarVacunas_BuscarVacunas.TabIndex = 150;
            this.btn_SeleccionarVacunas_BuscarVacunas.Text = "Seleccionar Vacuna";
            this.btn_SeleccionarVacunas_BuscarVacunas.UseVisualStyleBackColor = true;
            this.btn_SeleccionarVacunas_BuscarVacunas.Click += new System.EventHandler(this.btn_SeleccionarVacunas_BuscarVacunas_Click);
            // 
            // cmb_vacuna
            // 
            this.cmb_vacuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vacuna.FormattingEnabled = true;
            this.cmb_vacuna.Location = new System.Drawing.Point(17, 60);
            this.cmb_vacuna.Name = "cmb_vacuna";
            this.cmb_vacuna.Size = new System.Drawing.Size(239, 21);
            this.cmb_vacuna.TabIndex = 151;
            // 
            // lbl_Lote
            // 
            this.lbl_Lote.AutoSize = true;
            this.lbl_Lote.Location = new System.Drawing.Point(563, 38);
            this.lbl_Lote.Name = "lbl_Lote";
            this.lbl_Lote.Size = new System.Drawing.Size(28, 13);
            this.lbl_Lote.TabIndex = 152;
            this.lbl_Lote.Text = "Lote";
            // 
            // txt_lote
            // 
            this.txt_lote.Location = new System.Drawing.Point(566, 60);
            this.txt_lote.Name = "txt_lote";
            this.txt_lote.Size = new System.Drawing.Size(131, 20);
            this.txt_lote.TabIndex = 153;
            // 
            // cmb_centroMedico
            // 
            this.cmb_centroMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_centroMedico.FormattingEnabled = true;
            this.cmb_centroMedico.Location = new System.Drawing.Point(719, 60);
            this.cmb_centroMedico.Name = "cmb_centroMedico";
            this.cmb_centroMedico.Size = new System.Drawing.Size(236, 21);
            this.cmb_centroMedico.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 154;
            this.label1.Text = "Centro Medico";
            // 
            // BuscarVacunasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.cmb_centroMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lote);
            this.Controls.Add(this.lbl_Lote);
            this.Controls.Add(this.cmb_vacuna);
            this.Controls.Add(this.btn_SeleccionarVacunas_BuscarVacunas);
            this.Controls.Add(this.btn_Limpiar_BuscarVacunas);
            this.Controls.Add(this.btn_Cancelar_BuscarVacunas);
            this.Controls.Add(this.dtg_ListaVacunas_VerVacunas);
            this.Controls.Add(this.btn_Buscar_BuscarVacunas);
            this.Controls.Add(this.lbl_Nombre_BuscarVacunas);
            this.Controls.Add(this.lbl_BuscarVacunas);
            this.Controls.Add(this.cmb_Laboratorio_BuscarVacunas);
            this.Controls.Add(this.lbl_Laboratorio_BuscarVacunas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarVacunasForm";
            this.Text = "BuscarVacunas";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ListaVacunas_VerVacunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar_BuscarVacunas;
        private System.Windows.Forms.Button btn_Cancelar_BuscarVacunas;
        private System.Windows.Forms.DataGridView dtg_ListaVacunas_VerVacunas;
        private System.Windows.Forms.Button btn_Buscar_BuscarVacunas;
        private System.Windows.Forms.Label lbl_Nombre_BuscarVacunas;
        private System.Windows.Forms.Label lbl_BuscarVacunas;
        private System.Windows.Forms.ComboBox cmb_Laboratorio_BuscarVacunas;
        private System.Windows.Forms.Label lbl_Laboratorio_BuscarVacunas;
        private System.Windows.Forms.Button btn_SeleccionarVacunas_BuscarVacunas;
        private System.Windows.Forms.ComboBox cmb_vacuna;
        private System.Windows.Forms.Label lbl_Lote;
        private System.Windows.Forms.TextBox txt_lote;
        private System.Windows.Forms.ComboBox cmb_centroMedico;
        private System.Windows.Forms.Label label1;
    }
}