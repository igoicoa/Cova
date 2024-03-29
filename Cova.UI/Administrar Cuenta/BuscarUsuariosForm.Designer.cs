﻿
namespace Cova.UI
{
    partial class BuscarUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarUsuariosForm));
            this.btn_Limpiar_BuscarUsuario = new System.Windows.Forms.Button();
            this.btn_Cancelar_BuscarUsuario = new System.Windows.Forms.Button();
            this.txt_DNI_BuscarUsuario = new System.Windows.Forms.TextBox();
            this.txt_Usuario_BuscarUsuario = new System.Windows.Forms.TextBox();
            this.lbl_DNI_BuscarUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario_BuscarUsuario = new System.Windows.Forms.Label();
            this.bttn_Buscar_BuscarUsuario = new System.Windows.Forms.Button();
            this.dgv_usuario = new System.Windows.Forms.DataGridView();
            this.lbl_BuscarUsuarios = new System.Windows.Forms.Label();
            this.gb_TipoUsuario_BuscarUsuarios = new System.Windows.Forms.GroupBox();
            this.rb_administrador_BuscarUsuarios = new System.Windows.Forms.RadioButton();
            this.rb_enfermero_BuscarUsuarios = new System.Windows.Forms.RadioButton();
            this.rb_medico_BuscarUsuarios = new System.Windows.Forms.RadioButton();
            this.rb_paciente_BuscarUsuarios = new System.Windows.Forms.RadioButton();
            this.btn_SeleccionarUsuario_BuscarUsuarios = new System.Windows.Forms.Button();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).BeginInit();
            this.gb_TipoUsuario_BuscarUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Limpiar_BuscarUsuario
            // 
            this.btn_Limpiar_BuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar_BuscarUsuario.Location = new System.Drawing.Point(608, 96);
            this.btn_Limpiar_BuscarUsuario.Name = "btn_Limpiar_BuscarUsuario";
            this.btn_Limpiar_BuscarUsuario.Size = new System.Drawing.Size(78, 23);
            this.btn_Limpiar_BuscarUsuario.TabIndex = 146;
            this.btn_Limpiar_BuscarUsuario.Text = "Limpiar";
            this.btn_Limpiar_BuscarUsuario.UseVisualStyleBackColor = true;
            this.btn_Limpiar_BuscarUsuario.Click += new System.EventHandler(this.btn_Limpiar_BuscarUsuario_Click);
            // 
            // btn_Cancelar_BuscarUsuario
            // 
            this.btn_Cancelar_BuscarUsuario.Location = new System.Drawing.Point(692, 97);
            this.btn_Cancelar_BuscarUsuario.Name = "btn_Cancelar_BuscarUsuario";
            this.btn_Cancelar_BuscarUsuario.Size = new System.Drawing.Size(78, 23);
            this.btn_Cancelar_BuscarUsuario.TabIndex = 145;
            this.btn_Cancelar_BuscarUsuario.Text = "Cancelar";
            this.btn_Cancelar_BuscarUsuario.UseVisualStyleBackColor = true;
            this.btn_Cancelar_BuscarUsuario.Click += new System.EventHandler(this.btn_Cancelar_BuscarUsuario_Click);
            // 
            // txt_DNI_BuscarUsuario
            // 
            this.txt_DNI_BuscarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_DNI_BuscarUsuario.Location = new System.Drawing.Point(202, 99);
            this.txt_DNI_BuscarUsuario.Name = "txt_DNI_BuscarUsuario";
            this.txt_DNI_BuscarUsuario.Size = new System.Drawing.Size(136, 20);
            this.txt_DNI_BuscarUsuario.TabIndex = 142;
            // 
            // txt_Usuario_BuscarUsuario
            // 
            this.txt_Usuario_BuscarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Usuario_BuscarUsuario.Location = new System.Drawing.Point(19, 100);
            this.txt_Usuario_BuscarUsuario.Name = "txt_Usuario_BuscarUsuario";
            this.txt_Usuario_BuscarUsuario.Size = new System.Drawing.Size(136, 20);
            this.txt_Usuario_BuscarUsuario.TabIndex = 141;
            // 
            // lbl_DNI_BuscarUsuario
            // 
            this.lbl_DNI_BuscarUsuario.AutoSize = true;
            this.lbl_DNI_BuscarUsuario.Location = new System.Drawing.Point(199, 83);
            this.lbl_DNI_BuscarUsuario.Name = "lbl_DNI_BuscarUsuario";
            this.lbl_DNI_BuscarUsuario.Size = new System.Drawing.Size(26, 13);
            this.lbl_DNI_BuscarUsuario.TabIndex = 140;
            this.lbl_DNI_BuscarUsuario.Text = "DNI";
            // 
            // lbl_Usuario_BuscarUsuario
            // 
            this.lbl_Usuario_BuscarUsuario.AutoSize = true;
            this.lbl_Usuario_BuscarUsuario.Location = new System.Drawing.Point(14, 83);
            this.lbl_Usuario_BuscarUsuario.Name = "lbl_Usuario_BuscarUsuario";
            this.lbl_Usuario_BuscarUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario_BuscarUsuario.TabIndex = 139;
            this.lbl_Usuario_BuscarUsuario.Text = "Usuario";
            // 
            // bttn_Buscar_BuscarUsuario
            // 
            this.bttn_Buscar_BuscarUsuario.Location = new System.Drawing.Point(408, 96);
            this.bttn_Buscar_BuscarUsuario.Name = "bttn_Buscar_BuscarUsuario";
            this.bttn_Buscar_BuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.bttn_Buscar_BuscarUsuario.TabIndex = 138;
            this.bttn_Buscar_BuscarUsuario.Text = "Buscar";
            this.bttn_Buscar_BuscarUsuario.UseVisualStyleBackColor = true;
            this.bttn_Buscar_BuscarUsuario.Click += new System.EventHandler(this.bttn_Buscar_BuscarUsuario_Click);
            // 
            // dgv_usuario
            // 
            this.dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuario.Location = new System.Drawing.Point(12, 167);
            this.dgv_usuario.Name = "dgv_usuario";
            this.dgv_usuario.ReadOnly = true;
            this.dgv_usuario.Size = new System.Drawing.Size(776, 244);
            this.dgv_usuario.TabIndex = 137;
            // 
            // lbl_BuscarUsuarios
            // 
            this.lbl_BuscarUsuarios.AutoSize = true;
            this.lbl_BuscarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BuscarUsuarios.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_BuscarUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lbl_BuscarUsuarios.Name = "lbl_BuscarUsuarios";
            this.lbl_BuscarUsuarios.Size = new System.Drawing.Size(185, 25);
            this.lbl_BuscarUsuarios.TabIndex = 147;
            this.lbl_BuscarUsuarios.Text = "Buscar Usuarios";
            // 
            // gb_TipoUsuario_BuscarUsuarios
            // 
            this.gb_TipoUsuario_BuscarUsuarios.Controls.Add(this.rb_administrador_BuscarUsuarios);
            this.gb_TipoUsuario_BuscarUsuarios.Controls.Add(this.rb_enfermero_BuscarUsuarios);
            this.gb_TipoUsuario_BuscarUsuarios.Controls.Add(this.rb_medico_BuscarUsuarios);
            this.gb_TipoUsuario_BuscarUsuarios.Controls.Add(this.rb_paciente_BuscarUsuarios);
            this.gb_TipoUsuario_BuscarUsuarios.Location = new System.Drawing.Point(17, 38);
            this.gb_TipoUsuario_BuscarUsuarios.Name = "gb_TipoUsuario_BuscarUsuarios";
            this.gb_TipoUsuario_BuscarUsuarios.Size = new System.Drawing.Size(355, 42);
            this.gb_TipoUsuario_BuscarUsuarios.TabIndex = 148;
            this.gb_TipoUsuario_BuscarUsuarios.TabStop = false;
            this.gb_TipoUsuario_BuscarUsuarios.Text = "Tipo de Usuario";
            // 
            // rb_administrador_BuscarUsuarios
            // 
            this.rb_administrador_BuscarUsuarios.AutoSize = true;
            this.rb_administrador_BuscarUsuarios.Location = new System.Drawing.Point(252, 19);
            this.rb_administrador_BuscarUsuarios.Name = "rb_administrador_BuscarUsuarios";
            this.rb_administrador_BuscarUsuarios.Size = new System.Drawing.Size(88, 17);
            this.rb_administrador_BuscarUsuarios.TabIndex = 3;
            this.rb_administrador_BuscarUsuarios.TabStop = true;
            this.rb_administrador_BuscarUsuarios.Text = "Administrador";
            this.rb_administrador_BuscarUsuarios.UseVisualStyleBackColor = true;
            // 
            // rb_enfermero_BuscarUsuarios
            // 
            this.rb_enfermero_BuscarUsuarios.AutoSize = true;
            this.rb_enfermero_BuscarUsuarios.Location = new System.Drawing.Point(173, 19);
            this.rb_enfermero_BuscarUsuarios.Name = "rb_enfermero_BuscarUsuarios";
            this.rb_enfermero_BuscarUsuarios.Size = new System.Drawing.Size(73, 17);
            this.rb_enfermero_BuscarUsuarios.TabIndex = 2;
            this.rb_enfermero_BuscarUsuarios.TabStop = true;
            this.rb_enfermero_BuscarUsuarios.Text = "Enfermero";
            this.rb_enfermero_BuscarUsuarios.UseVisualStyleBackColor = true;
            // 
            // rb_medico_BuscarUsuarios
            // 
            this.rb_medico_BuscarUsuarios.AutoSize = true;
            this.rb_medico_BuscarUsuarios.Location = new System.Drawing.Point(98, 19);
            this.rb_medico_BuscarUsuarios.Name = "rb_medico_BuscarUsuarios";
            this.rb_medico_BuscarUsuarios.Size = new System.Drawing.Size(60, 17);
            this.rb_medico_BuscarUsuarios.TabIndex = 1;
            this.rb_medico_BuscarUsuarios.TabStop = true;
            this.rb_medico_BuscarUsuarios.Text = "Medico";
            this.rb_medico_BuscarUsuarios.UseVisualStyleBackColor = true;
            // 
            // rb_paciente_BuscarUsuarios
            // 
            this.rb_paciente_BuscarUsuarios.AutoSize = true;
            this.rb_paciente_BuscarUsuarios.Location = new System.Drawing.Point(15, 19);
            this.rb_paciente_BuscarUsuarios.Name = "rb_paciente_BuscarUsuarios";
            this.rb_paciente_BuscarUsuarios.Size = new System.Drawing.Size(67, 17);
            this.rb_paciente_BuscarUsuarios.TabIndex = 0;
            this.rb_paciente_BuscarUsuarios.TabStop = true;
            this.rb_paciente_BuscarUsuarios.Text = "Paciente";
            this.rb_paciente_BuscarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btn_SeleccionarUsuario_BuscarUsuarios
            // 
            this.btn_SeleccionarUsuario_BuscarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SeleccionarUsuario_BuscarUsuarios.Location = new System.Drawing.Point(489, 96);
            this.btn_SeleccionarUsuario_BuscarUsuarios.Name = "btn_SeleccionarUsuario_BuscarUsuarios";
            this.btn_SeleccionarUsuario_BuscarUsuarios.Size = new System.Drawing.Size(113, 23);
            this.btn_SeleccionarUsuario_BuscarUsuarios.TabIndex = 149;
            this.btn_SeleccionarUsuario_BuscarUsuarios.Text = "Seleccionar Usuario";
            this.btn_SeleccionarUsuario_BuscarUsuarios.UseVisualStyleBackColor = true;
            this.btn_SeleccionarUsuario_BuscarUsuarios.Click += new System.EventHandler(this.btn_SeleccionarUsuario_BuscarUsuarios_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.Control;
            this.txt_apellido.Location = new System.Drawing.Point(202, 140);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(136, 20);
            this.txt_apellido.TabIndex = 153;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.Location = new System.Drawing.Point(19, 141);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(136, 20);
            this.txt_nombre.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 150;
            this.label2.Text = "Nombre";
            // 
            // BuscarUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SeleccionarUsuario_BuscarUsuarios);
            this.Controls.Add(this.gb_TipoUsuario_BuscarUsuarios);
            this.Controls.Add(this.lbl_BuscarUsuarios);
            this.Controls.Add(this.btn_Limpiar_BuscarUsuario);
            this.Controls.Add(this.btn_Cancelar_BuscarUsuario);
            this.Controls.Add(this.txt_DNI_BuscarUsuario);
            this.Controls.Add(this.txt_Usuario_BuscarUsuario);
            this.Controls.Add(this.lbl_DNI_BuscarUsuario);
            this.Controls.Add(this.lbl_Usuario_BuscarUsuario);
            this.Controls.Add(this.bttn_Buscar_BuscarUsuario);
            this.Controls.Add(this.dgv_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarUsuariosForm";
            this.Text = "Buscar Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuario)).EndInit();
            this.gb_TipoUsuario_BuscarUsuarios.ResumeLayout(false);
            this.gb_TipoUsuario_BuscarUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Limpiar_BuscarUsuario;
        private System.Windows.Forms.Button btn_Cancelar_BuscarUsuario;
        private System.Windows.Forms.TextBox txt_DNI_BuscarUsuario;
        private System.Windows.Forms.TextBox txt_Usuario_BuscarUsuario;
        private System.Windows.Forms.Label lbl_DNI_BuscarUsuario;
        private System.Windows.Forms.Label lbl_Usuario_BuscarUsuario;
        private System.Windows.Forms.Button bttn_Buscar_BuscarUsuario;
        private System.Windows.Forms.DataGridView dgv_usuario;
        private System.Windows.Forms.Label lbl_BuscarUsuarios;
        private System.Windows.Forms.GroupBox gb_TipoUsuario_BuscarUsuarios;
        private System.Windows.Forms.RadioButton rb_administrador_BuscarUsuarios;
        private System.Windows.Forms.RadioButton rb_enfermero_BuscarUsuarios;
        private System.Windows.Forms.RadioButton rb_medico_BuscarUsuarios;
        private System.Windows.Forms.RadioButton rb_paciente_BuscarUsuarios;
        private System.Windows.Forms.Button btn_SeleccionarUsuario_BuscarUsuarios;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}