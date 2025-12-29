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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            btnBorrow = new Button();
            B_Book = new Button();
            BM_lbl = new Label();
            dgvAvailableBooks = new DataGridView();
            dgvMembers = new DataGridView();
            pictureBox2 = new PictureBox();
            txtSearchBook = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtSeachMember = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.DarkGray;
            btnBorrow.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = Color.White;
            btnBorrow.Location = new Point(863, 500);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(133, 33);
            btnBorrow.TabIndex = 39;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // B_Book
            // 
            B_Book.BackColor = Color.IndianRed;
            B_Book.ForeColor = Color.White;
            B_Book.Location = new Point(1011, 500);
            B_Book.Name = "B_Book";
            B_Book.Size = new Size(91, 33);
            B_Book.TabIndex = 38;
            B_Book.Text = "Back";
            B_Book.UseVisualStyleBackColor = false;
            B_Book.Click += B_Book_Click;
            // 
            // BM_lbl
            // 
            BM_lbl.AutoSize = true;
            BM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_lbl.Location = new Point(490, 2);
            BM_lbl.Name = "BM_lbl";
            BM_lbl.Size = new Size(253, 50);
            BM_lbl.TabIndex = 22;
            BM_lbl.Text = "Issue Books";
            // 
            // dgvAvailableBooks
            // 
            dgvAvailableBooks.AllowUserToAddRows = false;
            dgvAvailableBooks.AllowUserToDeleteRows = false;
            dgvAvailableBooks.AllowUserToResizeColumns = false;
            dgvAvailableBooks.AllowUserToResizeRows = false;
            dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAvailableBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvailableBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableBooks.EnableHeadersVisualStyles = false;
            dgvAvailableBooks.Location = new Point(28, 116);
            dgvAvailableBooks.Name = "dgvAvailableBooks";
            dgvAvailableBooks.RowHeadersVisible = false;
            dgvAvailableBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableBooks.ShowRowErrors = false;
            dgvAvailableBooks.Size = new Size(526, 367);
            dgvAvailableBooks.TabIndex = 47;
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeColumns = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Location = new Point(587, 116);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(536, 367);
            dgvMembers.TabIndex = 48;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(525, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // txtSearchBook
            // 
            txtSearchBook.Location = new Point(337, 83);
            txtSearchBook.Name = "txtSearchBook";
            txtSearchBook.PlaceholderText = "Search Book by Name or ISBN";
            txtSearchBook.Size = new Size(217, 23);
            txtSearchBook.TabIndex = 57;
            txtSearchBook.TextChanged += txtSearchBook_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(249, 83);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 56;
            label2.Text = "Search : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1093, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // txtSeachMember
            // 
            txtSeachMember.Location = new Point(895, 84);
            txtSeachMember.Name = "txtSeachMember";
            txtSeachMember.PlaceholderText = "Search Member by Name or Email";
            txtSeachMember.Size = new Size(227, 23);
            txtSeachMember.TabIndex = 60;
            txtSeachMember.TextChanged += txtSeachMember_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(809, 84);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 59;
            label1.Text = "Search : ";
            // 
            // panel2
            // 
            panel2.Location = new Point(1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 61);
            panel2.TabIndex = 62;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1137, 547);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 63;
            pictureBox3.TabStop = false;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(pictureBox1);
            Controls.Add(txtSeachMember);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(txtSearchBook);
            Controls.Add(label2);
            Controls.Add(dgvMembers);
            Controls.Add(dgvAvailableBooks);
            Controls.Add(btnBorrow);
            Controls.Add(B_Book);
            Controls.Add(BM_lbl);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Name = "BorrowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowForm";
            ((System.ComponentModel.ISupportInitialize)dgvAvailableBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrow;
        private Button B_Book;
        private Label BM_lbl;
        private DataGridView dgvAvailableBooks;
        private DataGridView dgvMembers;
        private PictureBox pictureBox2;
        private TextBox txtSearchBook;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtSeachMember;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox3;
    }
}