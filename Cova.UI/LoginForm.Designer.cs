namespace Cova.UI
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(168, 79);
            this.txt_usuario.MaxLength = 30;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(148, 20);
            this.txt_usuario.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(168, 134);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(148, 20);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(100, 207);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(85, 27);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Olvide Contraseña";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
    }
}