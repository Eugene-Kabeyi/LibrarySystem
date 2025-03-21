namespace LibrarySystem.UControl
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            label1 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            lblBooks = new Label();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            lblUsers = new Label();
            label6 = new Label();
            panel8 = new Panel();
            lblBorrowed = new Label();
            label8 = new Label();
            panel9 = new Panel();
            lblRequested = new Label();
            label10 = new Label();
            label13 = new Label();
            lblBook1 = new Label();
            label15 = new Label();
            lblBook3 = new Label();
            lblBook2 = new Label();
            lblBook4 = new Label();
            lblStaff = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(226, 29);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 18);
            label1.TabIndex = 1;
            label1.Text = "Total Books";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 352);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 4;
            label4.Text = "Recent Activities";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.liblib;
            pictureBox1.Location = new Point(23, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(746, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(lblBooks);
            panel5.Controls.Add(label1);
            panel5.Font = new Font("Modern No. 20", 11.9999981F);
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(20, 220);
            panel5.Name = "panel5";
            panel5.Size = new Size(125, 121);
            panel5.TabIndex = 14;
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBooks.Location = new Point(38, 42);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(45, 50);
            lblBooks.TabIndex = 7;
            lblBooks.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Controls.Add(lblStaff);
            panel6.Controls.Add(label2);
            panel6.Font = new Font("Modern No. 20", 11.9999981F);
            panel6.ForeColor = SystemColors.ControlLightLight;
            panel6.Location = new Point(612, 220);
            panel6.Name = "panel6";
            panel6.Size = new Size(136, 121);
            panel6.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            label2.Location = new Point(-1, 12);
            label2.Name = "label2";
            label2.Size = new Size(140, 18);
            label2.TabIndex = 1;
            label2.Text = "No. of Librarians";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Highlight;
            panel7.Controls.Add(lblUsers);
            panel7.Controls.Add(label6);
            panel7.Font = new Font("Modern No. 20", 11.9999981F);
            panel7.ForeColor = SystemColors.ControlLightLight;
            panel7.Location = new Point(468, 220);
            panel7.Name = "panel7";
            panel7.Size = new Size(125, 121);
            panel7.TabIndex = 15;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsers.Location = new Point(44, 42);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(45, 50);
            lblUsers.TabIndex = 7;
            lblUsers.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            label6.Location = new Point(2, 12);
            label6.Name = "label6";
            label6.Size = new Size(125, 18);
            label6.TabIndex = 1;
            label6.Text = "No. of Members";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Highlight;
            panel8.Controls.Add(lblBorrowed);
            panel8.Controls.Add(label8);
            panel8.Font = new Font("Modern No. 20", 11.9999981F);
            panel8.ForeColor = SystemColors.ControlLightLight;
            panel8.Location = new Point(320, 220);
            panel8.Name = "panel8";
            panel8.Size = new Size(125, 121);
            panel8.TabIndex = 15;
            // 
            // lblBorrowed
            // 
            lblBorrowed.AutoSize = true;
            lblBorrowed.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBorrowed.Location = new Point(41, 42);
            lblBorrowed.Name = "lblBorrowed";
            lblBorrowed.Size = new Size(45, 50);
            lblBorrowed.TabIndex = 7;
            lblBorrowed.Text = "0";
            lblBorrowed.Click += label11_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            label8.Location = new Point(0, 12);
            label8.Name = "label8";
            label8.Size = new Size(127, 18);
            label8.TabIndex = 1;
            label8.Text = "Borrowed Books";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Highlight;
            panel9.Controls.Add(lblRequested);
            panel9.Controls.Add(label10);
            panel9.Font = new Font("Modern No. 20", 11.9999981F);
            panel9.ForeColor = SystemColors.ControlLightLight;
            panel9.Location = new Point(169, 220);
            panel9.Name = "panel9";
            panel9.Size = new Size(130, 121);
            panel9.TabIndex = 15;
            // 
            // lblRequested
            // 
            lblRequested.AutoSize = true;
            lblRequested.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequested.Location = new Point(44, 42);
            lblRequested.Name = "lblRequested";
            lblRequested.Size = new Size(45, 50);
            lblRequested.TabIndex = 7;
            lblRequested.Text = "0";
            lblRequested.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            label10.Location = new Point(0, 12);
            label10.Name = "label10";
            label10.Size = new Size(131, 18);
            label10.TabIndex = 1;
            label10.Text = "Requested Books";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(39, 384);
            label13.Name = "label13";
            label13.Size = new Size(182, 21);
            label13.TabIndex = 16;
            label13.Text = "Newly Added Books";
            label13.Click += label13_Click;
            // 
            // lblBook1
            // 
            lblBook1.AutoSize = true;
            lblBook1.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook1.Location = new Point(47, 411);
            lblBook1.Name = "lblBook1";
            lblBook1.Size = new Size(52, 17);
            lblBook1.TabIndex = 17;
            lblBook1.Text = "Book 1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(47, 476);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 18;
            label15.Text = "label15";
            // 
            // lblBook3
            // 
            lblBook3.AutoSize = true;
            lblBook3.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook3.Location = new Point(47, 454);
            lblBook3.Name = "lblBook3";
            lblBook3.Size = new Size(52, 17);
            lblBook3.TabIndex = 19;
            lblBook3.Text = "Book 3";
            // 
            // lblBook2
            // 
            lblBook2.AutoSize = true;
            lblBook2.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook2.Location = new Point(47, 432);
            lblBook2.Name = "lblBook2";
            lblBook2.Size = new Size(52, 17);
            lblBook2.TabIndex = 20;
            lblBook2.Text = "Book 2";
            // 
            // lblBook4
            // 
            lblBook4.AutoSize = true;
            lblBook4.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook4.Location = new Point(47, 476);
            lblBook4.Name = "lblBook4";
            lblBook4.Size = new Size(52, 17);
            lblBook4.TabIndex = 21;
            lblBook4.Text = "Book 4";
            lblBook4.Click += label18_Click;
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStaff.Location = new Point(43, 42);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(45, 50);
            lblStaff.TabIndex = 8;
            lblStaff.Text = "0";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblBook4);
            Controls.Add(lblBook2);
            Controls.Add(lblBook3);
            Controls.Add(label15);
            Controls.Add(lblBook1);
            Controls.Add(label13);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lblWelcome);
            Name = "Dashboard";
            Size = new Size(800, 500);
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblWelcome;
        private Label label1;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private Panel panel7;
        private Label label6;
        private Panel panel8;
        private Label label8;
        private Panel panel9;
        private Label label10;
        private Label lblBooks;
        private Label lblStaff;
        private Label lblUsers;
        private Label lblBorrowed;
        private Label lblRequested;
        private Label label13;
        private Label lblBook1;
        private Label label15;
        private Label lblBook3;
        private Label lblBook2;
        private Label lblBook4;
    }

        #endregion
    
}
