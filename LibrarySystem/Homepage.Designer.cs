namespace LibrarySystem
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            btnRequest = new FontAwesome.Sharp.IconButton();
            btnBorrowed = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblLogout = new Label();
            btnBooklist = new FontAwesome.Sharp.IconButton();
            libName = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            picUser = new PictureBox();
            lblFname = new Label();
            pnlContent = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // btnRequest
            // 
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = SystemColors.ControlLightLight;
            btnRequest.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnRequest.IconColor = Color.White;
            btnRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRequest.IconSize = 30;
            btnRequest.Location = new Point(0, 193);
            btnRequest.Margin = new Padding(3, 10, 3, 10);
            btnRequest.Name = "btnRequest";
            btnRequest.Padding = new Padding(10, 0, 4, 0);
            btnRequest.Size = new Size(174, 53);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "Request Book";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnBorrowed
            // 
            btnBorrowed.FlatAppearance.BorderSize = 0;
            btnBorrowed.FlatStyle = FlatStyle.Flat;
            btnBorrowed.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowed.ForeColor = SystemColors.ControlLightLight;
            btnBorrowed.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnBorrowed.IconColor = Color.White;
            btnBorrowed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrowed.IconSize = 30;
            btnBorrowed.Location = new Point(0, 244);
            btnBorrowed.Margin = new Padding(3, 10, 3, 10);
            btnBorrowed.Name = "btnBorrowed";
            btnBorrowed.Padding = new Padding(10, 0, 4, 0);
            btnBorrowed.Size = new Size(184, 66);
            btnBorrowed.TabIndex = 3;
            btnBorrowed.Text = "Borrowed Book";
            btnBorrowed.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrowed.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrowed.UseVisualStyleBackColor = true;
            btnBorrowed.Click += btnBorrowed_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 30;
            btnHome.Location = new Point(0, 106);
            btnHome.Margin = new Padding(3, 10, 3, 10);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(0, 0, 20, 0);
            btnHome.Size = new Size(174, 36);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(lblLogout);
            panel2.Controls.Add(btnBooklist);
            panel2.Controls.Add(btnRequest);
            panel2.Controls.Add(btnBorrowed);
            panel2.Controls.Add(btnHome);
            panel2.Controls.Add(libName);
            panel2.Controls.Add(logo);
            panel2.Location = new Point(-1, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 595);
            panel2.TabIndex = 4;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.ForeColor = Color.Red;
            lblLogout.Location = new Point(61, 428);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(59, 18);
            lblLogout.TabIndex = 6;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
            // 
            // btnBooklist
            // 
            btnBooklist.FlatAppearance.BorderSize = 0;
            btnBooklist.FlatStyle = FlatStyle.Flat;
            btnBooklist.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooklist.ForeColor = SystemColors.ControlLightLight;
            btnBooklist.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnBooklist.IconColor = Color.White;
            btnBooklist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBooklist.IconSize = 30;
            btnBooklist.Location = new Point(0, 143);
            btnBooklist.Margin = new Padding(3, 10, 3, 10);
            btnBooklist.Name = "btnBooklist";
            btnBooklist.Padding = new Padding(1, 0, 4, 0);
            btnBooklist.Size = new Size(174, 53);
            btnBooklist.TabIndex = 5;
            btnBooklist.Text = "Book List";
            btnBooklist.TextAlign = ContentAlignment.MiddleLeft;
            btnBooklist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooklist.UseVisualStyleBackColor = true;
            btnBooklist.Click += btnBooklist_Click;
            // 
            // libName
            // 
            libName.Font = new Font("Forte", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            libName.ForeColor = SystemColors.ButtonHighlight;
            libName.Location = new Point(61, 22);
            libName.Name = "libName";
            libName.Size = new Size(123, 70);
            libName.TabIndex = 1;
            libName.Text = "Elimu Library";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Firefly_logo_of_library_64016;
            logo.Location = new Point(3, 22);
            logo.Name = "logo";
            logo.Size = new Size(57, 47);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(picUser);
            panel1.Controls.Add(lblFname);
            panel1.Location = new Point(169, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 66);
            panel1.TabIndex = 3;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.user_icon;
            picUser.Location = new Point(750, 3);
            picUser.Name = "picUser";
            picUser.Size = new Size(73, 60);
            picUser.SizeMode = PictureBoxSizeMode.Zoom;
            picUser.TabIndex = 5;
            picUser.TabStop = false;
            picUser.Click += picUser_Click;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.ForeColor = SystemColors.ControlLightLight;
            lblFname.Location = new Point(679, 28);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(45, 21);
            lblFname.TabIndex = 4;
            lblFname.Text = "User";
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(179, 71);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(825, 520);
            pnlContent.TabIndex = 6;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 591);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Homepage";
            Text = "Homepage";
            Load += Homepage_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnRequest;
        private FontAwesome.Sharp.IconButton btnBorrowed;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel2;
        private Label libName;
        private PictureBox logo;
        private Panel panel1;
        private PictureBox picUser;
        private Label lblFname;
        private FontAwesome.Sharp.IconButton btnBooklist;
        private Panel pnlContent;
        private Label lblLogout;
    }
}