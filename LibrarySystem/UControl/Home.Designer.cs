namespace LibrarySystem.UControl
{
    partial class Home
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
            userName = new Label();
            pictureBox1 = new PictureBox();
            panel8 = new Panel();
            lblBorrowed = new Label();
            label8 = new Label();
            panel9 = new Panel();
            lblRequested = new Label();
            label10 = new Label();
            lblBook4 = new Label();
            lblBook2 = new Label();
            lblBook3 = new Label();
            lblBook1 = new Label();
            label13 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblFine = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(13, 11);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(128, 29);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome,";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userName.Location = new Point(142, 11);
            userName.Name = "userName";
            userName.Size = new Size(71, 29);
            userName.TabIndex = 2;
            userName.Text = "user ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.liblib;
            pictureBox1.Location = new Point(13, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(834, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Highlight;
            panel8.Controls.Add(lblBorrowed);
            panel8.Controls.Add(label8);
            panel8.Font = new Font("Modern No. 20", 11.9999981F);
            panel8.ForeColor = SystemColors.ControlLightLight;
            panel8.Location = new Point(322, 220);
            panel8.Name = "panel8";
            panel8.Size = new Size(125, 121);
            panel8.TabIndex = 16;
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
            panel9.Location = new Point(171, 220);
            panel9.Name = "panel9";
            panel9.Size = new Size(130, 121);
            panel9.TabIndex = 17;
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
            // lblBook4
            // 
            lblBook4.AutoSize = true;
            lblBook4.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook4.Location = new Point(40, 470);
            lblBook4.Name = "lblBook4";
            lblBook4.Size = new Size(52, 17);
            lblBook4.TabIndex = 27;
            lblBook4.Text = "Book 4";
            // 
            // lblBook2
            // 
            lblBook2.AutoSize = true;
            lblBook2.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook2.Location = new Point(40, 426);
            lblBook2.Name = "lblBook2";
            lblBook2.Size = new Size(52, 17);
            lblBook2.TabIndex = 26;
            lblBook2.Text = "Book 2";
            // 
            // lblBook3
            // 
            lblBook3.AutoSize = true;
            lblBook3.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook3.Location = new Point(40, 448);
            lblBook3.Name = "lblBook3";
            lblBook3.Size = new Size(52, 17);
            lblBook3.TabIndex = 25;
            lblBook3.Text = "Book 3";
            // 
            // lblBook1
            // 
            lblBook1.AutoSize = true;
            lblBook1.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Italic);
            lblBook1.Location = new Point(40, 405);
            lblBook1.Name = "lblBook1";
            lblBook1.Size = new Size(52, 17);
            lblBook1.TabIndex = 24;
            lblBook1.Text = "Book 1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(32, 378);
            label13.Name = "label13";
            label13.Size = new Size(205, 21);
            label13.TabIndex = 23;
            label13.Text = "Recently Added Books";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 346);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 22;
            label1.Text = "Recent Activities";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(lblFine);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Modern No. 20", 11.9999981F);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(471, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 121);
            panel1.TabIndex = 17;
            // 
            // lblFine
            // 
            lblFine.AutoSize = true;
            lblFine.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFine.Location = new Point(77, 42);
            lblFine.Name = "lblFine";
            lblFine.Size = new Size(45, 50);
            lblFine.TabIndex = 7;
            lblFine.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            label3.Location = new Point(53, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(106, 18);
            label3.TabIndex = 1;
            label3.Text = "Fine Amount";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblBook4);
            Controls.Add(lblBook2);
            Controls.Add(lblBook3);
            Controls.Add(lblBook1);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(pictureBox1);
            Controls.Add(userName);
            Controls.Add(lblWelcome);
            Name = "Home";
            Size = new Size(850, 490);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label userName;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Label lblBorrowed;
        private Label label8;
        private Panel panel9;
        private Label lblRequested;
        private Label label10;
        private Label lblBook4;
        private Label lblBook2;
        private Label lblBook3;
        private Label lblBook1;
        private Label label13;
        private Label label1;
        private Panel panel1;
        private Label lblFine;
        private Label label3;
    }
}
