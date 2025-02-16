namespace RYHME.view
{
    partial class RegisterForm
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
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtPassword = new TextBox();
            txtRePassword = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(279, 140);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(191, 31);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(501, 140);
            txtNama.Margin = new Padding(4, 5, 4, 5);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(202, 31);
            txtNama.TabIndex = 3;
            txtNama.Text = "Contact";
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(279, 208);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 31);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Password";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(501, 208);
            txtRePassword.Margin = new Padding(4, 5, 4, 5);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(202, 31);
            txtRePassword.TabIndex = 5;
            txtRePassword.Text = "Re-Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.AppWorkspace;
            btnRegister.Location = new Point(582, 275);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(121, 38);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 414);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 7;
            label1.Text = "back to Login";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginRegis;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(740, 400);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtRePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtNama;
        private TextBox txtPassword;
        private TextBox txtRePassword;
        private Button btnRegister;
        private Label label1;
    }
}