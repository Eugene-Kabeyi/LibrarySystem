﻿

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
            btnDash = new FontAwesome.Sharp.IconButton();
            btnEditBooks = new FontAwesome.Sharp.IconButton();
            btnMembers = new FontAwesome.Sharp.IconButton();
            btnLibrarians = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnRequestedBooks = new FontAwesome.Sharp.IconButton();
            btnBorrowedBooks = new FontAwesome.Sharp.IconButton();
            lblLogout = new Label();
            libName = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            picAdmin = new PictureBox();
            lblUsername = new Label();
            pnlContent = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdmin).BeginInit();
            SuspendLayout();
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
            btnDash.Location = new Point(0, 106);
            btnDash.Margin = new Padding(3, 10, 3, 10);
            btnDash.Name = "btnDash";
            btnDash.Padding = new Padding(10, 0, 20, 0);
            btnDash.Size = new Size(174, 36);
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
            btnEditBooks.Location = new Point(3, 237);
            btnEditBooks.Margin = new Padding(3, 10, 3, 10);
            btnEditBooks.Name = "btnEditBooks";
            btnEditBooks.Padding = new Padding(0, 0, 30, 0);
            btnEditBooks.Size = new Size(171, 36);
            btnEditBooks.TabIndex = 3;
            btnEditBooks.Text = "Books";
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
            btnMembers.Location = new Point(0, 196);
            btnMembers.Margin = new Padding(3, 10, 3, 10);
            btnMembers.Name = "btnMembers";
            btnMembers.Padding = new Padding(10, 0, 20, 0);
            btnMembers.Size = new Size(174, 36);
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
            btnLibrarians.Location = new Point(0, 151);
            btnLibrarians.Margin = new Padding(3, 10, 3, 10);
            btnLibrarians.Name = "btnLibrarians";
            btnLibrarians.Padding = new Padding(10, 0, 20, 0);
            btnLibrarians.Size = new Size(174, 36);
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
            panel2.Controls.Add(lblLogout);
            panel2.Controls.Add(btnMembers);
            panel2.Controls.Add(btnEditBooks);
            panel2.Controls.Add(btnDash);
            panel2.Controls.Add(libName);
            panel2.Controls.Add(logo);
            panel2.Location = new Point(-2, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 594);
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
            btnRequestedBooks.Location = new Point(3, 276);
            btnRequestedBooks.Margin = new Padding(3, 10, 3, 10);
            btnRequestedBooks.Name = "btnRequestedBooks";
            btnRequestedBooks.Padding = new Padding(10, 0, 30, 0);
            btnRequestedBooks.Size = new Size(174, 48);
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
            btnBorrowedBooks.Location = new Point(0, 327);
            btnBorrowedBooks.Margin = new Padding(3, 10, 3, 10);
            btnBorrowedBooks.Name = "btnBorrowedBooks";
            btnBorrowedBooks.Padding = new Padding(10, 0, 30, 0);
            btnBorrowedBooks.Size = new Size(175, 50);
            btnBorrowedBooks.TabIndex = 7;
            btnBorrowedBooks.Text = "Borrowed Books";
            btnBorrowedBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnBorrowedBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBorrowedBooks.UseVisualStyleBackColor = true;
            btnBorrowedBooks.Click += btnBorrowedBooks_Click;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.ForeColor = Color.Red;
            lblLogout.Location = new Point(51, 449);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(59, 18);
            lblLogout.TabIndex = 2;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
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
            logo.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(picAdmin);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(168, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 59);
            panel1.TabIndex = 0;
            // 
            // picAdmin
            // 
            picAdmin.Image = Properties.Resources.user_icon;
            picAdmin.Location = new Point(773, 6);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(73, 50);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 5;
            picAdmin.TabStop = false;
            picAdmin.Click += picAdmin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(686, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(72, 24);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Admin";
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(176, 59);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(848, 520);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint_1;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1023, 581);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private FontAwesome.Sharp.IconButton btnDash;
        private FontAwesome.Sharp.IconButton btnEditBooks;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnLibrarians;
        private Panel panel2;
        private Label libName;
        private PictureBox logo;
        private Panel panel1;
        private PictureBox picAdmin;
        private Label lblUsername;
        private FontAwesome.Sharp.IconButton btnRequestedBooks;
        private FontAwesome.Sharp.IconButton btnBorrowedBooks;
        private Label lblLogout;
        private Panel pnlContent;
    }
}