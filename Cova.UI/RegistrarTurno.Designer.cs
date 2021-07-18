
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
            this.lbl_RegistrarTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_RegistrarTurno
            // 
            this.lbl_RegistrarTurno.AutoSize = true;
            this.lbl_RegistrarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegistrarTurno.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_RegistrarTurno.Location = new System.Drawing.Point(3, 9);
            this.lbl_RegistrarTurno.Name = "lbl_RegistrarTurno";
            this.lbl_RegistrarTurno.Size = new System.Drawing.Size(169, 25);
            this.lbl_RegistrarTurno.TabIndex = 130;
            this.lbl_RegistrarTurno.Text = "RegistrarTurno";
            this.lbl_RegistrarTurno.UseWaitCursor = true;
            // 
            // RegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_RegistrarTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarTurno";
            this.Text = "RegistrarTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegistrarTurno;
    }
}