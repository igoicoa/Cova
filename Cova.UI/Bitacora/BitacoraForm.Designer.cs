
namespace Cova.UI.Bitacora
{
    partial class BitacoraForm
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
            this.lbl_Bitacora = new System.Windows.Forms.Label();
            this.bg_Filtros_Bitacora = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaDesde_Bitacora = new System.Windows.Forms.Label();
            this.lbl_FechaHasta_Bitacora = new System.Windows.Forms.Label();
            this.lbl_Usuario_Bitacora = new System.Windows.Forms.Label();
            this.lbl_Criticidad_Bitacora = new System.Windows.Forms.Label();
            this.txt_Usuario_Bitacora = new System.Windows.Forms.TextBox();
            this.cmb_Criticidad_Bitacora = new System.Windows.Forms.ComboBox();
            this.btn_Limpiar_Bitacora = new System.Windows.Forms.Button();
            this.btn_Cancelar_Bitacora = new System.Windows.Forms.Button();
            this.btn_Filtrar_Bitacora = new System.Windows.Forms.Button();
            this.dgv_Bitacora = new System.Windows.Forms.DataGridView();
            this.bg_Filtros_Bitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bitacora
            // 
            this.lbl_Bitacora.AutoSize = true;
            this.lbl_Bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bitacora.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_Bitacora.Location = new System.Drawing.Point(12, 9);
            this.lbl_Bitacora.Name = "lbl_Bitacora";
            this.lbl_Bitacora.Size = new System.Drawing.Size(99, 25);
            this.lbl_Bitacora.TabIndex = 129;
            this.lbl_Bitacora.Text = "Bitacora";
            // 
            // bg_Filtros_Bitacora
            // 
            this.bg_Filtros_Bitacora.Controls.Add(this.btn_Limpiar_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.btn_Cancelar_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.btn_Filtrar_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.cmb_Criticidad_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.txt_Usuario_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.lbl_Criticidad_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.lbl_Usuario_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.lbl_FechaHasta_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.lbl_FechaDesde_Bitacora);
            this.bg_Filtros_Bitacora.Controls.Add(this.dateTimePicker2);
            this.bg_Filtros_Bitacora.Controls.Add(this.dateTimePicker1);
            this.bg_Filtros_Bitacora.Location = new System.Drawing.Point(17, 46);
            this.bg_Filtros_Bitacora.Name = "bg_Filtros_Bitacora";
            this.bg_Filtros_Bitacora.Size = new System.Drawing.Size(597, 138);
            this.bg_Filtros_Bitacora.TabIndex = 130;
            this.bg_Filtros_Bitacora.TabStop = false;
            this.bg_Filtros_Bitacora.Text = "Filtros";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(99, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker2.TabIndex = 132;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 131;
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
            // lbl_FechaHasta_Bitacora
            // 
            this.lbl_FechaHasta_Bitacora.AutoSize = true;
            this.lbl_FechaHasta_Bitacora.Location = new System.Drawing.Point(6, 67);
            this.lbl_FechaHasta_Bitacora.Name = "lbl_FechaHasta_Bitacora";
            this.lbl_FechaHasta_Bitacora.Size = new System.Drawing.Size(68, 13);
            this.lbl_FechaHasta_Bitacora.TabIndex = 134;
            this.lbl_FechaHasta_Bitacora.Text = "Fecha Hasta";
            // 
            // lbl_Usuario_Bitacora
            // 
            this.lbl_Usuario_Bitacora.AutoSize = true;
            this.lbl_Usuario_Bitacora.Location = new System.Drawing.Point(366, 25);
            this.lbl_Usuario_Bitacora.Name = "lbl_Usuario_Bitacora";
            this.lbl_Usuario_Bitacora.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario_Bitacora.TabIndex = 135;
            this.lbl_Usuario_Bitacora.Text = "Usuario";
            // 
            // lbl_Criticidad_Bitacora
            // 
            this.lbl_Criticidad_Bitacora.AutoSize = true;
            this.lbl_Criticidad_Bitacora.Location = new System.Drawing.Point(366, 66);
            this.lbl_Criticidad_Bitacora.Name = "lbl_Criticidad_Bitacora";
            this.lbl_Criticidad_Bitacora.Size = new System.Drawing.Size(50, 13);
            this.lbl_Criticidad_Bitacora.TabIndex = 136;
            this.lbl_Criticidad_Bitacora.Text = "Criticidad";
            // 
            // txt_Usuario_Bitacora
            // 
            this.txt_Usuario_Bitacora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Usuario_Bitacora.Enabled = false;
            this.txt_Usuario_Bitacora.Location = new System.Drawing.Point(415, 22);
            this.txt_Usuario_Bitacora.Name = "txt_Usuario_Bitacora";
            this.txt_Usuario_Bitacora.Size = new System.Drawing.Size(132, 20);
            this.txt_Usuario_Bitacora.TabIndex = 177;
            // 
            // cmb_Criticidad_Bitacora
            // 
            this.cmb_Criticidad_Bitacora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Criticidad_Bitacora.FormattingEnabled = true;
            this.cmb_Criticidad_Bitacora.Location = new System.Drawing.Point(415, 64);
            this.cmb_Criticidad_Bitacora.Name = "cmb_Criticidad_Bitacora";
            this.cmb_Criticidad_Bitacora.Size = new System.Drawing.Size(132, 21);
            this.cmb_Criticidad_Bitacora.TabIndex = 178;
            // 
            // btn_Limpiar_Bitacora
            // 
            this.btn_Limpiar_Bitacora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar_Bitacora.Location = new System.Drawing.Point(351, 100);
            this.btn_Limpiar_Bitacora.Name = "btn_Limpiar_Bitacora";
            this.btn_Limpiar_Bitacora.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar_Bitacora.TabIndex = 181;
            this.btn_Limpiar_Bitacora.Text = "Limpiar";
            this.btn_Limpiar_Bitacora.UseVisualStyleBackColor = true;
            this.btn_Limpiar_Bitacora.Click += new System.EventHandler(this.btn_Limpiar_Bitacora_Click);
            // 
            // btn_Cancelar_Bitacora
            // 
            this.btn_Cancelar_Bitacora.Location = new System.Drawing.Point(270, 100);
            this.btn_Cancelar_Bitacora.Name = "btn_Cancelar_Bitacora";
            this.btn_Cancelar_Bitacora.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar_Bitacora.TabIndex = 180;
            this.btn_Cancelar_Bitacora.Text = "Cancelar";
            this.btn_Cancelar_Bitacora.UseVisualStyleBackColor = true;
            this.btn_Cancelar_Bitacora.Click += new System.EventHandler(this.btn_Cancelar_Bitacora_Click);
            // 
            // btn_Filtrar_Bitacora
            // 
            this.btn_Filtrar_Bitacora.Location = new System.Drawing.Point(184, 100);
            this.btn_Filtrar_Bitacora.Name = "btn_Filtrar_Bitacora";
            this.btn_Filtrar_Bitacora.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar_Bitacora.TabIndex = 179;
            this.btn_Filtrar_Bitacora.Text = "Aplicar";
            this.btn_Filtrar_Bitacora.UseVisualStyleBackColor = true;
            // 
            // dgv_Bitacora
            // 
            this.dgv_Bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bitacora.Location = new System.Drawing.Point(17, 223);
            this.dgv_Bitacora.Name = "dgv_Bitacora";
            this.dgv_Bitacora.Size = new System.Drawing.Size(754, 321);
            this.dgv_Bitacora.TabIndex = 131;
            // 
            // BitacoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.dgv_Bitacora);
            this.Controls.Add(this.bg_Filtros_Bitacora);
            this.Controls.Add(this.lbl_Bitacora);
            this.Name = "BitacoraForm";
            this.Text = "BitacoraForm";
            this.bg_Filtros_Bitacora.ResumeLayout(false);
            this.bg_Filtros_Bitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bitacora;
        private System.Windows.Forms.GroupBox bg_Filtros_Bitacora;
        private System.Windows.Forms.Label lbl_Criticidad_Bitacora;
        private System.Windows.Forms.Label lbl_Usuario_Bitacora;
        private System.Windows.Forms.Label lbl_FechaHasta_Bitacora;
        private System.Windows.Forms.Label lbl_FechaDesde_Bitacora;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Usuario_Bitacora;
        private System.Windows.Forms.ComboBox cmb_Criticidad_Bitacora;
        private System.Windows.Forms.Button btn_Limpiar_Bitacora;
        private System.Windows.Forms.Button btn_Cancelar_Bitacora;
        private System.Windows.Forms.Button btn_Filtrar_Bitacora;
        private System.Windows.Forms.DataGridView dgv_Bitacora;
    }
}