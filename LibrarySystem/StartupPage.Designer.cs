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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            staffToLogin = new FontAwesome.Sharp.IconButton();
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
            richTextBox1.Location = new Point(414, 72);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(374, 202);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.Highlight;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Modern No. 20", 14.25F);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(455, 283);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(30, 0, 0, 0);
            iconButton1.Size = new Size(267, 42);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Sign in as User";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // staffToLogin
            // 
            staffToLogin.BackColor = SystemColors.Highlight;
            staffToLogin.FlatStyle = FlatStyle.Flat;
            staffToLogin.Font = new Font("Modern No. 20", 14.25F);
            staffToLogin.ForeColor = SystemColors.ControlLightLight;
            staffToLogin.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            staffToLogin.IconColor = Color.White;
            staffToLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            staffToLogin.IconSize = 35;
            staffToLogin.Location = new Point(455, 348);
            staffToLogin.Name = "staffToLogin";
            staffToLogin.Padding = new Padding(30, 0, 0, 0);
            staffToLogin.Size = new Size(267, 42);
            staffToLogin.TabIndex = 4;
            staffToLogin.Text = "Sign in as Staff";
            staffToLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            staffToLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Firefly_logo_of_library_64016;
            pictureBox2.Location = new Point(564, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // StartupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(staffToLogin);
            Controls.Add(iconButton1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StartupPage";
            Text = "StartupPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton staffToLogin;
        private PictureBox pictureBox2;
    }
}