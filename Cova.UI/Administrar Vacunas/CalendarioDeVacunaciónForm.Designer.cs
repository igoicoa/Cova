
namespace Cova.UI
{
    partial class CalendarioDeVacunaciónForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarioDeVacunaciónForm));
            this.lbl_CalendariodeVacunacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_CalendarioVacunacion = new System.Windows.Forms.DataGridView();
            this.lbl_Estado_CalendarioVacunacion = new System.Windows.Forms.Label();
            this.cmb_Estado_CalendarioVacunacion = new System.Windows.Forms.ComboBox();
            this.bttn_Mostrar_CalendarioVacunacion = new System.Windows.Forms.Button();
            this.btnCancelar_CalendarioVacunacion = new System.Windows.Forms.Button();
            this.btn_Limpiar_CalendarioVacunacion = new System.Windows.Forms.Button();
            this.txt_apellido_CalendarioVacunacion = new System.Windows.Forms.TextBox();
            this.lbl_Apellido_CalendarioVacunacion = new System.Windows.Forms.Label();
            this.txt_nombre_CalendarioVacunacion = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_CalendarioVacunacion = new System.Windows.Forms.Label();
            this.txt_DNI_CalendarioVacunacion = new System.Windows.Forms.TextBox();
            this.lbl_NumeroDoc_CalendarioVacunacion = new System.Windows.Forms.Label();
            this.txt_edad_CalendarioVacunacion = new System.Windows.Forms.TextBox();
            this.lbl_Edad_CalendarioVacunacion = new System.Windows.Forms.Label();
            this.btn_BuscarPacientes_CalendarioVacunacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CalendarioVacunacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CalendariodeVacunacion
            // 
            this.lbl_CalendariodeVacunacion.AutoSize = true;
            this.lbl_CalendariodeVacunacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CalendariodeVacunacion.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_CalendariodeVacunacion.Location = new System.Drawing.Point(3, 9);
            this.lbl_CalendariodeVacunacion.Name = "lbl_CalendariodeVacunacion";
            this.lbl_CalendariodeVacunacion.Size = new System.Drawing.Size(289, 25);
            this.lbl_CalendariodeVacunacion.TabIndex = 69;
            this.lbl_CalendariodeVacunacion.Text = "Calendario de Vacunación";
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
            this.dtgv_CalendarioVacunacion.Location = new System.Drawing.Point(8, 259);
            this.dtgv_CalendarioVacunacion.Name = "dtgv_CalendarioVacunacion";
            this.dtgv_CalendarioVacunacion.Size = new System.Drawing.Size(790, 324);
            this.dtgv_CalendarioVacunacion.TabIndex = 71;
            // 
            // lbl_Estado_CalendarioVacunacion
            // 
            this.lbl_Estado_CalendarioVacunacion.AutoSize = true;
            this.lbl_Estado_CalendarioVacunacion.Location = new System.Drawing.Point(418, 131);
            this.lbl_Estado_CalendarioVacunacion.Name = "lbl_Estado_CalendarioVacunacion";
            this.lbl_Estado_CalendarioVacunacion.Size = new System.Drawing.Size(40, 13);
            this.lbl_Estado_CalendarioVacunacion.TabIndex = 74;
            this.lbl_Estado_CalendarioVacunacion.Text = "Estado";
            // 
            // cmb_Estado_CalendarioVacunacion
            // 
            this.cmb_Estado_CalendarioVacunacion.FormattingEnabled = true;
            this.cmb_Estado_CalendarioVacunacion.Items.AddRange(new object[] {
            "Pendiente",
            "Completo"});
            this.cmb_Estado_CalendarioVacunacion.Location = new System.Drawing.Point(421, 145);
            this.cmb_Estado_CalendarioVacunacion.Name = "cmb_Estado_CalendarioVacunacion";
            this.cmb_Estado_CalendarioVacunacion.Size = new System.Drawing.Size(132, 21);
            this.cmb_Estado_CalendarioVacunacion.TabIndex = 75;
            // 
            // bttn_Mostrar_CalendarioVacunacion
            // 
            this.bttn_Mostrar_CalendarioVacunacion.Location = new System.Drawing.Point(259, 207);
            this.bttn_Mostrar_CalendarioVacunacion.Name = "bttn_Mostrar_CalendarioVacunacion";
            this.bttn_Mostrar_CalendarioVacunacion.Size = new System.Drawing.Size(75, 23);
            this.bttn_Mostrar_CalendarioVacunacion.TabIndex = 76;
            this.bttn_Mostrar_CalendarioVacunacion.Text = "Mostrar";
            this.bttn_Mostrar_CalendarioVacunacion.UseVisualStyleBackColor = true;
            this.bttn_Mostrar_CalendarioVacunacion.Click += new System.EventHandler(this.bttn_Mostrar_CalendarioVacunacion_Click);
            // 
            // btnCancelar_CalendarioVacunacion
            // 
            this.btnCancelar_CalendarioVacunacion.Location = new System.Drawing.Point(340, 208);
            this.btnCancelar_CalendarioVacunacion.Name = "btnCancelar_CalendarioVacunacion";
            this.btnCancelar_CalendarioVacunacion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_CalendarioVacunacion.TabIndex = 77;
            this.btnCancelar_CalendarioVacunacion.Text = "Cancelar";
            this.btnCancelar_CalendarioVacunacion.UseVisualStyleBackColor = true;
            this.btnCancelar_CalendarioVacunacion.Click += new System.EventHandler(this.btnCancelar_CalendarioVacunacion_Click);
            // 
            // btn_Limpiar_CalendarioVacunacion
            // 
            this.btn_Limpiar_CalendarioVacunacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar_CalendarioVacunacion.Location = new System.Drawing.Point(421, 207);
            this.btn_Limpiar_CalendarioVacunacion.Name = "btn_Limpiar_CalendarioVacunacion";
            this.btn_Limpiar_CalendarioVacunacion.Size = new System.Drawing.Size(78, 23);
            this.btn_Limpiar_CalendarioVacunacion.TabIndex = 147;
            this.btn_Limpiar_CalendarioVacunacion.Text = "Limpiar";
            this.btn_Limpiar_CalendarioVacunacion.UseVisualStyleBackColor = true;
            this.btn_Limpiar_CalendarioVacunacion.Click += new System.EventHandler(this.btn_Limpiar_CalendarioVacunacion_Click);
            // 
            // txt_apellido_CalendarioVacunacion
            // 
            this.txt_apellido_CalendarioVacunacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_apellido_CalendarioVacunacion.Enabled = false;
            this.txt_apellido_CalendarioVacunacion.Location = new System.Drawing.Point(8, 147);
            this.txt_apellido_CalendarioVacunacion.Name = "txt_apellido_CalendarioVacunacion";
            this.txt_apellido_CalendarioVacunacion.Size = new System.Drawing.Size(363, 20);
            this.txt_apellido_CalendarioVacunacion.TabIndex = 151;
            // 
            // lbl_Apellido_CalendarioVacunacion
            // 
            this.lbl_Apellido_CalendarioVacunacion.AutoSize = true;
            this.lbl_Apellido_CalendarioVacunacion.Location = new System.Drawing.Point(5, 131);
            this.lbl_Apellido_CalendarioVacunacion.Name = "lbl_Apellido_CalendarioVacunacion";
            this.lbl_Apellido_CalendarioVacunacion.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido_CalendarioVacunacion.TabIndex = 150;
            this.lbl_Apellido_CalendarioVacunacion.Text = "Apellido";
            // 
            // txt_nombre_CalendarioVacunacion
            // 
            this.txt_nombre_CalendarioVacunacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nombre_CalendarioVacunacion.Enabled = false;
            this.txt_nombre_CalendarioVacunacion.Location = new System.Drawing.Point(8, 97);
            this.txt_nombre_CalendarioVacunacion.Name = "txt_nombre_CalendarioVacunacion";
            this.txt_nombre_CalendarioVacunacion.Size = new System.Drawing.Size(363, 20);
            this.txt_nombre_CalendarioVacunacion.TabIndex = 149;
            // 
            // lbl_Nombre_CalendarioVacunacion
            // 
            this.lbl_Nombre_CalendarioVacunacion.AutoSize = true;
            this.lbl_Nombre_CalendarioVacunacion.Location = new System.Drawing.Point(5, 81);
            this.lbl_Nombre_CalendarioVacunacion.Name = "lbl_Nombre_CalendarioVacunacion";
            this.lbl_Nombre_CalendarioVacunacion.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre_CalendarioVacunacion.TabIndex = 148;
            this.lbl_Nombre_CalendarioVacunacion.Text = "Nombre";
            // 
            // txt_DNI_CalendarioVacunacion
            // 
            this.txt_DNI_CalendarioVacunacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_DNI_CalendarioVacunacion.Enabled = false;
            this.txt_DNI_CalendarioVacunacion.Location = new System.Drawing.Point(421, 98);
            this.txt_DNI_CalendarioVacunacion.Name = "txt_DNI_CalendarioVacunacion";
            this.txt_DNI_CalendarioVacunacion.Size = new System.Drawing.Size(132, 20);
            this.txt_DNI_CalendarioVacunacion.TabIndex = 153;
            // 
            // lbl_NumeroDoc_CalendarioVacunacion
            // 
            this.lbl_NumeroDoc_CalendarioVacunacion.AutoSize = true;
            this.lbl_NumeroDoc_CalendarioVacunacion.Location = new System.Drawing.Point(418, 81);
            this.lbl_NumeroDoc_CalendarioVacunacion.Name = "lbl_NumeroDoc_CalendarioVacunacion";
            this.lbl_NumeroDoc_CalendarioVacunacion.Size = new System.Drawing.Size(100, 13);
            this.lbl_NumeroDoc_CalendarioVacunacion.TabIndex = 152;
            this.lbl_NumeroDoc_CalendarioVacunacion.Text = "Numero documento";
            // 
            // txt_edad_CalendarioVacunacion
            // 
            this.txt_edad_CalendarioVacunacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_edad_CalendarioVacunacion.Location = new System.Drawing.Point(604, 94);
            this.txt_edad_CalendarioVacunacion.Name = "txt_edad_CalendarioVacunacion";
            this.txt_edad_CalendarioVacunacion.Size = new System.Drawing.Size(70, 20);
            this.txt_edad_CalendarioVacunacion.TabIndex = 155;
            // 
            // lbl_Edad_CalendarioVacunacion
            // 
            this.lbl_Edad_CalendarioVacunacion.AutoEllipsis = true;
            this.lbl_Edad_CalendarioVacunacion.AutoSize = true;
            this.lbl_Edad_CalendarioVacunacion.Location = new System.Drawing.Point(602, 81);
            this.lbl_Edad_CalendarioVacunacion.Name = "lbl_Edad_CalendarioVacunacion";
            this.lbl_Edad_CalendarioVacunacion.Size = new System.Drawing.Size(32, 13);
            this.lbl_Edad_CalendarioVacunacion.TabIndex = 154;
            this.lbl_Edad_CalendarioVacunacion.Text = "Edad";
            // 
            // btn_BuscarPacientes_CalendarioVacunacion
            // 
            this.btn_BuscarPacientes_CalendarioVacunacion.BackColor = System.Drawing.Color.MistyRose;
            this.btn_BuscarPacientes_CalendarioVacunacion.Location = new System.Drawing.Point(695, 126);
            this.btn_BuscarPacientes_CalendarioVacunacion.Name = "btn_BuscarPacientes_CalendarioVacunacion";
            this.btn_BuscarPacientes_CalendarioVacunacion.Size = new System.Drawing.Size(103, 23);
            this.btn_BuscarPacientes_CalendarioVacunacion.TabIndex = 156;
            this.btn_BuscarPacientes_CalendarioVacunacion.Text = "Buscar Pacientes";
            this.btn_BuscarPacientes_CalendarioVacunacion.UseVisualStyleBackColor = false;
            this.btn_BuscarPacientes_CalendarioVacunacion.Click += new System.EventHandler(this.btn_BuscarPacientes_CalendarioVacunacion_Click);
            // 
            // CalendarioDeVacunaciónForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 595);
            this.Controls.Add(this.btn_BuscarPacientes_CalendarioVacunacion);
            this.Controls.Add(this.txt_edad_CalendarioVacunacion);
            this.Controls.Add(this.lbl_Edad_CalendarioVacunacion);
            this.Controls.Add(this.txt_DNI_CalendarioVacunacion);
            this.Controls.Add(this.lbl_NumeroDoc_CalendarioVacunacion);
            this.Controls.Add(this.txt_apellido_CalendarioVacunacion);
            this.Controls.Add(this.lbl_Apellido_CalendarioVacunacion);
            this.Controls.Add(this.txt_nombre_CalendarioVacunacion);
            this.Controls.Add(this.lbl_Nombre_CalendarioVacunacion);
            this.Controls.Add(this.btn_Limpiar_CalendarioVacunacion);
            this.Controls.Add(this.btnCancelar_CalendarioVacunacion);
            this.Controls.Add(this.bttn_Mostrar_CalendarioVacunacion);
            this.Controls.Add(this.cmb_Estado_CalendarioVacunacion);
            this.Controls.Add(this.lbl_Estado_CalendarioVacunacion);
            this.Controls.Add(this.dtgv_CalendarioVacunacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_CalendariodeVacunacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarioDeVacunaciónForm";
            this.Text = "CalendarioDeVacunación";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CalendarioVacunacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CalendariodeVacunacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_Estado_CalendarioVacunacion;
        private System.Windows.Forms.ComboBox cmb_Estado_CalendarioVacunacion;
        private System.Windows.Forms.Button bttn_Mostrar_CalendarioVacunacion;
        private System.Windows.Forms.Button btnCancelar_CalendarioVacunacion;
        private System.Windows.Forms.Button btn_Limpiar_CalendarioVacunacion;
        private System.Windows.Forms.TextBox txt_apellido_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_Apellido_CalendarioVacunacion;
        private System.Windows.Forms.TextBox txt_nombre_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_Nombre_CalendarioVacunacion;
        private System.Windows.Forms.TextBox txt_DNI_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_NumeroDoc_CalendarioVacunacion;
        private System.Windows.Forms.TextBox txt_edad_CalendarioVacunacion;
        private System.Windows.Forms.Label lbl_Edad_CalendarioVacunacion;
        private System.Windows.Forms.Button btn_BuscarPacientes_CalendarioVacunacion;
    }
}