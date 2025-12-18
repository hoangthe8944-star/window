namespace ex1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label5 = new Label();
            linkRegister = new LinkLabel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(353, 47);
            label5.Name = "label5";
            label5.Size = new Size(97, 35);
            label5.TabIndex = 20;
            label5.Text = "Log in";
            label5.Click += btnLogin_Click;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.LinkColor = Color.FromArgb(255, 128, 128);
            linkRegister.Location = new Point(573, 375);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(59, 20);
            linkRegister.TabIndex = 19;
            linkRegister.TabStop = true;
            linkRegister.Text = "Sign up";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 192, 192);
            btnLogin.Location = new Point(479, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 47);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(479, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 218);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(479, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(241, 27);
            txtEmail.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 144);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 11;
            label1.Text = "Email";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(linkRegister);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private LinkLabel linkRegister;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
    }
}