
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
            this.lbl_RealizarBackup = new System.Windows.Forms.Label();
            this.btn_IniciarBackup_RealizarRestore = new System.Windows.Forms.Button();
            this.dgv_Backups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_IniciarRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Backups)).BeginInit();
            this.SuspendLayout();
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
            this.btn_IniciarBackup_RealizarRestore.Location = new System.Drawing.Point(20, 107);
            this.btn_IniciarBackup_RealizarRestore.Name = "btn_IniciarBackup_RealizarRestore";
            this.btn_IniciarBackup_RealizarRestore.Size = new System.Drawing.Size(90, 23);
            this.btn_IniciarBackup_RealizarRestore.TabIndex = 180;
            this.btn_IniciarBackup_RealizarRestore.Text = "Iniciar Backup";
            this.btn_IniciarBackup_RealizarRestore.UseVisualStyleBackColor = true;
            this.btn_IniciarBackup_RealizarRestore.Click += new System.EventHandler(this.btn_IniciarBackup_RealizarRestore_Click);
            // 
            // dgv_Backups
            // 
            this.dgv_Backups.AllowUserToAddRows = false;
            this.dgv_Backups.AllowUserToDeleteRows = false;
            this.dgv_Backups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Backups.Location = new System.Drawing.Point(12, 155);
            this.dgv_Backups.MultiSelect = false;
            this.dgv_Backups.Name = "dgv_Backups";
            this.dgv_Backups.ReadOnly = true;
            this.dgv_Backups.Size = new System.Drawing.Size(803, 397);
            this.dgv_Backups.TabIndex = 181;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 182;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(70, 60);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(144, 20);
            this.txt_nombre.TabIndex = 183;
            // 
            // btn_IniciarRestore
            // 
            this.btn_IniciarRestore.Location = new System.Drawing.Point(379, 107);
            this.btn_IniciarRestore.Name = "btn_IniciarRestore";
            this.btn_IniciarRestore.Size = new System.Drawing.Size(90, 23);
            this.btn_IniciarRestore.TabIndex = 184;
            this.btn_IniciarRestore.Text = "Iniciar Restore";
            this.btn_IniciarRestore.UseVisualStyleBackColor = true;
            this.btn_IniciarRestore.Click += new System.EventHandler(this.btn_IniciarRestore_Click);
            // 
            // RealizarBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 621);
            this.Controls.Add(this.btn_IniciarRestore);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Backups);
            this.Controls.Add(this.btn_IniciarBackup_RealizarRestore);
            this.Controls.Add(this.lbl_RealizarBackup);
            this.Name = "RealizarBackupForm";
            this.Text = "RealizarBackupForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Backups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_RealizarBackup;
        private System.Windows.Forms.Button btn_IniciarBackup_RealizarRestore;
        private System.Windows.Forms.DataGridView dgv_Backups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_IniciarRestore;
    }
}