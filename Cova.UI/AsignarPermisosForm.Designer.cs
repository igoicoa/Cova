namespace Cova.UI
{
    partial class AsignarPermisosForm
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
            this.tv_PermisosMaster = new System.Windows.Forms.TreeView();
            this.tv_PermisosUsuario = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_usuarioNombre = new System.Windows.Forms.TextBox();
            this.txt_usuarioApellido = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_agregarPermiso = new System.Windows.Forms.Button();
            this.btn_quitarPermiso = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_PermisosMaster
            // 
            this.tv_PermisosMaster.Location = new System.Drawing.Point(20, 161);
            this.tv_PermisosMaster.Name = "tv_PermisosMaster";
            this.tv_PermisosMaster.Size = new System.Drawing.Size(256, 340);
            this.tv_PermisosMaster.TabIndex = 0;
            // 
            // tv_PermisosUsuario
            // 
            this.tv_PermisosUsuario.Location = new System.Drawing.Point(476, 161);
            this.tv_PermisosUsuario.Name = "tv_PermisosUsuario";
            this.tv_PermisosUsuario.Size = new System.Drawing.Size(256, 340);
            this.tv_PermisosUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Permisos usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido:";
            // 
            // txt_usuarioNombre
            // 
            this.txt_usuarioNombre.Location = new System.Drawing.Point(76, 21);
            this.txt_usuarioNombre.Name = "txt_usuarioNombre";
            this.txt_usuarioNombre.Size = new System.Drawing.Size(173, 20);
            this.txt_usuarioNombre.TabIndex = 6;
            // 
            // txt_usuarioApellido
            // 
            this.txt_usuarioApellido.Location = new System.Drawing.Point(76, 53);
            this.txt_usuarioApellido.Name = "txt_usuarioApellido";
            this.txt_usuarioApellido.Size = new System.Drawing.Size(173, 20);
            this.txt_usuarioApellido.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(76, 101);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(174, 101);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 10;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_agregarPermiso
            // 
            this.btn_agregarPermiso.Location = new System.Drawing.Point(339, 284);
            this.btn_agregarPermiso.Name = "btn_agregarPermiso";
            this.btn_agregarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarPermiso.TabIndex = 11;
            this.btn_agregarPermiso.Text = "Agregar";
            this.btn_agregarPermiso.UseVisualStyleBackColor = true;
            // 
            // btn_quitarPermiso
            // 
            this.btn_quitarPermiso.Location = new System.Drawing.Point(339, 346);
            this.btn_quitarPermiso.Name = "btn_quitarPermiso";
            this.btn_quitarPermiso.Size = new System.Drawing.Size(75, 23);
            this.btn_quitarPermiso.TabIndex = 12;
            this.btn_quitarPermiso.Text = "Quitar";
            this.btn_quitarPermiso.UseVisualStyleBackColor = true;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(281, 12);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(603, 112);
            this.dgv_usuarios.TabIndex = 13;
            // 
            // AsignarPermisosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 529);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_quitarPermiso);
            this.Controls.Add(this.btn_agregarPermiso);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_usuarioApellido);
            this.Controls.Add(this.txt_usuarioNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_PermisosUsuario);
            this.Controls.Add(this.tv_PermisosMaster);
            this.Name = "AsignarPermisosForm";
            this.Text = "Asignar Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_PermisosMaster;
        private System.Windows.Forms.TreeView tv_PermisosUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_usuarioNombre;
        private System.Windows.Forms.TextBox txt_usuarioApellido;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_agregarPermiso;
        private System.Windows.Forms.Button btn_quitarPermiso;
        private System.Windows.Forms.DataGridView dgv_usuarios;
    }
}