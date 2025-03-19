namespace LibrarySystem.UControl
{
    partial class BookDetails
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
            grpBookDetails = new GroupBox();
            txtNoBooks = new TextBox();
            lblBookNo = new Label();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            txtPublisher = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            lblPublisher = new Label();
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
            dataGridViewBooks.Location = new Point(30, 336);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(662, 133);
            dataGridViewBooks.TabIndex = 31;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(txtNoBooks);
            grpBookDetails.Controls.Add(lblBookNo);
            grpBookDetails.Controls.Add(btnEdit);
            grpBookDetails.Controls.Add(btnSave);
            grpBookDetails.Controls.Add(btnDelete);
            grpBookDetails.Controls.Add(btnClear);
            grpBookDetails.Controls.Add(btnAdd);
            grpBookDetails.Controls.Add(txtPublisher);
            grpBookDetails.Controls.Add(txtISBN);
            grpBookDetails.Controls.Add(txtTitle);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(lblPublisher);
            grpBookDetails.Controls.Add(lblISBN);
            grpBookDetails.Controls.Add(lblAuthor);
            grpBookDetails.Controls.Add(lblTitle);
            grpBookDetails.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBookDetails.Location = new Point(29, 51);
            grpBookDetails.Margin = new Padding(2);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Padding = new Padding(2);
            grpBookDetails.Size = new Size(662, 278);
            grpBookDetails.TabIndex = 30;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book Details";
            // 
            // txtNoBooks
            // 
            txtNoBooks.Location = new Point(162, 209);
            txtNoBooks.Margin = new Padding(2);
            txtNoBooks.Name = "txtNoBooks";
            txtNoBooks.Size = new Size(256, 30);
            txtNoBooks.TabIndex = 31;
            // 
            // lblBookNo
            // 
            lblBookNo.AutoSize = true;
            lblBookNo.Font = new Font("Modern No. 20", 11.9999981F);
            lblBookNo.Location = new Point(67, 215);
            lblBookNo.Margin = new Padding(2, 0, 2, 0);
            lblBookNo.Name = "lblBookNo";
            lblBookNo.Size = new Size(88, 18);
            lblBookNo.TabIndex = 30;
            lblBookNo.Text = "No of Books";
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
            btnEdit.Location = new Point(522, 184);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(10, 0, 0, 0);
            btnEdit.Size = new Size(103, 34);
            btnEdit.TabIndex = 29;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
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
            btnSave.Location = new Point(211, 244);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(30, 0, 0, 0);
            btnSave.Size = new Size(166, 34);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
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
            btnDelete.Location = new Point(522, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(103, 34);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnClear.Location = new Point(522, 105);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(10, 0, 0, 0);
            btnClear.Size = new Size(103, 34);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleLeft;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 22;
            btnAdd.Location = new Point(522, 65);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(103, 34);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(162, 160);
            txtPublisher.Margin = new Padding(2);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(256, 30);
            txtPublisher.TabIndex = 11;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(162, 112);
            txtISBN.Margin = new Padding(2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(256, 30);
            txtISBN.TabIndex = 10;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(162, 27);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(256, 30);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(162, 68);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(256, 30);
            txtAuthor.TabIndex = 5;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Modern No. 20", 11.9999981F);
            lblPublisher.Location = new Point(67, 166);
            lblPublisher.Margin = new Padding(2, 0, 2, 0);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(71, 18);
            lblPublisher.TabIndex = 4;
            lblPublisher.Text = "Publisher";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Modern No. 20", 11.9999981F);
            lblISBN.Location = new Point(67, 120);
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
            lblAuthor.Location = new Point(67, 74);
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
            lblTitle.Location = new Point(67, 27);
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
            btnSearch.Location = new Point(350, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 24);
            btnSearch.TabIndex = 33;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnEdit_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 32;
            textBox1.Text = "Search";
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewBooks);
            Controls.Add(grpBookDetails);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Name = "BookDetails";
            Size = new Size(729, 472);
            Load += BookDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private GroupBox grpBookDetails;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnAdd;
        private TextBox txtPublisher;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblPublisher;
        private Label lblISBN;
        private Label lblAuthor;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnEdit;
        private TextBox txtNoBooks;
        private Label lblBookNo;
    }
}
