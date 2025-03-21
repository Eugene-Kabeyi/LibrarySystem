

namespace LibrarySystem
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            llb = new Label();
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
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(llb);
            panel1.Location = new Point(72, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 382);
            panel1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(63, 63);
            label8.Name = "label8";
            label8.Size = new Size(341, 29);
            label8.TabIndex = 20;
            label8.Text = "Welcome to Elimu Library";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 8.999999F);
            label7.Location = new Point(147, 313);
            label7.Name = "label7";
            label7.Size = new Size(183, 15);
            label7.TabIndex = 16;
            label7.Text = "Incase of any issues Contact ADMIN";
            label7.Click += label7_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Modern No. 20", 11.249999F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(151, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 33);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(299, 23);
            txtUsername.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 11.249999F);
            label5.Location = new Point(38, 192);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // llb
            // 
            llb.AutoSize = true;
            llb.Font = new Font("Modern No. 20", 11.249999F);
            llb.Location = new Point(38, 136);
            llb.Name = "llb";
            llb.Size = new Size(68, 17);
            llb.TabIndex = 8;
            llb.Text = "Username";
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
            btnback.Location = new Point(21, 3);
            btnback.Name = "btnback";
            btnback.Padding = new Padding(10, 0, 0, 0);
            btnback.Rotation = 270D;
            btnback.Size = new Size(189, 34);
            btnback.TabIndex = 23;
            btnback.Text = "Back to Start Up";
            btnback.TextAlign = ContentAlignment.MiddleLeft;
            btnback.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnBack_Click;
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 467);
            Controls.Add(btnback);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StaffLogin";
            Text = "StaffLogin";
            Load += StaffLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }




        #endregion

        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label7;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Label llb;
        private FontAwesome.Sharp.IconButton btnback;
    }
}