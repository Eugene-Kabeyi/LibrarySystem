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
            dataGridViewBooks = new DataGridView();
            lblPublisher = new Label();
            grpBookDetails = new GroupBox();
            btnClear = new FontAwesome.Sharp.IconButton();
            txtPublisher = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            lblISBN = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(27, 280);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(662, 125);
            dataGridViewBooks.TabIndex = 39;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Modern No. 20", 11.9999981F);
            lblPublisher.Location = new Point(65, 179);
            lblPublisher.Margin = new Padding(2, 0, 2, 0);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(71, 18);
            lblPublisher.TabIndex = 4;
            lblPublisher.Text = "Publisher";
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(btnClear);
            grpBookDetails.Controls.Add(txtPublisher);
            grpBookDetails.Controls.Add(txtISBN);
            grpBookDetails.Controls.Add(txtTitle);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(lblPublisher);
            grpBookDetails.Controls.Add(lblISBN);
            grpBookDetails.Controls.Add(lblAuthor);
            grpBookDetails.Controls.Add(lblTitle);
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
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(162, 175);
            txtPublisher.Margin = new Padding(2);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(256, 30);
            txtPublisher.TabIndex = 11;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(162, 127);
            txtISBN.Margin = new Padding(2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(256, 30);
            txtISBN.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(162, 42);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(256, 30);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(162, 83);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(256, 30);
            txtAuthor.TabIndex = 5;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Modern No. 20", 11.9999981F);
            lblISBN.Location = new Point(65, 133);
            lblISBN.Margin = new Padding(2, 0, 2, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(45, 18);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Modern No. 20", 11.9999981F);
            lblAuthor.Location = new Point(65, 87);
            lblAuthor.Margin = new Padding(2, 0, 2, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 18);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(65, 40);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(39, 18);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
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
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 40;
            textBox1.Text = "Search";
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
        private Label lblPublisher;
        private GroupBox grpBookDetails;
        private TextBox txtPublisher;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblISBN;
        private Label lblAuthor;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnClear;
    }
}
