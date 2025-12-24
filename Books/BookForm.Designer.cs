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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            BT_lbl = new Label();
            BM_lbl = new Label();
            BISBN_lbl = new Label();
            BAID_lbl = new Label();
            BC_lbl = new Label();
            BS_box = new CheckBox();
            BCategory_Combobox = new ComboBox();
            BAID_box = new TextBox();
            BISBN_box = new TextBox();
            BT_box = new TextBox();
            BAdd_btn = new Button();
            BDelete_btn = new Button();
            BUpdate_btn = new Button();
            BClear_btn = new Button();
            B_Book = new Button();
            ViewBook_btn = new Button();
            search_lbl = new Label();
            viewBookGrid = new DataGridView();
            book_category = new DataGridViewTextBoxColumn();
            book_status = new DataGridViewTextBoxColumn();
            author_id = new DataGridViewTextBoxColumn();
            book_isbn = new DataGridViewTextBoxColumn();
            book_title = new DataGridViewTextBoxColumn();
            book_id = new DataGridViewTextBoxColumn();
            SearchBox = new TextBox();
            searchIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            SuspendLayout();
            // 
            // BT_lbl
            // 
            BT_lbl.AutoSize = true;
            BT_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BT_lbl.Location = new Point(12, 155);
            BT_lbl.Name = "BT_lbl";
            BT_lbl.Size = new Size(121, 20);
            BT_lbl.TabIndex = 0;
            BT_lbl.Text = "Enter Book Title : ";
            BT_lbl.Click += label1_Click;
            // 
            // BM_lbl
            // 
            BM_lbl.AutoSize = true;
            BM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_lbl.Location = new Point(235, 25);
            BM_lbl.Name = "BM_lbl";
            BM_lbl.Size = new Size(376, 50);
            BM_lbl.TabIndex = 1;
            BM_lbl.Text = "Book Management";
            // 
            // BISBN_lbl
            // 
            BISBN_lbl.AutoSize = true;
            BISBN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BISBN_lbl.Location = new Point(12, 195);
            BISBN_lbl.Name = "BISBN_lbl";
            BISBN_lbl.Size = new Size(89, 20);
            BISBN_lbl.TabIndex = 2;
            BISBN_lbl.Text = "Enter ISBN : ";
            // 
            // BAID_lbl
            // 
            BAID_lbl.AutoSize = true;
            BAID_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAID_lbl.Location = new Point(12, 236);
            BAID_lbl.Name = "BAID_lbl";
            BAID_lbl.Size = new Size(117, 20);
            BAID_lbl.TabIndex = 4;
            BAID_lbl.Text = "Enter Author ID : ";
            // 
            // BC_lbl
            // 
            BC_lbl.AutoSize = true;
            BC_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BC_lbl.Location = new Point(12, 312);
            BC_lbl.Name = "BC_lbl";
            BC_lbl.Size = new Size(64, 20);
            BC_lbl.TabIndex = 5;
            BC_lbl.Text = "Category";
            BC_lbl.Click += label6_Click;
            // 
            // BS_box
            // 
            BS_box.AutoSize = true;
            BS_box.CheckAlign = ContentAlignment.TopRight;
            BS_box.Checked = true;
            BS_box.CheckState = CheckState.Checked;
            BS_box.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BS_box.Location = new Point(12, 272);
            BS_box.Name = "BS_box";
            BS_box.Size = new Size(117, 24);
            BS_box.TabIndex = 7;
            BS_box.Text = "Current Status";
            BS_box.UseVisualStyleBackColor = true;
            // 
            // BCategory_Combobox
            // 
            BCategory_Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            BCategory_Combobox.FormattingEnabled = true;
            BCategory_Combobox.Location = new Point(82, 313);
            BCategory_Combobox.Name = "BCategory_Combobox";
            BCategory_Combobox.Size = new Size(121, 23);
            BCategory_Combobox.TabIndex = 8;
            // 
            // BAID_box
            // 
            BAID_box.Location = new Point(128, 233);
            BAID_box.Name = "BAID_box";
            BAID_box.PlaceholderText = "Author ID";
            BAID_box.Size = new Size(137, 23);
            BAID_box.TabIndex = 12;
            // 
            // BISBN_box
            // 
            BISBN_box.Location = new Point(128, 192);
            BISBN_box.Name = "BISBN_box";
            BISBN_box.PlaceholderText = "Book ISBN";
            BISBN_box.Size = new Size(137, 23);
            BISBN_box.TabIndex = 13;
            // 
            // BT_box
            // 
            BT_box.Location = new Point(128, 152);
            BT_box.Name = "BT_box";
            BT_box.PlaceholderText = "Book Title";
            BT_box.Size = new Size(137, 23);
            BT_box.TabIndex = 14;
            // 
            // BAdd_btn
            // 
            BAdd_btn.Location = new Point(12, 393);
            BAdd_btn.Name = "BAdd_btn";
            BAdd_btn.Size = new Size(91, 33);
            BAdd_btn.TabIndex = 15;
            BAdd_btn.Text = "Add";
            BAdd_btn.UseVisualStyleBackColor = true;
            // 
            // BDelete_btn
            // 
            BDelete_btn.Location = new Point(214, 393);
            BDelete_btn.Name = "BDelete_btn";
            BDelete_btn.Size = new Size(91, 33);
            BDelete_btn.TabIndex = 16;
            BDelete_btn.Text = "Delete";
            BDelete_btn.UseVisualStyleBackColor = true;
            // 
            // BUpdate_btn
            // 
            BUpdate_btn.Location = new Point(116, 393);
            BUpdate_btn.Name = "BUpdate_btn";
            BUpdate_btn.Size = new Size(91, 33);
            BUpdate_btn.TabIndex = 17;
            BUpdate_btn.Text = "Update";
            BUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // BClear_btn
            // 
            BClear_btn.BackColor = Color.Khaki;
            BClear_btn.Location = new Point(312, 393);
            BClear_btn.Name = "BClear_btn";
            BClear_btn.Size = new Size(91, 33);
            BClear_btn.TabIndex = 18;
            BClear_btn.Text = "Clear";
            BClear_btn.UseVisualStyleBackColor = false;
            BClear_btn.Click += button3_Click;
            // 
            // B_Book
            // 
            B_Book.BackColor = Color.IndianRed;
            B_Book.ForeColor = Color.White;
            B_Book.Location = new Point(693, 393);
            B_Book.Name = "B_Book";
            B_Book.Size = new Size(91, 33);
            B_Book.TabIndex = 19;
            B_Book.Text = "Back";
            B_Book.UseVisualStyleBackColor = false;
            // 
            // ViewBook_btn
            // 
            ViewBook_btn.BackColor = Color.DarkGray;
            ViewBook_btn.ForeColor = Color.White;
            ViewBook_btn.Location = new Point(596, 393);
            ViewBook_btn.Name = "ViewBook_btn";
            ViewBook_btn.Size = new Size(91, 33);
            ViewBook_btn.TabIndex = 20;
            ViewBook_btn.Text = "View All";
            ViewBook_btn.UseVisualStyleBackColor = false;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.Gray;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(483, 94);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 10;
            search_lbl.Text = "Search : ";
            search_lbl.Click += label1_Click_1;
            // 
            // viewBookGrid
            // 
            viewBookGrid.AllowUserToAddRows = false;
            viewBookGrid.AllowUserToDeleteRows = false;
            viewBookGrid.AllowUserToResizeColumns = false;
            viewBookGrid.AllowUserToResizeRows = false;
            viewBookGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewBookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookGrid.Columns.AddRange(new DataGridViewColumn[] { book_id, book_title, book_isbn, author_id, book_status, book_category });
            viewBookGrid.Location = new Point(285, 123);
            viewBookGrid.Name = "viewBookGrid";
            viewBookGrid.RowHeadersVisible = false;
            viewBookGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBookGrid.ShowRowErrors = false;
            viewBookGrid.Size = new Size(499, 253);
            viewBookGrid.TabIndex = 9;
            // 
            // book_category
            // 
            book_category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_category.HeaderText = "Category";
            book_category.Name = "book_category";
            book_category.ReadOnly = true;
            book_category.Resizable = DataGridViewTriState.False;
            // 
            // book_status
            // 
            book_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_status.HeaderText = "Status";
            book_status.Name = "book_status";
            book_status.ReadOnly = true;
            book_status.Resizable = DataGridViewTriState.False;
            // 
            // author_id
            // 
            author_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author_id.HeaderText = "Author ID";
            author_id.Name = "author_id";
            author_id.ReadOnly = true;
            author_id.Resizable = DataGridViewTriState.False;
            // 
            // book_isbn
            // 
            book_isbn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_isbn.HeaderText = "ISBN";
            book_isbn.Name = "book_isbn";
            book_isbn.ReadOnly = true;
            book_isbn.Resizable = DataGridViewTriState.False;
            // 
            // book_title
            // 
            book_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_title.HeaderText = "Title";
            book_title.Name = "book_title";
            book_title.ReadOnly = true;
            book_title.Resizable = DataGridViewTriState.False;
            // 
            // book_id
            // 
            book_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_id.HeaderText = "Book ID";
            book_id.Name = "book_id";
            book_id.ReadOnly = true;
            book_id.Resizable = DataGridViewTriState.False;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(567, 94);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search Book By Name";
            SearchBox.Size = new Size(207, 23);
            SearchBox.TabIndex = 21;
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(745, 94);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(28, 23);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 22;
            searchIcon.TabStop = false;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchIcon);
            Controls.Add(SearchBox);
            Controls.Add(search_lbl);
            Controls.Add(viewBookGrid);
            Controls.Add(ViewBook_btn);
            Controls.Add(B_Book);
            Controls.Add(BClear_btn);
            Controls.Add(BUpdate_btn);
            Controls.Add(BDelete_btn);
            Controls.Add(BAdd_btn);
            Controls.Add(BT_box);
            Controls.Add(BISBN_box);
            Controls.Add(BAID_box);
            Controls.Add(BCategory_Combobox);
            Controls.Add(BS_box);
            Controls.Add(BC_lbl);
            Controls.Add(BAID_lbl);
            Controls.Add(BISBN_lbl);
            Controls.Add(BM_lbl);
            Controls.Add(BT_lbl);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
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
        private ComboBox BCategory_Combobox;
        private TextBox BAID_box;
        private TextBox BISBN_box;
        private TextBox BT_box;
        private Button BAdd_btn;
        private Button BDelete_btn;
        private Button BUpdate_btn;
        private Button BClear_btn;
        private Button B_Book;
        private Button ViewBook_btn;
        private Label search_lbl;
        private DataGridView viewBookGrid;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn book_title;
        private DataGridViewTextBoxColumn book_isbn;
        private DataGridViewTextBoxColumn author_id;
        private DataGridViewTextBoxColumn book_status;
        private DataGridViewTextBoxColumn book_category;
        private TextBox SearchBox;
        private PictureBox searchIcon;
    }
}