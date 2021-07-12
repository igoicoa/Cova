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
            this.rb_administrador = new System.Windows.Forms.RadioButton();
            this.rb_enfermero = new System.Windows.Forms.RadioButton();
            this.rb_medico = new System.Windows.Forms.RadioButton();
            this.rb_paciente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCrearCuenta = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBox_CrearCuentaNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidoCrearCuenta = new System.Windows.Forms.TextBox();
            this.lbl_ApellidoCrearCuenta = new System.Windows.Forms.Label();
            this.lblSexoCrearCuenta = new System.Windows.Forms.Label();
            this.radioButtonMasculino_CrearCuenta = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino_CrearCuenta = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil_CrearCuenta = new System.Windows.Forms.Label();
            this.textBoxEstadoCivil_CrearCuenta = new System.Windows.Forms.TextBox();
            this.textBoxTelefono_CrearCuenta = new System.Windows.Forms.TextBox();
            this.lblTelefono_CrearCuenta = new System.Windows.Forms.Label();
            this.lblEspecialidad_CrearUsuario = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCiudad_CrearUsuario = new System.Windows.Forms.Label();
            this.textBoxDireccion_CrearCuenta = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblFechaNacimiento_CrearCuenta = new System.Windows.Forms.Label();
            this.monthCalendarCrearCuenta = new System.Windows.Forms.MonthCalendar();
            this.lblCoberturaMedica_CrearUsuario = new System.Windows.Forms.Label();
            this.lblImagen_CrearCuenta = new System.Windows.Forms.Label();
            this.btnCrear_CrearCuenta = new System.Windows.Forms.Button();
            this.btnCancelar_CrearCuenta = new System.Windows.Forms.Button();
            this.btnLimpiar_CrearCuenta = new System.Windows.Forms.Button();
            this.comboBoxCoberturaMedica_CrearCuenta = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagen_CrearCuenta = new System.Windows.Forms.PictureBox();
            this.textBoxClave_CrearCuenta = new System.Windows.Forms.TextBox();
            this.lblClave_CrearCuenta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen_CrearCuenta)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombreCrearCuenta
            // 
            this.lblNombreCrearCuenta.AutoSize = true;
            this.lblNombreCrearCuenta.Location = new System.Drawing.Point(43, 138);
            this.lblNombreCrearCuenta.Name = "lblNombreCrearCuenta";
            this.lblNombreCrearCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCrearCuenta.TabIndex = 7;
            this.lblNombreCrearCuenta.Text = "Nombre";
            this.lblNombreCrearCuenta.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DNI",
            "Cédula de Ciudadania"});
            this.comboBox1.Location = new System.Drawing.Point(43, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBox_CrearCuentaNombre
            // 
            this.txtBox_CrearCuentaNombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBox_CrearCuentaNombre.Location = new System.Drawing.Point(43, 155);
            this.txtBox_CrearCuentaNombre.Name = "txtBox_CrearCuentaNombre";
            this.txtBox_CrearCuentaNombre.Size = new System.Drawing.Size(363, 20);
            this.txtBox_CrearCuentaNombre.TabIndex = 9;
            // 
            // textBoxApellidoCrearCuenta
            // 
            this.textBoxApellidoCrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxApellidoCrearCuenta.Location = new System.Drawing.Point(43, 205);
            this.textBoxApellidoCrearCuenta.Name = "textBoxApellidoCrearCuenta";
            this.textBoxApellidoCrearCuenta.Size = new System.Drawing.Size(363, 20);
            this.textBoxApellidoCrearCuenta.TabIndex = 11;
            // 
            // lbl_ApellidoCrearCuenta
            // 
            this.lbl_ApellidoCrearCuenta.AutoSize = true;
            this.lbl_ApellidoCrearCuenta.Location = new System.Drawing.Point(43, 188);
            this.lbl_ApellidoCrearCuenta.Name = "lbl_ApellidoCrearCuenta";
            this.lbl_ApellidoCrearCuenta.Size = new System.Drawing.Size(44, 13);
            this.lbl_ApellidoCrearCuenta.TabIndex = 10;
            this.lbl_ApellidoCrearCuenta.Text = "Apellido";
            this.lbl_ApellidoCrearCuenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSexoCrearCuenta
            // 
            this.lblSexoCrearCuenta.AutoEllipsis = true;
            this.lblSexoCrearCuenta.AutoSize = true;
            this.lblSexoCrearCuenta.Location = new System.Drawing.Point(43, 239);
            this.lblSexoCrearCuenta.Name = "lblSexoCrearCuenta";
            this.lblSexoCrearCuenta.Size = new System.Drawing.Size(31, 13);
            this.lblSexoCrearCuenta.TabIndex = 12;
            this.lblSexoCrearCuenta.Text = "Sexo";
            this.lblSexoCrearCuenta.Click += new System.EventHandler(this.lblSexoCrearCuenta_Click);
            // 
            // radioButtonMasculino_CrearCuenta
            // 
            this.radioButtonMasculino_CrearCuenta.AutoSize = true;
            this.radioButtonMasculino_CrearCuenta.Location = new System.Drawing.Point(46, 255);
            this.radioButtonMasculino_CrearCuenta.Name = "radioButtonMasculino_CrearCuenta";
            this.radioButtonMasculino_CrearCuenta.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino_CrearCuenta.TabIndex = 13;
            this.radioButtonMasculino_CrearCuenta.TabStop = true;
            this.radioButtonMasculino_CrearCuenta.Text = "Masculino";
            this.radioButtonMasculino_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino_CrearCuenta
            // 
            this.radioButtonFemenino_CrearCuenta.AutoSize = true;
            this.radioButtonFemenino_CrearCuenta.Location = new System.Drawing.Point(125, 255);
            this.radioButtonFemenino_CrearCuenta.Name = "radioButtonFemenino_CrearCuenta";
            this.radioButtonFemenino_CrearCuenta.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino_CrearCuenta.TabIndex = 14;
            this.radioButtonFemenino_CrearCuenta.TabStop = true;
            this.radioButtonFemenino_CrearCuenta.Text = "Femenino";
            this.radioButtonFemenino_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil_CrearCuenta
            // 
            this.lblEstadoCivil_CrearCuenta.AutoEllipsis = true;
            this.lblEstadoCivil_CrearCuenta.AutoSize = true;
            this.lblEstadoCivil_CrearCuenta.Location = new System.Drawing.Point(417, 236);
            this.lblEstadoCivil_CrearCuenta.Name = "lblEstadoCivil_CrearCuenta";
            this.lblEstadoCivil_CrearCuenta.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil_CrearCuenta.TabIndex = 15;
            this.lblEstadoCivil_CrearCuenta.Text = "Estado Civil";
            // 
            // textBoxEstadoCivil_CrearCuenta
            // 
            this.textBoxEstadoCivil_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxEstadoCivil_CrearCuenta.Location = new System.Drawing.Point(420, 249);
            this.textBoxEstadoCivil_CrearCuenta.Name = "textBoxEstadoCivil_CrearCuenta";
            this.textBoxEstadoCivil_CrearCuenta.Size = new System.Drawing.Size(187, 20);
            this.textBoxEstadoCivil_CrearCuenta.TabIndex = 16;
            // 
            // textBoxTelefono_CrearCuenta
            // 
            this.textBoxTelefono_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTelefono_CrearCuenta.Location = new System.Drawing.Point(41, 304);
            this.textBoxTelefono_CrearCuenta.Name = "textBoxTelefono_CrearCuenta";
            this.textBoxTelefono_CrearCuenta.Size = new System.Drawing.Size(187, 20);
            this.textBoxTelefono_CrearCuenta.TabIndex = 18;
            // 
            // lblTelefono_CrearCuenta
            // 
            this.lblTelefono_CrearCuenta.AutoEllipsis = true;
            this.lblTelefono_CrearCuenta.AutoSize = true;
            this.lblTelefono_CrearCuenta.Location = new System.Drawing.Point(38, 291);
            this.lblTelefono_CrearCuenta.Name = "lblTelefono_CrearCuenta";
            this.lblTelefono_CrearCuenta.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono_CrearCuenta.TabIndex = 17;
            this.lblTelefono_CrearCuenta.Text = "Telefono";
            // 
            // lblEspecialidad_CrearUsuario
            // 
            this.lblEspecialidad_CrearUsuario.AutoEllipsis = true;
            this.lblEspecialidad_CrearUsuario.AutoSize = true;
            this.lblEspecialidad_CrearUsuario.Location = new System.Drawing.Point(420, 291);
            this.lblEspecialidad_CrearUsuario.Name = "lblEspecialidad_CrearUsuario";
            this.lblEspecialidad_CrearUsuario.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad_CrearUsuario.TabIndex = 19;
            this.lblEspecialidad_CrearUsuario.Text = "Especialidad";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.Location = new System.Drawing.Point(423, 356);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 22;
            // 
            // lblCiudad_CrearUsuario
            // 
            this.lblCiudad_CrearUsuario.AutoEllipsis = true;
            this.lblCiudad_CrearUsuario.AutoSize = true;
            this.lblCiudad_CrearUsuario.Location = new System.Drawing.Point(420, 343);
            this.lblCiudad_CrearUsuario.Name = "lblCiudad_CrearUsuario";
            this.lblCiudad_CrearUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad_CrearUsuario.TabIndex = 21;
            this.lblCiudad_CrearUsuario.Text = "Ciudad";
            // 
            // textBoxDireccion_CrearCuenta
            // 
            this.textBoxDireccion_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxDireccion_CrearCuenta.Location = new System.Drawing.Point(41, 356);
            this.textBoxDireccion_CrearCuenta.Name = "textBoxDireccion_CrearCuenta";
            this.textBoxDireccion_CrearCuenta.Size = new System.Drawing.Size(187, 20);
            this.textBoxDireccion_CrearCuenta.TabIndex = 24;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoEllipsis = true;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(38, 343);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Direccion";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DNI",
            "Cédula de Ciudadania"});
            this.comboBox2.Location = new System.Drawing.Point(423, 307);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // lblFechaNacimiento_CrearCuenta
            // 
            this.lblFechaNacimiento_CrearCuenta.AutoSize = true;
            this.lblFechaNacimiento_CrearCuenta.Location = new System.Drawing.Point(40, 394);
            this.lblFechaNacimiento_CrearCuenta.Name = "lblFechaNacimiento_CrearCuenta";
            this.lblFechaNacimiento_CrearCuenta.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento_CrearCuenta.TabIndex = 26;
            this.lblFechaNacimiento_CrearCuenta.Text = "Fecha de Nacimiento";
            // 
            // monthCalendarCrearCuenta
            // 
            this.monthCalendarCrearCuenta.Location = new System.Drawing.Point(41, 416);
            this.monthCalendarCrearCuenta.Name = "monthCalendarCrearCuenta";
            this.monthCalendarCrearCuenta.TabIndex = 27;
            // 
            // lblCoberturaMedica_CrearUsuario
            // 
            this.lblCoberturaMedica_CrearUsuario.AutoSize = true;
            this.lblCoberturaMedica_CrearUsuario.Location = new System.Drawing.Point(420, 394);
            this.lblCoberturaMedica_CrearUsuario.Name = "lblCoberturaMedica_CrearUsuario";
            this.lblCoberturaMedica_CrearUsuario.Size = new System.Drawing.Size(91, 13);
            this.lblCoberturaMedica_CrearUsuario.TabIndex = 28;
            this.lblCoberturaMedica_CrearUsuario.Text = "Cobertura Medica";
            // 
            // lblImagen_CrearCuenta
            // 
            this.lblImagen_CrearCuenta.AutoSize = true;
            this.lblImagen_CrearCuenta.Location = new System.Drawing.Point(465, 14);
            this.lblImagen_CrearCuenta.Name = "lblImagen_CrearCuenta";
            this.lblImagen_CrearCuenta.Size = new System.Drawing.Size(42, 13);
            this.lblImagen_CrearCuenta.TabIndex = 29;
            this.lblImagen_CrearCuenta.Text = "Imagen";
            // 
            // btnCrear_CrearCuenta
            // 
            this.btnCrear_CrearCuenta.Location = new System.Drawing.Point(44, 601);
            this.btnCrear_CrearCuenta.Name = "btnCrear_CrearCuenta";
            this.btnCrear_CrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCrear_CrearCuenta.TabIndex = 31;
            this.btnCrear_CrearCuenta.Text = "Crear";
            this.btnCrear_CrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrear_CrearCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar_CrearCuenta
            // 
            this.btnCancelar_CrearCuenta.Location = new System.Drawing.Point(126, 601);
            this.btnCancelar_CrearCuenta.Name = "btnCancelar_CrearCuenta";
            this.btnCancelar_CrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_CrearCuenta.TabIndex = 32;
            this.btnCancelar_CrearCuenta.Text = "Cancelar";
            this.btnCancelar_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar_CrearCuenta
            // 
            this.btnLimpiar_CrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar_CrearCuenta.Location = new System.Drawing.Point(207, 601);
            this.btnLimpiar_CrearCuenta.Name = "btnLimpiar_CrearCuenta";
            this.btnLimpiar_CrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar_CrearCuenta.TabIndex = 33;
            this.btnLimpiar_CrearCuenta.Text = "Limpiar";
            this.btnLimpiar_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // comboBoxCoberturaMedica_CrearCuenta
            // 
            this.comboBoxCoberturaMedica_CrearCuenta.FormattingEnabled = true;
            this.comboBoxCoberturaMedica_CrearCuenta.Items.AddRange(new object[] {
            "DNI",
            "Cédula de Ciudadania"});
            this.comboBoxCoberturaMedica_CrearCuenta.Location = new System.Drawing.Point(423, 410);
            this.comboBoxCoberturaMedica_CrearCuenta.Name = "comboBoxCoberturaMedica_CrearCuenta";
            this.comboBoxCoberturaMedica_CrearCuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCoberturaMedica_CrearCuenta.TabIndex = 34;
            // 
            // pictureBoxImagen_CrearCuenta
            // 
            //this.pictureBoxImagen_CrearCuenta.Image = global::Cova.UI.Properties.Resources.Imagen;
            this.pictureBoxImagen_CrearCuenta.Location = new System.Drawing.Point(468, 30);
            this.pictureBoxImagen_CrearCuenta.Name = "pictureBoxImagen_CrearCuenta";
            this.pictureBoxImagen_CrearCuenta.Size = new System.Drawing.Size(159, 145);
            this.pictureBoxImagen_CrearCuenta.TabIndex = 30;
            this.pictureBoxImagen_CrearCuenta.TabStop = false;
            // 
            // textBoxClave_CrearCuenta
            // 
            this.textBoxClave_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxClave_CrearCuenta.Location = new System.Drawing.Point(271, 106);
            this.textBoxClave_CrearCuenta.Name = "textBoxClave_CrearCuenta";
            this.textBoxClave_CrearCuenta.Size = new System.Drawing.Size(123, 20);
            this.textBoxClave_CrearCuenta.TabIndex = 69;
            // 
            // lblClave_CrearCuenta
            // 
            this.lblClave_CrearCuenta.AutoSize = true;
            this.lblClave_CrearCuenta.Location = new System.Drawing.Point(268, 89);
            this.lblClave_CrearCuenta.Name = "lblClave_CrearCuenta";
            this.lblClave_CrearCuenta.Size = new System.Drawing.Size(34, 13);
            this.lblClave_CrearCuenta.TabIndex = 68;
            this.lblClave_CrearCuenta.Text = "Clave";
            // 
            // CrearCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.textBoxClave_CrearCuenta);
            this.Controls.Add(this.lblClave_CrearCuenta);
            this.Controls.Add(this.comboBoxCoberturaMedica_CrearCuenta);
            this.Controls.Add(this.btnLimpiar_CrearCuenta);
            this.Controls.Add(this.btnCancelar_CrearCuenta);
            this.Controls.Add(this.btnCrear_CrearCuenta);
            this.Controls.Add(this.pictureBoxImagen_CrearCuenta);
            this.Controls.Add(this.lblImagen_CrearCuenta);
            this.Controls.Add(this.lblCoberturaMedica_CrearUsuario);
            this.Controls.Add(this.monthCalendarCrearCuenta);
            this.Controls.Add(this.lblFechaNacimiento_CrearCuenta);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBoxDireccion_CrearCuenta);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblCiudad_CrearUsuario);
            this.Controls.Add(this.lblEspecialidad_CrearUsuario);
            this.Controls.Add(this.textBoxTelefono_CrearCuenta);
            this.Controls.Add(this.lblTelefono_CrearCuenta);
            this.Controls.Add(this.textBoxEstadoCivil_CrearCuenta);
            this.Controls.Add(this.lblEstadoCivil_CrearCuenta);
            this.Controls.Add(this.radioButtonFemenino_CrearCuenta);
            this.Controls.Add(this.radioButtonMasculino_CrearCuenta);
            this.Controls.Add(this.lblSexoCrearCuenta);
            this.Controls.Add(this.textBoxApellidoCrearCuenta);
            this.Controls.Add(this.lbl_ApellidoCrearCuenta);
            this.Controls.Add(this.txtBox_CrearCuentaNombre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNombreCrearCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearCuentaForm";
            this.Text = "Crear Cuenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen_CrearCuenta)).EndInit();
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
        private System.Windows.Forms.Label lblNombreCrearCuenta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBox_CrearCuentaNombre;
        private System.Windows.Forms.TextBox textBoxApellidoCrearCuenta;
        private System.Windows.Forms.Label lbl_ApellidoCrearCuenta;
        private System.Windows.Forms.Label lblSexoCrearCuenta;
        private System.Windows.Forms.RadioButton radioButtonMasculino_CrearCuenta;
        private System.Windows.Forms.RadioButton radioButtonFemenino_CrearCuenta;
        private System.Windows.Forms.Label lblEstadoCivil_CrearCuenta;
        private System.Windows.Forms.TextBox textBoxEstadoCivil_CrearCuenta;
        private System.Windows.Forms.TextBox textBoxTelefono_CrearCuenta;
        private System.Windows.Forms.Label lblTelefono_CrearCuenta;
        private System.Windows.Forms.Label lblEspecialidad_CrearUsuario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCiudad_CrearUsuario;
        private System.Windows.Forms.TextBox textBoxDireccion_CrearCuenta;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblFechaNacimiento_CrearCuenta;
        private System.Windows.Forms.MonthCalendar monthCalendarCrearCuenta;
        private System.Windows.Forms.Label lblCoberturaMedica_CrearUsuario;
        private System.Windows.Forms.Label lblImagen_CrearCuenta;
        private System.Windows.Forms.PictureBox pictureBoxImagen_CrearCuenta;
        private System.Windows.Forms.Button btnCrear_CrearCuenta;
        private System.Windows.Forms.Button btnCancelar_CrearCuenta;
        private System.Windows.Forms.Button btnLimpiar_CrearCuenta;
        private System.Windows.Forms.ComboBox comboBoxCoberturaMedica_CrearCuenta;
        private System.Windows.Forms.TextBox textBoxClave_CrearCuenta;
        private System.Windows.Forms.Label lblClave_CrearCuenta;
    }
}