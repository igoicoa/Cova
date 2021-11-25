
namespace Cova.UI
{
    partial class RegistrarTurnoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTurnoForm));
            this.lbl_RegistrarTurnos = new System.Windows.Forms.Label();
            this.dgv_RegistrarTurnos = new System.Windows.Forms.DataGridView();
            this.gb_Filtros = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarProfesional = new System.Windows.Forms.Button();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.btn_Reservar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.lbl_FechaHasta_Bitacora = new System.Windows.Forms.Label();
            this.lbl_FechaDesde_Bitacora = new System.Windows.Forms.Label();
            this.dtp_FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrarTurnos)).BeginInit();
            this.gb_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RegistrarTurnos
            // 
            this.lbl_RegistrarTurnos.AutoSize = true;
            this.lbl_RegistrarTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistrarTurnos.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_RegistrarTurnos.Location = new System.Drawing.Point(3, 9);
            this.lbl_RegistrarTurnos.Name = "lbl_RegistrarTurnos";
            this.lbl_RegistrarTurnos.Size = new System.Drawing.Size(188, 25);
            this.lbl_RegistrarTurnos.TabIndex = 130;
            this.lbl_RegistrarTurnos.Text = "Registrar Turnos";
            this.lbl_RegistrarTurnos.UseWaitCursor = true;
            // 
            // dgv_RegistrarTurnos
            // 
            this.dgv_RegistrarTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RegistrarTurnos.Location = new System.Drawing.Point(12, 226);
            this.dgv_RegistrarTurnos.Name = "dgv_RegistrarTurnos";
            this.dgv_RegistrarTurnos.Size = new System.Drawing.Size(754, 426);
            this.dgv_RegistrarTurnos.TabIndex = 133;
            // 
            // gb_Filtros
            // 
            this.gb_Filtros.Controls.Add(this.label1);
            this.gb_Filtros.Controls.Add(this.btn_BuscarProfesional);
            this.gb_Filtros.Controls.Add(this.txt_profesional);
            this.gb_Filtros.Controls.Add(this.btn_Reservar);
            this.gb_Filtros.Controls.Add(this.btn_Cancelar);
            this.gb_Filtros.Controls.Add(this.btn_Filtrar);
            this.gb_Filtros.Controls.Add(this.lbl_FechaHasta_Bitacora);
            this.gb_Filtros.Controls.Add(this.lbl_FechaDesde_Bitacora);
            this.gb_Filtros.Controls.Add(this.dtp_FechaHasta);
            this.gb_Filtros.Controls.Add(this.dtp_FechaDesde);
            this.gb_Filtros.Location = new System.Drawing.Point(12, 49);
            this.gb_Filtros.Name = "gb_Filtros";
            this.gb_Filtros.Size = new System.Drawing.Size(772, 138);
            this.gb_Filtros.TabIndex = 132;
            this.gb_Filtros.TabStop = false;
            this.gb_Filtros.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 184;
            this.label1.Text = "Profesional";
            // 
            // btn_BuscarProfesional
            // 
            this.btn_BuscarProfesional.Location = new System.Drawing.Point(419, 26);
            this.btn_BuscarProfesional.Name = "btn_BuscarProfesional";
            this.btn_BuscarProfesional.Size = new System.Drawing.Size(121, 23);
            this.btn_BuscarProfesional.TabIndex = 183;
            this.btn_BuscarProfesional.Text = "Buscar Profesional";
            this.btn_BuscarProfesional.UseVisualStyleBackColor = true;
            this.btn_BuscarProfesional.Click += new System.EventHandler(this.btn_BuscarProfesional_Click);
            // 
            // txt_profesional
            // 
            this.txt_profesional.Enabled = false;
            this.txt_profesional.Location = new System.Drawing.Point(514, 60);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.ReadOnly = true;
            this.txt_profesional.Size = new System.Drawing.Size(240, 20);
            this.txt_profesional.TabIndex = 182;
            // 
            // btn_Reservar
            // 
            this.btn_Reservar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reservar.Location = new System.Drawing.Point(351, 100);
            this.btn_Reservar.Name = "btn_Reservar";
            this.btn_Reservar.Size = new System.Drawing.Size(75, 23);
            this.btn_Reservar.TabIndex = 181;
            this.btn_Reservar.Text = "Reservar";
            this.btn_Reservar.UseVisualStyleBackColor = true;
            this.btn_Reservar.Click += new System.EventHandler(this.btn_Reservar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(270, 100);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 180;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Location = new System.Drawing.Point(184, 100);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 179;
            this.btn_Filtrar.Text = "Buscar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // lbl_FechaHasta_Bitacora
            // 
            this.lbl_FechaHasta_Bitacora.AutoSize = true;
            this.lbl_FechaHasta_Bitacora.Location = new System.Drawing.Point(6, 67);
            this.lbl_FechaHasta_Bitacora.Name = "lbl_FechaHasta_Bitacora";
            this.lbl_FechaHasta_Bitacora.Size = new System.Drawing.Size(68, 13);
            this.lbl_FechaHasta_Bitacora.TabIndex = 134;
            this.lbl_FechaHasta_Bitacora.Text = "Fecha Hasta";
            // 
            // lbl_FechaDesde_Bitacora
            // 
            this.lbl_FechaDesde_Bitacora.AutoSize = true;
            this.lbl_FechaDesde_Bitacora.Location = new System.Drawing.Point(6, 25);
            this.lbl_FechaDesde_Bitacora.Name = "lbl_FechaDesde_Bitacora";
            this.lbl_FechaDesde_Bitacora.Size = new System.Drawing.Size(71, 13);
            this.lbl_FechaDesde_Bitacora.TabIndex = 133;
            this.lbl_FechaDesde_Bitacora.Text = "Fecha Desde";
            // 
            // dtp_FechaHasta
            // 
            this.dtp_FechaHasta.Location = new System.Drawing.Point(99, 60);
            this.dtp_FechaHasta.Name = "dtp_FechaHasta";
            this.dtp_FechaHasta.Size = new System.Drawing.Size(219, 20);
            this.dtp_FechaHasta.TabIndex = 132;
            // 
            // dtp_FechaDesde
            // 
            this.dtp_FechaDesde.Location = new System.Drawing.Point(99, 25);
            this.dtp_FechaDesde.Name = "dtp_FechaDesde";
            this.dtp_FechaDesde.Size = new System.Drawing.Size(219, 20);
            this.dtp_FechaDesde.TabIndex = 131;
            // 
            // RegistrarTurnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 721);
            this.Controls.Add(this.dgv_RegistrarTurnos);
            this.Controls.Add(this.gb_Filtros);
            this.Controls.Add(this.lbl_RegistrarTurnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarTurnoForm";
            this.Text = "RegistrarTurno";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrarTurnos)).EndInit();
            this.gb_Filtros.ResumeLayout(false);
            this.gb_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegistrarTurnos;
        private System.Windows.Forms.DataGridView dgv_RegistrarTurnos;
        private System.Windows.Forms.GroupBox gb_Filtros;
        private System.Windows.Forms.Button btn_Reservar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.Label lbl_FechaHasta_Bitacora;
        private System.Windows.Forms.Label lbl_FechaDesde_Bitacora;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde;
        private System.Windows.Forms.Button btn_BuscarProfesional;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Label label1;
    }
}