namespace Smart_Library_Management_System.Members
{
    partial class Member_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Form));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ViewMember_btn = new Button();
            btnClose = new Button();
            txt_name = new TextBox();
            txt_email = new TextBox();
            ANat_lbl = new Label();
            MM_lbl = new Label();
            AN_lbl = new Label();
            searchIcon = new PictureBox();
            txtSearch = new TextBox();
            search_lbl = new Label();
            dgvMembers = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnClear);
            panel1.Location = new Point(22, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 156);
            panel1.TabIndex = 66;
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
            btnAdd.Click += btnAdd_Click;
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
            btnUpdate.Click += btnUpdate_Click;
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
            // ViewMember_btn
            // 
            ViewMember_btn.BackColor = Color.DarkGray;
            ViewMember_btn.ForeColor = Color.White;
            ViewMember_btn.Location = new Point(928, 496);
            ViewMember_btn.Name = "ViewMember_btn";
            ViewMember_btn.Size = new Size(91, 33);
            ViewMember_btn.TabIndex = 65;
            ViewMember_btn.Text = "View All";
            ViewMember_btn.UseVisualStyleBackColor = false;
            ViewMember_btn.Click += ViewMember_btn_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1025, 496);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 33);
            btnClose.TabIndex = 64;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(158, 122);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Full Name";
            txt_name.Size = new Size(195, 23);
            txt_name.TabIndex = 63;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(158, 162);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Email";
            txt_email.Size = new Size(195, 23);
            txt_email.TabIndex = 62;
            txt_email.Text = "@gmail.com";
            // 
            // ANat_lbl
            // 
            ANat_lbl.AutoSize = true;
            ANat_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ANat_lbl.Location = new Point(33, 165);
            ANat_lbl.Name = "ANat_lbl";
            ANat_lbl.Size = new Size(94, 20);
            ANat_lbl.TabIndex = 60;
            ANat_lbl.Text = "Enter Email : ";
            // 
            // MM_lbl
            // 
            MM_lbl.AutoSize = true;
            MM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MM_lbl.Location = new Point(387, 15);
            MM_lbl.Name = "MM_lbl";
            MM_lbl.Size = new Size(433, 50);
            MM_lbl.TabIndex = 59;
            MM_lbl.Text = "Member Management";
            // 
            // AN_lbl
            // 
            AN_lbl.AutoSize = true;
            AN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AN_lbl.Location = new Point(33, 125);
            AN_lbl.Name = "AN_lbl";
            AN_lbl.Size = new Size(93, 20);
            AN_lbl.TabIndex = 58;
            AN_lbl.Text = "Enter Name : ";
            // 
            // searchIcon
            // 
            searchIcon.Image = (Image)resources.GetObject("searchIcon.Image");
            searchIcon.Location = new Point(1088, 83);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(27, 20);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 69;
            searchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(879, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Member By Name or Email";
            txtSearch.Size = new Size(238, 23);
            txtSearch.TabIndex = 68;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // search_lbl
            // 
            search_lbl.AutoSize = true;
            search_lbl.BackColor = Color.Gray;
            search_lbl.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lbl.ForeColor = Color.White;
            search_lbl.Location = new Point(791, 81);
            search_lbl.Name = "search_lbl";
            search_lbl.Size = new Size(88, 23);
            search_lbl.TabIndex = 67;
            search_lbl.Text = "Search : ";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeColumns = false;
            dgvMembers.AllowUserToResizeRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Location = new Point(433, 112);
            dgvMembers.Name = "dgvMembers";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(693, 378);
            dgvMembers.TabIndex = 70;
            dgvMembers.CellClick += dgvMembers_CellClick_1;
            // 
            // Member_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(dgvMembers);
            Controls.Add(panel1);
            Controls.Add(ViewMember_btn);
            Controls.Add(btnClose);
            Controls.Add(txt_name);
            Controls.Add(txt_email);
            Controls.Add(ANat_lbl);
            Controls.Add(MM_lbl);
            Controls.Add(AN_lbl);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
            Controls.Add(search_lbl);
            Name = "Member_Form";
            Text = "Member_Form";
            Load += Member_Form_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button ViewMember_btn;
        private Button btnClose;
        private TextBox txt_name;
        private TextBox txt_email;
        private Label ANat_lbl;
        private Label MM_lbl;
        private Label AN_lbl;
        private PictureBox searchIcon;
        private TextBox txtSearch;
        private Label search_lbl;
        private DataGridView dgvMembers;
    }
}