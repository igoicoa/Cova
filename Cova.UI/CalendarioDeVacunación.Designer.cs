
namespace Cova.UI
{
    partial class CalendarioDeVacunación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioDeVacunación));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_CalendarioVacunacion = new System.Windows.Forms.DataGridView();
            this.lbl_UsuarioCalendarioVacunacion = new System.Windows.Forms.Label();
            this.txtBoxUsuario_CalendarioVacunacion = new System.Windows.Forms.TextBox();
            this.lbl_EstadoCalendarioVacunacion = new System.Windows.Forms.Label();
            this.cmb_EstadoCalendarioVacunacion = new System.Windows.Forms.ComboBox();
            this.bttn_MostrarCalendarioVacunacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CalendarioVacunacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 25);
            this.label3.TabIndex = 69;
            this.label3.Text = "Calendario de Vacunación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Este menú sirve para llevar un control en el que se registran las vacunas aplicad" +
    "as y pendientes a niños y a adultos.";
            // 
            // dtgv_CalendarioVacunacion
            // 
            this.dtgv_CalendarioVacunacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CalendarioVacunacion.Location = new System.Drawing.Point(8, 142);
            this.dtgv_CalendarioVacunacion.Name = "dtgv_CalendarioVacunacion";
            this.dtgv_CalendarioVacunacion.Size = new System.Drawing.Size(790, 309);
            this.dtgv_CalendarioVacunacion.TabIndex = 71;
            // 
            // lbl_UsuarioCalendarioVacunacion
            // 
            this.lbl_UsuarioCalendarioVacunacion.AutoSize = true;
            this.lbl_UsuarioCalendarioVacunacion.Location = new System.Drawing.Point(13, 75);
            this.lbl_UsuarioCalendarioVacunacion.Name = "lbl_UsuarioCalendarioVacunacion";
            this.lbl_UsuarioCalendarioVacunacion.Size = new System.Drawing.Size(43, 13);
            this.lbl_UsuarioCalendarioVacunacion.TabIndex = 72;
            this.lbl_UsuarioCalendarioVacunacion.Text = "Usuario";
            // 
            // txtBoxUsuario_CalendarioVacunacion
            // 
            this.txtBoxUsuario_CalendarioVacunacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBoxUsuario_CalendarioVacunacion.Location = new System.Drawing.Point(16, 91);
            this.txtBoxUsuario_CalendarioVacunacion.Name = "txtBoxUsuario_CalendarioVacunacion";
            this.txtBoxUsuario_CalendarioVacunacion.Size = new System.Drawing.Size(123, 20);
            this.txtBoxUsuario_CalendarioVacunacion.TabIndex = 73;
            // 
            // lbl_EstadoCalendarioVacunacion
            // 
            this.lbl_EstadoCalendarioVacunacion.AutoSize = true;
            this.lbl_EstadoCalendarioVacunacion.Location = new System.Drawing.Point(190, 75);
            this.lbl_EstadoCalendarioVacunacion.Name = "lbl_EstadoCalendarioVacunacion";
            this.lbl_EstadoCalendarioVacunacion.Size = new System.Drawing.Size(40, 13);
            this.lbl_EstadoCalendarioVacunacion.TabIndex = 74;
            this.lbl_EstadoCalendarioVacunacion.Text = "Estado";
            // 
            // cmb_EstadoCalendarioVacunacion
            // 
            this.cmb_EstadoCalendarioVacunacion.FormattingEnabled = true;
            this.cmb_EstadoCalendarioVacunacion.Items.AddRange(new object[] {
            "Pendiente",
            "Aplicada"});
            this.cmb_EstadoCalendarioVacunacion.Location = new System.Drawing.Point(193, 89);
            this.cmb_EstadoCalendarioVacunacion.Name = "cmb_EstadoCalendarioVacunacion";
            this.cmb_EstadoCalendarioVacunacion.Size = new System.Drawing.Size(121, 21);
            this.cmb_EstadoCalendarioVacunacion.TabIndex = 75;
            // 
            // bttn_MostrarCalendarioVacunacion
            // 
            this.bttn_MostrarCalendarioVacunacion.Location = new System.Drawing.Point(345, 88);
            this.bttn_MostrarCalendarioVacunacion.Name = "bttn_MostrarCalendarioVacunacion";
            this.bttn_MostrarCalendarioVacunacion.Size = new System.Drawing.Size(75, 23);
            this.bttn_MostrarCalendarioVacunacion.TabIndex = 76;
            this.bttn_MostrarCalendarioVacunacion.Text = "Mostrar";
            this.bttn_MostrarCalendarioVacunacion.UseVisualStyleBackColor = true;
            // 
            // CalendarioDeVacunación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.bttn_MostrarCalendarioVacunacion);
            this.Controls.Add(this.cmb_EstadoCalendarioVacunacion);
            this.Controls.Add(this.lbl_EstadoCalendarioVacunacion);
            this.Controls.Add(this.txtBoxUsuario_CalendarioVacunacion);
            this.Controls.Add(this.lbl_UsuarioCalendarioVacunacion);
            this.Controls.Add(this.dtgv_CalendarioVacunacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarioDeVacunación";
            this.Text = "CalendarioDeVacunación";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CalendarioVacunacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_UsuarioCalendarioVacunacion;
        private System.Windows.Forms.TextBox txtBoxUsuario_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_EstadoCalendarioVacunacion;
        private System.Windows.Forms.ComboBox cmb_EstadoCalendarioVacunacion;
        private System.Windows.Forms.Button bttn_MostrarCalendarioVacunacion;
    }
}