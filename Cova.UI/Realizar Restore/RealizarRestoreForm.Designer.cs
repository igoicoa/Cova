
namespace Cova.UI.Realizar_Restore
{
    partial class RealizarRestoreForm
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
            this.btn_IniciarRestore_RealizarRestore = new System.Windows.Forms.Button();
            this.gb_RealizarRestore = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar_RealizarRestore = new System.Windows.Forms.Button();
            this.btn_Examinar_RealizarRestore = new System.Windows.Forms.Button();
            this.lbl_Ruta_RealizarRestore = new System.Windows.Forms.Label();
            this.lbl_RealizarRestore = new System.Windows.Forms.Label();
            this.gb_RealizarRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IniciarRestore_RealizarRestore
            // 
            this.btn_IniciarRestore_RealizarRestore.Location = new System.Drawing.Point(106, 153);
            this.btn_IniciarRestore_RealizarRestore.Name = "btn_IniciarRestore_RealizarRestore";
            this.btn_IniciarRestore_RealizarRestore.Size = new System.Drawing.Size(90, 23);
            this.btn_IniciarRestore_RealizarRestore.TabIndex = 186;
            this.btn_IniciarRestore_RealizarRestore.Text = "Iniciar Restore";
            this.btn_IniciarRestore_RealizarRestore.UseVisualStyleBackColor = true;
            // 
            // gb_RealizarRestore
            // 
            this.gb_RealizarRestore.Controls.Add(this.btn_Cancelar_RealizarRestore);
            this.gb_RealizarRestore.Controls.Add(this.btn_Examinar_RealizarRestore);
            this.gb_RealizarRestore.Controls.Add(this.lbl_Ruta_RealizarRestore);
            this.gb_RealizarRestore.Location = new System.Drawing.Point(17, 46);
            this.gb_RealizarRestore.Name = "gb_RealizarRestore";
            this.gb_RealizarRestore.Size = new System.Drawing.Size(313, 88);
            this.gb_RealizarRestore.TabIndex = 185;
            this.gb_RealizarRestore.TabStop = false;
            this.gb_RealizarRestore.Text = "Filtros";
            // 
            // btn_Cancelar_RealizarRestore
            // 
            this.btn_Cancelar_RealizarRestore.Location = new System.Drawing.Point(219, 54);
            this.btn_Cancelar_RealizarRestore.Name = "btn_Cancelar_RealizarRestore";
            this.btn_Cancelar_RealizarRestore.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar_RealizarRestore.TabIndex = 180;
            this.btn_Cancelar_RealizarRestore.Text = "Cancelar";
            this.btn_Cancelar_RealizarRestore.UseVisualStyleBackColor = true;
            this.btn_Cancelar_RealizarRestore.Click += new System.EventHandler(this.btn_Cancelar_RealizarRestore_Click);
            // 
            // btn_Examinar_RealizarRestore
            // 
            this.btn_Examinar_RealizarRestore.Location = new System.Drawing.Point(219, 25);
            this.btn_Examinar_RealizarRestore.Name = "btn_Examinar_RealizarRestore";
            this.btn_Examinar_RealizarRestore.Size = new System.Drawing.Size(75, 23);
            this.btn_Examinar_RealizarRestore.TabIndex = 179;
            this.btn_Examinar_RealizarRestore.Text = "Examinar";
            this.btn_Examinar_RealizarRestore.UseVisualStyleBackColor = true;
            // 
            // lbl_Ruta_RealizarRestore
            // 
            this.lbl_Ruta_RealizarRestore.AutoSize = true;
            this.lbl_Ruta_RealizarRestore.Location = new System.Drawing.Point(6, 25);
            this.lbl_Ruta_RealizarRestore.Name = "lbl_Ruta_RealizarRestore";
            this.lbl_Ruta_RealizarRestore.Size = new System.Drawing.Size(63, 13);
            this.lbl_Ruta_RealizarRestore.TabIndex = 133;
            this.lbl_Ruta_RealizarRestore.Text = "Ruta:     C:/";
            // 
            // lbl_RealizarRestore
            // 
            this.lbl_RealizarRestore.AutoSize = true;
            this.lbl_RealizarRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RealizarRestore.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_RealizarRestore.Location = new System.Drawing.Point(12, 9);
            this.lbl_RealizarRestore.Name = "lbl_RealizarRestore";
            this.lbl_RealizarRestore.Size = new System.Drawing.Size(188, 25);
            this.lbl_RealizarRestore.TabIndex = 184;
            this.lbl_RealizarRestore.Text = "Realizar Restore";
            // 
            // RealizarRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 189);
            this.Controls.Add(this.btn_IniciarRestore_RealizarRestore);
            this.Controls.Add(this.gb_RealizarRestore);
            this.Controls.Add(this.lbl_RealizarRestore);
            this.Name = "RealizarRestoreForm";
            this.Text = "RealizarRestoreForm";
            this.gb_RealizarRestore.ResumeLayout(false);
            this.gb_RealizarRestore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IniciarRestore_RealizarRestore;
        private System.Windows.Forms.GroupBox gb_RealizarRestore;
        private System.Windows.Forms.Button btn_Cancelar_RealizarRestore;
        private System.Windows.Forms.Button btn_Examinar_RealizarRestore;
        private System.Windows.Forms.Label lbl_Ruta_RealizarRestore;
        private System.Windows.Forms.Label lbl_RealizarRestore;
    }
}