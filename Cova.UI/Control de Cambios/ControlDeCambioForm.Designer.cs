
namespace Cova.UI.Control_de_Cambios
{
    partial class ControlDeCambioForm
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
            this.dgv_ControlCambios = new System.Windows.Forms.DataGridView();
            this.bg_Filtros_ControlCambios = new System.Windows.Forms.GroupBox();
            this.cmb_Usuarios_ControlCambios = new System.Windows.Forms.ComboBox();
            this.btn_Limpiar_ControlCambios = new System.Windows.Forms.Button();
            this.btn_Cancelar_ControlCambios = new System.Windows.Forms.Button();
            this.btn_Filtrar_ControlCambios = new System.Windows.Forms.Button();
            this.lbl_Usuario_ControlCambios = new System.Windows.Forms.Label();
            this.lbl_FechaHasta_ControlCambios = new System.Windows.Forms.Label();
            this.lbl_FechaDesde_ControlCambios = new System.Windows.Forms.Label();
            this.dtp_FechaHasta_ControlCambios = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaDesde_ControlCambios = new System.Windows.Forms.DateTimePicker();
            this.lbl_ControlCambios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControlCambios)).BeginInit();
            this.bg_Filtros_ControlCambios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ControlCambios
            // 
            this.dgv_ControlCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ControlCambios.Location = new System.Drawing.Point(12, 204);
            this.dgv_ControlCambios.Name = "dgv_ControlCambios";
            this.dgv_ControlCambios.Size = new System.Drawing.Size(754, 321);
            this.dgv_ControlCambios.TabIndex = 134;
            // 
            // bg_Filtros_ControlCambios
            // 
            this.bg_Filtros_ControlCambios.Controls.Add(this.cmb_Usuarios_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.btn_Limpiar_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.btn_Cancelar_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.btn_Filtrar_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.lbl_Usuario_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.lbl_FechaHasta_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.lbl_FechaDesde_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.dtp_FechaHasta_ControlCambios);
            this.bg_Filtros_ControlCambios.Controls.Add(this.dtp_FechaDesde_ControlCambios);
            this.bg_Filtros_ControlCambios.Location = new System.Drawing.Point(17, 46);
            this.bg_Filtros_ControlCambios.Name = "bg_Filtros_ControlCambios";
            this.bg_Filtros_ControlCambios.Size = new System.Drawing.Size(728, 138);
            this.bg_Filtros_ControlCambios.TabIndex = 133;
            this.bg_Filtros_ControlCambios.TabStop = false;
            this.bg_Filtros_ControlCambios.Text = "Filtros";
            // 
            // cmb_Usuarios_ControlCambios
            // 
            this.cmb_Usuarios_ControlCambios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Usuarios_ControlCambios.FormattingEnabled = true;
            this.cmb_Usuarios_ControlCambios.Location = new System.Drawing.Point(439, 25);
            this.cmb_Usuarios_ControlCambios.Name = "cmb_Usuarios_ControlCambios";
            this.cmb_Usuarios_ControlCambios.Size = new System.Drawing.Size(132, 21);
            this.cmb_Usuarios_ControlCambios.TabIndex = 182;
            // 
            // btn_Limpiar_ControlCambios
            // 
            this.btn_Limpiar_ControlCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar_ControlCambios.Location = new System.Drawing.Point(351, 100);
            this.btn_Limpiar_ControlCambios.Name = "btn_Limpiar_ControlCambios";
            this.btn_Limpiar_ControlCambios.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar_ControlCambios.TabIndex = 181;
            this.btn_Limpiar_ControlCambios.Text = "Limpiar";
            this.btn_Limpiar_ControlCambios.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar_ControlCambios
            // 
            this.btn_Cancelar_ControlCambios.Location = new System.Drawing.Point(270, 100);
            this.btn_Cancelar_ControlCambios.Name = "btn_Cancelar_ControlCambios";
            this.btn_Cancelar_ControlCambios.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar_ControlCambios.TabIndex = 180;
            this.btn_Cancelar_ControlCambios.Text = "Cancelar";
            this.btn_Cancelar_ControlCambios.UseVisualStyleBackColor = true;
            this.btn_Cancelar_ControlCambios.Click += new System.EventHandler(this.btn_Cancelar_ControlCambios_Click);
            // 
            // btn_Filtrar_ControlCambios
            // 
            this.btn_Filtrar_ControlCambios.Location = new System.Drawing.Point(184, 100);
            this.btn_Filtrar_ControlCambios.Name = "btn_Filtrar_ControlCambios";
            this.btn_Filtrar_ControlCambios.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar_ControlCambios.TabIndex = 179;
            this.btn_Filtrar_ControlCambios.Text = "Filtrar";
            this.btn_Filtrar_ControlCambios.UseVisualStyleBackColor = true;
            this.btn_Filtrar_ControlCambios.Click += new System.EventHandler(this.btn_Filtrar_ControlCambios_Click);
            // 
            // lbl_Usuario_ControlCambios
            // 
            this.lbl_Usuario_ControlCambios.AutoSize = true;
            this.lbl_Usuario_ControlCambios.Location = new System.Drawing.Point(366, 25);
            this.lbl_Usuario_ControlCambios.Name = "lbl_Usuario_ControlCambios";
            this.lbl_Usuario_ControlCambios.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario_ControlCambios.TabIndex = 135;
            this.lbl_Usuario_ControlCambios.Text = "Usuario";
            // 
            // lbl_FechaHasta_ControlCambios
            // 
            this.lbl_FechaHasta_ControlCambios.AutoSize = true;
            this.lbl_FechaHasta_ControlCambios.Location = new System.Drawing.Point(6, 67);
            this.lbl_FechaHasta_ControlCambios.Name = "lbl_FechaHasta_ControlCambios";
            this.lbl_FechaHasta_ControlCambios.Size = new System.Drawing.Size(68, 13);
            this.lbl_FechaHasta_ControlCambios.TabIndex = 134;
            this.lbl_FechaHasta_ControlCambios.Text = "Fecha Hasta";
            // 
            // lbl_FechaDesde_ControlCambios
            // 
            this.lbl_FechaDesde_ControlCambios.AutoSize = true;
            this.lbl_FechaDesde_ControlCambios.Location = new System.Drawing.Point(6, 25);
            this.lbl_FechaDesde_ControlCambios.Name = "lbl_FechaDesde_ControlCambios";
            this.lbl_FechaDesde_ControlCambios.Size = new System.Drawing.Size(71, 13);
            this.lbl_FechaDesde_ControlCambios.TabIndex = 133;
            this.lbl_FechaDesde_ControlCambios.Text = "Fecha Desde";
            // 
            // dtp_FechaHasta_ControlCambios
            // 
            this.dtp_FechaHasta_ControlCambios.Location = new System.Drawing.Point(99, 60);
            this.dtp_FechaHasta_ControlCambios.Name = "dtp_FechaHasta_ControlCambios";
            this.dtp_FechaHasta_ControlCambios.Size = new System.Drawing.Size(219, 20);
            this.dtp_FechaHasta_ControlCambios.TabIndex = 132;
            // 
            // dtp_FechaDesde_ControlCambios
            // 
            this.dtp_FechaDesde_ControlCambios.Location = new System.Drawing.Point(99, 25);
            this.dtp_FechaDesde_ControlCambios.Name = "dtp_FechaDesde_ControlCambios";
            this.dtp_FechaDesde_ControlCambios.Size = new System.Drawing.Size(219, 20);
            this.dtp_FechaDesde_ControlCambios.TabIndex = 131;
            // 
            // lbl_ControlCambios
            // 
            this.lbl_ControlCambios.AutoSize = true;
            this.lbl_ControlCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ControlCambios.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_ControlCambios.Location = new System.Drawing.Point(12, 9);
            this.lbl_ControlCambios.Name = "lbl_ControlCambios";
            this.lbl_ControlCambios.Size = new System.Drawing.Size(219, 25);
            this.lbl_ControlCambios.TabIndex = 132;
            this.lbl_ControlCambios.Text = "Control de Cambios";
            // 
            // ControlDeCambioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 571);
            this.Controls.Add(this.dgv_ControlCambios);
            this.Controls.Add(this.bg_Filtros_ControlCambios);
            this.Controls.Add(this.lbl_ControlCambios);
            this.Name = "ControlDeCambioForm";
            this.Text = "ControlDeCambioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControlCambios)).EndInit();
            this.bg_Filtros_ControlCambios.ResumeLayout(false);
            this.bg_Filtros_ControlCambios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ControlCambios;
        private System.Windows.Forms.GroupBox bg_Filtros_ControlCambios;
        private System.Windows.Forms.ComboBox cmb_Usuarios_ControlCambios;
        private System.Windows.Forms.Button btn_Limpiar_ControlCambios;
        private System.Windows.Forms.Button btn_Cancelar_ControlCambios;
        private System.Windows.Forms.Button btn_Filtrar_ControlCambios;
        private System.Windows.Forms.Label lbl_Usuario_ControlCambios;
        private System.Windows.Forms.Label lbl_FechaHasta_ControlCambios;
        private System.Windows.Forms.Label lbl_FechaDesde_ControlCambios;
        private System.Windows.Forms.DateTimePicker dtp_FechaHasta_ControlCambios;
        private System.Windows.Forms.DateTimePicker dtp_FechaDesde_ControlCambios;
        private System.Windows.Forms.Label lbl_ControlCambios;
    }
}