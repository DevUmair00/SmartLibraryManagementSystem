namespace Smart_Library_Management_System.Books
{
    partial class BookForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            BT_lbl = new Label();
            BM_lbl = new Label();
            BISBN_lbl = new Label();
            BAID_lbl = new Label();
            BC_lbl = new Label();
            cmbCategory = new ComboBox();
            txtISBN = new TextBox();
            txtTitle = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            B_Book = new Button();
            ViewBook_btn = new Button();
            search_lbl = new Label();
            dgvBooks = new DataGridView();
            txtSearch = new TextBox();
            searchIcon = new PictureBox();
            cmbAuthor = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_lbl
            // 
            BT_lbl.AutoSize = true;
            BT_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_lbl.Location = new Point(27, 132);
            BT_lbl.Name = "BT_lbl";
            BT_lbl.Size = new Size(121, 20);
            BT_lbl.TabIndex = 0;
            BT_lbl.Text = "Enter Book Title : ";
            // 
            // BM_lbl
            // 
            BM_lbl.AutoSize = true;
            BM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_lbl.Location = new Point(429, 19);
            BM_lbl.Name = "BM_lbl";
            BM_lbl.Size = new Size(376, 50);
            BM_lbl.TabIndex = 1;
            BM_lbl.Text = "Book Management";
            BM_lbl.Click += BM_lbl_Click;
            // 
            // BISBN_lbl
            // 
            BISBN_lbl.AutoSize = true;
            BISBN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BISBN_lbl.Location = new Point(27, 172);
            BISBN_lbl.Name = "BISBN_lbl";
            BISBN_lbl.Size = new Size(89, 20);
            BISBN_lbl.TabIndex = 2;
            BISBN_lbl.Text = "Enter ISBN : ";
            // 
            // BAID_lbl
            // 
            BAID_lbl.AutoSize = true;
            BAID_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAID_lbl.Location = new Point(27, 213);
            BAID_lbl.Name = "BAID_lbl";
            BAID_lbl.Size = new Size(105, 20);
            BAID_lbl.TabIndex = 4;
            BAID_lbl.Text = "Select Author : ";
            // 
            // BC_lbl
            // 
            BC_lbl.AutoSize = true;
            BC_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BC_lbl.Location = new Point(27, 260);
            BC_lbl.Name = "BC_lbl";
            BC_lbl.Size = new Size(114, 20);
            BC_lbl.TabIndex = 5;
            BC_lbl.Text = "Select Category :";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(143, 260);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(179, 23);
            cmbCategory.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(143, 169);
            txtISBN.Name = "txtISBN";
            txtISBN.PlaceholderText = "Book ISBN";
            txtISBN.Size = new Size(179, 23);
            txtISBN.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(143, 129);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Book Title";
            txtTitle.Size = new Size(179, 23);
            txtTitle.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(12, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 45);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(168, 24);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 45);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(12, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 45);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnClear.Location = new Point(168, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 45);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // B_Book
            // 
            B_Book.BackColor = Color.IndianRed;
            B_Book.ForeColor = Color.White;
            B_Book.Location = new Point(1032, 499);
            B_Book.Name = "B_Book";
            B_Book.Size = new Size(90, 34);
            B_Book.TabIndex = 19;
            B_Book.Text = "Back";
            B_Book.UseVisualStyleBackColor = false;
            B_Book.Click += B_Book_Click;
            // 
            // ViewBook_btn
            // 
            ViewBook_btn.BackColor = Color.DarkGray;
            ViewBook_btn.ForeColor = Color.White;
            ViewBook_btn.Location = new Point(935, 499);
            ViewBook_btn.Name = "ViewBook_btn";
            ViewBook_btn.Size = new Size(90, 34);
            ViewBook_btn.TabIndex = 20;
            ViewBook_btn.Text = "View All";
            ViewBook_btn.UseVisualStyleBackColor = false;
            ViewBook_btn.Click += ViewBook_btn_Click;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.Gray;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(835, 79);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 10;
            search_lbl.Text = "Search : ";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Location = new Point(369, 117);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.ShowRowErrors = false;
            dgvBooks.Size = new Size(756, 362);
            dgvBooks.TabIndex = 9;
            dgvBooks.CellClick += dgvBooks_CellClick_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(919, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Book By Name or ISBN";
            txtSearch.Size = new Size(207, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(1097, 80);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(27, 20);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 22;
            searchIcon.TabStop = false;
            // 
            // cmbAuthor
            // 
            cmbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(143, 213);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(179, 23);
            cmbAuthor.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(12, 323);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 156);
            panel1.TabIndex = 24;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(cmbAuthor);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
            Controls.Add(search_lbl);
            Controls.Add(dgvBooks);
            Controls.Add(ViewBook_btn);
            Controls.Add(B_Book);
            Controls.Add(txtTitle);
            Controls.Add(txtISBN);
            Controls.Add(cmbCategory);
            Controls.Add(BC_lbl);
            Controls.Add(BAID_lbl);
            Controls.Add(BISBN_lbl);
            Controls.Add(BM_lbl);
            Controls.Add(BT_lbl);
            Controls.Add(panel1);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BT_lbl;
        private Label BM_lbl;
        private Label BISBN_lbl;
        private Label BAID_lbl;
        private Label BC_lbl;
        private CheckBox BS_box;
        private ComboBox cmbCategory;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private Button B_Book;
        private Button ViewBook_btn;
        private Label search_lbl;
        private DataGridView dgvBooks;
        private TextBox txtSearch;
        private PictureBox searchIcon;
        private ComboBox cmbAuthor;
        private Panel panel1;
    }
}