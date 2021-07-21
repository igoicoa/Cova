
namespace Cova.UI
{
    partial class CrearRecetas_CertificadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearRecetas_CertificadosForm));
            this.lbl_CrearRecetayCertificado = new System.Windows.Forms.Label();
            this.btnCancelar_ModificarRecetayCertificado = new System.Windows.Forms.Button();
            this.gb_TipoDocumento_ModificarRecetayCertificado = new System.Windows.Forms.GroupBox();
            this.rb_Certificado_ModificarRecetayCertificado = new System.Windows.Forms.RadioButton();
            this.rb_Receta_ModificarRecetayCertificado = new System.Windows.Forms.RadioButton();
            this.gb_TipoDocumento_ModificarRecetayCertificado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CrearRecetayCertificado
            // 
            this.lbl_CrearRecetayCertificado.AutoSize = true;
            this.lbl_CrearRecetayCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CrearRecetayCertificado.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_CrearRecetayCertificado.Location = new System.Drawing.Point(12, 9);
            this.lbl_CrearRecetayCertificado.Name = "lbl_CrearRecetayCertificado";
            this.lbl_CrearRecetayCertificado.Size = new System.Drawing.Size(291, 25);
            this.lbl_CrearRecetayCertificado.TabIndex = 91;
            this.lbl_CrearRecetayCertificado.Text = "Crear Receta y Certificado";
            // 
            // btnCancelar_ModificarRecetayCertificado
            // 
            this.btnCancelar_ModificarRecetayCertificado.Location = new System.Drawing.Point(68, 107);
            this.btnCancelar_ModificarRecetayCertificado.Name = "btnCancelar_ModificarRecetayCertificado";
            this.btnCancelar_ModificarRecetayCertificado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_ModificarRecetayCertificado.TabIndex = 97;
            this.btnCancelar_ModificarRecetayCertificado.Text = "Cancelar";
            this.btnCancelar_ModificarRecetayCertificado.UseVisualStyleBackColor = true;
            this.btnCancelar_ModificarRecetayCertificado.Click += new System.EventHandler(this.btnCancelar_CrearRecetayCertificado_Click);
            // 
            // gb_TipoDocumento_ModificarRecetayCertificado
            // 
            this.gb_TipoDocumento_ModificarRecetayCertificado.Controls.Add(this.rb_Certificado_ModificarRecetayCertificado);
            this.gb_TipoDocumento_ModificarRecetayCertificado.Controls.Add(this.rb_Receta_ModificarRecetayCertificado);
            this.gb_TipoDocumento_ModificarRecetayCertificado.Location = new System.Drawing.Point(12, 58);
            this.gb_TipoDocumento_ModificarRecetayCertificado.Name = "gb_TipoDocumento_ModificarRecetayCertificado";
            this.gb_TipoDocumento_ModificarRecetayCertificado.Size = new System.Drawing.Size(185, 43);
            this.gb_TipoDocumento_ModificarRecetayCertificado.TabIndex = 100;
            this.gb_TipoDocumento_ModificarRecetayCertificado.TabStop = false;
            this.gb_TipoDocumento_ModificarRecetayCertificado.Text = "Tipo de Documento";
            // 
            // rb_Certificado_ModificarRecetayCertificado
            // 
            this.rb_Certificado_ModificarRecetayCertificado.AutoSize = true;
            this.rb_Certificado_ModificarRecetayCertificado.Location = new System.Drawing.Point(98, 19);
            this.rb_Certificado_ModificarRecetayCertificado.Name = "rb_Certificado_ModificarRecetayCertificado";
            this.rb_Certificado_ModificarRecetayCertificado.Size = new System.Drawing.Size(75, 17);
            this.rb_Certificado_ModificarRecetayCertificado.TabIndex = 1;
            this.rb_Certificado_ModificarRecetayCertificado.TabStop = true;
            this.rb_Certificado_ModificarRecetayCertificado.Text = "Certificado";
            this.rb_Certificado_ModificarRecetayCertificado.UseVisualStyleBackColor = true;
            this.rb_Certificado_ModificarRecetayCertificado.CheckedChanged += new System.EventHandler(this.rb_Certificado_CrearRecetayCertificado_CheckedChanged);
            // 
            // rb_Receta_ModificarRecetayCertificado
            // 
            this.rb_Receta_ModificarRecetayCertificado.AutoSize = true;
            this.rb_Receta_ModificarRecetayCertificado.Location = new System.Drawing.Point(15, 19);
            this.rb_Receta_ModificarRecetayCertificado.Name = "rb_Receta_ModificarRecetayCertificado";
            this.rb_Receta_ModificarRecetayCertificado.Size = new System.Drawing.Size(60, 17);
            this.rb_Receta_ModificarRecetayCertificado.TabIndex = 0;
            this.rb_Receta_ModificarRecetayCertificado.TabStop = true;
            this.rb_Receta_ModificarRecetayCertificado.Text = "Receta";
            this.rb_Receta_ModificarRecetayCertificado.UseVisualStyleBackColor = true;
            this.rb_Receta_ModificarRecetayCertificado.CheckedChanged += new System.EventHandler(this.rb_Receta_CrearRecetayCertificado_CheckedChanged);
            // 
            // CrearRecetas_CertificadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 146);
            this.Controls.Add(this.gb_TipoDocumento_ModificarRecetayCertificado);
            this.Controls.Add(this.btnCancelar_ModificarRecetayCertificado);
            this.Controls.Add(this.lbl_CrearRecetayCertificado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearRecetas_CertificadosForm";
            this.Text = "CrearRecetas_CertificadosForm";
            this.gb_TipoDocumento_ModificarRecetayCertificado.ResumeLayout(false);
            this.gb_TipoDocumento_ModificarRecetayCertificado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CrearRecetayCertificado;
        private System.Windows.Forms.Button btnCancelar_ModificarRecetayCertificado;
        private System.Windows.Forms.GroupBox gb_TipoDocumento_ModificarRecetayCertificado;
        private System.Windows.Forms.RadioButton rb_Certificado_ModificarRecetayCertificado;
        private System.Windows.Forms.RadioButton rb_Receta_ModificarRecetayCertificado;
    }
}