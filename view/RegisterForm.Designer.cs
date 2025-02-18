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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(223, 100);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(154, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(401, 100);
            txtContact.Margin = new Padding(3, 4, 3, 4);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(162, 27);
            txtContact.TabIndex = 3;
            txtContact.TextChanged += txtNama_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(223, 166);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(401, 166);
            txtRePassword.Margin = new Padding(3, 4, 3, 4);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(162, 27);
            txtRePassword.TabIndex = 5;
            txtRePassword.UseSystemPasswordChar = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(223, 76);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(401, 76);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 9;
            label3.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(223, 142);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(401, 142);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 11;
            label5.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginRegis;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(592, 320);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}