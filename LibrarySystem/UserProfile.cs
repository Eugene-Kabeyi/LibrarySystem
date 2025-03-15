using System;
using System.Windows.Forms;
namespace LibrarySystem
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            label1 = new Label();
            user_pic = new PictureBox();
            name = new Label();
            email = new Label();
            contact = new Label();
            txtName = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            btnPic = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)user_pic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 19);
            label1.Name = "label1";
            label1.Size = new Size(202, 36);
            label1.TabIndex = 0;
            label1.Text = "User Profile";
            // 
            // user_pic
            // 
            user_pic.Location = new Point(42, 89);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(146, 137);
            user_pic.TabIndex = 1;
            user_pic.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Modern No. 20", 11.9999981F);
            name.Location = new Point(285, 89);
            name.Name = "name";
            name.Size = new Size(44, 18);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Modern No. 20", 11.9999981F);
            email.Location = new Point(285, 140);
            email.Name = "email";
            email.Size = new Size(48, 18);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Font = new Font("Modern No. 20", 11.9999981F);
            contact.Location = new Point(285, 194);
            contact.Name = "contact";
            contact.Size = new Size(56, 18);
            contact.TabIndex = 4;
            contact.Text = "Contact";
            // 
            // txtName
            // 
            txtName.Location = new Point(366, 86);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(184, 25);
            txtName.TabIndex = 5;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(366, 191);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(184, 25);
            txtContact.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(366, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(184, 25);
            txtEmail.TabIndex = 7;
            // 
            // btnPic
            // 
            btnPic.FlatStyle = FlatStyle.Popup;
            btnPic.Font = new Font("Modern No. 20", 11.9999981F);
            btnPic.Location = new Point(54, 262);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(123, 39);
            btnPic.TabIndex = 8;
            btnPic.Text = "Upload Picture";
            btnPic.UseVisualStyleBackColor = true;
            btnPic.Click += btnPic_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Modern No. 20", 11.9999981F);
            btnEdit.Location = new Point(296, 262);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(123, 39);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F);
            btnSave.Location = new Point(450, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // UserProfile
            // 
            ClientSize = new Size(630, 363);
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
            Font = new Font("Modern No. 20", 11.9999981F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserProfile";
            Load += ProfilePage_Load;
            ((System.ComponentModel.ISupportInitialize)user_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnPic_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter to allow only image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Show dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string imagePath = openFileDialog.FileName;

                // Display the image in the PictureBox
                user_pic.Image = Image.FromFile(imagePath);

                // Resize the image to fit the PictureBox (optional)
                user_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtContact.ReadOnly = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtContact.ReadOnly = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }




        private Label label1;
        private PictureBox user_pic;
        private Label name;
        private Label email;
        private Label contact;
        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button btnPic;
        private Button btnEdit;
        private Button btnSave;

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }
    }
}