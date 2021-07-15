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
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.lblCiudad_CrearUsuario = new System.Windows.Forms.Label();
            this.textBoxCalle_CrearCuenta = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento_CrearCuenta = new System.Windows.Forms.Label();
            this.monthCalendarCrearCuenta = new System.Windows.Forms.MonthCalendar();
            this.lblCoberturaMedica_CrearUsuario = new System.Windows.Forms.Label();
            this.lblImagen_CrearCuenta = new System.Windows.Forms.Label();
            this.btnCrear_CrearCuenta = new System.Windows.Forms.Button();
            this.btnCancelar_CrearCuenta = new System.Windows.Forms.Button();
            this.btnLimpiar_CrearCuenta = new System.Windows.Forms.Button();
            this.cmb_coberturaMedica = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagen_CrearCuenta = new System.Windows.Forms.PictureBox();
            this.gb_paciente = new System.Windows.Forms.GroupBox();
            this.chk_particular = new System.Windows.Forms.CheckBox();
            this.dtp_fechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaVencimiento = new System.Windows.Forms.Label();
            this.txt_numeroAfiliado = new System.Windows.Forms.TextBox();
            this.lbl_numeroAfiliado = new System.Windows.Forms.Label();
            this.cmb_Plan = new System.Windows.Forms.ComboBox();
            this.lbl_Plan = new System.Windows.Forms.Label();
            this.gb_Profesional = new System.Windows.Forms.GroupBox();
            this.cmb_especialidad = new System.Windows.Forms.ComboBox();
            this.lbl_especialidad = new System.Windows.Forms.Label();
            this.txt_matriculaProvincial = new System.Windows.Forms.TextBox();
            this.lbl_matriculaProvincial = new System.Windows.Forms.Label();
            this.txt_matriculaNacional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_calleNumero = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClave_CrearCuenta = new System.Windows.Forms.Label();
            this.textBoxClave_CrearCuenta = new System.Windows.Forms.TextBox();
            this.txt_documentoNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen_CrearCuenta)).BeginInit();
            this.gb_paciente.SuspendLayout();
            this.gb_Profesional.SuspendLayout();
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
            this.rb_administrador.CheckedChanged += new System.EventHandler(this.rb_administrador_CheckedChanged);
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
            this.rb_enfermero.CheckedChanged += new System.EventHandler(this.rb_enfermero_CheckedChanged);
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
            this.rb_medico.CheckedChanged += new System.EventHandler(this.rb_medico_CheckedChanged);
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
            this.rb_paciente.CheckedChanged += new System.EventHandler(this.rb_paciente_CheckedChanged);
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
            this.lblNombreCrearCuenta.Location = new System.Drawing.Point(43, 200);
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
            this.txtBox_CrearCuentaNombre.Location = new System.Drawing.Point(43, 217);
            this.txtBox_CrearCuentaNombre.Name = "txtBox_CrearCuentaNombre";
            this.txtBox_CrearCuentaNombre.Size = new System.Drawing.Size(363, 20);
            this.txtBox_CrearCuentaNombre.TabIndex = 9;
            // 
            // textBoxApellidoCrearCuenta
            // 
            this.textBoxApellidoCrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxApellidoCrearCuenta.Location = new System.Drawing.Point(43, 267);
            this.textBoxApellidoCrearCuenta.Name = "textBoxApellidoCrearCuenta";
            this.textBoxApellidoCrearCuenta.Size = new System.Drawing.Size(363, 20);
            this.textBoxApellidoCrearCuenta.TabIndex = 11;
            // 
            // lbl_ApellidoCrearCuenta
            // 
            this.lbl_ApellidoCrearCuenta.AutoSize = true;
            this.lbl_ApellidoCrearCuenta.Location = new System.Drawing.Point(43, 250);
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
            this.lblSexoCrearCuenta.Location = new System.Drawing.Point(43, 301);
            this.lblSexoCrearCuenta.Name = "lblSexoCrearCuenta";
            this.lblSexoCrearCuenta.Size = new System.Drawing.Size(31, 13);
            this.lblSexoCrearCuenta.TabIndex = 12;
            this.lblSexoCrearCuenta.Text = "Sexo";
            this.lblSexoCrearCuenta.Click += new System.EventHandler(this.lblSexoCrearCuenta_Click);
            // 
            // radioButtonMasculino_CrearCuenta
            // 
            this.radioButtonMasculino_CrearCuenta.AutoSize = true;
            this.radioButtonMasculino_CrearCuenta.Location = new System.Drawing.Point(46, 317);
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
            this.radioButtonFemenino_CrearCuenta.Location = new System.Drawing.Point(125, 317);
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
            this.lblEstadoCivil_CrearCuenta.Location = new System.Drawing.Point(481, 250);
            this.lblEstadoCivil_CrearCuenta.Name = "lblEstadoCivil_CrearCuenta";
            this.lblEstadoCivil_CrearCuenta.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil_CrearCuenta.TabIndex = 15;
            this.lblEstadoCivil_CrearCuenta.Text = "Estado Civil";
            // 
            // textBoxEstadoCivil_CrearCuenta
            // 
            this.textBoxEstadoCivil_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxEstadoCivil_CrearCuenta.Location = new System.Drawing.Point(484, 264);
            this.textBoxEstadoCivil_CrearCuenta.Name = "textBoxEstadoCivil_CrearCuenta";
            this.textBoxEstadoCivil_CrearCuenta.Size = new System.Drawing.Size(192, 20);
            this.textBoxEstadoCivil_CrearCuenta.TabIndex = 16;
            // 
            // textBoxTelefono_CrearCuenta
            // 
            this.textBoxTelefono_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTelefono_CrearCuenta.Location = new System.Drawing.Point(202, 168);
            this.textBoxTelefono_CrearCuenta.Name = "textBoxTelefono_CrearCuenta";
            this.textBoxTelefono_CrearCuenta.Size = new System.Drawing.Size(181, 20);
            this.textBoxTelefono_CrearCuenta.TabIndex = 18;
            // 
            // lblTelefono_CrearCuenta
            // 
            this.lblTelefono_CrearCuenta.AutoEllipsis = true;
            this.lblTelefono_CrearCuenta.AutoSize = true;
            this.lblTelefono_CrearCuenta.Location = new System.Drawing.Point(199, 155);
            this.lblTelefono_CrearCuenta.Name = "lblTelefono_CrearCuenta";
            this.lblTelefono_CrearCuenta.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono_CrearCuenta.TabIndex = 17;
            this.lblTelefono_CrearCuenta.Text = "Telefono";
            // 
            // txt_provincia
            // 
            this.txt_provincia.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_provincia.Location = new System.Drawing.Point(241, 412);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(187, 20);
            this.txt_provincia.TabIndex = 22;
            // 
            // lblCiudad_CrearUsuario
            // 
            this.lblCiudad_CrearUsuario.AutoEllipsis = true;
            this.lblCiudad_CrearUsuario.AutoSize = true;
            this.lblCiudad_CrearUsuario.Location = new System.Drawing.Point(238, 399);
            this.lblCiudad_CrearUsuario.Name = "lblCiudad_CrearUsuario";
            this.lblCiudad_CrearUsuario.Size = new System.Drawing.Size(51, 13);
            this.lblCiudad_CrearUsuario.TabIndex = 21;
            this.lblCiudad_CrearUsuario.Text = "Provincia";
            // 
            // textBoxCalle_CrearCuenta
            // 
            this.textBoxCalle_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxCalle_CrearCuenta.Location = new System.Drawing.Point(44, 365);
            this.textBoxCalle_CrearCuenta.Name = "textBoxCalle_CrearCuenta";
            this.textBoxCalle_CrearCuenta.Size = new System.Drawing.Size(181, 20);
            this.textBoxCalle_CrearCuenta.TabIndex = 24;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoEllipsis = true;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(41, 352);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(30, 13);
            this.lblDireccion.TabIndex = 23;
            this.lblDireccion.Text = "Calle";
            // 
            // lblFechaNacimiento_CrearCuenta
            // 
            this.lblFechaNacimiento_CrearCuenta.AutoSize = true;
            this.lblFechaNacimiento_CrearCuenta.Location = new System.Drawing.Point(40, 456);
            this.lblFechaNacimiento_CrearCuenta.Name = "lblFechaNacimiento_CrearCuenta";
            this.lblFechaNacimiento_CrearCuenta.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento_CrearCuenta.TabIndex = 26;
            this.lblFechaNacimiento_CrearCuenta.Text = "Fecha de Nacimiento";
            // 
            // monthCalendarCrearCuenta
            // 
            this.monthCalendarCrearCuenta.Location = new System.Drawing.Point(41, 478);
            this.monthCalendarCrearCuenta.Name = "monthCalendarCrearCuenta";
            this.monthCalendarCrearCuenta.TabIndex = 27;
            // 
            // lblCoberturaMedica_CrearUsuario
            // 
            this.lblCoberturaMedica_CrearUsuario.AutoSize = true;
            this.lblCoberturaMedica_CrearUsuario.Location = new System.Drawing.Point(10, 62);
            this.lblCoberturaMedica_CrearUsuario.Name = "lblCoberturaMedica_CrearUsuario";
            this.lblCoberturaMedica_CrearUsuario.Size = new System.Drawing.Size(91, 13);
            this.lblCoberturaMedica_CrearUsuario.TabIndex = 28;
            this.lblCoberturaMedica_CrearUsuario.Text = "Cobertura Medica";
            // 
            // lblImagen_CrearCuenta
            // 
            this.lblImagen_CrearCuenta.AutoSize = true;
            this.lblImagen_CrearCuenta.Location = new System.Drawing.Point(484, 14);
            this.lblImagen_CrearCuenta.Name = "lblImagen_CrearCuenta";
            this.lblImagen_CrearCuenta.Size = new System.Drawing.Size(42, 13);
            this.lblImagen_CrearCuenta.TabIndex = 29;
            this.lblImagen_CrearCuenta.Text = "Imagen";
            // 
            // btnCrear_CrearCuenta
            // 
            this.btnCrear_CrearCuenta.Location = new System.Drawing.Point(333, 605);
            this.btnCrear_CrearCuenta.Name = "btnCrear_CrearCuenta";
            this.btnCrear_CrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCrear_CrearCuenta.TabIndex = 31;
            this.btnCrear_CrearCuenta.Text = "Crear";
            this.btnCrear_CrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrear_CrearCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar_CrearCuenta
            // 
            this.btnCancelar_CrearCuenta.Location = new System.Drawing.Point(418, 605);
            this.btnCancelar_CrearCuenta.Name = "btnCancelar_CrearCuenta";
            this.btnCancelar_CrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_CrearCuenta.TabIndex = 32;
            this.btnCancelar_CrearCuenta.Text = "Cancelar";
            this.btnCancelar_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar_CrearCuenta
            // 
            this.btnLimpiar_CrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar_CrearCuenta.Location = new System.Drawing.Point(506, 605);
            this.btnLimpiar_CrearCuenta.Name = "btnLimpiar_CrearCuenta";
            this.btnLimpiar_CrearCuenta.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar_CrearCuenta.TabIndex = 33;
            this.btnLimpiar_CrearCuenta.Text = "Limpiar";
            this.btnLimpiar_CrearCuenta.UseVisualStyleBackColor = true;
            // 
            // cmb_coberturaMedica
            // 
            this.cmb_coberturaMedica.FormattingEnabled = true;
            this.cmb_coberturaMedica.Items.AddRange(new object[] {
            "DNI",
            "Cédula de Ciudadania"});
            this.cmb_coberturaMedica.Location = new System.Drawing.Point(10, 77);
            this.cmb_coberturaMedica.Name = "cmb_coberturaMedica";
            this.cmb_coberturaMedica.Size = new System.Drawing.Size(143, 21);
            this.cmb_coberturaMedica.TabIndex = 34;
            this.cmb_coberturaMedica.SelectedIndexChanged += new System.EventHandler(this.cmb_coberturaMedica_SelectedIndexChanged);
            // 
            // pictureBoxImagen_CrearCuenta
            // 
            this.pictureBoxImagen_CrearCuenta.Location = new System.Drawing.Point(487, 30);
            this.pictureBoxImagen_CrearCuenta.Name = "pictureBoxImagen_CrearCuenta";
            this.pictureBoxImagen_CrearCuenta.Size = new System.Drawing.Size(159, 145);
            this.pictureBoxImagen_CrearCuenta.TabIndex = 30;
            this.pictureBoxImagen_CrearCuenta.TabStop = false;
            // 
            // gb_paciente
            // 
            this.gb_paciente.Controls.Add(this.chk_particular);
            this.gb_paciente.Controls.Add(this.dtp_fechaVencimiento);
            this.gb_paciente.Controls.Add(this.lbl_FechaVencimiento);
            this.gb_paciente.Controls.Add(this.txt_numeroAfiliado);
            this.gb_paciente.Controls.Add(this.lbl_numeroAfiliado);
            this.gb_paciente.Controls.Add(this.cmb_Plan);
            this.gb_paciente.Controls.Add(this.lbl_Plan);
            this.gb_paciente.Controls.Add(this.cmb_coberturaMedica);
            this.gb_paciente.Controls.Add(this.lblCoberturaMedica_CrearUsuario);
            this.gb_paciente.Location = new System.Drawing.Point(477, 365);
            this.gb_paciente.Name = "gb_paciente";
            this.gb_paciente.Size = new System.Drawing.Size(355, 180);
            this.gb_paciente.TabIndex = 70;
            this.gb_paciente.TabStop = false;
            this.gb_paciente.Text = "Paciente";
            // 
            // chk_particular
            // 
            this.chk_particular.AutoSize = true;
            this.chk_particular.Location = new System.Drawing.Point(13, 29);
            this.chk_particular.Name = "chk_particular";
            this.chk_particular.Size = new System.Drawing.Size(70, 17);
            this.chk_particular.TabIndex = 80;
            this.chk_particular.Text = "Particular";
            this.chk_particular.UseVisualStyleBackColor = true;
            this.chk_particular.CheckedChanged += new System.EventHandler(this.chk_particular_CheckedChanged);
            // 
            // dtp_fechaVencimiento
            // 
            this.dtp_fechaVencimiento.Location = new System.Drawing.Point(171, 126);
            this.dtp_fechaVencimiento.Name = "dtp_fechaVencimiento";
            this.dtp_fechaVencimiento.Size = new System.Drawing.Size(143, 20);
            this.dtp_fechaVencimiento.TabIndex = 79;
            // 
            // lbl_FechaVencimiento
            // 
            this.lbl_FechaVencimiento.AutoEllipsis = true;
            this.lbl_FechaVencimiento.AutoSize = true;
            this.lbl_FechaVencimiento.Location = new System.Drawing.Point(168, 107);
            this.lbl_FechaVencimiento.Name = "lbl_FechaVencimiento";
            this.lbl_FechaVencimiento.Size = new System.Drawing.Size(98, 13);
            this.lbl_FechaVencimiento.TabIndex = 78;
            this.lbl_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // txt_numeroAfiliado
            // 
            this.txt_numeroAfiliado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_numeroAfiliado.Location = new System.Drawing.Point(9, 126);
            this.txt_numeroAfiliado.Name = "txt_numeroAfiliado";
            this.txt_numeroAfiliado.Size = new System.Drawing.Size(144, 20);
            this.txt_numeroAfiliado.TabIndex = 77;
            // 
            // lbl_numeroAfiliado
            // 
            this.lbl_numeroAfiliado.AutoEllipsis = true;
            this.lbl_numeroAfiliado.AutoSize = true;
            this.lbl_numeroAfiliado.Location = new System.Drawing.Point(10, 107);
            this.lbl_numeroAfiliado.Name = "lbl_numeroAfiliado";
            this.lbl_numeroAfiliado.Size = new System.Drawing.Size(81, 13);
            this.lbl_numeroAfiliado.TabIndex = 76;
            this.lbl_numeroAfiliado.Text = "Numero Afiliado";
            // 
            // cmb_Plan
            // 
            this.cmb_Plan.FormattingEnabled = true;
            this.cmb_Plan.Location = new System.Drawing.Point(171, 77);
            this.cmb_Plan.Name = "cmb_Plan";
            this.cmb_Plan.Size = new System.Drawing.Size(143, 21);
            this.cmb_Plan.TabIndex = 36;
            // 
            // lbl_Plan
            // 
            this.lbl_Plan.AutoSize = true;
            this.lbl_Plan.Location = new System.Drawing.Point(168, 62);
            this.lbl_Plan.Name = "lbl_Plan";
            this.lbl_Plan.Size = new System.Drawing.Size(28, 13);
            this.lbl_Plan.TabIndex = 35;
            this.lbl_Plan.Text = "Plan";
            // 
            // gb_Profesional
            // 
            this.gb_Profesional.Controls.Add(this.cmb_especialidad);
            this.gb_Profesional.Controls.Add(this.lbl_especialidad);
            this.gb_Profesional.Controls.Add(this.txt_matriculaProvincial);
            this.gb_Profesional.Controls.Add(this.lbl_matriculaProvincial);
            this.gb_Profesional.Controls.Add(this.txt_matriculaNacional);
            this.gb_Profesional.Controls.Add(this.label1);
            this.gb_Profesional.Location = new System.Drawing.Point(477, 365);
            this.gb_Profesional.Name = "gb_Profesional";
            this.gb_Profesional.Size = new System.Drawing.Size(354, 189);
            this.gb_Profesional.TabIndex = 71;
            this.gb_Profesional.TabStop = false;
            this.gb_Profesional.Text = "Profesional";
            // 
            // cmb_especialidad
            // 
            this.cmb_especialidad.FormattingEnabled = true;
            this.cmb_especialidad.Location = new System.Drawing.Point(24, 143);
            this.cmb_especialidad.Name = "cmb_especialidad";
            this.cmb_especialidad.Size = new System.Drawing.Size(187, 21);
            this.cmb_especialidad.TabIndex = 82;
            // 
            // lbl_especialidad
            // 
            this.lbl_especialidad.AutoSize = true;
            this.lbl_especialidad.Location = new System.Drawing.Point(24, 127);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(70, 13);
            this.lbl_especialidad.TabIndex = 75;
            this.lbl_especialidad.Text = "Especialidad:";
            // 
            // txt_matriculaProvincial
            // 
            this.txt_matriculaProvincial.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_matriculaProvincial.Location = new System.Drawing.Point(24, 94);
            this.txt_matriculaProvincial.Name = "txt_matriculaProvincial";
            this.txt_matriculaProvincial.Size = new System.Drawing.Size(187, 20);
            this.txt_matriculaProvincial.TabIndex = 74;
            // 
            // lbl_matriculaProvincial
            // 
            this.lbl_matriculaProvincial.AutoSize = true;
            this.lbl_matriculaProvincial.Location = new System.Drawing.Point(24, 78);
            this.lbl_matriculaProvincial.Name = "lbl_matriculaProvincial";
            this.lbl_matriculaProvincial.Size = new System.Drawing.Size(102, 13);
            this.lbl_matriculaProvincial.TabIndex = 73;
            this.lbl_matriculaProvincial.Text = "Matricula Provincial:";
            // 
            // txt_matriculaNacional
            // 
            this.txt_matriculaNacional.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_matriculaNacional.Location = new System.Drawing.Point(24, 46);
            this.txt_matriculaNacional.Name = "txt_matriculaNacional";
            this.txt_matriculaNacional.Size = new System.Drawing.Size(187, 20);
            this.txt_matriculaNacional.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Matricula Nacional:";
            // 
            // txt_calleNumero
            // 
            this.txt_calleNumero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_calleNumero.Location = new System.Drawing.Point(237, 365);
            this.txt_calleNumero.Name = "txt_calleNumero";
            this.txt_calleNumero.Size = new System.Drawing.Size(102, 20);
            this.txt_calleNumero.TabIndex = 73;
            // 
            // Numero
            // 
            this.Numero.AutoEllipsis = true;
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(234, 352);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(44, 13);
            this.Numero.TabIndex = 72;
            this.Numero.Text = "Numero";
            // 
            // txt_localidad
            // 
            this.txt_localidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_localidad.Location = new System.Drawing.Point(46, 412);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(179, 20);
            this.txt_localidad.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Localidad";
            // 
            // lblClave_CrearCuenta
            // 
            this.lblClave_CrearCuenta.AutoSize = true;
            this.lblClave_CrearCuenta.Location = new System.Drawing.Point(41, 151);
            this.lblClave_CrearCuenta.Name = "lblClave_CrearCuenta";
            this.lblClave_CrearCuenta.Size = new System.Drawing.Size(34, 13);
            this.lblClave_CrearCuenta.TabIndex = 68;
            this.lblClave_CrearCuenta.Text = "Clave";
            // 
            // textBoxClave_CrearCuenta
            // 
            this.textBoxClave_CrearCuenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxClave_CrearCuenta.Location = new System.Drawing.Point(44, 168);
            this.textBoxClave_CrearCuenta.Name = "textBoxClave_CrearCuenta";
            this.textBoxClave_CrearCuenta.Size = new System.Drawing.Size(123, 20);
            this.textBoxClave_CrearCuenta.TabIndex = 69;
            // 
            // txt_documentoNumero
            // 
            this.txt_documentoNumero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_documentoNumero.Location = new System.Drawing.Point(197, 106);
            this.txt_documentoNumero.Name = "txt_documentoNumero";
            this.txt_documentoNumero.Size = new System.Drawing.Size(132, 20);
            this.txt_documentoNumero.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Numero documento";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Email.Location = new System.Drawing.Point(483, 216);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(193, 20);
            this.txt_Email.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Piso";
            // 
            // txt_piso
            // 
            this.txt_piso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_piso.Location = new System.Drawing.Point(358, 365);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(70, 20);
            this.txt_piso.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(41, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "Crear Cuentas";
            // 
            // CrearCuentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 658);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_documentoNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_localidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_calleNumero);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.gb_Profesional);
            this.Controls.Add(this.gb_paciente);
            this.Controls.Add(this.textBoxClave_CrearCuenta);
            this.Controls.Add(this.lblClave_CrearCuenta);
            this.Controls.Add(this.btnLimpiar_CrearCuenta);
            this.Controls.Add(this.btnCancelar_CrearCuenta);
            this.Controls.Add(this.btnCrear_CrearCuenta);
            this.Controls.Add(this.pictureBoxImagen_CrearCuenta);
            this.Controls.Add(this.lblImagen_CrearCuenta);
            this.Controls.Add(this.monthCalendarCrearCuenta);
            this.Controls.Add(this.lblFechaNacimiento_CrearCuenta);
            this.Controls.Add(this.textBoxCalle_CrearCuenta);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txt_provincia);
            this.Controls.Add(this.lblCiudad_CrearUsuario);
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
            this.gb_paciente.ResumeLayout(false);
            this.gb_paciente.PerformLayout();
            this.gb_Profesional.ResumeLayout(false);
            this.gb_Profesional.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.Label lblCiudad_CrearUsuario;
        private System.Windows.Forms.TextBox textBoxCalle_CrearCuenta;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaNacimiento_CrearCuenta;
        private System.Windows.Forms.MonthCalendar monthCalendarCrearCuenta;
        private System.Windows.Forms.Label lblCoberturaMedica_CrearUsuario;
        private System.Windows.Forms.Label lblImagen_CrearCuenta;
        private System.Windows.Forms.PictureBox pictureBoxImagen_CrearCuenta;
        private System.Windows.Forms.Button btnCrear_CrearCuenta;
        private System.Windows.Forms.Button btnCancelar_CrearCuenta;
        private System.Windows.Forms.Button btnLimpiar_CrearCuenta;
        private System.Windows.Forms.ComboBox cmb_coberturaMedica;
        private System.Windows.Forms.GroupBox gb_paciente;
        private System.Windows.Forms.GroupBox gb_Profesional;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.TextBox txt_matriculaProvincial;
        private System.Windows.Forms.Label lbl_matriculaProvincial;
        private System.Windows.Forms.TextBox txt_matriculaNacional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_calleNumero;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox txt_localidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Plan;
        private System.Windows.Forms.Label lbl_Plan;
        private System.Windows.Forms.Label lbl_FechaVencimiento;
        private System.Windows.Forms.TextBox txt_numeroAfiliado;
        private System.Windows.Forms.Label lbl_numeroAfiliado;
        private System.Windows.Forms.DateTimePicker dtp_fechaVencimiento;
        private System.Windows.Forms.CheckBox chk_particular;
        private System.Windows.Forms.Label lblClave_CrearCuenta;
        private System.Windows.Forms.TextBox textBoxClave_CrearCuenta;
        private System.Windows.Forms.TextBox txt_documentoNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.ComboBox cmb_especialidad;
        private System.Windows.Forms.Label label7;
    }
}