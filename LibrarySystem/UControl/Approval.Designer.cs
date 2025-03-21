namespace LibrarySystem.UControl
{
    partial class Approval
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grBxBorrowed = new GroupBox();
            btnDeny = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            txtRequestDate = new TextBox();
            txtEmail = new TextBox();
            lblTitle = new Label();
            lblBorrower = new Label();
            txtTitle = new TextBox();
            lblBorrowDate = new Label();
            btnApprove = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            dgvBorrowedBooks = new DataGridView();
            grBxBorrowed.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // grBxBorrowed
            // 
            grBxBorrowed.Controls.Add(btnDeny);
            grBxBorrowed.Controls.Add(panel1);
            grBxBorrowed.Controls.Add(btnApprove);
            grBxBorrowed.Controls.Add(btnClear);
            grBxBorrowed.Controls.Add(dgvBorrowedBooks);
            grBxBorrowed.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grBxBorrowed.Location = new Point(20, 18);
            grBxBorrowed.Margin = new Padding(2);
            grBxBorrowed.Name = "grBxBorrowed";
            grBxBorrowed.Padding = new Padding(2);
            grBxBorrowed.Size = new Size(728, 386);
            grBxBorrowed.TabIndex = 14;
            grBxBorrowed.TabStop = false;
            grBxBorrowed.Text = "Approval of Request";
            grBxBorrowed.Enter += grBxBorrowed_Enter;
            // 
            // btnDeny
            // 
            btnDeny.BackColor = Color.Maroon;
            btnDeny.FlatStyle = FlatStyle.Flat;
            btnDeny.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnDeny.ForeColor = SystemColors.ControlLightLight;
            btnDeny.IconChar = FontAwesome.Sharp.IconChar.X;
            btnDeny.IconColor = Color.White;
            btnDeny.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDeny.IconSize = 22;
            btnDeny.Location = new Point(563, 110);
            btnDeny.Name = "btnDeny";
            btnDeny.Padding = new Padding(10, 0, 0, 0);
            btnDeny.Size = new Size(124, 34);
            btnDeny.TabIndex = 28;
            btnDeny.Text = "Deny";
            btnDeny.TextAlign = ContentAlignment.MiddleLeft;
            btnDeny.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeny.UseVisualStyleBackColor = false;
            btnDeny.Click += btnDeny_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtRequestDate);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblBorrower);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblBorrowDate);
            panel1.Location = new Point(5, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 181);
            panel1.TabIndex = 20;
            // 
            // txtRequestDate
            // 
            txtRequestDate.Location = new Point(163, 103);
            txtRequestDate.Margin = new Padding(2);
            txtRequestDate.Name = "txtRequestDate";
            txtRequestDate.ReadOnly = true;
            txtRequestDate.Size = new Size(289, 30);
            txtRequestDate.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 66);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(289, 30);
            txtEmail.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 11.9999981F);
            lblTitle.Location = new Point(30, 38);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 18);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Title";
            // 
            // lblBorrower
            // 
            lblBorrower.AutoSize = true;
            lblBorrower.Font = new Font("Modern No. 20", 11.9999981F);
            lblBorrower.Location = new Point(30, 75);
            lblBorrower.Margin = new Padding(2, 0, 2, 0);
            lblBorrower.Name = "lblBorrower";
            lblBorrower.Size = new Size(112, 18);
            lblBorrower.TabIndex = 2;
            lblBorrower.Text = "Borrower Email";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(163, 32);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(289, 30);
            txtTitle.TabIndex = 1;
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Font = new Font("Modern No. 20", 11.9999981F);
            lblBorrowDate.Location = new Point(30, 110);
            lblBorrowDate.Margin = new Padding(0, 0, 2, 0);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(101, 18);
            lblBorrowDate.TabIndex = 4;
            lblBorrowDate.Text = "Requsted Date";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = SystemColors.Highlight;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnApprove.ForeColor = SystemColors.ControlLightLight;
            btnApprove.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnApprove.IconColor = Color.White;
            btnApprove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnApprove.IconSize = 22;
            btnApprove.Location = new Point(563, 69);
            btnApprove.Name = "btnApprove";
            btnApprove.Padding = new Padding(10, 0, 0, 0);
            btnApprove.Size = new Size(124, 34);
            btnApprove.TabIndex = 18;
            btnApprove.Text = "Approve";
            btnApprove.TextAlign = ContentAlignment.MiddleLeft;
            btnApprove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Highlight;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnClear.IconColor = Color.White;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.IconSize = 22;
            btnClear.Location = new Point(563, 151);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(10, 0, 0, 0);
            btnClear.Size = new Size(124, 34);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleLeft;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBorrowedBooks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBorrowedBooks.Location = new Point(0, 231);
            dgvBorrowedBooks.Margin = new Padding(2);
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 62;
            dgvBorrowedBooks.RowTemplate.Height = 28;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.Size = new Size(720, 146);
            dgvBorrowedBooks.TabIndex = 12;
            dgvBorrowedBooks.CellClick += dgvBorrowedBooks_CellClick;
            // 
            // Approval
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grBxBorrowed);
            Name = "Approval";
            Size = new Size(774, 415);
            Load += Approval_Load;
            grBxBorrowed.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grBxBorrowed;
        private Panel panel1;
        private TextBox txtEmail;
        private Label lblTitle;
        private Label lblBorrower;
        private TextBox txtTitle;
        private FontAwesome.Sharp.IconButton btnApprove;
        private FontAwesome.Sharp.IconButton btnClear;
        private DataGridView dgvBorrowedBooks;
        private FontAwesome.Sharp.IconButton btnDeny;
        private Label lblBorrowDate;
        private TextBox txtRequestDate;
    }
}
