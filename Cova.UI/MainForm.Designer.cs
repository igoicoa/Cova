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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.aplicarVacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioDeTurnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTurnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarTurnoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCoberturaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCoberturaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCoberturaMedicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCoberturasMedicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistoriaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarRecetaCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRecetaCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRecetaCertificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRecetasCertificadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.inicioToolStripMenuItem.Tag = "menuinicio";
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Tag = "menuiniciologin";
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Tag = "menuiniciologout";
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
            this.administrarToolStripMenuItem.Tag = "menuadministrar";
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
            this.administrarCuentaToolStripMenuItem.Tag = "administrarcuenta";
            this.administrarCuentaToolStripMenuItem.Text = "Administrar Cuenta";
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearCuentaToolStripMenuItem.Tag = "Crearcuenta";
            this.crearCuentaToolStripMenuItem.Text = "Crear Cuenta";
            this.crearCuentaToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaToolStripMenuItem_Click);
            // 
            // modificarCuentaToolStripMenuItem
            // 
            this.modificarCuentaToolStripMenuItem.Name = "modificarCuentaToolStripMenuItem";
            this.modificarCuentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modificarCuentaToolStripMenuItem.Tag = "Modificarcuenta";
            this.modificarCuentaToolStripMenuItem.Text = "Modificar Cuenta";
            this.modificarCuentaToolStripMenuItem.Click += new System.EventHandler(this.modificarCuentaToolStripMenuItem_Click);
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verUsuariosToolStripMenuItem.Tag = "VerUsuarios";
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // administrarVacunasToolStripMenuItem
            // 
            this.administrarVacunasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioDeVacunaciónToolStripMenuItem,
            this.crearVacunasToolStripMenuItem,
            this.modificarVacunasToolStripMenuItem,
            this.verVacunasToolStripMenuItem,
            this.aplicarVacunaToolStripMenuItem});
            this.administrarVacunasToolStripMenuItem.Name = "administrarVacunasToolStripMenuItem";
            this.administrarVacunasToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarVacunasToolStripMenuItem.Tag = "AdministrarVacunas";
            this.administrarVacunasToolStripMenuItem.Text = "Administrar Vacunas";
            // 
            // calendarioDeVacunaciónToolStripMenuItem
            // 
            this.calendarioDeVacunaciónToolStripMenuItem.Name = "calendarioDeVacunaciónToolStripMenuItem";
            this.calendarioDeVacunaciónToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.calendarioDeVacunaciónToolStripMenuItem.Tag = "CalendariodeVacunacion";
            this.calendarioDeVacunaciónToolStripMenuItem.Text = "Calendario de Vacunación";
            this.calendarioDeVacunaciónToolStripMenuItem.Click += new System.EventHandler(this.calendarioDeVacunaciónToolStripMenuItem_Click);
            // 
            // crearVacunasToolStripMenuItem
            // 
            this.crearVacunasToolStripMenuItem.Name = "crearVacunasToolStripMenuItem";
            this.crearVacunasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.crearVacunasToolStripMenuItem.Tag = "CrearVacunas";
            this.crearVacunasToolStripMenuItem.Text = "Crear Vacunas";
            this.crearVacunasToolStripMenuItem.Click += new System.EventHandler(this.crearVacunasToolStripMenuItem_Click);
            // 
            // modificarVacunasToolStripMenuItem
            // 
            this.modificarVacunasToolStripMenuItem.Name = "modificarVacunasToolStripMenuItem";
            this.modificarVacunasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.modificarVacunasToolStripMenuItem.Tag = "ModificarVacunas";
            this.modificarVacunasToolStripMenuItem.Text = "Modificar Vacunas";
            this.modificarVacunasToolStripMenuItem.Click += new System.EventHandler(this.modificarVacunasToolStripMenuItem_Click);
            // 
            // verVacunasToolStripMenuItem
            // 
            this.verVacunasToolStripMenuItem.Name = "verVacunasToolStripMenuItem";
            this.verVacunasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verVacunasToolStripMenuItem.Tag = "VerVacunas";
            this.verVacunasToolStripMenuItem.Text = "Ver Vacunas";
            this.verVacunasToolStripMenuItem.Click += new System.EventHandler(this.verVacunasToolStripMenuItem_Click);
            // 
            // aplicarVacunaToolStripMenuItem
            // 
            this.aplicarVacunaToolStripMenuItem.Name = "aplicarVacunaToolStripMenuItem";
            this.aplicarVacunaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aplicarVacunaToolStripMenuItem.Tag = "AplicarVacunas";
            this.aplicarVacunaToolStripMenuItem.Text = "Aplicar Vacuna";
            this.aplicarVacunaToolStripMenuItem.Click += new System.EventHandler(this.aplicarVacunaToolStripMenuItem_Click);
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
            this.administrarTurnosToolStripMenuItem.Tag = "administrarturnos";
            this.administrarTurnosToolStripMenuItem.Text = "Administrar Turnos";
            // 
            // calendarioDeTurnosToolStripMenuItem1
            // 
            this.calendarioDeTurnosToolStripMenuItem1.Name = "calendarioDeTurnosToolStripMenuItem1";
            this.calendarioDeTurnosToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.calendarioDeTurnosToolStripMenuItem1.Tag = "CalendariodeTurnos";
            this.calendarioDeTurnosToolStripMenuItem1.Text = "Calendario de Turnos";
            // 
            // registrarTurnoToolStripMenuItem1
            // 
            this.registrarTurnoToolStripMenuItem1.Name = "registrarTurnoToolStripMenuItem1";
            this.registrarTurnoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.registrarTurnoToolStripMenuItem1.Text = "RegistrarTurnos";
            this.registrarTurnoToolStripMenuItem1.Click += new System.EventHandler(this.registrarTurnoToolStripMenuItem1_Click);
            // 
            // cancelarTurnoToolStripMenuItem1
            // 
            this.cancelarTurnoToolStripMenuItem1.Name = "cancelarTurnoToolStripMenuItem1";
            this.cancelarTurnoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.cancelarTurnoToolStripMenuItem1.Tag = "CancelarTurnos";
            this.cancelarTurnoToolStripMenuItem1.Text = "Cancelar Turnos";
            // 
            // verMisTurnosToolStripMenuItem
            // 
            this.verMisTurnosToolStripMenuItem.Name = "verMisTurnosToolStripMenuItem";
            this.verMisTurnosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verMisTurnosToolStripMenuItem.Tag = "VerMisturnos";
            this.verMisTurnosToolStripMenuItem.Text = "Ver Mis Turnos";
            // 
            // administrarCoberturaMedicaToolStripMenuItem
            // 
            this.administrarCoberturaMedicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCoberturaMedicaToolStripMenuItem,
            this.modificarCoberturaMedicaToolStripMenuItem,
            this.verCoberturasMedicasToolStripMenuItem});
            this.administrarCoberturaMedicaToolStripMenuItem.Name = "administrarCoberturaMedicaToolStripMenuItem";
            this.administrarCoberturaMedicaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarCoberturaMedicaToolStripMenuItem.Tag = "AdministrarCoberturaMedica";
            this.administrarCoberturaMedicaToolStripMenuItem.Text = "Administrar Cobertura Medica";
            // 
            // crearCoberturaMedicaToolStripMenuItem
            // 
            this.crearCoberturaMedicaToolStripMenuItem.Name = "crearCoberturaMedicaToolStripMenuItem";
            this.crearCoberturaMedicaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.crearCoberturaMedicaToolStripMenuItem.Tag = "CrearCoberturaMedica";
            this.crearCoberturaMedicaToolStripMenuItem.Text = "Crear Cobertura Medica";
            this.crearCoberturaMedicaToolStripMenuItem.Click += new System.EventHandler(this.crearCoberturaMedicaToolStripMenuItem_Click);
            // 
            // modificarCoberturaMedicaToolStripMenuItem
            // 
            this.modificarCoberturaMedicaToolStripMenuItem.Name = "modificarCoberturaMedicaToolStripMenuItem";
            this.modificarCoberturaMedicaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.modificarCoberturaMedicaToolStripMenuItem.Tag = "ModificarCoberturaMedica";
            this.modificarCoberturaMedicaToolStripMenuItem.Text = "Modificar Cobertura Medica";
            this.modificarCoberturaMedicaToolStripMenuItem.Click += new System.EventHandler(this.modificarCoberturaMedicaToolStripMenuItem_Click);
            // 
            // verCoberturasMedicasToolStripMenuItem
            // 
            this.verCoberturasMedicasToolStripMenuItem.Name = "verCoberturasMedicasToolStripMenuItem";
            this.verCoberturasMedicasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.verCoberturasMedicasToolStripMenuItem.Tag = "VerCoberturaMedica";
            this.verCoberturasMedicasToolStripMenuItem.Text = "Ver Coberturas Medicas";
            this.verCoberturasMedicasToolStripMenuItem.Click += new System.EventHandler(this.verCoberturasMedicasToolStripMenuItem_Click);
            // 
            // administrarHistoriaClinicaToolStripMenuItem
            // 
            this.administrarHistoriaClinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearHistoriaClinicaToolStripMenuItem,
            this.verHistoriaClinicaToolStripMenuItem});
            this.administrarHistoriaClinicaToolStripMenuItem.Name = "administrarHistoriaClinicaToolStripMenuItem";
            this.administrarHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarHistoriaClinicaToolStripMenuItem.Tag = "AdministrarHistoriaClinica";
            this.administrarHistoriaClinicaToolStripMenuItem.Text = "Administrar Historia Clinica";
            // 
            // crearHistoriaClinicaToolStripMenuItem
            // 
            this.crearHistoriaClinicaToolStripMenuItem.Name = "crearHistoriaClinicaToolStripMenuItem";
            this.crearHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.crearHistoriaClinicaToolStripMenuItem.Tag = "CrearHistoriaClinica";
            this.crearHistoriaClinicaToolStripMenuItem.Text = "Crear Historia Clinica";
            this.crearHistoriaClinicaToolStripMenuItem.Click += new System.EventHandler(this.crearHistoriaClinicaToolStripMenuItem_Click);
            // 
            // verHistoriaClinicaToolStripMenuItem
            // 
            this.verHistoriaClinicaToolStripMenuItem.Name = "verHistoriaClinicaToolStripMenuItem";
            this.verHistoriaClinicaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verHistoriaClinicaToolStripMenuItem.Tag = "VerHistoriaClinica";
            this.verHistoriaClinicaToolStripMenuItem.Text = "Ver Historia Clinica";
            this.verHistoriaClinicaToolStripMenuItem.Click += new System.EventHandler(this.verHistoriaClinicaToolStripMenuItem_Click);
            // 
            // administrarRecetaCertificadoToolStripMenuItem
            // 
            this.administrarRecetaCertificadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRecetaCertificadoToolStripMenuItem,
            this.modificarRecetaCertificadoToolStripMenuItem,
            this.verRecetasCertificadosToolStripMenuItem});
            this.administrarRecetaCertificadoToolStripMenuItem.Name = "administrarRecetaCertificadoToolStripMenuItem";
            this.administrarRecetaCertificadoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.administrarRecetaCertificadoToolStripMenuItem.Tag = "AdministrarReceta/Certificado";
            this.administrarRecetaCertificadoToolStripMenuItem.Text = "Administrar Receta/Certificado";
            // 
            // crearRecetaCertificadoToolStripMenuItem
            // 
            this.crearRecetaCertificadoToolStripMenuItem.Name = "crearRecetaCertificadoToolStripMenuItem";
            this.crearRecetaCertificadoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.crearRecetaCertificadoToolStripMenuItem.Tag = "CrearReceta/Certificado";
            this.crearRecetaCertificadoToolStripMenuItem.Text = "Crear Receta/Certificado";
            this.crearRecetaCertificadoToolStripMenuItem.Click += new System.EventHandler(this.crearRecetaCertificadoToolStripMenuItem_Click);
            // 
            // modificarRecetaCertificadoToolStripMenuItem
            // 
            this.modificarRecetaCertificadoToolStripMenuItem.Name = "modificarRecetaCertificadoToolStripMenuItem";
            this.modificarRecetaCertificadoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.modificarRecetaCertificadoToolStripMenuItem.Tag = "ModificarReceta/Certificado";
            this.modificarRecetaCertificadoToolStripMenuItem.Text = "Modificar Receta/Certificado";
            this.modificarRecetaCertificadoToolStripMenuItem.Click += new System.EventHandler(this.modificarRecetaCertificadoToolStripMenuItem_Click);
            // 
            // verRecetasCertificadosToolStripMenuItem
            // 
            this.verRecetasCertificadosToolStripMenuItem.Name = "verRecetasCertificadosToolStripMenuItem";
            this.verRecetasCertificadosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.verRecetasCertificadosToolStripMenuItem.Tag = "VerReceta/Certificado";
            this.verRecetasCertificadosToolStripMenuItem.Text = "Ver Recetas/Certificados";
            this.verRecetasCertificadosToolStripMenuItem.Click += new System.EventHandler(this.verRecetasCertificadosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarBackupToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.administrarIdiomaToolStripMenuItem,
            this.controlDeCambioToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Tag = "Seguridad";
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // realizarBackupToolStripMenuItem
            // 
            this.realizarBackupToolStripMenuItem.Name = "realizarBackupToolStripMenuItem";
            this.realizarBackupToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.realizarBackupToolStripMenuItem.Tag = "RealizarBackup";
            this.realizarBackupToolStripMenuItem.Text = "Realizar Backup";
            this.realizarBackupToolStripMenuItem.Click += new System.EventHandler(this.realizarBackupToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.bitacoraToolStripMenuItem.Tag = "Bitacora";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarPermisosToolStripMenuItem});
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.permisosToolStripMenuItem.Tag = "Permisos";
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // asignarPermisosToolStripMenuItem
            // 
            this.asignarPermisosToolStripMenuItem.Name = "asignarPermisosToolStripMenuItem";
            this.asignarPermisosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.asignarPermisosToolStripMenuItem.Tag = "AsignarPermisos";
            this.asignarPermisosToolStripMenuItem.Text = "Asignar Permisos";
            this.asignarPermisosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosToolStripMenuItem_Click_1);
            // 
            // administrarIdiomaToolStripMenuItem
            // 
            this.administrarIdiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarIdiomaToolStripMenuItem,
            this.crearIdiomaToolStripMenuItem});
            this.administrarIdiomaToolStripMenuItem.Name = "administrarIdiomaToolStripMenuItem";
            this.administrarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.administrarIdiomaToolStripMenuItem.Tag = "AdministrarIdioma";
            this.administrarIdiomaToolStripMenuItem.Text = "Administrar Idioma";
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cambiarIdiomaToolStripMenuItem.Tag = "CambiarIdioma";
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // crearIdiomaToolStripMenuItem
            // 
            this.crearIdiomaToolStripMenuItem.Name = "crearIdiomaToolStripMenuItem";
            this.crearIdiomaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.crearIdiomaToolStripMenuItem.Tag = "CrearIdioma";
            this.crearIdiomaToolStripMenuItem.Text = "Crear Idioma";
            this.crearIdiomaToolStripMenuItem.Click += new System.EventHandler(this.crearIdiomaToolStripMenuItem_Click);
            // 
            // controlDeCambioToolStripMenuItem
            // 
            this.controlDeCambioToolStripMenuItem.Name = "controlDeCambioToolStripMenuItem";
            this.controlDeCambioToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.controlDeCambioToolStripMenuItem.Tag = "Controlde_Cambio";
            this.controlDeCambioToolStripMenuItem.Text = "Control de Cambio";
            this.controlDeCambioToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambioToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactoToolStripMenuItem,
            this.novedadesToolStripMenuItem});
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informaciónToolStripMenuItem.Tag = "Informacion";
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactoToolStripMenuItem.Tag = "Contacto";
            this.contactoToolStripMenuItem.Text = "Contacto";
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novedadesToolStripMenuItem.Tag = "Novedades";
            this.novedadesToolStripMenuItem.Text = "Novedades";
            this.novedadesToolStripMenuItem.Click += new System.EventHandler(this.novedadesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeVacunaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicarVacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioDeTurnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarTurnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarTurnoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verMisTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarCoberturaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCoberturaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCoberturaMedicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistoriaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarRecetaCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRecetaCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRecetaCertificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verRecetasCertificadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCoberturasMedicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambioToolStripMenuItem;
    }
}

