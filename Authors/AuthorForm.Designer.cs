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
            ViewMember_btn = new Button();
            Back_M = new Button();
            MClear_btn = new Button();
            MUpdate_btn = new Button();
            MDelete_btn = new Button();
            MAdd_btn = new Button();
            AN_box = new TextBox();
            ANat_box = new TextBox();
            viewBookGrid = new DataGridView();
            ANat_lbl = new Label();
            AM_lbl = new Label();
            AN_lbl = new Label();
            author_id = new DataGridViewTextBoxColumn();
            author_name = new DataGridViewTextBoxColumn();
            author_nationality = new DataGridViewTextBoxColumn();
            totalBooks = new DataGridViewTextBoxColumn();
            author_availableBooks = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).BeginInit();
            SuspendLayout();
            // 
            // ViewMember_btn
            // 
            ViewMember_btn.BackColor = Color.DarkGray;
            ViewMember_btn.ForeColor = Color.White;
            ViewMember_btn.Location = new Point(596, 393);
            ViewMember_btn.Name = "ViewMember_btn";
            ViewMember_btn.Size = new Size(91, 33);
            ViewMember_btn.TabIndex = 53;
            ViewMember_btn.Text = "View All";
            ViewMember_btn.UseVisualStyleBackColor = false;
            // 
            // Back_M
            // 
            Back_M.BackColor = Color.IndianRed;
            Back_M.ForeColor = Color.White;
            Back_M.Location = new Point(693, 393);
            Back_M.Name = "Back_M";
            Back_M.Size = new Size(91, 33);
            Back_M.TabIndex = 52;
            Back_M.Text = "Back";
            Back_M.UseVisualStyleBackColor = false;
            // 
            // MClear_btn
            // 
            MClear_btn.BackColor = Color.Khaki;
            MClear_btn.Location = new Point(222, 405);
            MClear_btn.Name = "MClear_btn";
            MClear_btn.Size = new Size(91, 33);
            MClear_btn.TabIndex = 51;
            MClear_btn.Text = "Clear";
            MClear_btn.UseVisualStyleBackColor = false;
            // 
            // MUpdate_btn
            // 
            MUpdate_btn.Location = new Point(26, 405);
            MUpdate_btn.Name = "MUpdate_btn";
            MUpdate_btn.Size = new Size(91, 33);
            MUpdate_btn.TabIndex = 50;
            MUpdate_btn.Text = "Update";
            MUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // MDelete_btn
            // 
            MDelete_btn.Location = new Point(124, 405);
            MDelete_btn.Name = "MDelete_btn";
            MDelete_btn.Size = new Size(91, 33);
            MDelete_btn.TabIndex = 49;
            MDelete_btn.Text = "Delete";
            MDelete_btn.UseVisualStyleBackColor = true;
            // 
            // MAdd_btn
            // 
            MAdd_btn.Location = new Point(14, 224);
            MAdd_btn.Name = "MAdd_btn";
            MAdd_btn.Size = new Size(91, 33);
            MAdd_btn.TabIndex = 48;
            MAdd_btn.Text = "Add";
            MAdd_btn.UseVisualStyleBackColor = true;
            // 
            // AN_box
            // 
            AN_box.Location = new Point(137, 126);
            AN_box.Name = "AN_box";
            AN_box.PlaceholderText = "Full Name";
            AN_box.Size = new Size(137, 23);
            AN_box.TabIndex = 47;
            // 
            // ANat_box
            // 
            ANat_box.Location = new Point(137, 166);
            ANat_box.Name = "ANat_box";
            ANat_box.PlaceholderText = "Nationality";
            ANat_box.Size = new Size(137, 23);
            ANat_box.TabIndex = 46;
            // 
            // viewBookGrid
            // 
            viewBookGrid.AllowUserToAddRows = false;
            viewBookGrid.AllowUserToDeleteRows = false;
            viewBookGrid.AllowUserToResizeColumns = false;
            viewBookGrid.AllowUserToResizeRows = false;
            viewBookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookGrid.Columns.AddRange(new DataGridViewColumn[] { author_id, author_name, author_nationality, totalBooks, author_availableBooks });
            viewBookGrid.Location = new Point(289, 90);
            viewBookGrid.Name = "viewBookGrid";
            viewBookGrid.RowHeadersVisible = false;
            viewBookGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBookGrid.Size = new Size(499, 283);
            viewBookGrid.TabIndex = 45;
            // 
            // ANat_lbl
            // 
            ANat_lbl.AutoSize = true;
            ANat_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ANat_lbl.Location = new Point(12, 169);
            ANat_lbl.Name = "ANat_lbl";
            ANat_lbl.Size = new Size(124, 20);
            ANat_lbl.TabIndex = 43;
            ANat_lbl.Text = "Enter Nationality : ";
            // 
            // AM_lbl
            // 
            AM_lbl.AutoSize = true;
            AM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AM_lbl.Location = new Point(232, 9);
            AM_lbl.Name = "AM_lbl";
            AM_lbl.Size = new Size(408, 50);
            AM_lbl.TabIndex = 42;
            AM_lbl.Text = "Author Management";
            // 
            // AN_lbl
            // 
            AN_lbl.AutoSize = true;
            AN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AN_lbl.Location = new Point(12, 129);
            AN_lbl.Name = "AN_lbl";
            AN_lbl.Size = new Size(93, 20);
            AN_lbl.TabIndex = 41;
            AN_lbl.Text = "Enter Name : ";
            // 
            // author_id
            // 
            author_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author_id.HeaderText = "Author ID";
            author_id.Name = "author_id";
            author_id.ReadOnly = true;
            // 
            // author_name
            // 
            author_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author_name.HeaderText = "Name";
            author_name.Name = "author_name";
            author_name.ReadOnly = true;
            // 
            // author_nationality
            // 
            author_nationality.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author_nationality.HeaderText = "Nationality";
            author_nationality.Name = "author_nationality";
            author_nationality.ReadOnly = true;
            author_nationality.Resizable = DataGridViewTriState.False;
            // 
            // totalBooks
            // 
            totalBooks.HeaderText = "Total Available";
            totalBooks.Name = "totalBooks";
            totalBooks.ReadOnly = true;
            totalBooks.Width = 130;
            // 
            // author_availableBooks
            // 
            author_availableBooks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            author_availableBooks.HeaderText = "Books List";
            author_availableBooks.Name = "author_availableBooks";
            author_availableBooks.ReadOnly = true;
            author_availableBooks.Resizable = DataGridViewTriState.False;
            author_availableBooks.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ViewMember_btn);
            Controls.Add(Back_M);
            Controls.Add(MClear_btn);
            Controls.Add(MUpdate_btn);
            Controls.Add(MDelete_btn);
            Controls.Add(MAdd_btn);
            Controls.Add(AN_box);
            Controls.Add(ANat_box);
            Controls.Add(viewBookGrid);
            Controls.Add(ANat_lbl);
            Controls.Add(AM_lbl);
            Controls.Add(AN_lbl);
            Name = "AuthorForm";
            Text = "AuthorForm";
            Load += AuthorForm_Load;
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker MDate_Picker;
        private Button MClear_btn;
        private Button MUpdate_btn;
        private Button MDelete_btn;
        private Button MAdd_btn;
        private TextBox AN_box;
        private TextBox ANat_box;
        private TextBox BI_box;
        private DataGridView viewBookGrid;
        private Label BAID_lbl;
        private Label MID_lbl;
        private Label ANat_lbl;
        private Button ViewMember_btn;
        private Button Back_M;
        private Label AM_lbl;
        private Label AN_lbl;
        private DataGridViewTextBoxColumn author_id;
        private DataGridViewTextBoxColumn author_name;
        private DataGridViewTextBoxColumn author_nationality;
        private DataGridViewTextBoxColumn totalBooks;
        private DataGridViewComboBoxColumn author_availableBooks;
    }
}