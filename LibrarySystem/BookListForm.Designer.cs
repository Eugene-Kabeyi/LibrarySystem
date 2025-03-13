namespace Library_System
{
    partial class BookListForm
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
            gbBookList = new GroupBox();
            dgvBooks = new DataGridView();
            btnRefresh = new Button();
            cmbCategoryFilter = new ComboBox();
            lblCategoryFilter = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            gbBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // gbBookList
            // 
            gbBookList.Controls.Add(dgvBooks);
            gbBookList.Controls.Add(btnRefresh);
            gbBookList.Controls.Add(cmbCategoryFilter);
            gbBookList.Controls.Add(lblCategoryFilter);
            gbBookList.Controls.Add(txtSearch);
            gbBookList.Controls.Add(lblSearch);
            gbBookList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBookList.Location = new Point(9, 9);
            gbBookList.Margin = new Padding(2, 2, 2, 2);
            gbBookList.Name = "gbBookList";
            gbBookList.Padding = new Padding(2, 2, 2, 2);
            gbBookList.Size = new Size(938, 359);
            gbBookList.TabIndex = 0;
            gbBookList.TabStop = false;
            gbBookList.Text = "BookList";
            gbBookList.Enter += gbBookList_Enter;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(16, 106);
            dgvBooks.Margin = new Padding(2, 2, 2, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.RowTemplate.Height = 28;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(567, 180);
            dgvBooks.TabIndex = 5;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(467, 300);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(116, 33);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(107, 67);
            cmbCategoryFilter.Margin = new Padding(2, 2, 2, 2);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(118, 28);
            cmbCategoryFilter.TabIndex = 3;
            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
            // 
            // lblCategoryFilter
            // 
            lblCategoryFilter.AutoSize = true;
            lblCategoryFilter.Location = new Point(5, 67);
            lblCategoryFilter.Margin = new Padding(2, 0, 2, 0);
            lblCategoryFilter.Name = "lblCategoryFilter";
            lblCategoryFilter.Size = new Size(86, 20);
            lblCategoryFilter.TabIndex = 2;
            lblCategoryFilter.Text = "Category:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(86, 28);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(79, 26);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(5, 30);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 386);
            Controls.Add(gbBookList);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BookListForm";
            Text = "BookListForm";
            gbBookList.ResumeLayout(false);
            gbBookList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBookList;
        private System.Windows.Forms.Label lblCategoryFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbCategoryFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvBooks;
    }
}