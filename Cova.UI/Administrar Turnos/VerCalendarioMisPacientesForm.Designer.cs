
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
            this.lbl_VerCalendarioTurnos = new System.Windows.Forms.Label();
            this.dtp_fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaDesde_VerCalendariodePacientes = new System.Windows.Forms.Label();
            this.dtp_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaHasta_VerCalendariodePacientes = new System.Windows.Forms.Label();
            this.dtg_VerCalendarioPacientes = new System.Windows.Forms.DataGridView();
            this.btn_Buscar_VerCalendariodePacientes = new System.Windows.Forms.Button();
            this.gb_Filtros = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_VerCalendarioPacientes)).BeginInit();
            this.gb_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_VerCalendarioTurnos
            // 
            this.lbl_VerCalendarioTurnos.AutoSize = true;
            this.lbl_VerCalendarioTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VerCalendarioTurnos.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_VerCalendarioTurnos.Location = new System.Drawing.Point(12, 9);
            this.lbl_VerCalendarioTurnos.Name = "lbl_VerCalendarioTurnos";
            this.lbl_VerCalendarioTurnos.Size = new System.Drawing.Size(309, 25);
            this.lbl_VerCalendarioTurnos.TabIndex = 129;
            this.lbl_VerCalendarioTurnos.Text = "Ver calendario de Pacientes";
            this.lbl_VerCalendarioTurnos.UseWaitCursor = true;
            // 
            // dtp_fechaDesde
            // 
            this.dtp_fechaDesde.Location = new System.Drawing.Point(83, 25);
            this.dtp_fechaDesde.Name = "dtp_fechaDesde";
            this.dtp_fechaDesde.Size = new System.Drawing.Size(214, 20);
            this.dtp_fechaDesde.TabIndex = 139;
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
            // dtp_FechaHasta
            // 
            this.dtp_FechaHasta.Location = new System.Drawing.Point(83, 66);
            this.dtp_FechaHasta.Name = "dtp_FechaHasta";
            this.dtp_FechaHasta.Size = new System.Drawing.Size(214, 20);
            this.dtp_FechaHasta.TabIndex = 141;
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
            this.dtg_VerCalendarioPacientes.Location = new System.Drawing.Point(17, 195);
            this.dtg_VerCalendarioPacientes.Name = "dtg_VerCalendarioPacientes";
            this.dtg_VerCalendarioPacientes.ReadOnly = true;
            this.dtg_VerCalendarioPacientes.Size = new System.Drawing.Size(304, 311);
            this.dtg_VerCalendarioPacientes.TabIndex = 142;
            // 
            // btn_Buscar_VerCalendariodePacientes
            // 
            this.btn_Buscar_VerCalendariodePacientes.Location = new System.Drawing.Point(126, 106);
            this.btn_Buscar_VerCalendariodePacientes.Name = "btn_Buscar_VerCalendariodePacientes";
            this.btn_Buscar_VerCalendariodePacientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar_VerCalendariodePacientes.TabIndex = 149;
            this.btn_Buscar_VerCalendariodePacientes.Text = "Buscar";
            this.btn_Buscar_VerCalendariodePacientes.UseVisualStyleBackColor = true;
            this.btn_Buscar_VerCalendariodePacientes.Click += new System.EventHandler(this.btn_Buscar_VerCalendariodePacientes_Click);
            // 
            // gb_Filtros
            // 
            this.gb_Filtros.Controls.Add(this.btn_cancelar);
            this.gb_Filtros.Controls.Add(this.lbl_FechaDesde_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.dtp_fechaDesde);
            this.gb_Filtros.Controls.Add(this.btn_Buscar_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.lbl_FechaHasta_VerCalendariodePacientes);
            this.gb_Filtros.Controls.Add(this.dtp_FechaHasta);
            this.gb_Filtros.Location = new System.Drawing.Point(17, 49);
            this.gb_Filtros.Name = "gb_Filtros";
            this.gb_Filtros.Size = new System.Drawing.Size(393, 140);
            this.gb_Filtros.TabIndex = 154;
            this.gb_Filtros.TabStop = false;
            this.gb_Filtros.Text = "Filtros";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(222, 106);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 150;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // VerCalendarioMisPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 544);
            this.Controls.Add(this.gb_Filtros);
            this.Controls.Add(this.dtg_VerCalendarioPacientes);
            this.Controls.Add(this.lbl_VerCalendarioTurnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerCalendarioMisPacientesForm";
            this.Text = "Mis Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_VerCalendarioPacientes)).EndInit();
            this.gb_Filtros.ResumeLayout(false);
            this.gb_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VerCalendarioTurnos;
        private System.Windows.Forms.DateTimePicker dtp_fechaDesde;
        private System.Windows.Forms.Label lbl_FechaDesde_VerCalendariodePacientes;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta;
        private System.Windows.Forms.Label lbl_FechaHasta_VerCalendariodePacientes;
        private System.Windows.Forms.DataGridView dtg_VerCalendarioPacientes;
        private System.Windows.Forms.Button btn_Buscar_VerCalendariodePacientes;
        private System.Windows.Forms.GroupBox gb_Filtros;
        private System.Windows.Forms.Button btn_cancelar;
    }
}