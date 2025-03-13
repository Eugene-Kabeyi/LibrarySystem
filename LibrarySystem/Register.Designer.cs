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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
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
            pictureBox1.Location = new Point(201, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.249999F);
            label1.Location = new Point(38, 109);
            label1.Name = "label1";
            label1.Size = new Size(76, 17);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(246, 109);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11.249999F);
            label3.Location = new Point(38, 165);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(38, 212);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 234);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(394, 23);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 11.249999F);
            label5.Location = new Point(38, 267);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(38, 291);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 23);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Modern No. 20", 11.249999F);
            label6.Location = new Point(250, 267);
            label6.Name = "label6";
            label6.Size = new Size(119, 17);
            label6.TabIndex = 12;
            label6.Text = "Confirm Password";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(246, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(186, 23);
            textBox5.TabIndex = 13;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(38, 332);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(312, 19);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "I agree to the Library Terms of Service and Privacy Policy";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Modern No. 20", 11.249999F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(136, 371);
            button1.Name = "button1";
            button1.Size = new Size(170, 33);
            button1.TabIndex = 15;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 9.75F);
            label7.Location = new Point(112, 433);
            label7.Name = "label7";
            label7.Size = new Size(152, 15);
            label7.TabIndex = 16;
            label7.Text = "Already Have An Account?";
            label7.Click += label7_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Modern No. 20", 9.75F);
            linkLabel1.Location = new Point(265, 432);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(39, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Font = new Font("Modern No. 20", 11.249999F);
            rdBtnMale.Location = new Point(164, 188);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(57, 21);
            rdBtnMale.TabIndex = 18;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Male";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Font = new Font("Modern No. 20", 11.249999F);
            rdBtnFemale.Location = new Point(43, 188);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(70, 21);
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
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(rdBtnFemale);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(rdBtnMale);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(32, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 486);
            panel1.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(63, 59);
            label8.Name = "label8";
            label8.Size = new Size(341, 29);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 525);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private CheckBox checkBox3;
        private Button button1;
        private Label label7;
        private LinkLabel linkLabel1;
        private RadioButton rdBtnMale;
        private RadioButton rdBtnFemale;
        private Panel panel1;
        private Label label8;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}