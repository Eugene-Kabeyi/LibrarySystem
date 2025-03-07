using System;
using System.Windows.Forms;
namespace LibrarySystem
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

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
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 37);
            label1.TabIndex = 0;
            label1.Text = "User Profile";
            // 
            // user_pic
            // 
            user_pic.Location = new Point(86, 79);
            user_pic.Name = "user_pic";
            user_pic.Size = new Size(146, 137);
            user_pic.TabIndex = 1;
            user_pic.TabStop = false;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(329, 79);
            name.Name = "name";
            name.Size = new Size(39, 15);
            name.TabIndex = 2;
            name.Text = "Name";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(329, 130);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Location = new Point(329, 184);
            contact.Name = "contact";
            contact.Size = new Size(49, 15);
            contact.TabIndex = 4;
            contact.Text = "Contact";
            // 
            // txtName
            // 
            txtName.Location = new Point(410, 76);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(184, 23);
            txtName.TabIndex = 5;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(410, 181);
            txtContact.Name = "txtContact";
            txtContact.ReadOnly = true;
            txtContact.Size = new Size(184, 23);
            txtContact.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(410, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 7;
            // 
            // btnPic
            // 
            btnPic.FlatStyle = FlatStyle.Popup;
            btnPic.Location = new Point(98, 252);
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
            btnEdit.Location = new Point(340, 252);
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
            btnSave.Location = new Point(494, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 39);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ProfilePage
            // 
            ClientSize = new Size(669, 434);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfilePage";
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
