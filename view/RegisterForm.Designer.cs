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
            txtContact = new TextBox();
            txtPassword = new TextBox();
            txtRePassword = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(223, 112);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 27);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(401, 112);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(162, 27);
            txtContact.TabIndex = 3;
            txtContact.Text = "Contact";
            txtContact.TextChanged += txtNama_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(223, 166);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Password";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(401, 166);
            txtRePassword.Margin = new Padding(3, 4, 3, 4);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(162, 27);
            txtRePassword.TabIndex = 5;
            txtRePassword.Text = "Re-Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.AppWorkspace;
            btnRegister.Location = new Point(466, 220);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(97, 30);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 331);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 7;
            label1.Text = "back to Login";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginRegis;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(592, 320);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtRePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtContact);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtContact;
        private TextBox txtPassword;
        private TextBox txtRePassword;
        private Button btnRegister;
        private Label label1;
    }
}