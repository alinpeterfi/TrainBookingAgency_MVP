
namespace PS_project12.View
{
    partial class AuthenticationV
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
            this.lUser = new System.Windows.Forms.Label();
            this.l2User = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAuthentication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lUser.Location = new System.Drawing.Point(26, 28);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(37, 15);
            this.lUser.TabIndex = 0;
            this.lUser.Text = "USER";
            // 
            // l2User
            // 
            this.l2User.AutoSize = true;
            this.l2User.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l2User.Location = new System.Drawing.Point(26, 82);
            this.l2User.Name = "l2User";
            this.l2User.Size = new System.Drawing.Size(73, 15);
            this.l2User.TabIndex = 1;
            this.l2User.Text = "PASSWORD";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(26, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(134, 23);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(26, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(134, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // btnAuthentication
            // 
            this.btnAuthentication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthentication.Location = new System.Drawing.Point(26, 138);
            this.btnAuthentication.Name = "btnAuthentication";
            this.btnAuthentication.Size = new System.Drawing.Size(134, 42);
            this.btnAuthentication.TabIndex = 4;
            this.btnAuthentication.Text = "AUTHENTICATION";
            this.btnAuthentication.UseVisualStyleBackColor = true;
            this.btnAuthentication.Click += new System.EventHandler(this.btnAuthentication_Click);
            // 
            // AuthenticationV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 202);
            this.Controls.Add(this.btnAuthentication);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.l2User);
            this.Controls.Add(this.lUser);
            this.Name = "AuthenticationV";
            this.Text = "AuthenticationV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label l2User;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAuthentication;
    }
}