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
            txtISBN = new TextBox();
            grpReqBookDetails = new GroupBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnDelete = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            txtPublisher = new TextBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            lblPublisher = new Label();
            lblISBN = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            grpReqBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(178, 127);
            txtISBN.Margin = new Padding(2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(256, 30);
            txtISBN.TabIndex = 10;
            // 
            // grpReqBookDetails
            // 
            grpReqBookDetails.Controls.Add(iconButton1);
            grpReqBookDetails.Controls.Add(btnSave);
            grpReqBookDetails.Controls.Add(btnDelete);
            grpReqBookDetails.Controls.Add(btnReset);
            grpReqBookDetails.Controls.Add(txtPublisher);
            grpReqBookDetails.Controls.Add(txtISBN);
            grpReqBookDetails.Controls.Add(txtTitle);
            grpReqBookDetails.Controls.Add(txtAuthor);
            grpReqBookDetails.Controls.Add(lblPublisher);
            grpReqBookDetails.Controls.Add(lblISBN);
            grpReqBookDetails.Controls.Add(lblAuthor);
            grpReqBookDetails.Controls.Add(lblTitle);
            grpReqBookDetails.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpReqBookDetails.Location = new Point(17, 44);
            grpReqBookDetails.Margin = new Padding(2);
            grpReqBookDetails.Name = "grpReqBookDetails";
            grpReqBookDetails.Padding = new Padding(2);
            grpReqBookDetails.Size = new Size(662, 221);
            grpReqBookDetails.TabIndex = 30;
            grpReqBookDetails.TabStop = false;
            grpReqBookDetails.Text = "Request Book";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Maroon;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 22;
            iconButton1.Location = new Point(533, 122);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(112, 34);
            iconButton1.TabIndex = 27;
            iconButton1.Text = "Delete";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 22;
            btnSave.Location = new Point(533, 38);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 26;
            btnSave.Text = "Request";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ControlLightLight;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.IconSize = 22;
            btnDelete.Location = new Point(533, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Clear";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Highlight;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Bold);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            btnReset.IconColor = Color.White;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 22;
            btnReset.Location = new Point(533, 163);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 0, 0);
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 24;
            btnReset.Text = "Close";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(178, 175);
            txtPublisher.Margin = new Padding(2);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(256, 30);
            txtPublisher.TabIndex = 11;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(178, 42);
            txtTitle.Margin = new Padding(2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(256, 30);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(178, 83);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(256, 30);
            txtAuthor.TabIndex = 5;
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Font = new Font("Modern No. 20", 11.9999981F);
            lblPublisher.Location = new Point(83, 181);
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
            lblISBN.Location = new Point(83, 135);
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
            lblAuthor.Location = new Point(83, 89);
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
            lblTitle.Location = new Point(83, 42);
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
            btnSearch.Location = new Point(338, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 24);
            btnSearch.TabIndex = 33;
            btnSearch.TextAlign = ContentAlignment.MiddleLeft;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 32;
            textBox1.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 270);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 125);
            dataGridView1.TabIndex = 31;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpReqBookDetails);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Request";
            Size = new Size(723, 410);
            grpReqBookDetails.ResumeLayout(false);
            grpReqBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtISBN;
        private GroupBox grpReqBookDetails;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReset;
        private TextBox txtPublisher;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label lblPublisher;
        private Label lblISBN;
        private Label lblAuthor;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}
