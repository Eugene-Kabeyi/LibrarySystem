

namespace LibrarySystem
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            iconButton2 = new FontAwesome.Sharp.IconButton();
            lbLogout = new Label();
            btnDash = new FontAwesome.Sharp.IconButton();
            btnEditBooks = new FontAwesome.Sharp.IconButton();
            btnMembers = new FontAwesome.Sharp.IconButton();
            btnLibrarians = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnRequestedBooks = new FontAwesome.Sharp.IconButton();
            btnBorrowedBooks = new FontAwesome.Sharp.IconButton();
            libName = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            picAdmin = new PictureBox();
            lbAdmin = new Label();
            pnlContent = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(514, 370);
            iconButton2.Margin = new Padding(4, 5, 4, 5);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(11, 13);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // lbLogout
            // 
            lbLogout.AutoSize = true;
            lbLogout.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogout.ForeColor = Color.Red;
            lbLogout.Location = new Point(87, 673);
            lbLogout.Margin = new Padding(4, 0, 4, 0);
            lbLogout.Name = "lbLogout";
            lbLogout.Size = new Size(67, 22);
            lbLogout.TabIndex = 2;
            lbLogout.Text = "Logout";
            lbLogout.Click += lblLogout_Click;
            // 
            // btnDash
            // 
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDash.ForeColor = SystemColors.ControlLightLight;
            btnDash.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnDash.IconColor = Color.White;
            btnDash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDash.IconSize = 30;
            btnDash.Location = new Point(0, 177);
            btnDash.Margin = new Padding(4, 17, 4, 17);
            btnDash.Name = "btnDash";
            btnDash.Padding = new Padding(14, 0, 29, 0);
            btnDash.Size = new Size(249, 60);
            btnDash.TabIndex = 2;
            btnDash.Text = "Dashboard";
            btnDash.TextAlign = ContentAlignment.MiddleLeft;
            btnDash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDashboard_Click;
            // 
            // btnEditBooks
            // 
            btnEditBooks.FlatAppearance.BorderSize = 0;
            btnEditBooks.FlatStyle = FlatStyle.Flat;
            btnEditBooks.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBooks.ForeColor = SystemColors.ControlLightLight;
            btnEditBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnEditBooks.IconColor = Color.White;
            btnEditBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditBooks.IconSize = 30;
            btnEditBooks.Location = new Point(4, 395);
            btnEditBooks.Margin = new Padding(4, 17, 4, 17);
            btnEditBooks.Name = "btnEditBooks";
            btnEditBooks.Padding = new Padding(14, 0, 43, 0);
            btnEditBooks.Size = new Size(244, 60);
            btnEditBooks.TabIndex = 3;
            btnEditBooks.Text = "Edit Books";
            btnEditBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnEditBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditBooks.UseVisualStyleBackColor = true;
            btnEditBooks.Click += btnEditBooks_Click;
            // 
            // btnMembers
            // 
            btnMembers.FlatAppearance.BorderSize = 0;
            btnMembers.FlatStyle = FlatStyle.Flat;
            btnMembers.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMembers.ForeColor = SystemColors.ControlLightLight;
            btnMembers.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnMembers.IconColor = Color.White;
            btnMembers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMembers.IconSize = 30;
            btnMembers.Location = new Point(0, 327);
            btnMembers.Margin = new Padding(4, 17, 4, 17);
            btnMembers.Name = "btnMembers";
            btnMembers.Padding = new Padding(14, 0, 29, 0);
            btnMembers.Size = new Size(249, 60);
            btnMembers.TabIndex = 4;
            btnMembers.Text = "Mambers";
            btnMembers.TextAlign = ContentAlignment.MiddleLeft;
            btnMembers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembers.UseVisualStyleBackColor = true;
            btnMembers.Click += btnMembers_Click;
            // 
            // btnLibrarians
            // 
            btnLibrarians.FlatAppearance.BorderSize = 0;
            btnLibrarians.FlatStyle = FlatStyle.Flat;
            btnLibrarians.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibrarians.ForeColor = SystemColors.ControlLightLight;
            btnLibrarians.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            btnLibrarians.IconColor = Color.White;
            btnLibrarians.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibrarians.IconSize = 30;
            btnLibrarians.Location = new Point(0, 252);
            btnLibrarians.Margin = new Padding(4, 17, 4, 17);
            btnLibrarians.Name = "btnLibrarians";
            btnLibrarians.Padding = new Padding(14, 0, 29, 0);
            btnLibrarians.Size = new Size(249, 60);
            btnLibrarians.TabIndex = 5;
            btnLibrarians.Text = "Librarians";
            btnLibrarians.TextAlign = ContentAlignment.MiddleLeft;
            btnLibrarians.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibrarians.UseVisualStyleBackColor = true;
            btnLibrarians.Click += btnLibrarians_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(btnRequestedBooks);
            panel2.Controls.Add(btnLibrarians);
            panel2.Controls.Add(btnBorrowedBooks);
            panel2.Controls.Add(btnMembers);
            panel2.Controls.Add(btnEditBooks);
            panel2.Controls.Add(btnDash);
            panel2.Controls.Add(lbLogout);
            panel2.Controls.Add(libName);
            panel2.Controls.Add(logo);
            panel2.Location = new Point(-3, -8);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 763);
            panel2.TabIndex = 1;
            // 
            // btnRequestedBooks
            // 
            btnRequestedBooks.FlatAppearance.BorderSize = 0;
            btnRequestedBooks.FlatStyle = FlatStyle.Flat;
            btnRequestedBooks.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequestedBooks.ForeColor = SystemColors.ControlLightLight;
            btnRequestedBooks.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnRequestedBooks.IconColor = Color.White;
            btnRequestedBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRequestedBooks.IconSize = 30;
            btnRequestedBooks.Location = new Point(4, 460);
            btnRequestedBooks.Margin = new Padding(4, 17, 4, 17);
            btnRequestedBooks.Name = "btnRequestedBooks";
            btnRequestedBooks.Padding = new Padding(14, 0, 43, 0);
            btnRequestedBooks.Size = new Size(249, 80);
            btnRequestedBooks.TabIndex = 8;
            btnRequestedBooks.Text = "Requested Books";
            btnRequestedBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnRequestedBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequestedBooks.UseVisualStyleBackColor = true;
            btnRequestedBooks.Click += btnRequestedBooks_Click;
            // 
            // btnBorrowedBooks
            // 
            btnBorrowedBooks.FlatAppearance.BorderSize = 0;
            btnBorrowedBooks.FlatStyle = FlatStyle.Flat;
            btnBorrowedBooks.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowedBooks.ForeColor = SystemColors.ControlLightLight;
            btnBorrowedBooks.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnBorrowedBooks.IconColor = Color.White;
            btnBorrowedBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBorrowedBooks.IconSize = 30;
            btnBorrowedBooks.Location = new Point(0, 545);
            btnBorrowedBooks.Margin = new Padding(4, 17, 4, 17);
            btnBorrowedBooks.Name = "btnBorrowedBooks";
            btnBorrowedBooks.Padding = new Padding(14, 0, 43, 0);
            btnBorrowedBooks.Size = new Size(250, 83);
            btnBorrowedBooks.TabIndex = 7;
            btnBorrowedBooks.Text = "Borrowed Books";
            btnBorrowedBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrowedBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrowedBooks.UseVisualStyleBackColor = true;
            btnBorrowedBooks.Click += btnBorrowedBooks_Click;
            // 
            // libName
            // 
            libName.Font = new Font("Forte", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            libName.ForeColor = SystemColors.ButtonHighlight;
            libName.Location = new Point(87, 37);
            libName.Margin = new Padding(4, 0, 4, 0);
            libName.Name = "libName";
            libName.Size = new Size(176, 117);
            libName.TabIndex = 1;
            libName.Text = "Elimu Library";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Firefly_logo_of_library_64016;
            logo.Location = new Point(4, 37);
            logo.Margin = new Padding(4, 5, 4, 5);
            logo.Name = "logo";
            logo.Size = new Size(81, 78);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(picAdmin);
            panel1.Controls.Add(lbAdmin);
            panel1.Location = new Point(240, -3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 98);
            panel1.TabIndex = 0;
            // 
            // picAdmin
            // 
            picAdmin.Image = Properties.Resources.user_icon;
            picAdmin.Location = new Point(781, 10);
            picAdmin.Margin = new Padding(4, 5, 4, 5);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(104, 83);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 5;
            picAdmin.TabStop = false;
            picAdmin.Click += picAdmin_Click;
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbAdmin.ForeColor = SystemColors.ControlLightLight;
            lbAdmin.Location = new Point(663, 37);
            lbAdmin.Margin = new Padding(4, 0, 4, 0);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(100, 31);
            lbAdmin.TabIndex = 4;
            lbAdmin.Text = "Admin";
           
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(241, 96);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(904, 654);
            pnlContent.TabIndex = 3;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1143, 750);
            Controls.Add(pnlContent);
            Controls.Add(iconButton2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminPanel";
            Text = "AdminPanel";
            Load += AdminPanel_Load_1;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).EndInit();
            ResumeLayout(false);


        }

       



        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private Label lbLogout;
        private FontAwesome.Sharp.IconButton btnDash;
        private FontAwesome.Sharp.IconButton btnEditBooks;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnLibrarians;
        private Panel panel2;
        private Label libName;
        private PictureBox logo;
        private Panel panel1;
        private PictureBox picAdmin;
        private Label lbAdmin;
        private FontAwesome.Sharp.IconButton btnRequestedBooks;
        private FontAwesome.Sharp.IconButton btnBorrowedBooks;
        private Panel pnlContent;
    }
}