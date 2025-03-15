namespace LibrarySystem
{
    partial class StartupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupPage));
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            btnuserToLogin = new FontAwesome.Sharp.IconButton();
            btnstaffToLogin = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLightLight;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(591, 120);
            richTextBox1.Margin = new Padding(4, 5, 4, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(534, 337);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 752);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnuserToLogin
            // 
            btnuserToLogin.BackColor = SystemColors.Highlight;
            btnuserToLogin.FlatStyle = FlatStyle.Flat;
            btnuserToLogin.Font = new Font("Modern No. 20", 14.25F);
            btnuserToLogin.ForeColor = SystemColors.Window;
            btnuserToLogin.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            btnuserToLogin.IconColor = Color.White;
            btnuserToLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnuserToLogin.IconSize = 35;
            btnuserToLogin.Location = new Point(650, 472);
            btnuserToLogin.Margin = new Padding(4, 5, 4, 5);
            btnuserToLogin.Name = "btnuserToLogin";
            btnuserToLogin.Padding = new Padding(43, 0, 0, 0);
            btnuserToLogin.Size = new Size(381, 70);
            btnuserToLogin.TabIndex = 3;
            btnuserToLogin.Text = "Sign in as User";
            btnuserToLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnuserToLogin.UseVisualStyleBackColor = false;
            btnuserToLogin.Click += BtnUserToLogin_Click;
            btnuserToLogin.MouseEnter += Button_MouseEnter;
            btnuserToLogin.MouseLeave += Button_MouseLeave;
            // 
            // btnstaffToLogin
            // 
            btnstaffToLogin.BackColor = SystemColors.Highlight;
            btnstaffToLogin.FlatStyle = FlatStyle.Flat;
            btnstaffToLogin.Font = new Font("Modern No. 20", 14.25F);
            btnstaffToLogin.ForeColor = SystemColors.Window;
            btnstaffToLogin.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btnstaffToLogin.IconColor = Color.White;
            btnstaffToLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnstaffToLogin.IconSize = 35;
            btnstaffToLogin.Location = new Point(650, 580);
            btnstaffToLogin.Margin = new Padding(4, 5, 4, 5);
            btnstaffToLogin.Name = "btnstaffToLogin";
            btnstaffToLogin.Padding = new Padding(43, 0, 0, 0);
            btnstaffToLogin.Size = new Size(381, 70);
            btnstaffToLogin.TabIndex = 4;
            btnstaffToLogin.Text = "Sign in as Staff";
            btnstaffToLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnstaffToLogin.UseVisualStyleBackColor = false;
            btnstaffToLogin.Click += BtnStaffToLogin_Click;
            btnstaffToLogin.MouseEnter += Button_MouseEnter;
            btnstaffToLogin.MouseLeave += Button_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Firefly_logo_of_library_64016;
            pictureBox2.Location = new Point(806, 20);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // StartupPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox2);
            Controls.Add(btnstaffToLogin);
            Controls.Add(btnuserToLogin);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "StartupPage";
            Text = "StartupPage";
            Load += StartupPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnuserToLogin;
        private FontAwesome.Sharp.IconButton btnstaffToLogin;
        private PictureBox pictureBox2;
    }
}