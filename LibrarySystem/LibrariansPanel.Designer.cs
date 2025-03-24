namespace LibrarySystem
{
    partial class LibrariansPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrariansPanel));
            btnMembers = new FontAwesome.Sharp.IconButton();
            btnEditBooks = new FontAwesome.Sharp.IconButton();
            btnLibDash = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lblLogout = new Label();
            btnRequestedBooks = new FontAwesome.Sharp.IconButton();
            btnBorrowedBooks = new FontAwesome.Sharp.IconButton();
            libName = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            picLibrarian = new PictureBox();
            lblUsername = new Label();
            pnlContent = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLibrarian).BeginInit();
            SuspendLayout();
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
            btnMembers.Location = new Point(0, 162);
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
            btnEditBooks.Location = new Point(0, 210);
            btnEditBooks.Margin = new Padding(3, 10, 3, 10);
            btnEditBooks.Name = "btnEditBooks";
            btnEditBooks.Padding = new Padding(0, 0, 30, 0);
            btnEditBooks.Size = new Size(174, 36);
            btnEditBooks.TabIndex = 3;
            btnEditBooks.Text = "Books";
            btnEditBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnEditBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditBooks.UseVisualStyleBackColor = true;
            btnEditBooks.Click += btnEditBooks_Click;
            // 
            // btnLibDash
            // 
            btnLibDash.FlatAppearance.BorderSize = 0;
            btnLibDash.FlatStyle = FlatStyle.Flat;
            btnLibDash.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibDash.ForeColor = SystemColors.ControlLightLight;
            btnLibDash.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            btnLibDash.IconColor = Color.White;
            btnLibDash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibDash.IconSize = 30;
            btnLibDash.Location = new Point(0, 106);
            btnLibDash.Margin = new Padding(3, 10, 3, 10);
            btnLibDash.Name = "btnLibDash";
            btnLibDash.Padding = new Padding(10, 0, 20, 0);
            btnLibDash.Size = new Size(174, 36);
            btnLibDash.TabIndex = 2;
            btnLibDash.Text = "Dashboard";
            btnLibDash.TextAlign = ContentAlignment.MiddleLeft;
            btnLibDash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibDash.UseVisualStyleBackColor = true;
            btnLibDash.Click += btnLibDash_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(lblLogout);
            panel2.Controls.Add(btnRequestedBooks);
            panel2.Controls.Add(btnBorrowedBooks);
            panel2.Controls.Add(btnMembers);
            panel2.Controls.Add(btnEditBooks);
            panel2.Controls.Add(btnLibDash);
            panel2.Controls.Add(libName);
            panel2.Controls.Add(logo);
            panel2.Location = new Point(-1, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 603);
            panel2.TabIndex = 4;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogout.ForeColor = Color.Red;
            lblLogout.Location = new Point(44, 457);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(59, 18);
            lblLogout.TabIndex = 7;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
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
            btnRequestedBooks.Location = new Point(0, 255);
            btnRequestedBooks.Margin = new Padding(3, 10, 3, 10);
            btnRequestedBooks.Name = "btnRequestedBooks";
            btnRequestedBooks.Padding = new Padding(10, 0, 30, 0);
            btnRequestedBooks.Size = new Size(174, 48);
            btnRequestedBooks.TabIndex = 6;
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
            btnBorrowedBooks.Location = new Point(0, 309);
            btnBorrowedBooks.Margin = new Padding(3, 10, 3, 10);
            btnBorrowedBooks.Name = "btnBorrowedBooks";
            btnBorrowedBooks.Padding = new Padding(10, 0, 30, 0);
            btnBorrowedBooks.Size = new Size(175, 50);
            btnBorrowedBooks.TabIndex = 5;
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
            panel1.Controls.Add(picLibrarian);
            panel1.Controls.Add(lblUsername);
            panel1.Location = new Point(169, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 59);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // picLibrarian
            // 
            picLibrarian.Image = Properties.Resources.user_icon;
            picLibrarian.Location = new Point(761, 6);
            picLibrarian.Name = "picLibrarian";
            picLibrarian.Size = new Size(73, 50);
            picLibrarian.SizeMode = PictureBoxSizeMode.Zoom;
            picLibrarian.TabIndex = 5;
            picLibrarian.TabStop = false;
            picLibrarian.Click += picLibrarian_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ControlLightLight;
            lblUsername.Location = new Point(656, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 24);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Librarian";
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(179, 64);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(824, 520);
            pnlContent.TabIndex = 5;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // LibrariansPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 587);
            Controls.Add(pnlContent);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LibrariansPanel";
            Text = "LibrariansPanel";
            Load += LibrariansPanel_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLibrarian).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnEditBooks;
        private FontAwesome.Sharp.IconButton btnLibDash;
        private Panel panel2;
        private Label libName;
        private PictureBox logo;
        private Panel panel1;
        private PictureBox picLibrarian;
        private Label lblUsername;
        private FontAwesome.Sharp.IconButton btnRequestedBooks;
        private FontAwesome.Sharp.IconButton btnBorrowedBooks;
        private Panel pnlContent;
        private Label lblLogout;
    }
}