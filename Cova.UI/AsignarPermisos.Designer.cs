namespace Cova.UI
{
    partial class AsignarPermisos
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
            this.SuspendLayout();
            // 
            // tv_PermisosMaster
            // 
            this.tv_PermisosMaster.Location = new System.Drawing.Point(23, 114);
            this.tv_PermisosMaster.Name = "tv_PermisosMaster";
            this.tv_PermisosMaster.Size = new System.Drawing.Size(256, 287);
            this.tv_PermisosMaster.TabIndex = 0;
            // 
            // tv_PermisosUsuario
            // 
            this.tv_PermisosUsuario.Location = new System.Drawing.Point(479, 114);
            this.tv_PermisosUsuario.Name = "tv_PermisosUsuario";
            this.tv_PermisosUsuario.Size = new System.Drawing.Size(256, 287);
            this.tv_PermisosUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Permisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Permisos usuario";
            // 
            // AsignarPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_PermisosUsuario);
            this.Controls.Add(this.tv_PermisosMaster);
            this.Name = "AsignarPermisos";
            this.Text = "Asignar Permisos";
            this.Load += new System.EventHandler(this.AsignarPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_PermisosMaster;
        private System.Windows.Forms.TreeView tv_PermisosUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}