namespace Smart_Library_Management_System.Fines
{
    partial class Fine_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fine_Form));
            ViewAuthors_btn = new Button();
            Back_A = new Button();
            FPaid_btn = new Button();
            dgvFines = new DataGridView();
            MM_lbl = new Label();
            pictureBox2 = new PictureBox();
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ViewAuthors_btn
            // 
            ViewAuthors_btn.BackColor = Color.DarkGray;
            ViewAuthors_btn.ForeColor = Color.White;
            ViewAuthors_btn.Location = new Point(938, 497);
            ViewAuthors_btn.Name = "ViewAuthors_btn";
            ViewAuthors_btn.Size = new Size(91, 33);
            ViewAuthors_btn.TabIndex = 69;
            ViewAuthors_btn.Text = "View All";
            ViewAuthors_btn.UseVisualStyleBackColor = false;
            ViewAuthors_btn.Click += ViewAuthors_btn_Click;
            // 
            // Back_A
            // 
            Back_A.BackColor = Color.IndianRed;
            Back_A.ForeColor = Color.White;
            Back_A.Location = new Point(1035, 497);
            Back_A.Name = "Back_A";
            Back_A.Size = new Size(91, 33);
            Back_A.TabIndex = 68;
            Back_A.Text = "Back";
            Back_A.UseVisualStyleBackColor = false;
            Back_A.Click += Back_A_Click;
            // 
            // FPaid_btn
            // 
            FPaid_btn.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FPaid_btn.ForeColor = Color.DimGray;
            FPaid_btn.Location = new Point(45, 497);
            FPaid_btn.Name = "FPaid_btn";
            FPaid_btn.Size = new Size(121, 45);
            FPaid_btn.TabIndex = 64;
            FPaid_btn.Text = "Paid";
            FPaid_btn.UseVisualStyleBackColor = true;
            FPaid_btn.Click += FPaid_btn_Click;
            // 
            // dgvFines
            // 
            dgvFines.AllowUserToAddRows = false;
            dgvFines.AllowUserToDeleteRows = false;
            dgvFines.AllowUserToResizeColumns = false;
            dgvFines.AllowUserToResizeRows = false;
            dgvFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFines.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFines.EnableHeadersVisualStyles = false;
            dgvFines.Location = new Point(27, 96);
            dgvFines.Name = "dgvFines";
            dgvFines.ReadOnly = true;
            dgvFines.RowHeadersVisible = false;
            dgvFines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFines.Size = new Size(1099, 395);
            dgvFines.TabIndex = 60;
            dgvFines.DataBindingComplete += dgvFines_DataBindingComplete;
            // 
            // MM_lbl
            // 
            MM_lbl.AutoSize = true;
            MM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MM_lbl.Location = new Point(424, 9);
            MM_lbl.Name = "MM_lbl";
            MM_lbl.Size = new Size(361, 50);
            MM_lbl.TabIndex = 70;
            MM_lbl.Text = "Fine Management";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1087, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(899, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Fine by Name";
            txtSearch.Size = new Size(217, 23);
            txtSearch.TabIndex = 72;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(811, 67);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 71;
            label2.Text = "Search : ";
            // 
            // Fine_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(pictureBox2);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(MM_lbl);
            Controls.Add(ViewAuthors_btn);
            Controls.Add(Back_A);
            Controls.Add(FPaid_btn);
            Controls.Add(dgvFines);
            Name = "Fine_Form";
            Text = "Fine_Form";
            ((System.ComponentModel.ISupportInitialize)dgvFines).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn AuthorNationality;
        private DataGridViewTextBoxColumn AuthorID;
        private DataGridViewTextBoxColumn AutorName;
        private Button ViewAuthors_btn;
        private Button Back_A;
        private Button AClear_btn;
        private Button AUpdate_btn;
        private Button ADelete_btn;
        private Button FPaid_btn;
        private DataGridView dgvFines;
        private Label MM_lbl;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
        private Label label2;
    }
}