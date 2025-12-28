namespace Smart_Library_Management_System.Borrows
{
    partial class ActiveBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveBorrow));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            searchIcon = new PictureBox();
            SearchBox = new TextBox();
            search_lbl = new Label();
            dgvActiveBorrows = new DataGridView();
            BM_lbl = new Label();
            btnReturn = new Button();
            B_Book = new Button();
            btnRefresh = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvActiveBorrows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(1083, 79);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(28, 23);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 56;
            searchIcon.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(905, 79);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search By ID or Name";
            SearchBox.Size = new Size(207, 23);
            SearchBox.TabIndex = 55;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.Gray;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(821, 79);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 54;
            search_lbl.Text = "Search : ";
            // 
            // dgvActiveBorrows
            // 
            dgvActiveBorrows.AllowUserToAddRows = false;
            dgvActiveBorrows.AllowUserToDeleteRows = false;
            dgvActiveBorrows.AllowUserToResizeColumns = false;
            dgvActiveBorrows.AllowUserToResizeRows = false;
            dgvActiveBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvActiveBorrows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvActiveBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveBorrows.EnableHeadersVisualStyles = false;
            dgvActiveBorrows.Location = new Point(53, 114);
            dgvActiveBorrows.Name = "dgvActiveBorrows";
            dgvActiveBorrows.RowHeadersVisible = false;
            dgvActiveBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveBorrows.Size = new Size(1059, 367);
            dgvActiveBorrows.TabIndex = 53;
            // 
            // BM_lbl
            // 
            BM_lbl.AutoSize = true;
            BM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_lbl.Location = new Point(438, 5);
            BM_lbl.Name = "BM_lbl";
            BM_lbl.Size = new Size(302, 50);
            BM_lbl.TabIndex = 57;
            BM_lbl.Text = " Borrow Books";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DarkGray;
            btnReturn.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(876, 500);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(133, 33);
            btnReturn.TabIndex = 59;
            btnReturn.Text = "Return Book";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // B_Book
            // 
            B_Book.BackColor = Color.IndianRed;
            B_Book.ForeColor = Color.White;
            B_Book.Location = new Point(1024, 500);
            B_Book.Name = "B_Book";
            B_Book.Size = new Size(91, 33);
            B_Book.TabIndex = 58;
            B_Book.Text = "Back";
            B_Book.UseVisualStyleBackColor = false;
            B_Book.Click += B_Book_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkGray;
            btnRefresh.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(53, 500);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 33);
            btnRefresh.TabIndex = 60;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 61);
            panel2.TabIndex = 61;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1137, 547);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // ActiveBorrow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(btnRefresh);
            Controls.Add(btnReturn);
            Controls.Add(B_Book);
            Controls.Add(BM_lbl);
            Controls.Add(searchIcon);
            Controls.Add(SearchBox);
            Controls.Add(search_lbl);
            Controls.Add(dgvActiveBorrows);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "ActiveBorrow";
            Text = "ActiveBorrow";
            Load += ActiveBorrow_Load;
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvActiveBorrows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox searchIcon;
        private TextBox SearchBox;
        private Label search_lbl;
        private DataGridView dgvActiveBorrows;
        private Label BM_lbl;
        private Button btnReturn;
        private Button B_Book;
        private Button btnRefresh;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}