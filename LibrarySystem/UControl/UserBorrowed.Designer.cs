
namespace LibrarySystem.UControl
{
    partial class UserBorrowed
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
            dataGridViewBooks = new DataGridView();
            grpBookDetails = new GroupBox();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            txtoverdueDays = new TextBox();
            label1 = new Label();
            txtReturnDate = new TextBox();
            txtBorrowDate = new TextBox();
            lblTitle = new Label();
            txtBookTitle = new TextBox();
            lblBorrowDate = new Label();
            lblReturnDate = new Label();
            txtFine = new TextBox();
            lblFine = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Gadugi", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBooks.Location = new Point(27, 266);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(662, 139);
            dataGridViewBooks.TabIndex = 39;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(txtFine);
            grpBookDetails.Controls.Add(lblFine);
            grpBookDetails.Controls.Add(txtoverdueDays);
            grpBookDetails.Controls.Add(label1);
            grpBookDetails.Controls.Add(txtReturnDate);
            grpBookDetails.Controls.Add(txtBorrowDate);
            grpBookDetails.Controls.Add(lblTitle);
            grpBookDetails.Controls.Add(txtBookTitle);
            grpBookDetails.Controls.Add(lblBorrowDate);
            grpBookDetails.Controls.Add(lblReturnDate);
            grpBookDetails.Controls.Add(btnClear);
            grpBookDetails.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBookDetails.Location = new Point(26, 40);
            grpBookDetails.Margin = new Padding(2);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Padding = new Padding(2);
            grpBookDetails.Size = new Size(662, 221);
            grpBookDetails.TabIndex = 38;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Books Borrowed";
            grpBookDetails.Enter += grpBookDetails_Enter;
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
            btnClear.Location = new Point(477, 100);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(20, 0, 0, 0);
            btnClear.Size = new Size(152, 34);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleLeft;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Highlight;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.IconSize = 22;
            btnSearch.Location = new Point(347, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 24);
            btnSearch.TabIndex = 41;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 40;
            textBox1.Text = "Search";
            // 
            // txtoverdueDays
            // 
            txtoverdueDays.Location = new Point(153, 156);
            txtoverdueDays.Margin = new Padding(2);
            txtoverdueDays.Name = "txtoverdueDays";
            txtoverdueDays.ReadOnly = true;
            txtoverdueDays.Size = new Size(289, 30);
            txtoverdueDays.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.9999981F);
            label1.Location = new Point(20, 163);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 34;
            label1.Text = "Overdue Days";
            // 
            // txtReturnDate
            // 
            txtReturnDate.Location = new Point(153, 122);
            txtReturnDate.Margin = new Padding(2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.ReadOnly = true;
            txtReturnDate.Size = new Size(289, 30);
            txtReturnDate.TabIndex = 33;
            // 
            // txtBorrowDate
            // 
            txtBorrowDate.Location = new Point(153, 87);
            txtBorrowDate.Margin = new Padding(2);
            txtBorrowDate.Name = "txtBorrowDate";
            txtBorrowDate.ReadOnly = true;
            txtBorrowDate.Size = new Size(289, 30);
            txtBorrowDate.TabIndex = 32;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 11.9999981F);
            lblTitle.Location = new Point(20, 60);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 18);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Book Title";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(153, 53);
            txtBookTitle.Margin = new Padding(2);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.ReadOnly = true;
            txtBookTitle.Size = new Size(289, 30);
            txtBookTitle.TabIndex = 29;
            // 
            // lblBorrowDate
            // 
            lblBorrowDate.AutoSize = true;
            lblBorrowDate.Font = new Font("Modern No. 20", 11.9999981F);
            lblBorrowDate.Location = new Point(20, 92);
            lblBorrowDate.Margin = new Padding(0, 0, 2, 0);
            lblBorrowDate.Name = "lblBorrowDate";
            lblBorrowDate.Size = new Size(90, 18);
            lblBorrowDate.TabIndex = 30;
            lblBorrowDate.Text = "Borrow Date";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Modern No. 20", 11.9999981F);
            lblReturnDate.Location = new Point(20, 129);
            lblReturnDate.Margin = new Padding(2, 0, 2, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(88, 18);
            lblReturnDate.TabIndex = 31;
            lblReturnDate.Text = "Return Date";
            // 
            // txtFine
            // 
            txtFine.Location = new Point(153, 190);
            txtFine.Margin = new Padding(2);
            txtFine.Name = "txtFine";
            txtFine.ReadOnly = true;
            txtFine.Size = new Size(289, 30);
            txtFine.TabIndex = 37;
            // 
            // lblFine
            // 
            lblFine.AutoSize = true;
            lblFine.Font = new Font("Modern No. 20", 11.9999981F);
            lblFine.Location = new Point(20, 197);
            lblFine.Margin = new Padding(2, 0, 2, 0);
            lblFine.Name = "lblFine";
            lblFine.Size = new Size(95, 18);
            lblFine.TabIndex = 36;
            lblFine.Text = "Fine Amount";
            // 
            // UserBorrowed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewBooks);
            Controls.Add(grpBookDetails);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Name = "UserBorrowed";
            Size = new Size(750, 420);
            Load += UserBorrowed_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView dataGridViewBooks;
        private GroupBox grpBookDetails;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnClear;
        private TextBox txtoverdueDays;
        private Label label1;
        private TextBox txtReturnDate;
        private TextBox txtBorrowDate;
        private Label lblTitle;
        private TextBox txtBookTitle;
        private Label lblBorrowDate;
        private Label lblReturnDate;
        private TextBox txtFine;
        private Label lblFine;
    }
}
