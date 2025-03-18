namespace LibrarySystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtFirstname = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtConmfirmPass = new TextBox();
            checkBoxTOC = new CheckBox();
            btnCreateAccount = new Button();
            label7 = new Label();
            lblToLogin = new LinkLabel();
            rdBtnMale = new RadioButton();
            rdBtnFemale = new RadioButton();
            panel1 = new Panel();
            label8 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // txtFirstname
            // 
            txtFirstname.Location = new Point(54, 215);
            txtFirstname.Margin = new Padding(4, 5, 4, 5);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(264, 31);
            txtFirstname.TabIndex = 2;
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
            // txtLastName
            // 
            txtLastName.Location = new Point(351, 215);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(264, 31);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11.249999F);
            label3.Location = new Point(54, 275);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(54, 353);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 390);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(561, 31);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 11.249999F);
            label5.Location = new Point(54, 445);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 485);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 31);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 11.249999F);
            label6.Location = new Point(357, 445);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 25);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password";
            // 
            // txtConmfirmPass
            // 
            txtConmfirmPass.Location = new Point(351, 485);
            txtConmfirmPass.Margin = new Padding(4, 5, 4, 5);
            txtConmfirmPass.Name = "txtConmfirmPass";
            txtConmfirmPass.Size = new Size(264, 31);
            txtConmfirmPass.TabIndex = 13;
            txtConmfirmPass.UseSystemPasswordChar = true;
            // 
            // checkBoxTOC
            // 
            checkBoxTOC.AutoSize = true;
            checkBoxTOC.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxTOC.Location = new Point(54, 553);
            checkBoxTOC.Margin = new Padding(4, 5, 4, 5);
            checkBoxTOC.Name = "checkBoxTOC";
            checkBoxTOC.Size = new Size(454, 25);
            checkBoxTOC.TabIndex = 14;
            checkBoxTOC.Text = "I agree to the Library Terms of Service and Privacy Policy";
            checkBoxTOC.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = SystemColors.Highlight;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Modern No. 20", 11.249999F);
            btnCreateAccount.ForeColor = SystemColors.ControlLightLight;
            btnCreateAccount.Location = new Point(194, 618);
            btnCreateAccount.Margin = new Padding(4, 5, 4, 5);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(243, 55);
            btnCreateAccount.TabIndex = 15;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 9.75F);
            label7.Location = new Point(160, 722);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(230, 22);
            label7.TabIndex = 16;
            label7.Text = "Already Have An Account?";
            // 
            // lblToLogin
            // 
            lblToLogin.AutoSize = true;
            lblToLogin.Font = new Font("Modern No. 20", 9.75F);
            lblToLogin.Location = new Point(379, 720);
            lblToLogin.Margin = new Padding(4, 0, 4, 0);
            lblToLogin.Name = "lblToLogin";
            lblToLogin.Size = new Size(59, 22);
            lblToLogin.TabIndex = 17;
            lblToLogin.TabStop = true;
            lblToLogin.Text = "Login";
            lblToLogin.LinkClicked += lblToLogin_Click;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Font = new Font("Modern No. 20", 11.249999F);
            rdBtnMale.Location = new Point(234, 313);
            rdBtnMale.Margin = new Padding(4, 5, 4, 5);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(84, 29);
            rdBtnMale.TabIndex = 18;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Male";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Font = new Font("Modern No. 20", 11.249999F);
            rdBtnFemale.Location = new Point(61, 313);
            rdBtnFemale.Margin = new Padding(4, 5, 4, 5);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(104, 29);
            rdBtnFemale.TabIndex = 19;
            rdBtnFemale.TabStop = true;
            rdBtnFemale.Text = "Female";
            rdBtnFemale.UseVisualStyleBackColor = true;
            rdBtnFemale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtFirstname);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblToLogin);
            panel1.Controls.Add(rdBtnFemale);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCreateAccount);
            panel1.Controls.Add(rdBtnMale);
            panel1.Controls.Add(checkBoxTOC);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConmfirmPass);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(46, 28);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 809);
            panel1.TabIndex = 20;
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 875);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtFirstname;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtConmfirmPass;
        private CheckBox checkBoxTOC;
        private Button btnCreateAccount;
        private Label label7;
        private LinkLabel lblToLogin;
        private RadioButton rdBtnMale;
        private RadioButton rdBtnFemale;
        private Panel panel1;
        private Label label8;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}