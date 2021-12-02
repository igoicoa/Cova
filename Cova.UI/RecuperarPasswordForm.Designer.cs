namespace Cova.UI
{
    partial class RecuperarPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarPasswordForm));
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Bienvenida_Loguin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_recuperarPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(112, 165);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(148, 20);
            this.txt_email.TabIndex = 8;
            this.txt_email.UseSystemPasswordChar = true;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(112, 114);
            this.txt_usuario.MaxLength = 30;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(148, 20);
            this.txt_usuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 235);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Bienvenida_Loguin
            // 
            this.lbl_Bienvenida_Loguin.AutoSize = true;
            this.lbl_Bienvenida_Loguin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenida_Loguin.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl_Bienvenida_Loguin.Location = new System.Drawing.Point(15, 19);
            this.lbl_Bienvenida_Loguin.Name = "lbl_Bienvenida_Loguin";
            this.lbl_Bienvenida_Loguin.Size = new System.Drawing.Size(334, 25);
            this.lbl_Bienvenida_Loguin.TabIndex = 10;
            this.lbl_Bienvenida_Loguin.Text = "Bienvenido/a al Sistema Cova.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese su usuario y email para recuperar la contraseña";
            // 
            // btn_recuperarPwd
            // 
            this.btn_recuperarPwd.Location = new System.Drawing.Point(44, 224);
            this.btn_recuperarPwd.Name = "btn_recuperarPwd";
            this.btn_recuperarPwd.Size = new System.Drawing.Size(124, 27);
            this.btn_recuperarPwd.TabIndex = 12;
            this.btn_recuperarPwd.Text = "Recuperar Contraseña";
            this.btn_recuperarPwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_recuperarPwd.UseVisualStyleBackColor = true;
            this.btn_recuperarPwd.Click += new System.EventHandler(this.btn_recuperarPwd_Click);
            // 
            // RecuperarPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 288);
            this.Controls.Add(this.btn_recuperarPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Bienvenida_Loguin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "RecuperarPasswordForm";
            this.Text = "RecuperarPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Bienvenida_Loguin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_recuperarPwd;
    }
}