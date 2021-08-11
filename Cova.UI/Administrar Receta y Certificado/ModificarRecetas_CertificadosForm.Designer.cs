
namespace Cova.UI
{
    partial class ModificarRecetas_CertificadosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarRecetas_CertificadosForm));
            this.gb_TipoDocumento_ModificarRecetayCertificado = new System.Windows.Forms.GroupBox();
            this.rb_Certificado_CrearRecetayCertificado = new System.Windows.Forms.RadioButton();
            this.rb_Receta_CrearRecetayCertificado = new System.Windows.Forms.RadioButton();
            this.btnCancelar_CrearRecetayCertificado = new System.Windows.Forms.Button();
            this.lbl_ModificarRecetayCertificado = new System.Windows.Forms.Label();
            this.gb_TipoDocumento_ModificarRecetayCertificado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TipoDocumento_ModificarRecetayCertificado
            // 
            this.gb_TipoDocumento_ModificarRecetayCertificado.Controls.Add(this.rb_Certificado_CrearRecetayCertificado);
            this.gb_TipoDocumento_ModificarRecetayCertificado.Controls.Add(this.rb_Receta_CrearRecetayCertificado);
            this.gb_TipoDocumento_ModificarRecetayCertificado.Location = new System.Drawing.Point(17, 56);
            this.gb_TipoDocumento_ModificarRecetayCertificado.Name = "gb_TipoDocumento_ModificarRecetayCertificado";
            this.gb_TipoDocumento_ModificarRecetayCertificado.Size = new System.Drawing.Size(185, 43);
            this.gb_TipoDocumento_ModificarRecetayCertificado.TabIndex = 103;
            this.gb_TipoDocumento_ModificarRecetayCertificado.TabStop = false;
            this.gb_TipoDocumento_ModificarRecetayCertificado.Text = "Tipo de Documento";
            // 
            // rb_Certificado_CrearRecetayCertificado
            // 
            this.rb_Certificado_CrearRecetayCertificado.AutoSize = true;
            this.rb_Certificado_CrearRecetayCertificado.Location = new System.Drawing.Point(98, 19);
            this.rb_Certificado_CrearRecetayCertificado.Name = "rb_Certificado_CrearRecetayCertificado";
            this.rb_Certificado_CrearRecetayCertificado.Size = new System.Drawing.Size(75, 17);
            this.rb_Certificado_CrearRecetayCertificado.TabIndex = 1;
            this.rb_Certificado_CrearRecetayCertificado.TabStop = true;
            this.rb_Certificado_CrearRecetayCertificado.Text = "Certificado";
            this.rb_Certificado_CrearRecetayCertificado.UseVisualStyleBackColor = true;
            // 
            // rb_Receta_CrearRecetayCertificado
            // 
            this.rb_Receta_CrearRecetayCertificado.AutoSize = true;
            this.rb_Receta_CrearRecetayCertificado.Location = new System.Drawing.Point(15, 19);
            this.rb_Receta_CrearRecetayCertificado.Name = "rb_Receta_CrearRecetayCertificado";
            this.rb_Receta_CrearRecetayCertificado.Size = new System.Drawing.Size(60, 17);
            this.rb_Receta_CrearRecetayCertificado.TabIndex = 0;
            this.rb_Receta_CrearRecetayCertificado.TabStop = true;
            this.rb_Receta_CrearRecetayCertificado.Text = "Receta";
            this.rb_Receta_CrearRecetayCertificado.UseVisualStyleBackColor = true;
            this.rb_Receta_CrearRecetayCertificado.CheckedChanged += new System.EventHandler(this.rb_Receta_CrearRecetayCertificado_CheckedChanged);
            // 
            // btnCancelar_CrearRecetayCertificado
            // 
            this.btnCancelar_CrearRecetayCertificado.Location = new System.Drawing.Point(73, 105);
            this.btnCancelar_CrearRecetayCertificado.Name = "btnCancelar_CrearRecetayCertificado";
            this.btnCancelar_CrearRecetayCertificado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_CrearRecetayCertificado.TabIndex = 102;
            this.btnCancelar_CrearRecetayCertificado.Text = "Cancelar";
            this.btnCancelar_CrearRecetayCertificado.UseVisualStyleBackColor = true;
            this.btnCancelar_CrearRecetayCertificado.Click += new System.EventHandler(this.btnCancelar_CrearRecetayCertificado_Click);
            // 
            // lbl_ModificarRecetayCertificado
            // 
            this.lbl_ModificarRecetayCertificado.AutoSize = true;
            this.lbl_ModificarRecetayCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ModificarRecetayCertificado.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_ModificarRecetayCertificado.Location = new System.Drawing.Point(12, 9);
            this.lbl_ModificarRecetayCertificado.Name = "lbl_ModificarRecetayCertificado";
            this.lbl_ModificarRecetayCertificado.Size = new System.Drawing.Size(330, 25);
            this.lbl_ModificarRecetayCertificado.TabIndex = 101;
            this.lbl_ModificarRecetayCertificado.Text = "Modificar Receta y Certificado";
            // 
            // ModificarRecetas_CertificadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 148);
            this.Controls.Add(this.gb_TipoDocumento_ModificarRecetayCertificado);
            this.Controls.Add(this.btnCancelar_CrearRecetayCertificado);
            this.Controls.Add(this.lbl_ModificarRecetayCertificado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarRecetas_CertificadosForm";
            this.Text = "ModificarRecetas_CertificadosForm";
            this.gb_TipoDocumento_ModificarRecetayCertificado.ResumeLayout(false);
            this.gb_TipoDocumento_ModificarRecetayCertificado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TipoDocumento_ModificarRecetayCertificado;
        private System.Windows.Forms.RadioButton rb_Certificado_CrearRecetayCertificado;
        private System.Windows.Forms.RadioButton rb_Receta_CrearRecetayCertificado;
        private System.Windows.Forms.Button btnCancelar_CrearRecetayCertificado;
        private System.Windows.Forms.Label lbl_ModificarRecetayCertificado;
    }
}