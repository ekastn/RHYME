namespace RYHME
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelChild = new Panel();
            panelTop = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 704);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(4, 262);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(238, 50);
            button4.TabIndex = 1;
            button4.Text = "Releases";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(4, 211);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(238, 50);
            button3.TabIndex = 1;
            button3.Text = "Albums";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(4, 160);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(238, 50);
            button2.TabIndex = 1;
            button2.Text = "Artists";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 109);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(238, 50);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelChild
            // 
            panelChild.BackColor = SystemColors.ControlDarkDark;
            panelChild.Dock = DockStyle.Fill;
            panelChild.Location = new Point(238, 0);
            panelChild.Margin = new Padding(4, 4, 4, 4);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(916, 704);
            panelChild.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ActiveCaption;
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(238, 0);
            panelTop.Margin = new Padding(4, 4, 4, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(916, 64);
            panelTop.TabIndex = 2;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 654);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(238, 50);
            button5.TabIndex = 2;
            button5.Text = "Logout";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 704);
            Controls.Add(panelTop);
            Controls.Add(panelChild);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panelChild;
        private Panel panelTop;
        private Button button5;
    }
}
