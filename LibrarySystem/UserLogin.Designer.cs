
namespace LibrarySystem
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            lblSignup = new LinkLabel();
            label7 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnback = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblSignup);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(50, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 385);
            panel1.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(45, 73);
            label8.Name = "label8";
            label8.Size = new Size(341, 29);
            label8.TabIndex = 20;
            label8.Text = "Welcome to Elimu Library";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Modern No. 20", 8.999999F);
            lblSignup.Location = new Point(272, 316);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(45, 15);
            lblSignup.TabIndex = 17;
            lblSignup.TabStop = true;
            lblSignup.Text = "Sign Up";
            lblSignup.Click += lblSignup_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 8.999999F);
            label7.Location = new Point(151, 316);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 16;
            label7.Text = "Don't Have An Account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Modern No. 20", 11.249999F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(144, 250);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(180, 44);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(324, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(102, 133);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Modern No. 20", 11.249999F);
            lblPassword.Location = new Point(31, 197);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 17);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Modern No. 20", 11.249999F);
            lblEmail.Location = new Point(31, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            lblEmail.Click += label4_Click;
            // 
            // btnback
            // 
            btnback.BackColor = SystemColors.Highlight;
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnback.ForeColor = SystemColors.ControlLightLight;
            btnback.IconChar = FontAwesome.Sharp.IconChar.ArrowUpRightFromSquare;
            btnback.IconColor = Color.White;
            btnback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnback.IconSize = 22;
            btnback.Location = new Point(22, 12);
            btnback.Name = "btnback";
            btnback.Padding = new Padding(10, 0, 0, 0);
            btnback.Rotation = 270D;
            btnback.Size = new Size(189, 34);
            btnback.TabIndex = 22;
            btnback.Text = "Back to Start Up";
            btnback.TextAlign = ContentAlignment.MiddleLeft;
            btnback.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnBack_Click;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 521);
            Controls.Add(btnback);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserLogin";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private LinkLabel lblSignup;
        private Label label7;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private FontAwesome.Sharp.IconButton btnback;
    }
}