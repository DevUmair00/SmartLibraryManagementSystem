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
            B_Book = new Button();
            ViewBook_btn = new Button();
            dgvBooks = new DataGridView();
            txtSearch = new TextBox();
            searchIcon = new PictureBox();
            cmbAuthor = new ComboBox();
            cmbCategory1 = new ComboBox();
            pictureBox1 = new PictureBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            search_lbl = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_lbl
            // 
            BT_lbl.AutoSize = true;
            BT_lbl.BackColor = Color.WhiteSmoke;
            BT_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_lbl.Location = new Point(27, 170);
            BT_lbl.Name = "BT_lbl";
            BT_lbl.Size = new Size(121, 20);
            BT_lbl.TabIndex = 0;
            BT_lbl.Text = "Enter Book Title : ";
            // 
            // BM_lbl
            // 
            BM_lbl.AutoSize = true;
            BM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_lbl.Location = new Point(386, 6);
            BM_lbl.Name = "BM_lbl";
            BM_lbl.Size = new Size(376, 50);
            BM_lbl.TabIndex = 1;
            BM_lbl.Text = "Book Management";
            BM_lbl.Click += BM_lbl_Click;
            // 
            // BISBN_lbl
            // 
            BISBN_lbl.AutoSize = true;
            BISBN_lbl.BackColor = Color.WhiteSmoke;
            BISBN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BISBN_lbl.Location = new Point(27, 210);
            BISBN_lbl.Name = "BISBN_lbl";
            BISBN_lbl.Size = new Size(89, 20);
            BISBN_lbl.TabIndex = 2;
            BISBN_lbl.Text = "Enter ISBN : ";
            // 
            // BAID_lbl
            // 
            BAID_lbl.AutoSize = true;
            BAID_lbl.BackColor = Color.WhiteSmoke;
            BAID_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAID_lbl.Location = new Point(27, 251);
            BAID_lbl.Name = "BAID_lbl";
            BAID_lbl.Size = new Size(105, 20);
            BAID_lbl.TabIndex = 4;
            BAID_lbl.Text = "Select Author : ";
            // 
            // BC_lbl
            // 
            BC_lbl.AutoSize = true;
            BC_lbl.BackColor = Color.WhiteSmoke;
            BC_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BC_lbl.Location = new Point(27, 298);
            BC_lbl.Name = "BC_lbl";
            BC_lbl.Size = new Size(114, 20);
            BC_lbl.TabIndex = 5;
            BC_lbl.Text = "Select Category :";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(143, 299);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(179, 23);
            cmbCategory.TabIndex = 8;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(143, 207);
            txtISBN.Name = "txtISBN";
            txtISBN.PlaceholderText = "Book ISBN";
            txtISBN.Size = new Size(179, 23);
            txtISBN.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(143, 167);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Book Title";
            txtTitle.Size = new Size(179, 23);
            txtTitle.TabIndex = 14;
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
            dgvBooks.Location = new Point(370, 131);
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
            txtSearch.Location = new Point(917, 95);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Book By Name or ISBN";
            txtSearch.Size = new Size(207, 23);
            txtSearch.TabIndex = 21;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(1095, 96);
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
            cmbAuthor.Location = new Point(143, 251);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(179, 23);
            cmbAuthor.TabIndex = 23;
            // 
            // cmbCategory1
            // 
            cmbCategory1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory1.FormattingEnabled = true;
            cmbCategory1.Location = new Point(560, 96);
            cmbCategory1.Name = "cmbCategory1";
            cmbCategory1.Size = new Size(179, 23);
            cmbCategory1.TabIndex = 26;
            cmbCategory1.SelectedIndexChanged += cmbCategory1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PaleVioletRed;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1137, 547);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnClear.Location = new Point(168, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 45);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(168, 193);
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
            btnUpdate.Location = new Point(12, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 45);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(12, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 45);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(12, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 338);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 61);
            panel2.TabIndex = 61;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.Gray;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(829, 95);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 62;
            search_lbl.Text = "Search : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(370, 96);
            label2.Name = "label2";
            label2.Size = new Size(195, 23);
            label2.TabIndex = 63;
            label2.Text = "Search by Category: ";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(cmbCategory1);
            Controls.Add(label2);
            Controls.Add(search_lbl);
            Controls.Add(cmbAuthor);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
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
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookForm";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button B_Book;
        private Button ViewBook_btn;
        private DataGridView dgvBooks;
        private TextBox txtSearch;
        private PictureBox searchIcon;
        private ComboBox cmbAuthor;
        private ComboBox cmbCategory1;
        private PictureBox pictureBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel1;
        private Panel panel2;
        private Label search_lbl;
        private Label label2;
    }
}