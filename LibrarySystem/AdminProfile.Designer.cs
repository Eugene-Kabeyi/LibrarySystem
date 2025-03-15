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
            btnSave = new Button();
            btnEdit = new Button();
            btnPic = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtName = new TextBox();
            contact = new Label();
            email = new Label();
            name = new Label();
            user_pic = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)user_pic).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F);
            btnSave.Location = new Point(431, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 39);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Modern No. 20", 11.9999981F);
            btnEdit.Location = new Point(277, 252);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 39);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnPic
            // 
            btnPic.FlatStyle = FlatStyle.Popup;
            btnPic.Font = new Font("Modern No. 20", 11.9999981F);
            btnPic.Location = new Point(35, 252);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(123, 39);
            btnPic.TabIndex = 19;
            btnPic.Text = "Upload Picture";
            btnPic.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(347, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(347, 181);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(184, 23);
            txtContact.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(347, 76);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(184, 23);
            txtName.TabIndex = 16;
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Modern No. 20", 11.9999981F);
            contact.Location = new Point(266, 184);
            contact.Name = "contact";
            contact.Size = new Size(56, 18);
            contact.TabIndex = 15;
            contact.Text = "Contact";
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
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 360);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnPic);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(contact);
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

        private Button btnSave;
        private Button btnEdit;
        private Button btnPic;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtName;
        private Label contact;
        private Label email;
        private Label name;
        private PictureBox user_pic;
        private Label label1;
    }
}