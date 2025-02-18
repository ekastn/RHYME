namespace RYHME
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            labelRegister = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(363, 87);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(228, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(363, 140);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(228, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Location = new Point(426, 185);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(248, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = SystemColors.ControlLightLight;
            lblPassword.Location = new Point(248, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.BackColor = Color.Transparent;
            labelRegister.ForeColor = SystemColors.ButtonHighlight;
            labelRegister.Location = new Point(379, 228);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(201, 20);
            labelRegister.TabIndex = 6;
            labelRegister.Text = "Don't have account? Register";
            labelRegister.Click += labelRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginRegis;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(622, 299);
            Controls.Add(labelRegister);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private Label labelRegister;
    }
}
