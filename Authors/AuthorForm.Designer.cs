namespace Smart_Library_Management_System.Authors
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            ViewMember_btn = new Button();
            btnClose = new Button();
            txtAuthorName = new TextBox();
            txtNationality = new TextBox();
            dgvAuthors = new DataGridView();
            ANat_lbl = new Label();
            AM_lbl = new Label();
            AN_lbl = new Label();
            panel1 = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            searchIcon = new PictureBox();
            txtSearch = new TextBox();
            search_lbl = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ViewMember_btn
            // 
            ViewMember_btn.BackColor = Color.DarkGray;
            ViewMember_btn.ForeColor = Color.White;
            ViewMember_btn.Location = new Point(918, 500);
            ViewMember_btn.Name = "ViewMember_btn";
            ViewMember_btn.Size = new Size(91, 33);
            ViewMember_btn.TabIndex = 53;
            ViewMember_btn.Text = "View All";
            ViewMember_btn.UseVisualStyleBackColor = false;
            ViewMember_btn.Click += ViewMember_btn_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1015, 500);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 33);
            btnClose.TabIndex = 52;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(135, 19);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Full Name";
            txtAuthorName.Size = new Size(178, 23);
            txtAuthorName.TabIndex = 47;
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(135, 59);
            txtNationality.Name = "txtNationality";
            txtNationality.PlaceholderText = "Nationality";
            txtNationality.Size = new Size(178, 23);
            txtNationality.TabIndex = 46;
            // 
            // dgvAuthors
            // 
            dgvAuthors.AllowUserToAddRows = false;
            dgvAuthors.AllowUserToDeleteRows = false;
            dgvAuthors.AllowUserToResizeColumns = false;
            dgvAuthors.AllowUserToResizeRows = false;
            dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.EnableHeadersVisualStyles = false;
            dgvAuthors.Location = new Point(413, 113);
            dgvAuthors.Name = "dgvAuthors";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAuthors.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuthors.Size = new Size(693, 378);
            dgvAuthors.TabIndex = 45;
            dgvAuthors.CellClick += dgvAuthors_CellClick_1;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // ANat_lbl
            // 
            ANat_lbl.AutoSize = true;
            ANat_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ANat_lbl.ForeColor = Color.Black;
            ANat_lbl.Location = new Point(10, 62);
            ANat_lbl.Name = "ANat_lbl";
            ANat_lbl.Size = new Size(124, 20);
            ANat_lbl.TabIndex = 43;
            ANat_lbl.Text = "Enter Nationality : ";
            ANat_lbl.Click += ANat_lbl_Click;
            // 
            // AM_lbl
            // 
            AM_lbl.AutoSize = true;
            AM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AM_lbl.Location = new Point(377, 7);
            AM_lbl.Name = "AM_lbl";
            AM_lbl.Size = new Size(408, 50);
            AM_lbl.TabIndex = 42;
            AM_lbl.Text = "Author Management";
            // 
            // AN_lbl
            // 
            AN_lbl.AutoSize = true;
            AN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AN_lbl.ForeColor = Color.Black;
            AN_lbl.Location = new Point(10, 22);
            AN_lbl.Name = "AN_lbl";
            AN_lbl.Size = new Size(93, 20);
            AN_lbl.TabIndex = 41;
            AN_lbl.Text = "Enter Name : ";
            AN_lbl.Click += AN_lbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtNationality);
            panel1.Controls.Add(txtAuthorName);
            panel1.Controls.Add(AN_lbl);
            panel1.Controls.Add(ANat_lbl);
            panel1.Location = new Point(40, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 241);
            panel1.TabIndex = 54;
            panel1.Paint += panel1_Paint;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(13, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 45);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(13, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 45);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(169, 108);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 45);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Khaki;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnClear.Location = new Point(169, 177);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 45);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(1078, 86);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(27, 20);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 57;
            searchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(869, 85);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Author By Name or Ntionality";
            txtSearch.Size = new Size(238, 23);
            txtSearch.TabIndex = 56;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.WhiteSmoke;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.Black;
            search_lbl.Location = new Point(781, 85);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 55;
            search_lbl.Text = "Search : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1137, 547);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 61);
            panel2.TabIndex = 59;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
            Controls.Add(search_lbl);
            Controls.Add(ViewMember_btn);
            Controls.Add(btnClose);
            Controls.Add(dgvAuthors);
            Controls.Add(AM_lbl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "AuthorForm";
            Text = "AuthorForm";
            Load += AuthorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker MDate_Picker;
        private TextBox txtAuthorName;
        private TextBox txtNationality;
        private TextBox BI_box;
        private DataGridView dgvAuthors;
        private Label BAID_lbl;
        private Label MID_lbl;
        private Label ANat_lbl;
        private Button ViewMember_btn;
        private Button btnClose;
        private Label AM_lbl;
        private Label AN_lbl;
        private Panel panel1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private PictureBox searchIcon;
        private TextBox txtSearch;
        private Label search_lbl;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}