
namespace Cova.UI.Realizar_Backup
{
    partial class RealizarBackupForm
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
            this.gb_Filtros_Bitacora = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar_RealizarBackup = new System.Windows.Forms.Button();
            this.btn_Examinar_RealizarBackup = new System.Windows.Forms.Button();
            this.lbl_Ruta_RealizarBackup = new System.Windows.Forms.Label();
            this.lbl_RealizarBackup = new System.Windows.Forms.Label();
            this.btn_IniciarBackup_RealizarRestore = new System.Windows.Forms.Button();
            this.dgv_ControlCambios = new System.Windows.Forms.DataGridView();
            this.gb_Filtros_Bitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControlCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Filtros_Bitacora
            // 
            this.gb_Filtros_Bitacora.Controls.Add(this.btn_Cancelar_RealizarBackup);
            this.gb_Filtros_Bitacora.Controls.Add(this.btn_Examinar_RealizarBackup);
            this.gb_Filtros_Bitacora.Controls.Add(this.lbl_Ruta_RealizarBackup);
            this.gb_Filtros_Bitacora.Location = new System.Drawing.Point(17, 46);
            this.gb_Filtros_Bitacora.Name = "gb_Filtros_Bitacora";
            this.gb_Filtros_Bitacora.Size = new System.Drawing.Size(313, 88);
            this.gb_Filtros_Bitacora.TabIndex = 132;
            this.gb_Filtros_Bitacora.TabStop = false;
            this.gb_Filtros_Bitacora.Text = "Filtros";
            // 
            // btn_Cancelar_RealizarBackup
            // 
            this.btn_Cancelar_RealizarBackup.Location = new System.Drawing.Point(219, 54);
            this.btn_Cancelar_RealizarBackup.Name = "btn_Cancelar_RealizarBackup";
            this.btn_Cancelar_RealizarBackup.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar_RealizarBackup.TabIndex = 180;
            this.btn_Cancelar_RealizarBackup.Text = "Cancelar";
            this.btn_Cancelar_RealizarBackup.UseVisualStyleBackColor = true;
            this.btn_Cancelar_RealizarBackup.Click += new System.EventHandler(this.btn_Cancelar_RealizarBackup_Click);
            // 
            // btn_Examinar_RealizarBackup
            // 
            this.btn_Examinar_RealizarBackup.Location = new System.Drawing.Point(219, 25);
            this.btn_Examinar_RealizarBackup.Name = "btn_Examinar_RealizarBackup";
            this.btn_Examinar_RealizarBackup.Size = new System.Drawing.Size(75, 23);
            this.btn_Examinar_RealizarBackup.TabIndex = 179;
            this.btn_Examinar_RealizarBackup.Text = "Examinar";
            this.btn_Examinar_RealizarBackup.UseVisualStyleBackColor = true;
            // 
            // lbl_Ruta_RealizarBackup
            // 
            this.lbl_Ruta_RealizarBackup.AutoSize = true;
            this.lbl_Ruta_RealizarBackup.Location = new System.Drawing.Point(6, 25);
            this.lbl_Ruta_RealizarBackup.Name = "lbl_Ruta_RealizarBackup";
            this.lbl_Ruta_RealizarBackup.Size = new System.Drawing.Size(63, 13);
            this.lbl_Ruta_RealizarBackup.TabIndex = 133;
            this.lbl_Ruta_RealizarBackup.Text = "Ruta:     C:/";
            // 
            // lbl_RealizarBackup
            // 
            this.lbl_RealizarBackup.AutoSize = true;
            this.lbl_RealizarBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RealizarBackup.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_RealizarBackup.Location = new System.Drawing.Point(12, 9);
            this.lbl_RealizarBackup.Name = "lbl_RealizarBackup";
            this.lbl_RealizarBackup.Size = new System.Drawing.Size(184, 25);
            this.lbl_RealizarBackup.TabIndex = 131;
            this.lbl_RealizarBackup.Text = "Realizar Backup";
            // 
            // btn_IniciarBackup_RealizarRestore
            // 
            this.btn_IniciarBackup_RealizarRestore.Location = new System.Drawing.Point(106, 153);
            this.btn_IniciarBackup_RealizarRestore.Name = "btn_IniciarBackup_RealizarRestore";
            this.btn_IniciarBackup_RealizarRestore.Size = new System.Drawing.Size(90, 23);
            this.btn_IniciarBackup_RealizarRestore.TabIndex = 180;
            this.btn_IniciarBackup_RealizarRestore.Text = "Iniciar Backup";
            this.btn_IniciarBackup_RealizarRestore.UseVisualStyleBackColor = true;
            // 
            // dgv_ControlCambios
            // 
            this.dgv_ControlCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ControlCambios.Location = new System.Drawing.Point(17, 182);
            this.dgv_ControlCambios.Name = "dgv_ControlCambios";
            this.dgv_ControlCambios.Size = new System.Drawing.Size(803, 397);
            this.dgv_ControlCambios.TabIndex = 181;
            // 
            // RealizarBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 621);
            this.Controls.Add(this.dgv_ControlCambios);
            this.Controls.Add(this.btn_IniciarBackup_RealizarRestore);
            this.Controls.Add(this.gb_Filtros_Bitacora);
            this.Controls.Add(this.lbl_RealizarBackup);
            this.Name = "RealizarBackupForm";
            this.Text = "RealizarBackupForm";
            this.gb_Filtros_Bitacora.ResumeLayout(false);
            this.gb_Filtros_Bitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ControlCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Filtros_Bitacora;
        private System.Windows.Forms.Button btn_Cancelar_RealizarBackup;
        private System.Windows.Forms.Button btn_Examinar_RealizarBackup;
        private System.Windows.Forms.Label lbl_Ruta_RealizarBackup;
        private System.Windows.Forms.Label lbl_RealizarBackup;
        private System.Windows.Forms.Button btn_IniciarBackup_RealizarRestore;
        private System.Windows.Forms.DataGridView dgv_ControlCambios;
    }
}