
namespace LibrarySystem
{
    partial class UserProfile
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
            uploadPic = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            txtLname = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            txtFname = new TextBox();
            email = new Label();
            name = new Label();
            user_pic = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)user_pic).BeginInit();
            SuspendLayout();
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
            uploadPic.Location = new Point(37, 262);
            uploadPic.Name = "uploadPic";
            uploadPic.Padding = new Padding(10, 0, 0, 0);
            uploadPic.Size = new Size(103, 40);
            uploadPic.TabIndex = 52;
            uploadPic.Text = "Upload Picture";
            uploadPic.TextAlign = ContentAlignment.MiddleLeft;
            uploadPic.TextImageRelation = TextImageRelation.ImageBeforeText;
            uploadPic.UseVisualStyleBackColor = false;
            uploadPic.Visible = false;
            uploadPic.Click += btnPic_Click;
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
            btnEdit.Location = new Point(261, 268);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 51;
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
            btnSave.Location = new Point(417, 268);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(103, 34);
            btnSave.TabIndex = 50;
            btnSave.Text = "SAVE";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(336, 147);
            txtLname.Name = "txtLname";
            txtLname.ReadOnly = true;
            txtLname.Size = new Size(184, 23);
            txtLname.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11.9999981F);
            label2.Location = new Point(237, 150);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 48;
            label2.Text = "Lastname";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(336, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 47;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(336, 90);
            txtFname.Name = "txtFname";
            txtFname.ReadOnly = true;
            txtFname.Size = new Size(184, 23);
            txtFname.TabIndex = 46;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Modern No. 20", 11.9999981F);
            email.Location = new Point(237, 209);
            email.Name = "email";
            email.Size = new Size(48, 18);
            email.TabIndex = 45;
            email.Text = "Email";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Modern No. 20", 11.9999981F);
            name.Location = new Point(237, 93);
            name.Name = "name";
            name.Size = new Size(74, 18);
            name.TabIndex = 44;
            name.Text = "Firstname";
            // 
            // user_pic
            // 
            user_pic.Location = new Point(12, 90);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(146, 137);
            user_pic.SizeMode = PictureBoxSizeMode.Zoom;
            user_pic.TabIndex = 43;
            user_pic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 20);
            label1.Name = "label1";
            label1.Size = new Size(202, 36);
            label1.TabIndex = 42;
            label1.Text = "User Profile";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 374);
            Controls.Add(uploadPic);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(txtLname);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtFname);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(user_pic);
            Controls.Add(label1);
            Name = "UserProfile";
            Text = "Uprofile";
            Load += UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)user_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private FontAwesome.Sharp.IconButton uploadPic;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnSave;
        private TextBox txtLname;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtFname;
        private Label email;
        private Label name;
        private PictureBox user_pic;
        private Label label1;
    }
}