
namespace LibrarySystem.UControl
{
    partial class Librarians
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtSearch = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            btnEdit = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            uploadPic = new FontAwesome.Sharp.IconButton();
            txtLastname = new TextBox();
            btnSave = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtFirstname = new TextBox();
            pictureBox1 = new PictureBox();
            lbEmail = new Label();
            lbLname = new Label();
            lbFname = new Label();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            lbMembers = new Label();
            dataGridStaff = new DataGridView();
            createLibAcc = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(348, 23);
            txtSearch.TabIndex = 25;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(171, 91);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(196, 23);
            txtUsername.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.9999981F);
            label1.Location = new Point(44, 88);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 10;
            label1.Text = "Username";
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
            btnEdit.Location = new Point(640, 98);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 31;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(uploadPic);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtLastname);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(lbLname);
            panel2.Controls.Add(lbFname);
            panel2.Location = new Point(23, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 192);
            panel2.TabIndex = 27;
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
            uploadPic.Location = new Point(433, 145);
            uploadPic.Name = "uploadPic";
            uploadPic.Padding = new Padding(10, 0, 0, 0);
            uploadPic.Size = new Size(103, 41);
            uploadPic.TabIndex = 33;
            uploadPic.Text = "Upload Picture";
            uploadPic.TextAlign = ContentAlignment.MiddleLeft;
            uploadPic.TextImageRelation = TextImageRelation.ImageBeforeText;
            uploadPic.UseVisualStyleBackColor = false;
            uploadPic.Click += uploadPic_Click;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(171, 56);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(196, 23);
            txtLastname.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.Location = new Point(156, 152);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(35, 0, 0, 0);
            btnSave.Size = new Size(182, 34);
            btnSave.TabIndex = 32;
            btnSave.Text = "Update";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(171, 19);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(196, 23);
            txtFirstname.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(427, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Modern No. 20", 11.9999981F);
            lbEmail.Location = new Point(44, 125);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(48, 18);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbLname
            // 
            lbLname.AutoSize = true;
            lbLname.Font = new Font("Modern No. 20", 11.9999981F);
            lbLname.Location = new Point(44, 53);
            lbLname.Name = "lbLname";
            lbLname.Size = new Size(73, 18);
            lbLname.TabIndex = 2;
            lbLname.Text = "LastName";
            // 
            // lbFname
            // 
            lbFname.AutoSize = true;
            lbFname.Font = new Font("Modern No. 20", 11.9999981F);
            lbFname.Location = new Point(44, 19);
            lbFname.Name = "lbFname";
            lbFname.Size = new Size(74, 18);
            lbFname.TabIndex = 0;
            lbFname.Text = "Firstname";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 22;
            btnDelete.Location = new Point(640, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(103, 34);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Highlight;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnReset.IconColor = Color.White;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 22;
            btnReset.Location = new Point(640, 184);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 0, 0);
            btnReset.Size = new Size(103, 34);
            btnReset.TabIndex = 29;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.ControlLight;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 22;
            btnSearch.Location = new Point(385, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 28);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Search ";
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbMembers
            // 
            lbMembers.AutoSize = true;
            lbMembers.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMembers.Location = new Point(246, 5);
            lbMembers.Name = "lbMembers";
            lbMembers.Size = new Size(233, 50);
            lbMembers.TabIndex = 26;
            lbMembers.Text = "Librarians";
            // 
            // dataGridStaff
            // 
            dataGridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Gadugi", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridStaff.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridStaff.Location = new Point(21, 285);
            dataGridStaff.Name = "dataGridStaff";
            dataGridStaff.RowHeadersWidth = 62;
            dataGridStaff.Size = new Size(772, 134);
            dataGridStaff.TabIndex = 24;
            dataGridStaff.CellClick += dataGridStaff_CellClick;
            // 
            // createLibAcc
            // 
            createLibAcc.BackColor = SystemColors.Highlight;
            createLibAcc.FlatStyle = FlatStyle.Flat;
            createLibAcc.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            createLibAcc.ForeColor = SystemColors.ControlLightLight;
            createLibAcc.IconChar = FontAwesome.Sharp.IconChar.Add;
            createLibAcc.IconColor = Color.White;
            createLibAcc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            createLibAcc.IconSize = 30;
            createLibAcc.Location = new Point(278, 423);
            createLibAcc.Name = "createLibAcc";
            createLibAcc.Padding = new Padding(10, 0, 0, 0);
            createLibAcc.Size = new Size(220, 29);
            createLibAcc.TabIndex = 33;
            createLibAcc.Text = "Create New Account";
            createLibAcc.TextImageRelation = TextImageRelation.ImageBeforeText;
            createLibAcc.UseVisualStyleBackColor = false;
            createLibAcc.Click += createLibAcc_Click;
            // 
            // Librarians
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createLibAcc);
            Controls.Add(txtSearch);
            Controls.Add(btnEdit);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(lbMembers);
            Controls.Add(dataGridStaff);
            Name = "Librarians";
            Size = new Size(815, 469);
            Load += Librarians_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridStaff).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtSearch;
        private TextBox txtUsername;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnEdit;
        private Panel panel2;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtFirstname;
        private PictureBox pictureBox1;
        private Label lbEmail;
        private Label lbLname;
        private Label lbFname;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Label lbMembers;
        private DataGridView dataGridStaff;
        private FontAwesome.Sharp.IconButton uploadPic;
        private FontAwesome.Sharp.IconButton createLibAcc;
        private FontAwesome.Sharp.IconButton btnSave;
    }
}
