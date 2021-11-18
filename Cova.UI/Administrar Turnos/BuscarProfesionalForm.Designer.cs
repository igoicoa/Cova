namespace Cova.UI.Administrar_Turnos
{
    partial class BuscarProfesionalForm
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
            this.cmb_especialidad = new System.Windows.Forms.ComboBox();
            this.lbl_Especialidad = new System.Windows.Forms.Label();
            this.lbl_Profesional = new System.Windows.Forms.Label();
            this.lbl_BuscarVacunas = new System.Windows.Forms.Label();
            this.txt_profesionalApellido = new System.Windows.Forms.TextBox();
            this.txt_profesionalNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_medicos = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_especialidad
            // 
            this.cmb_especialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especialidad.FormattingEnabled = true;
            this.cmb_especialidad.Location = new System.Drawing.Point(599, 77);
            this.cmb_especialidad.Name = "cmb_especialidad";
            this.cmb_especialidad.Size = new System.Drawing.Size(132, 21);
            this.cmb_especialidad.TabIndex = 185;
            // 
            // lbl_Especialidad
            // 
            this.lbl_Especialidad.AutoSize = true;
            this.lbl_Especialidad.Location = new System.Drawing.Point(526, 81);
            this.lbl_Especialidad.Name = "lbl_Especialidad";
            this.lbl_Especialidad.Size = new System.Drawing.Size(67, 13);
            this.lbl_Especialidad.TabIndex = 184;
            this.lbl_Especialidad.Text = "Especialidad";
            // 
            // lbl_Profesional
            // 
            this.lbl_Profesional.AutoSize = true;
            this.lbl_Profesional.Location = new System.Drawing.Point(34, 80);
            this.lbl_Profesional.Name = "lbl_Profesional";
            this.lbl_Profesional.Size = new System.Drawing.Size(44, 13);
            this.lbl_Profesional.TabIndex = 183;
            this.lbl_Profesional.Text = "Apellido";
            // 
            // lbl_BuscarVacunas
            // 
            this.lbl_BuscarVacunas.AutoSize = true;
            this.lbl_BuscarVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarVacunas.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_BuscarVacunas.Location = new System.Drawing.Point(32, 19);
            this.lbl_BuscarVacunas.Name = "lbl_BuscarVacunas";
            this.lbl_BuscarVacunas.Size = new System.Drawing.Size(211, 25);
            this.lbl_BuscarVacunas.TabIndex = 187;
            this.lbl_BuscarVacunas.Text = "Buscar Profesional";
            // 
            // txt_profesionalApellido
            // 
            this.txt_profesionalApellido.Location = new System.Drawing.Point(97, 77);
            this.txt_profesionalApellido.Name = "txt_profesionalApellido";
            this.txt_profesionalApellido.Size = new System.Drawing.Size(136, 20);
            this.txt_profesionalApellido.TabIndex = 188;
            // 
            // txt_profesionalNombre
            // 
            this.txt_profesionalNombre.Location = new System.Drawing.Point(338, 77);
            this.txt_profesionalNombre.Name = "txt_profesionalNombre";
            this.txt_profesionalNombre.Size = new System.Drawing.Size(136, 20);
            this.txt_profesionalNombre.TabIndex = 190;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 189;
            this.label1.Text = "Nombre";
            // 
            // dgv_medicos
            // 
            this.dgv_medicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_medicos.Location = new System.Drawing.Point(37, 158);
            this.dgv_medicos.Name = "dgv_medicos";
            this.dgv_medicos.Size = new System.Drawing.Size(694, 270);
            this.dgv_medicos.TabIndex = 191;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(257, 118);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 192;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Seleccionar
            // 
            this.btn_Seleccionar.Location = new System.Drawing.Point(410, 118);
            this.btn_Seleccionar.Name = "btn_Seleccionar";
            this.btn_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Seleccionar.TabIndex = 193;
            this.btn_Seleccionar.Text = "Seleccionar";
            this.btn_Seleccionar.UseVisualStyleBackColor = true;
            // 
            // BuscarProfesionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Seleccionar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dgv_medicos);
            this.Controls.Add(this.txt_profesionalNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_profesionalApellido);
            this.Controls.Add(this.lbl_BuscarVacunas);
            this.Controls.Add(this.cmb_especialidad);
            this.Controls.Add(this.lbl_Especialidad);
            this.Controls.Add(this.lbl_Profesional);
            this.Name = "BuscarProfesionalForm";
            this.Text = "BuscarProfesionalForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_medicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_especialidad;
        private System.Windows.Forms.Label lbl_Especialidad;
        private System.Windows.Forms.Label lbl_Profesional;
        private System.Windows.Forms.Label lbl_BuscarVacunas;
        private System.Windows.Forms.TextBox txt_profesionalApellido;
        private System.Windows.Forms.TextBox txt_profesionalNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_medicos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Seleccionar;
    }
}