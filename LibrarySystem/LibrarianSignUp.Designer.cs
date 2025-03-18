namespace LibrarySystem
{
    partial class LibrarianSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianSignUp));
            txtUsername = new TextBox();
            userName = new Label();
            label8 = new Label();
            txtFirstname = new TextBox();
            pictureBox1 = new PictureBox();
            rdBtnFemale = new RadioButton();
            label1 = new Label();
            btnCreateAccount = new Button();
            rdBtnMale = new RadioButton();
            label2 = new Label();
            txtConfirmPass = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtLastname = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(54, 455);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(561, 31);
            txtUsername.TabIndex = 22;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Font = new Font("Modern No. 20", 11.249999F);
            userName.Location = new Point(54, 424);
            userName.Margin = new Padding(4, 0, 4, 0);
            userName.Name = "userName";
            userName.Size = new Size(103, 25);
            userName.TabIndex = 21;
            userName.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(90, 98);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(488, 42);
            label8.TabIndex = 20;
            label8.Text = "Welcome to Elimu Library";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(54, 215);
            txtFirstname.Margin = new Padding(4, 5, 4, 5);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(264, 31);
            txtFirstname.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(287, 7);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Font = new Font("Modern No. 20", 11.249999F);
            rdBtnFemale.Location = new Point(61, 295);
            rdBtnFemale.Margin = new Padding(4, 5, 4, 5);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(104, 29);
            rdBtnFemale.TabIndex = 19;
            rdBtnFemale.TabStop = true;
            rdBtnFemale.Text = "Female";
            rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.249999F);
            label1.Location = new Point(54, 182);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = SystemColors.Highlight;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Modern No. 20", 11.249999F);
            btnCreateAccount.ForeColor = SystemColors.ControlLightLight;
            btnCreateAccount.Location = new Point(194, 615);
            btnCreateAccount.Margin = new Padding(4, 5, 4, 5);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(243, 55);
            btnCreateAccount.TabIndex = 15;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Font = new Font("Modern No. 20", 11.249999F);
            rdBtnMale.Location = new Point(234, 295);
            rdBtnMale.Margin = new Padding(4, 5, 4, 5);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(84, 29);
            rdBtnMale.TabIndex = 18;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Male";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(351, 182);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(351, 534);
            txtConfirmPass.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(264, 31);
            txtConfirmPass.TabIndex = 13;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 11.249999F);
            label6.Location = new Point(357, 500);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 25);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 534);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(264, 31);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 374);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(561, 31);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 11.249999F);
            label5.Location = new Point(54, 500);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(54, 337);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11.249999F);
            label3.Location = new Point(54, 257);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(351, 215);
            txtLastname.Margin = new Padding(4, 5, 4, 5);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(264, 31);
            txtLastname.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(userName);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtFirstname);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(rdBtnFemale);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCreateAccount);
            panel1.Controls.Add(rdBtnMale);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConfirmPass);
            panel1.Controls.Add(txtLastname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(61, 14);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 715);
            panel1.TabIndex = 24;
            // 
            // LibrarianSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 754);
            Controls.Add(panel1);
            Name = "LibrarianSignUp";
            Text = "LibrarianSignUp";
            Load += LibrarianSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtUsername;
        private Label userName;
        private Label label8;
        private TextBox txtFirstname;
        private PictureBox pictureBox1;
        private RadioButton rdBtnFemale;
        private Label label1;
        private Button btnCreateAccount;
        private RadioButton rdBtnMale;
        private Label label2;
        private TextBox txtConfirmPass;
        private Label label6;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtLastname;
        private Panel panel1;
    }
}