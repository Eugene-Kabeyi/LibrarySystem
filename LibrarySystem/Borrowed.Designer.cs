namespace LibrarySystem
{
    partial class Borrowed
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
            grBxBorrowed = new GroupBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            lblTitle = new Label();
            lblBorrower = new Label();
            textBox1 = new TextBox();
            lblBorrowDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblReturnDate = new Label();
            dateTimePicker2 = new DateTimePicker();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            dgvBorrowedBooks = new DataGridView();
            grBxBorrowed.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // grBxBorrowed
            // 
            grBxBorrowed.Controls.Add(panel1);
            grBxBorrowed.Controls.Add(btnSave);
            grBxBorrowed.Controls.Add(btnEdit);
            grBxBorrowed.Controls.Add(iconButton1);
            grBxBorrowed.Controls.Add(btnReset);
            grBxBorrowed.Controls.Add(dgvBorrowedBooks);
            grBxBorrowed.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grBxBorrowed.Location = new Point(10, 11);
            grBxBorrowed.Margin = new Padding(2);
            grBxBorrowed.Name = "grBxBorrowed";
            grBxBorrowed.Padding = new Padding(2);
            grBxBorrowed.Size = new Size(728, 373);
            grBxBorrowed.TabIndex = 13;
            grBxBorrowed.TabStop = false;
            grBxBorrowed.Text = "Borrowed Books";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblBorrower);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lblBorrowDate);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblReturnDate);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Location = new Point(5, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 187);
            panel1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 44);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 30);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += txtBorrower_TextChanged;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = SystemColors.Highlight;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            iconButton2.ForeColor = SystemColors.ControlLightLight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 22;
            iconButton2.Location = new Point(199, 148);
            iconButton2.Margin = new Padding(0, 3, 3, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 0, 0);
            iconButton2.Size = new Size(93, 34);
            iconButton2.TabIndex = 19;
            iconButton2.Text = "Save";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 11.9999981F);
            lblTitle.Location = new Point(25, 16);
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
            lblBorrower.Location = new Point(25, 50);
            lblBorrower.Margin = new Padding(2, 0, 2, 0);
            lblBorrower.Name = "lblBorrower";
            lblBorrower.Size = new Size(108, 18);
            lblBorrower.TabIndex = 2;
            lblBorrower.Text = "Borrower Name";
            lblBorrower.Click += lblBorrower_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 10);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += txtTitle_TextChanged;
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Font = new Font("Modern No. 20", 11.9999981F);
            lblBorrowDate.Location = new Point(25, 83);
            lblBorrowDate.Margin = new Padding(0, 0, 2, 0);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(90, 18);
            lblBorrowDate.TabIndex = 4;
            lblBorrowDate.Text = "Borrow Date";
            lblBorrowDate.Click += lblBorrowDate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(158, 82);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 21);
            dateTimePicker1.TabIndex = 5;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Modern No. 20", 11.9999981F);
            lblReturnDate.Location = new Point(25, 114);
            lblReturnDate.Margin = new Padding(2, 0, 2, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(88, 18);
            lblReturnDate.TabIndex = 6;
            lblReturnDate.Text = "Return Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(158, 113);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(289, 21);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.ValueChanged += dtpReturnDate_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHand;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.Location = new Point(584, 80);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(103, 34);
            btnSave.TabIndex = 18;
            btnSave.Text = "Return";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.HandsBound;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 22;
            btnEdit.Location = new Point(584, 35);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Borrow";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.Highlight;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.Location = new Point(584, 125);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(103, 34);
            iconButton1.TabIndex = 16;
            iconButton1.Text = "Delete";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
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
            btnReset.Location = new Point(584, 169);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 0, 0);
            btnReset.Size = new Size(103, 34);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(4, 227);
            dgvBorrowedBooks.Margin = new Padding(2);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 62;
            dgvBorrowedBooks.RowTemplate.Height = 28;
            dgvBorrowedBooks.Size = new Size(720, 142);
            dgvBorrowedBooks.TabIndex = 12;
            dgvBorrowedBooks.CellContentClick += dgvBorrowedBooks_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 409);
            Controls.Add(grBxBorrowed);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grBxBorrowed.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBxBorrowed;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}