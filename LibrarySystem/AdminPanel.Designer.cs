﻿namespace LibrarySystem
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
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            btnDash = new FontAwesome.Sharp.IconButton();
            btnBooks = new FontAwesome.Sharp.IconButton();
            btnMembers = new FontAwesome.Sharp.IconButton();
            btnLibrarians = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            libName = new Label();
            logo = new PictureBox();
            panel1 = new Panel();
            picAdmin = new PictureBox();
            lbAdmin = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
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
            iconButton2.Location = new Point(360, 222);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(8, 8);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(61, 404);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 2;
            label5.Text = "Logout";
            label5.Click += label5_Click;
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
            btnDash.Click += btnOverview_Click;
            // 
            // btnBooks
            // 
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatStyle = FlatStyle.Flat;
            btnBooks.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = SystemColors.ControlLightLight;
            btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnBooks.IconColor = Color.White;
            btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBooks.IconSize = 30;
            btnBooks.Location = new Point(3, 237);
            btnBooks.Margin = new Padding(3, 10, 3, 10);
            btnBooks.Name = "btnBooks";
            btnBooks.Padding = new Padding(10, 0, 30, 0);
            btnBooks.Size = new Size(171, 36);
            btnBooks.TabIndex = 3;
            btnBooks.Text = "Edit Books";
            btnBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnBooks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBooks.UseVisualStyleBackColor = true;
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
            btnLibrarians.Click += iconButton3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(iconButton3);
            panel2.Controls.Add(btnLibrarians);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(btnMembers);
            panel2.Controls.Add(btnBooks);
            panel2.Controls.Add(btnDash);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(libName);
            panel2.Controls.Add(logo);
            panel2.Location = new Point(-2, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 458);
            panel2.TabIndex = 1;
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
            panel1.Controls.Add(lbAdmin);
            panel1.Location = new Point(168, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 59);
            panel1.TabIndex = 0;
            // 
            // picAdmin
            // 
            picAdmin.Image = Properties.Resources.user_icon;
            picAdmin.Location = new Point(547, 6);
            picAdmin.Name = "picAdmin";
            picAdmin.Size = new Size(73, 50);
            picAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            picAdmin.TabIndex = 5;
            picAdmin.TabStop = false;
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbAdmin.ForeColor = SystemColors.ControlLightLight;
            lbAdmin.Location = new Point(464, 22);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(67, 21);
            lbAdmin.TabIndex = 4;
            lbAdmin.Text = "Admin";
            lbAdmin.Click += label3_Click_1;
            // 
            // iconButton3
            // 
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = SystemColors.ControlLightLight;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.Location = new Point(0, 323);
            iconButton3.Margin = new Padding(3, 10, 3, 10);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 30, 0);
            iconButton3.Size = new Size(174, 48);
            iconButton3.TabIndex = 8;
            iconButton3.Text = "Reserved Books";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(0, 270);
            iconButton1.Margin = new Padding(3, 10, 3, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 30, 0);
            iconButton1.Size = new Size(175, 50);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Borrowed Books";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(iconButton2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label5;
        private FontAwesome.Sharp.IconButton btnDash;
        private FontAwesome.Sharp.IconButton btnBooks;
        private FontAwesome.Sharp.IconButton btnMembers;
        private FontAwesome.Sharp.IconButton btnLibrarians;
        private Panel panel2;
        private Label libName;
        private PictureBox logo;
        private Panel panel1;
        private PictureBox picAdmin;
        private Label lbAdmin;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}