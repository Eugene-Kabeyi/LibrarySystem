namespace LibrarySystem
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtName = new TextBox();
            lblUsername = new Label();
            email = new Label();
            name = new Label();
            user_pic = new PictureBox();
            label1 = new Label();
            uploadPic = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)user_pic).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(347, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(347, 181);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(184, 23);
            txtUsername.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(347, 76);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(184, 23);
            txtName.TabIndex = 16;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Modern No. 20", 11.9999981F);
            lblUsername.Location = new Point(266, 184);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 18);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "UserName";
            lblUsername.Click += contact_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Modern No. 20", 11.9999981F);
            email.Location = new Point(266, 130);
            email.Name = "email";
            email.Size = new Size(48, 18);
            email.TabIndex = 14;
            email.Text = "Email";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Modern No. 20", 11.9999981F);
            name.Location = new Point(266, 79);
            name.Name = "name";
            name.Size = new Size(44, 18);
            name.TabIndex = 13;
            name.Text = "Name";
            // 
            // user_pic
            // 
            user_pic.Location = new Point(23, 79);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(146, 137);
            user_pic.SizeMode = PictureBoxSizeMode.Zoom;
            user_pic.TabIndex = 12;
            user_pic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(236, 36);
            label1.TabIndex = 11;
            label1.Text = "Admin Profile";
            // 
            // uploadPic
            // 
            uploadPic.BackColor = SystemColors.Highlight;
            uploadPic.FlatStyle = FlatStyle.Flat;
            uploadPic.Font = new Font("Modern No. 20", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uploadPic.ForeColor = SystemColors.ControlLightLight;
            uploadPic.IconChar = FontAwesome.Sharp.IconChar.Upload;
            uploadPic.IconColor = Color.White;
            uploadPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            uploadPic.IconSize = 22;
            uploadPic.Location = new Point(42, 256);
            uploadPic.Name = "uploadPic";
            uploadPic.Padding = new Padding(10, 0, 0, 0);
            uploadPic.Size = new Size(103, 40);
            uploadPic.TabIndex = 55;
            uploadPic.Text = "Upload Picture";
            uploadPic.TextAlign = ContentAlignment.MiddleLeft;
            uploadPic.TextImageRelation = TextImageRelation.ImageBeforeText;
            uploadPic.UseVisualStyleBackColor = false;
            uploadPic.Visible = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 22;
            btnEdit.Location = new Point(266, 262);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 54;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.Location = new Point(422, 262);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(103, 34);
            btnSave.TabIndex = 53;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 360);
            Controls.Add(uploadPic);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(lblUsername);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(user_pic);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminProfile";
            Text = "AdminProfile";
            Load += AdminProfile_Load;
            ((System.ComponentModel.ISupportInitialize)user_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtName;
        private Label lblUsername;
        private Label email;
        private Label name;
        private PictureBox user_pic;
        private Label label1;
        private FontAwesome.Sharp.IconButton uploadPic;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}