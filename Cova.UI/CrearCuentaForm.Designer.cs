namespace Cova.UI
{
    partial class CrearCuentaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_paciente = new System.Windows.Forms.RadioButton();
            this.rb_medico = new System.Windows.Forms.RadioButton();
            this.rb_enfermero = new System.Windows.Forms.RadioButton();
            this.rb_administrador = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_administrador);
            this.groupBox1.Controls.Add(this.rb_enfermero);
            this.groupBox1.Controls.Add(this.rb_medico);
            this.groupBox1.Controls.Add(this.rb_paciente);
            this.groupBox1.Location = new System.Drawing.Point(43, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Usuario";
            // 
            // rb_paciente
            // 
            this.rb_paciente.AutoSize = true;
            this.rb_paciente.Location = new System.Drawing.Point(15, 19);
            this.rb_paciente.Name = "rb_paciente";
            this.rb_paciente.Size = new System.Drawing.Size(67, 17);
            this.rb_paciente.TabIndex = 0;
            this.rb_paciente.TabStop = true;
            this.rb_paciente.Text = "Paciente";
            this.rb_paciente.UseVisualStyleBackColor = true;
            // 
            // rb_medico
            // 
            this.rb_medico.AutoSize = true;
            this.rb_medico.Location = new System.Drawing.Point(98, 19);
            this.rb_medico.Name = "rb_medico";
            this.rb_medico.Size = new System.Drawing.Size(60, 17);
            this.rb_medico.TabIndex = 1;
            this.rb_medico.TabStop = true;
            this.rb_medico.Text = "Medico";
            this.rb_medico.UseVisualStyleBackColor = true;
            // 
            // rb_enfermero
            // 
            this.rb_enfermero.AutoSize = true;
            this.rb_enfermero.Location = new System.Drawing.Point(173, 19);
            this.rb_enfermero.Name = "rb_enfermero";
            this.rb_enfermero.Size = new System.Drawing.Size(73, 17);
            this.rb_enfermero.TabIndex = 2;
            this.rb_enfermero.TabStop = true;
            this.rb_enfermero.Text = "Enfermero";
            this.rb_enfermero.UseVisualStyleBackColor = true;
            // 
            // rb_administrador
            // 
            this.rb_administrador.AutoSize = true;
            this.rb_administrador.Location = new System.Drawing.Point(252, 19);
            this.rb_administrador.Name = "rb_administrador";
            this.rb_administrador.Size = new System.Drawing.Size(88, 17);
            this.rb_administrador.TabIndex = 3;
            this.rb_administrador.TabStop = true;
            this.rb_administrador.Text = "Administrador";
            this.rb_administrador.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "N";
            // 
            // CrearCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearCuentaForm";
            this.Text = "Crear Cuenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_administrador;
        private System.Windows.Forms.RadioButton rb_enfermero;
        private System.Windows.Forms.RadioButton rb_medico;
        private System.Windows.Forms.RadioButton rb_paciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}