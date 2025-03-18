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
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(616, 420);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 65);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Modern No. 20", 11.9999981F);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(396, 420);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 65);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnPic
            // 
            btnPic.BackColor = SystemColors.Highlight;
            btnPic.FlatStyle = FlatStyle.Popup;
            btnPic.Font = new Font("Modern No. 20", 11.9999981F);
            btnPic.ForeColor = SystemColors.ControlLightLight;
            btnPic.Location = new Point(50, 420);
            btnPic.Margin = new Padding(4, 5, 4, 5);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(176, 65);
            btnPic.TabIndex = 19;
            btnPic.Text = "Upload Picture";
            btnPic.UseVisualStyleBackColor = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(496, 217);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(261, 31);
            txtEmail.TabIndex = 18;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(496, 302);
            txtContact.Margin = new Padding(4, 5, 4, 5);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(261, 31);
            txtContact.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(496, 127);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(261, 31);
            txtName.TabIndex = 16;
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Modern No. 20", 11.9999981F);
            contact.Location = new Point(380, 307);
            contact.Margin = new Padding(4, 0, 4, 0);
            contact.Name = "contact";
            contact.Size = new Size(112, 25);
            contact.TabIndex = 15;
            contact.Text = "UserName";
            contact.Click += contact_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Modern No. 20", 11.9999981F);
            email.Location = new Point(380, 217);
            email.Margin = new Padding(4, 0, 4, 0);
            email.Name = "email";
            email.Size = new Size(74, 25);
            email.TabIndex = 14;
            email.Text = "Email";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Modern No. 20", 11.9999981F);
            name.Location = new Point(380, 132);
            name.Margin = new Padding(4, 0, 4, 0);
            name.Name = "name";
            name.Size = new Size(68, 25);
            name.TabIndex = 13;
            name.Text = "Name";
            // 
            // user_pic
            // 
            user_pic.Location = new Point(33, 132);
            user_pic.Margin = new Padding(4, 5, 4, 5);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(209, 228);
            user_pic.TabIndex = 12;
            user_pic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 54);
            label1.TabIndex = 11;
            label1.Text = "Admin Profile";
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 600);
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
            Margin = new Padding(4, 5, 4, 5);
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