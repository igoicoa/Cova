
namespace Cova.UI
{
    partial class RegistrarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTurno));
            this.lbl_RegistrarTurnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_RegistrarTurnos
            // 
            this.lbl_RegistrarTurnos.AutoSize = true;
            this.lbl_RegistrarTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistrarTurnos.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_RegistrarTurnos.Location = new System.Drawing.Point(3, 9);
            this.lbl_RegistrarTurnos.Name = "lbl_RegistrarTurnos";
            this.lbl_RegistrarTurnos.Size = new System.Drawing.Size(188, 25);
            this.lbl_RegistrarTurnos.TabIndex = 130;
            this.lbl_RegistrarTurnos.Text = "Registrar Turnos";
            this.lbl_RegistrarTurnos.UseWaitCursor = true;
            // 
            // RegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_RegistrarTurnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarTurno";
            this.Text = "RegistrarTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegistrarTurnos;
    }
}