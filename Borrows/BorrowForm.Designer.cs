namespace Smart_Library_Management_System.Borrows
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            ViewBook_btn = new Button();
            B_Book = new Button();
            BClear_btn = new Button();
            BUpdate_btn = new Button();
            BDelete_btn = new Button();
            BAdd_btn = new Button();
            DD_lbl = new Label();
            BM_lbl = new Label();
            BD_lbl = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            viewBookGrid = new DataGridView();
            book_id = new DataGridViewTextBoxColumn();
            book_title = new DataGridViewTextBoxColumn();
            book_status = new DataGridViewTextBoxColumn();
            book_category = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            member_id = new DataGridViewTextBoxColumn();
            member_name = new DataGridViewTextBoxColumn();
            member_email = new DataGridViewTextBoxColumn();
            viewBorrow_Grid = new DataGridView();
            borrow_id = new DataGridViewTextBoxColumn();
            memberid = new DataGridViewTextBoxColumn();
            bookid = new DataGridViewTextBoxColumn();
            borrow_date = new DataGridViewTextBoxColumn();
            due_date = new DataGridViewTextBoxColumn();
            return_date = new DataGridViewTextBoxColumn();
            searchIcon = new PictureBox();
            SearchBox = new TextBox();
            search_lbl = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)viewBorrow_Grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ViewBook_btn
            // 
            ViewBook_btn.BackColor = Color.DarkGray;
            ViewBook_btn.ForeColor = Color.White;
            ViewBook_btn.Location = new Point(1042, 526);
            ViewBook_btn.Name = "ViewBook_btn";
            ViewBook_btn.Size = new Size(91, 33);
            ViewBook_btn.TabIndex = 39;
            ViewBook_btn.Text = "View All";
            ViewBook_btn.UseVisualStyleBackColor = false;
            // 
            // B_Book
            // 
            B_Book.BackColor = Color.IndianRed;
            B_Book.ForeColor = Color.White;
            B_Book.Location = new Point(1169, 526);
            B_Book.Name = "B_Book";
            B_Book.Size = new Size(91, 33);
            B_Book.TabIndex = 38;
            B_Book.Text = "Back";
            B_Book.UseVisualStyleBackColor = false;
            // 
            // BClear_btn
            // 
            BClear_btn.BackColor = Color.Khaki;
            BClear_btn.Location = new Point(319, 535);
            BClear_btn.Name = "BClear_btn";
            BClear_btn.Size = new Size(91, 33);
            BClear_btn.TabIndex = 37;
            BClear_btn.Text = "Clear";
            BClear_btn.UseVisualStyleBackColor = false;
            // 
            // BUpdate_btn
            // 
            BUpdate_btn.Location = new Point(123, 535);
            BUpdate_btn.Name = "BUpdate_btn";
            BUpdate_btn.Size = new Size(91, 33);
            BUpdate_btn.TabIndex = 36;
            BUpdate_btn.Text = "Update";
            BUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // BDelete_btn
            // 
            BDelete_btn.Location = new Point(221, 535);
            BDelete_btn.Name = "BDelete_btn";
            BDelete_btn.Size = new Size(91, 33);
            BDelete_btn.TabIndex = 35;
            BDelete_btn.Text = "Delete";
            BDelete_btn.UseVisualStyleBackColor = true;
            // 
            // BAdd_btn
            // 
            BAdd_btn.Location = new Point(19, 535);
            BAdd_btn.Name = "BAdd_btn";
            BAdd_btn.Size = new Size(91, 33);
            BAdd_btn.TabIndex = 34;
            BAdd_btn.Text = "Add";
            BAdd_btn.UseVisualStyleBackColor = true;
            // 
            // DD_lbl
            // 
            DD_lbl.AutoSize = true;
            DD_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DD_lbl.Location = new Point(28, 474);
            DD_lbl.Name = "DD_lbl";
            DD_lbl.Size = new Size(72, 20);
            DD_lbl.TabIndex = 23;
            DD_lbl.Text = "Due Date :";
            // 
            // BM_lbl
            // 
            BM_lbl.AutoSize = true;
            BM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_lbl.Location = new Point(490, 9);
            BM_lbl.Name = "BM_lbl";
            BM_lbl.Size = new Size(290, 50);
            BM_lbl.TabIndex = 22;
            BM_lbl.Text = "Borrow Books";
            BM_lbl.Click += BM_lbl_Click;
            // 
            // BD_lbl
            // 
            BD_lbl.AutoSize = true;
            BD_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BD_lbl.Location = new Point(28, 445);
            BD_lbl.Name = "BD_lbl";
            BD_lbl.Size = new Size(92, 20);
            BD_lbl.TabIndex = 21;
            BD_lbl.Text = "Borrow Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 441);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 44;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(153, 474);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(137, 23);
            dateTimePicker3.TabIndex = 46;
            // 
            // viewBookGrid
            // 
            viewBookGrid.AllowUserToAddRows = false;
            viewBookGrid.AllowUserToDeleteRows = false;
            viewBookGrid.AllowUserToResizeColumns = false;
            viewBookGrid.AllowUserToResizeRows = false;
            viewBookGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewBookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookGrid.Columns.AddRange(new DataGridViewColumn[] { book_id, book_title, book_status, book_category });
            viewBookGrid.Location = new Point(12, 124);
            viewBookGrid.Name = "viewBookGrid";
            viewBookGrid.RowHeadersVisible = false;
            viewBookGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBookGrid.ShowRowErrors = false;
            viewBookGrid.Size = new Size(289, 283);
            viewBookGrid.TabIndex = 47;
            // 
            // book_id
            // 
            book_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_id.HeaderText = "Book ID";
            book_id.Name = "book_id";
            book_id.ReadOnly = true;
            book_id.Resizable = DataGridViewTriState.False;
            // 
            // book_title
            // 
            book_title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_title.HeaderText = "Title";
            book_title.Name = "book_title";
            book_title.ReadOnly = true;
            book_title.Resizable = DataGridViewTriState.False;
            // 
            // book_status
            // 
            book_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_status.HeaderText = "Status";
            book_status.Name = "book_status";
            book_status.ReadOnly = true;
            book_status.Resizable = DataGridViewTriState.False;
            // 
            // book_category
            // 
            book_category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            book_category.HeaderText = "Category";
            book_category.Name = "book_category";
            book_category.ReadOnly = true;
            book_category.Resizable = DataGridViewTriState.False;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { member_id, member_name, member_email });
            dataGridView1.Location = new Point(307, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(294, 283);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // member_id
            // 
            member_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            member_id.HeaderText = "Member ID";
            member_id.Name = "member_id";
            member_id.ReadOnly = true;
            // 
            // member_name
            // 
            member_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            member_name.HeaderText = "Name";
            member_name.Name = "member_name";
            member_name.ReadOnly = true;
            // 
            // member_email
            // 
            member_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            member_email.HeaderText = "Email";
            member_email.Name = "member_email";
            member_email.ReadOnly = true;
            // 
            // viewBorrow_Grid
            // 
            viewBorrow_Grid.AllowUserToAddRows = false;
            viewBorrow_Grid.AllowUserToDeleteRows = false;
            viewBorrow_Grid.AllowUserToResizeColumns = false;
            viewBorrow_Grid.AllowUserToResizeRows = false;
            viewBorrow_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBorrow_Grid.Columns.AddRange(new DataGridViewColumn[] { borrow_id, memberid, bookid, borrow_date, due_date, return_date });
            viewBorrow_Grid.Location = new Point(619, 133);
            viewBorrow_Grid.Name = "viewBorrow_Grid";
            viewBorrow_Grid.RowHeadersVisible = false;
            viewBorrow_Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBorrow_Grid.Size = new Size(667, 387);
            viewBorrow_Grid.TabIndex = 49;
            viewBorrow_Grid.CellContentClick += viewBorrow_Grid_CellContentClick;
            // 
            // borrow_id
            // 
            borrow_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            borrow_id.HeaderText = "Borrow ID";
            borrow_id.Name = "borrow_id";
            borrow_id.ReadOnly = true;
            // 
            // memberid
            // 
            memberid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            memberid.HeaderText = "Member ID";
            memberid.Name = "memberid";
            memberid.ReadOnly = true;
            // 
            // bookid
            // 
            bookid.HeaderText = "Book ID";
            bookid.Name = "bookid";
            bookid.ReadOnly = true;
            // 
            // borrow_date
            // 
            borrow_date.HeaderText = "Borrow Date";
            borrow_date.Name = "borrow_date";
            borrow_date.ReadOnly = true;
            // 
            // due_date
            // 
            due_date.HeaderText = "Due Date";
            due_date.Name = "due_date";
            due_date.ReadOnly = true;
            // 
            // return_date
            // 
            return_date.HeaderText = "Return Date";
            return_date.Name = "return_date";
            return_date.ReadOnly = true;
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(1247, 99);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(28, 23);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 52;
            searchIcon.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(1069, 99);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search By ID";
            SearchBox.Size = new Size(207, 23);
            SearchBox.TabIndex = 51;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.Gray;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(985, 99);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 50;
            search_lbl.Text = "Search : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(572, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(442, 95);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Member";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(355, 95);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 53;
            label1.Text = "Search : ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 95);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Book";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 56;
            label2.Text = "Search : ";
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 582);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(searchIcon);
            Controls.Add(SearchBox);
            Controls.Add(search_lbl);
            Controls.Add(viewBorrow_Grid);
            Controls.Add(dataGridView1);
            Controls.Add(viewBookGrid);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker1);
            Controls.Add(ViewBook_btn);
            Controls.Add(B_Book);
            Controls.Add(BClear_btn);
            Controls.Add(BUpdate_btn);
            Controls.Add(BDelete_btn);
            Controls.Add(BAdd_btn);
            Controls.Add(DD_lbl);
            Controls.Add(BM_lbl);
            Controls.Add(BD_lbl);
            Name = "BorrowForm";
            Text = "BorrowForm";
            Load += BorrowForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)viewBorrow_Grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewBook_btn;
        private Button B_Book;
        private Button BClear_btn;
        private Button BUpdate_btn;
        private Button BDelete_btn;
        private Button BAdd_btn;
        private Label DD_lbl;
        private Label BM_lbl;
        private Label BD_lbl;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker3;
        private DataGridView viewBookGrid;
        private DataGridViewTextBoxColumn book_id;
        private DataGridViewTextBoxColumn book_title;
        private DataGridViewTextBoxColumn book_status;
        private DataGridViewTextBoxColumn book_category;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn member_id;
        private DataGridViewTextBoxColumn member_name;
        private DataGridViewTextBoxColumn member_email;
        private DataGridView viewBorrow_Grid;
        private DataGridViewTextBoxColumn borrow_id;
        private DataGridViewTextBoxColumn memberid;
        private DataGridViewTextBoxColumn bookid;
        private DataGridViewTextBoxColumn borrow_date;
        private DataGridViewTextBoxColumn due_date;
        private DataGridViewTextBoxColumn return_date;
        private PictureBox searchIcon;
        private TextBox SearchBox;
        private Label search_lbl;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label label2;
    }
}