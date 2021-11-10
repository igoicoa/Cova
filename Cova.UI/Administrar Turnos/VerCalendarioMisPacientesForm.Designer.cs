
namespace Cova.UI
{
    partial class VerCalendarioMisPacientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCalendarioMisPacientesForm));
            this.lbl_VerCalendariodePacientes = new System.Windows.Forms.Label();
            this.dtp_fechaDesde_AplicarVacunas = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaDesde_VerCalendariodePacientes = new System.Windows.Forms.Label();
            this.dtp_FechaHAsta_VerCalendariodePacientes = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaHasta_VerCalendariodePacientes = new System.Windows.Forms.Label();
            this.dtg_VerCalendarioPacientes = new System.Windows.Forms.DataGridView();
            this.btn_Limpiar_VerCalendariodePacientes = new System.Windows.Forms.Button();
            this.btn_Cancelar_VerCalendariodePacientes = new System.Windows.Forms.Button();
            this.btn_Buscar_VerCalendariodePacientes = new System.Windows.Forms.Button();
            this.lbl_Estado_VerCalendariodePacientes = new System.Windows.Forms.Label();
            this.cmb_estado_VerCalendariodePacientes = new System.Windows.Forms.ComboBox();
            this.gb_Filtros = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_VerCalendarioPacientes)).BeginInit();
            this.gb_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_VerCalendariodePacientes
            // 
            this.lbl_VerCalendariodePacientes.AutoSize = true;
            this.lbl_VerCalendariodePacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VerCalendariodePacientes.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_VerCalendariodePacientes.Location = new System.Drawing.Point(12, 9);
            this.lbl_VerCalendariodePacientes.Name = "lbl_VerCalendariodePacientes";
            this.lbl_VerCalendariodePacientes.Size = new System.Drawing.Size(309, 25);
            this.lbl_VerCalendariodePacientes.TabIndex = 129;
            this.lbl_VerCalendariodePacientes.Text = "Ver calendario de Pacientes";
            this.lbl_VerCalendariodePacientes.UseWaitCursor = true;
            // 
            // dtp_fechaDesde_AplicarVacunas
            // 
            this.dtp_fechaDesde_AplicarVacunas.Location = new System.Drawing.Point(83, 25);
            this.dtp_fechaDesde_AplicarVacunas.Name = "dtp_fechaDesde_AplicarVacunas";
            this.dtp_fechaDesde_AplicarVacunas.Size = new System.Drawing.Size(214, 20);
            this.dtp_fechaDesde_AplicarVacunas.TabIndex = 139;
            // 
            // lbl_FechaDesde_VerCalendariodePacientes
            // 
            this.lbl_FechaDesde_VerCalendariodePacientes.AutoEllipsis = true;
            this.lbl_FechaDesde_VerCalendariodePacientes.AutoSize = true;
            this.lbl_FechaDesde_VerCalendariodePacientes.Location = new System.Drawing.Point(6, 28);
            this.lbl_FechaDesde_VerCalendariodePacientes.Name = "lbl_FechaDesde_VerCalendariodePacientes";
            this.lbl_FechaDesde_VerCalendariodePacientes.Size = new System.Drawing.Size(71, 13);
            this.lbl_FechaDesde_VerCalendariodePacientes.TabIndex = 138;
            this.lbl_FechaDesde_VerCalendariodePacientes.Text = "Fecha Desde";
            // 
            // dtp_FechaHAsta_VerCalendariodePacientes
            // 
            this.dtp_FechaHAsta_VerCalendariodePacientes.Location = new System.Drawing.Point(83, 66);
            this.dtp_FechaHAsta_VerCalendariodePacientes.Name = "dtp_FechaHAsta_VerCalendariodePacientes";
            this.dtp_FechaHAsta_VerCalendariodePacientes.Size = new System.Drawing.Size(214, 20);
            this.dtp_FechaHAsta_VerCalendariodePacientes.TabIndex = 141;
            // 
            // lbl_FechaHasta_VerCalendariodePacientes
            // 
            this.lbl_FechaHasta_VerCalendariodePacientes.AutoEllipsis = true;
            this.lbl_FechaHasta_VerCalendariodePacientes.AutoSize = true;
            this.lbl_FechaHasta_VerCalendariodePacientes.Location = new System.Drawing.Point(9, 69);
            this.lbl_FechaHasta_VerCalendariodePacientes.Name = "lbl_FechaHasta_VerCalendariodePacientes";
            this.lbl_FechaHasta_VerCalendariodePacientes.Size = new System.Drawing.Size(68, 13);
            this.lbl_FechaHasta_VerCalendariodePacientes.TabIndex = 140;
            this.lbl_FechaHasta_VerCalendariodePacientes.Text = "Fecha Hasta";
            // 
            // dtg_VerCalendarioPacientes
            // 
            this.dtg_VerCalendarioPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_VerCalendarioPacientes.Location = new System.Drawing.Point(17, 234);
            this.dtg_VerCalendarioPacientes.Name = "dtg_VerCalendarioPacientes";
            this.dtg_VerCalendarioPacientes.ReadOnly = true;
            this.dtg_VerCalendarioPacientes.Size = new System.Drawing.Size(785, 321);
            this.dtg_VerCalendarioPacientes.TabIndex = 142;
            // 
            // btn_Limpiar_VerCalendariodePacientes
            // 
            this.btn_Limpiar_VerCalendariodePacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar_VerCalendariodePacientes.Location = new System.Drawing.Point(352, 119);
            this.btn_Limpiar_VerCalendariodePacientes.Name = "btn_Limpiar_VerCalendariodePacientes";
            this.btn_Limpiar_VerCalendariodePacientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar_VerCalendariodePacientes.TabIndex = 151;
            this.btn_Limpiar_VerCalendariodePacientes.Text = "Limpiar";
            this.btn_Limpiar_VerCalendariodePacientes.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar_VerCalendariodePacientes
            // 
            this.btn_Cancelar_VerCalendariodePacientes.Location = new System.Drawing.Point(271, 119);
            this.btn_Cancelar_VerCalendariodePacientes.Name = "btn_Cancelar_VerCalendariodePacientes";
            this.btn_Cancelar_VerCalendariodePacientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar_VerCalendariodePacientes.TabIndex = 150;
            this.btn_Cancelar_VerCalendariodePacientes.Text = "Cancelar";
            this.btn_Cancelar_VerCalendariodePacientes.UseVisualStyleBackColor = true;
            this.btn_Cancelar_VerCalendariodePacientes.Click += new System.EventHandler(this.btn_Cancelar_VerCalendariodePacientes_Click);
            // 
            // btn_Buscar_VerCalendariodePacientes
            // 
            this.btn_Buscar_VerCalendariodePacientes.Location = new System.Drawing.Point(185, 119);
            this.btn_Buscar_VerCalendariodePacientes.Name = "btn_Buscar_VerCalendariodePacientes";
            this.btn_Buscar_VerCalendariodePacientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar_VerCalendariodePacientes.TabIndex = 149;
            this.btn_Buscar_VerCalendariodePacientes.Text = "Buscar";
            this.btn_Buscar_VerCalendariodePacientes.UseVisualStyleBackColor = true;
            // 
            // lbl_Estado_VerCalendariodePacientes
            // 
            this.lbl_Estado_VerCalendariodePacientes.AutoEllipsis = true;
            this.lbl_Estado_VerCalendariodePacientes.AutoSize = true;
            this.lbl_Estado_VerCalendariodePacientes.Location = new System.Drawing.Point(328, 25);
            this.lbl_Estado_VerCalendariodePacientes.Name = "lbl_Estado_VerCalendariodePacientes";
            this.lbl_Estado_VerCalendariodePacientes.Size = new System.Drawing.Size(40, 13);
            this.lbl_Estado_VerCalendariodePacientes.TabIndex = 152;
            this.lbl_Estado_VerCalendariodePacientes.Text = "Estado";
            // 
            // cmb_estado_VerCalendariodePacientes
            // 
            this.cmb_estado_VerCalendariodePacientes.FormattingEnabled = true;
            this.cmb_estado_VerCalendariodePacientes.Location = new System.Drawing.Point(374, 21);
            this.cmb_estado_VerCalendariodePacientes.Name = "cmb_estado_VerCalendariodePacientes";
            this.cmb_estado_VerCalendariodePacientes.Size = new System.Drawing.Size(96, 21);
            this.cmb_estado_VerCalendariodePacientes.TabIndex = 153;
            // 
            // gb_Filtros
            // 
            this.gb_Filtros.Controls.Add(this.lbl_FechaDesde_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.btn_Limpiar_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.cmb_estado_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.btn_Cancelar_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.dtp_fechaDesde_AplicarVacunas);
            this.gb_Filtros.Controls.Add(this.btn_Buscar_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.lbl_Estado_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.lbl_FechaHasta_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.dtp_FechaHAsta_VerCalendariodePacientes);
            this.gb_Filtros.Location = new System.Drawing.Point(17, 49);
            this.gb_Filtros.Name = "gb_Filtros";
            this.gb_Filtros.Size = new System.Drawing.Size(661, 166);
            this.gb_Filtros.TabIndex = 154;
            this.gb_Filtros.TabStop = false;
            this.gb_Filtros.Text = "Filtros";
            // 
            // VerCalendarioMisPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 619);
            this.Controls.Add(this.gb_Filtros);
            this.Controls.Add(this.dtg_VerCalendarioPacientes);
            this.Controls.Add(this.lbl_VerCalendariodePacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerCalendarioMisPacientesForm";
            this.Text = "VerCalendarioMisPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_VerCalendarioPacientes)).EndInit();
            this.gb_Filtros.ResumeLayout(false);
            this.gb_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VerCalendariodePacientes;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde_AplicarVacunas;
        private System.Windows.Forms.Label lbl_FechaDesde_VerCalendariodePacientes;
        private System.Windows.Forms.DateTimePicker dtp_FechaHAsta_VerCalendariodePacientes;
        private System.Windows.Forms.Label lbl_FechaHasta_VerCalendariodePacientes;
        private System.Windows.Forms.DataGridView dtg_VerCalendarioPacientes;
        private System.Windows.Forms.Button btn_Limpiar_VerCalendariodePacientes;
        private System.Windows.Forms.Button btn_Cancelar_VerCalendariodePacientes;
        private System.Windows.Forms.Button btn_Buscar_VerCalendariodePacientes;
        private System.Windows.Forms.Label lbl_Estado_VerCalendariodePacientes;
        private System.Windows.Forms.ComboBox cmb_estado_VerCalendariodePacientes;
        private System.Windows.Forms.GroupBox gb_Filtros;
    }
}