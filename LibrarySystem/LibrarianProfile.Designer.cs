namespace LibrarySystem
{
    partial class LibrarianProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianProfile));
            label1 = new Label();
            uploadPic = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtName = new TextBox();
            lblUsername = new Label();
            email = new Label();
            name = new Label();
            user_pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)user_pic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 36);
            label1.TabIndex = 11;
            label1.Text = "Librarian Profile";
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
            uploadPic.Location = new Point(57, 257);
            uploadPic.Name = "uploadPic";
            uploadPic.Padding = new Padding(10, 0, 0, 0);
            uploadPic.Size = new Size(103, 40);
            uploadPic.TabIndex = 65;
            uploadPic.Text = "Upload Picture";
            uploadPic.TextAlign = ContentAlignment.MiddleLeft;
            uploadPic.TextImageRelation = TextImageRelation.ImageBeforeText;
            uploadPic.UseVisualStyleBackColor = false;
            uploadPic.Visible = false;
            uploadPic.Click += uploadPic_Click;
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
            btnEdit.Location = new Point(281, 263);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 64;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnSave.Location = new Point(437, 263);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(103, 34);
            btnSave.TabIndex = 63;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(362, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 62;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(362, 182);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(184, 23);
            txtUsername.TabIndex = 61;
            // 
            // txtName
            // 
            txtName.Location = new Point(362, 77);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(184, 23);
            txtName.TabIndex = 60;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Modern No. 20", 11.9999981F);
            lblUsername.Location = new Point(281, 185);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 18);
            lblUsername.TabIndex = 59;
            lblUsername.Text = "UserName";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Modern No. 20", 11.9999981F);
            email.Location = new Point(281, 131);
            email.Name = "email";
            email.Size = new Size(48, 18);
            email.TabIndex = 58;
            email.Text = "Email";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Modern No. 20", 11.9999981F);
            name.Location = new Point(281, 80);
            name.Name = "name";
            name.Size = new Size(44, 18);
            name.TabIndex = 57;
            name.Text = "Name";
            // 
            // user_pic
            // 
            user_pic.Location = new Point(38, 80);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(146, 137);
            user_pic.SizeMode = PictureBoxSizeMode.Zoom;
            user_pic.TabIndex = 56;
            user_pic.TabStop = false;
            // 
            // LibrarianProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 356);
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
            Name = "LibrarianProfile";
            Text = "LibrarianProfile";
            Load += LibrarianProfile_Load;
            ((System.ComponentModel.ISupportInitialize)user_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FontAwesome.Sharp.IconButton uploadPic;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnSave;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtName;
        private Label lblUsername;
        private Label email;
        private Label name;
        private PictureBox user_pic;
    }
}