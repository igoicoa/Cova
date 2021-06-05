namespace Cova.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeVacunaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeTurnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verCalendarioDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTurnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarTurnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCoberturaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCoberturaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCoberturaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarRecetaCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRecetaCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRecetaCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecetasCertificadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquerarPaswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarCuentaToolStripMenuItem,
            this.administrarVacunasToolStripMenuItem,
            this.administrarTurnosToolStripMenuItem,
            this.administrarCoberturaMedicaToolStripMenuItem,
            this.administrarHistoriaClinicaToolStripMenuItem,
            this.administrarRecetaCertificadoToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // administrarCuentaToolStripMenuItem
            // 
            this.administrarCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaToolStripMenuItem,
            this.modificarCuentaToolStripMenuItem,
            this.verUsuariosToolStripMenuItem});
            this.administrarCuentaToolStripMenuItem.Name = "administrarCuentaToolStripMenuItem";
            this.administrarCuentaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarCuentaToolStripMenuItem.Text = "Administrar Cuenta";
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearCuentaToolStripMenuItem.Text = "Crear Cuena";
            // 
            // modificarCuentaToolStripMenuItem
            // 
            this.modificarCuentaToolStripMenuItem.Name = "modificarCuentaToolStripMenuItem";
            this.modificarCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modificarCuentaToolStripMenuItem.Text = "Modificar Cuenta";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            // 
            // administrarVacunasToolStripMenuItem
            // 
            this.administrarVacunasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioDeVacunaciónToolStripMenuItem,
            this.crearVacunasToolStripMenuItem,
            this.modificarVacunasToolStripMenuItem,
            this.verVacunasToolStripMenuItem});
            this.administrarVacunasToolStripMenuItem.Name = "administrarVacunasToolStripMenuItem";
            this.administrarVacunasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarVacunasToolStripMenuItem.Text = "Administrar Vacunas";
            // 
            // calendarioDeVacunaciónToolStripMenuItem
            // 
            this.calendarioDeVacunaciónToolStripMenuItem.Name = "calendarioDeVacunaciónToolStripMenuItem";
            this.calendarioDeVacunaciónToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calendarioDeVacunaciónToolStripMenuItem.Text = "Calendario de Vacunación";
            // 
            // crearVacunasToolStripMenuItem
            // 
            this.crearVacunasToolStripMenuItem.Name = "crearVacunasToolStripMenuItem";
            this.crearVacunasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.crearVacunasToolStripMenuItem.Text = "Crear Vacunas";
            // 
            // modificarVacunasToolStripMenuItem
            // 
            this.modificarVacunasToolStripMenuItem.Name = "modificarVacunasToolStripMenuItem";
            this.modificarVacunasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.modificarVacunasToolStripMenuItem.Text = "Modificar Vacunas";
            // 
            // verVacunasToolStripMenuItem
            // 
            this.verVacunasToolStripMenuItem.Name = "verVacunasToolStripMenuItem";
            this.verVacunasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verVacunasToolStripMenuItem.Text = "Ver Vacunas";
            // 
            // administrarTurnosToolStripMenuItem
            // 
            this.administrarTurnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioDeTurnosToolStripMenuItem1,
            this.registrarTurnoToolStripMenuItem1,
            this.cancelarTurnoToolStripMenuItem1,
            this.verMisTurnosToolStripMenuItem});
            this.administrarTurnosToolStripMenuItem.Name = "administrarTurnosToolStripMenuItem";
            this.administrarTurnosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarTurnosToolStripMenuItem.Text = "Administrar Turnos";
            // 
            // calendarioDeTurnosToolStripMenuItem1
            // 
            this.calendarioDeTurnosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCalendarioDePacientesToolStripMenuItem});
            this.calendarioDeTurnosToolStripMenuItem1.Name = "calendarioDeTurnosToolStripMenuItem1";
            this.calendarioDeTurnosToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.calendarioDeTurnosToolStripMenuItem1.Text = "Calendario de Turnos";
            // 
            // verCalendarioDePacientesToolStripMenuItem
            // 
            this.verCalendarioDePacientesToolStripMenuItem.Name = "verCalendarioDePacientesToolStripMenuItem";
            this.verCalendarioDePacientesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.verCalendarioDePacientesToolStripMenuItem.Text = "Ver Calendario de Mis Pacientes";
            // 
            // registrarTurnoToolStripMenuItem1
            // 
            this.registrarTurnoToolStripMenuItem1.Name = "registrarTurnoToolStripMenuItem1";
            this.registrarTurnoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.registrarTurnoToolStripMenuItem1.Text = "Registrar Turnos";
            // 
            // cancelarTurnoToolStripMenuItem1
            // 
            this.cancelarTurnoToolStripMenuItem1.Name = "cancelarTurnoToolStripMenuItem1";
            this.cancelarTurnoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.cancelarTurnoToolStripMenuItem1.Text = "Cancelar Turnos";
            // 
            // verMisTurnosToolStripMenuItem
            // 
            this.verMisTurnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeTurnosToolStripMenuItem});
            this.verMisTurnosToolStripMenuItem.Name = "verMisTurnosToolStripMenuItem";
            this.verMisTurnosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verMisTurnosToolStripMenuItem.Text = "Ver Mis Turnos";
            // 
            // historialDeTurnosToolStripMenuItem
            // 
            this.historialDeTurnosToolStripMenuItem.Name = "historialDeTurnosToolStripMenuItem";
            this.historialDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.historialDeTurnosToolStripMenuItem.Text = "Historial de Turnos";
            // 
            // administrarCoberturaMedicaToolStripMenuItem
            // 
            this.administrarCoberturaMedicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCoberturaMedicaToolStripMenuItem,
            this.modificarCoberturaMedicaToolStripMenuItem});
            this.administrarCoberturaMedicaToolStripMenuItem.Name = "administrarCoberturaMedicaToolStripMenuItem";
            this.administrarCoberturaMedicaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarCoberturaMedicaToolStripMenuItem.Text = "Administrar Cobertura Medica";
            // 
            // crearCoberturaMedicaToolStripMenuItem
            // 
            this.crearCoberturaMedicaToolStripMenuItem.Name = "crearCoberturaMedicaToolStripMenuItem";
            this.crearCoberturaMedicaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.crearCoberturaMedicaToolStripMenuItem.Text = "Crear Cobertura Medica";
            // 
            // modificarCoberturaMedicaToolStripMenuItem
            // 
            this.modificarCoberturaMedicaToolStripMenuItem.Name = "modificarCoberturaMedicaToolStripMenuItem";
            this.modificarCoberturaMedicaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.modificarCoberturaMedicaToolStripMenuItem.Text = "Modificar Cobertura Medica";
            // 
            // administrarHistoriaClinicaToolStripMenuItem
            // 
            this.administrarHistoriaClinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearHistoriaClinicaToolStripMenuItem,
            this.modificarHistoriaClinicaToolStripMenuItem,
            this.verHistoriaClinicaToolStripMenuItem});
            this.administrarHistoriaClinicaToolStripMenuItem.Name = "administrarHistoriaClinicaToolStripMenuItem";
            this.administrarHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarHistoriaClinicaToolStripMenuItem.Text = "Administrar Historia Clinica";
            // 
            // crearHistoriaClinicaToolStripMenuItem
            // 
            this.crearHistoriaClinicaToolStripMenuItem.Name = "crearHistoriaClinicaToolStripMenuItem";
            this.crearHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.crearHistoriaClinicaToolStripMenuItem.Text = "Crear Historia Clinica";
            // 
            // modificarHistoriaClinicaToolStripMenuItem
            // 
            this.modificarHistoriaClinicaToolStripMenuItem.Name = "modificarHistoriaClinicaToolStripMenuItem";
            this.modificarHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.modificarHistoriaClinicaToolStripMenuItem.Text = "Modificar Historia Clinica";
            // 
            // verHistoriaClinicaToolStripMenuItem
            // 
            this.verHistoriaClinicaToolStripMenuItem.Name = "verHistoriaClinicaToolStripMenuItem";
            this.verHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.verHistoriaClinicaToolStripMenuItem.Text = "Ver Historia Clinica";
            // 
            // administrarRecetaCertificadoToolStripMenuItem
            // 
            this.administrarRecetaCertificadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRecetaCertificadoToolStripMenuItem,
            this.modificarRecetaCertificadoToolStripMenuItem,
            this.verRecetasCertificadosToolStripMenuItem});
            this.administrarRecetaCertificadoToolStripMenuItem.Name = "administrarRecetaCertificadoToolStripMenuItem";
            this.administrarRecetaCertificadoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarRecetaCertificadoToolStripMenuItem.Text = "Administrar Receta/Certificado";
            // 
            // crearRecetaCertificadoToolStripMenuItem
            // 
            this.crearRecetaCertificadoToolStripMenuItem.Name = "crearRecetaCertificadoToolStripMenuItem";
            this.crearRecetaCertificadoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.crearRecetaCertificadoToolStripMenuItem.Text = "Crear Receta/Certificado";
            // 
            // modificarRecetaCertificadoToolStripMenuItem
            // 
            this.modificarRecetaCertificadoToolStripMenuItem.Name = "modificarRecetaCertificadoToolStripMenuItem";
            this.modificarRecetaCertificadoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.modificarRecetaCertificadoToolStripMenuItem.Text = "Modificar Receta/Certificado";
            // 
            // verRecetasCertificadosToolStripMenuItem
            // 
            this.verRecetasCertificadosToolStripMenuItem.Name = "verRecetasCertificadosToolStripMenuItem";
            this.verRecetasCertificadosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.verRecetasCertificadosToolStripMenuItem.Text = "Ver Recetas/Certificados";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarBackupToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.realizarRestoreToolStripMenuItem,
            this.bloquerarPaswordToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem,
            this.misDatosToolStripMenuItem,
            this.permisosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // realizarBackupToolStripMenuItem
            // 
            this.realizarBackupToolStripMenuItem.Name = "realizarBackupToolStripMenuItem";
            this.realizarBackupToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.realizarBackupToolStripMenuItem.Text = "Realizar Backup";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            // 
            // realizarRestoreToolStripMenuItem
            // 
            this.realizarRestoreToolStripMenuItem.Name = "realizarRestoreToolStripMenuItem";
            this.realizarRestoreToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.realizarRestoreToolStripMenuItem.Text = "Realizar Restore";
            // 
            // bloquerarPaswordToolStripMenuItem
            // 
            this.bloquerarPaswordToolStripMenuItem.Name = "bloquerarPaswordToolStripMenuItem";
            this.bloquerarPaswordToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bloquerarPaswordToolStripMenuItem.Text = "Bloquerar Contraseña";
            this.bloquerarPaswordToolStripMenuItem.Click += new System.EventHandler(this.bloquerarPaswordToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            // 
            // misDatosToolStripMenuItem
            // 
            this.misDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarDatosToolStripMenuItem});
            this.misDatosToolStripMenuItem.Name = "misDatosToolStripMenuItem";
            this.misDatosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.misDatosToolStripMenuItem.Text = "Mis Datos";
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Datos";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPermisosToolStripMenuItem,
            this.modificarPermisosToolStripMenuItem,
            this.asignarPermisosToolStripMenuItem});
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactoToolStripMenuItem,
            this.novedadesToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.contactoToolStripMenuItem.Text = "Contacto";
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // crearPermisosToolStripMenuItem
            // 
            this.crearPermisosToolStripMenuItem.Name = "crearPermisosToolStripMenuItem";
            this.crearPermisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearPermisosToolStripMenuItem.Text = "Crear Permisos";
            // 
            // modificarPermisosToolStripMenuItem
            // 
            this.modificarPermisosToolStripMenuItem.Name = "modificarPermisosToolStripMenuItem";
            this.modificarPermisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarPermisosToolStripMenuItem.Text = "Modificar Permisos";
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cova";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarRestoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquerarPaswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeVacunaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeTurnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verCalendarioDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTurnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarTurnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verMisTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCoberturaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCoberturaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCoberturaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarRecetaCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRecetaCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRecetaCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecetasCertificadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
    }
}

