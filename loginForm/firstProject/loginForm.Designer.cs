namespace firstProject
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            panel1 = new Panel();
            btnLogin = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 355);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Peru;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14.25F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(169, 287);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 26.25F);
            passField.Location = new Point(115, 202);
            passField.Name = "passField";
            passField.Size = new Size(220, 48);
            passField.TabIndex = 4;
            passField.Text = "admin";
            passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(45, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 26.25F);
            loginField.Location = new Point(115, 112);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(220, 52);
            loginField.TabIndex = 2;
            loginField.Text = "admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 95);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.BackColor = Color.Peru;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Tahoma", 18F);
            closeButton.ForeColor = Color.Red;
            closeButton.Location = new Point(383, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(25, 29);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave_1;
            // 
            // label1
            // 
            label1.BackColor = Color.Peru;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Gill Sans MT", 32F, FontStyle.Bold);
            label1.ForeColor = Color.Linen;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 95);
            label1.TabIndex = 0;
            label1.Text = "Authorization";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 355);
            Controls.Add(panel1);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            Text = "loginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private Button btnLogin;
        private TextBox passField;
        private PictureBox pictureBox2;
    }
}