namespace LibrarySystem.UControl
{
    partial class Request
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
            txtPublisher = new TextBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            lblPublisher = new Label();
            lblISBN = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            txtSearch = new TextBox();
            btnRequest = new FontAwesome.Sharp.IconButton();
            btnClear = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(34, 285);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(662, 199);
            dataGridViewBooks.TabIndex = 39;
            dataGridViewBooks.CellClick += dataGridViewBooks_CellClick;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(btnRequest);
            grpBookDetails.Controls.Add(txtPublisher);
            grpBookDetails.Controls.Add(txtISBN);
            grpBookDetails.Controls.Add(txtTitle);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(lblPublisher);
            grpBookDetails.Controls.Add(lblISBN);
            grpBookDetails.Controls.Add(lblAuthor);
            grpBookDetails.Controls.Add(lblTitle);
            grpBookDetails.Controls.Add(btnClear);
            grpBookDetails.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBookDetails.Location = new Point(34, 49);
            grpBookDetails.Margin = new Padding(2);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Padding = new Padding(2);
            grpBookDetails.Size = new Size(662, 231);
            grpBookDetails.TabIndex = 38;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book List";
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(199, 167);
            txtPublisher.Margin = new Padding(2);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.ReadOnly = true;
            txtPublisher.Size = new Size(256, 30);
            txtPublisher.TabIndex = 39;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(199, 119);
            txtISBN.Margin = new Padding(2);
            txtISBN.Name = "txtISBN";
            txtISBN.ReadOnly = true;
            txtISBN.Size = new Size(256, 30);
            txtISBN.TabIndex = 38;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(199, 34);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(256, 30);
            txtTitle.TabIndex = 37;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(199, 75);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(256, 30);
            txtAuthor.TabIndex = 36;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Modern No. 20", 11.9999981F);
            lblPublisher.Location = new Point(103, 172);
            lblPublisher.Margin = new Padding(2, 0, 2, 0);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(71, 18);
            lblPublisher.TabIndex = 35;
            lblPublisher.Text = "Publisher";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Modern No. 20", 11.9999981F);
            lblISBN.Location = new Point(103, 126);
            lblISBN.Margin = new Padding(2, 0, 2, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(45, 18);
            lblISBN.TabIndex = 34;
            lblISBN.Text = "ISBN";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Modern No. 20", 11.9999981F);
            lblAuthor.Location = new Point(103, 80);
            lblAuthor.Margin = new Padding(2, 0, 2, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 18);
            lblAuthor.TabIndex = 33;
            lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(103, 33);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(39, 18);
            lblTitle.TabIndex = 32;
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
            btnSearch.Location = new Point(355, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 24);
            btnSearch.TabIndex = 41;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(35, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(303, 23);
            txtSearch.TabIndex = 40;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = SystemColors.Highlight;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnRequest.ForeColor = SystemColors.ControlLightLight;
            btnRequest.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHand;
            btnRequest.IconColor = Color.White;
            btnRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRequest.IconSize = 22;
            btnRequest.Location = new Point(496, 94);
            btnRequest.Name = "btnRequest";
            btnRequest.Padding = new Padding(20, 0, 0, 0);
            btnRequest.Size = new Size(145, 34);
            btnRequest.TabIndex = 42;
            btnRequest.Text = "Request";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
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
            btnClear.Location = new Point(496, 146);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(20, 0, 0, 0);
            btnClear.Size = new Size(145, 34);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleLeft;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewBooks);
            Controls.Add(grpBookDetails);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "Request";
            Size = new Size(828, 511);
            Load += Request_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private GroupBox grpBookDetails;
        private TextBox txtPublisher;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblPublisher;
        private Label lblISBN;
        private Label lblAuthor;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnRequest;
        private FontAwesome.Sharp.IconButton btnClear;
    }
}
