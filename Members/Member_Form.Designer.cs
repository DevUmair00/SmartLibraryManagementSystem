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
            ViewMember_btn = new Button();
            Back_M = new Button();
            MClear_btn = new Button();
            MUpdate_btn = new Button();
            MDelete_btn = new Button();
            MAdd_btn = new Button();
            BT_box = new TextBox();
            BISBN_box = new TextBox();
            viewBookGrid = new DataGridView();
            member_id = new DataGridViewTextBoxColumn();
            member_name = new DataGridViewTextBoxColumn();
            member_email = new DataGridViewTextBoxColumn();
            membership_date = new DataGridViewTextBoxColumn();
            BAID_lbl = new Label();
            BISBN_lbl = new Label();
            MM_lbl = new Label();
            MN_lbl = new Label();
            MDate_Picker = new DateTimePicker();
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
            ViewMember_btn.TabIndex = 39;
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
            Back_M.TabIndex = 38;
            Back_M.Text = "Back";
            Back_M.UseVisualStyleBackColor = false;
            // 
            // MClear_btn
            // 
            MClear_btn.BackColor = Color.Khaki;
            MClear_btn.Location = new Point(312, 393);
            MClear_btn.Name = "MClear_btn";
            MClear_btn.Size = new Size(91, 33);
            MClear_btn.TabIndex = 37;
            MClear_btn.Text = "Clear";
            MClear_btn.UseVisualStyleBackColor = false;
            // 
            // MUpdate_btn
            // 
            MUpdate_btn.Location = new Point(116, 393);
            MUpdate_btn.Name = "MUpdate_btn";
            MUpdate_btn.Size = new Size(91, 33);
            MUpdate_btn.TabIndex = 36;
            MUpdate_btn.Text = "Update";
            MUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // MDelete_btn
            // 
            MDelete_btn.Location = new Point(214, 393);
            MDelete_btn.Name = "MDelete_btn";
            MDelete_btn.Size = new Size(91, 33);
            MDelete_btn.TabIndex = 35;
            MDelete_btn.Text = "Delete";
            MDelete_btn.UseVisualStyleBackColor = true;
            // 
            // MAdd_btn
            // 
            MAdd_btn.Location = new Point(12, 393);
            MAdd_btn.Name = "MAdd_btn";
            MAdd_btn.Size = new Size(91, 33);
            MAdd_btn.TabIndex = 34;
            MAdd_btn.Text = "Add";
            MAdd_btn.UseVisualStyleBackColor = true;
            // 
            // BT_box
            // 
            BT_box.Location = new Point(137, 126);
            BT_box.Name = "BT_box";
            BT_box.PlaceholderText = "Full Name";
            BT_box.Size = new Size(137, 23);
            BT_box.TabIndex = 33;
            // 
            // BISBN_box
            // 
            BISBN_box.Location = new Point(137, 166);
            BISBN_box.Name = "BISBN_box";
            BISBN_box.PlaceholderText = "Email";
            BISBN_box.Size = new Size(137, 23);
            BISBN_box.TabIndex = 32;
            // 
            // viewBookGrid
            // 
            viewBookGrid.AllowUserToAddRows = false;
            viewBookGrid.AllowUserToDeleteRows = false;
            viewBookGrid.AllowUserToResizeColumns = false;
            viewBookGrid.AllowUserToResizeRows = false;
            viewBookGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewBookGrid.Columns.AddRange(new DataGridViewColumn[] { member_id, member_name, member_email, membership_date });
            viewBookGrid.Location = new Point(289, 90);
            viewBookGrid.Name = "viewBookGrid";
            viewBookGrid.RowHeadersVisible = false;
            viewBookGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewBookGrid.Size = new Size(499, 283);
            viewBookGrid.TabIndex = 29;
            // 
            // member_id
            // 
            member_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            member_id.HeaderText = "ID";
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
            // membership_date
            // 
            membership_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            membership_date.HeaderText = "Membership Date";
            membership_date.Name = "membership_date";
            membership_date.ReadOnly = true;
            // 
            // BAID_lbl
            // 
            BAID_lbl.AutoSize = true;
            BAID_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BAID_lbl.Location = new Point(12, 245);
            BAID_lbl.Name = "BAID_lbl";
            BAID_lbl.Size = new Size(171, 20);
            BAID_lbl.TabIndex = 25;
            BAID_lbl.Text = "Select Membership Date : ";
            // 
            // BISBN_lbl
            // 
            BISBN_lbl.AutoSize = true;
            BISBN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BISBN_lbl.Location = new Point(12, 169);
            BISBN_lbl.Name = "BISBN_lbl";
            BISBN_lbl.Size = new Size(94, 20);
            BISBN_lbl.TabIndex = 23;
            BISBN_lbl.Text = "Enter Email : ";
            // 
            // MM_lbl
            // 
            MM_lbl.AutoSize = true;
            MM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MM_lbl.Location = new Point(235, 25);
            MM_lbl.Name = "MM_lbl";
            MM_lbl.Size = new Size(433, 50);
            MM_lbl.TabIndex = 22;
            MM_lbl.Text = "Member Management";
            // 
            // MN_lbl
            // 
            MN_lbl.AutoSize = true;
            MN_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MN_lbl.Location = new Point(12, 129);
            MN_lbl.Name = "MN_lbl";
            MN_lbl.Size = new Size(93, 20);
            MN_lbl.TabIndex = 21;
            MN_lbl.Text = "Enter Name : ";
            // 
            // MDate_Picker
            // 
            MDate_Picker.CalendarFont = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MDate_Picker.Location = new Point(12, 278);
            MDate_Picker.Name = "MDate_Picker";
            MDate_Picker.Size = new Size(217, 23);
            MDate_Picker.TabIndex = 40;
            MDate_Picker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Member_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MDate_Picker);
            Controls.Add(ViewMember_btn);
            Controls.Add(Back_M);
            Controls.Add(MClear_btn);
            Controls.Add(MUpdate_btn);
            Controls.Add(MDelete_btn);
            Controls.Add(MAdd_btn);
            Controls.Add(BT_box);
            Controls.Add(BISBN_box);
            Controls.Add(viewBookGrid);
            Controls.Add(BAID_lbl);
            Controls.Add(BISBN_lbl);
            Controls.Add(MM_lbl);
            Controls.Add(MN_lbl);
            Name = "Member_Form";
            Text = "Member_Form";
            ((System.ComponentModel.ISupportInitialize)viewBookGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewMember_btn;
        private Button Back_M;
        private Button MClear_btn;
        private Button MUpdate_btn;
        private Button MDelete_btn;
        private Button MAdd_btn;
        private TextBox BT_box;
        private TextBox BISBN_box;
        private DataGridView viewBookGrid;
        private Label BAID_lbl;
        private Label BISBN_lbl;
        private Label MM_lbl;
        private Label MN_lbl;
        private DateTimePicker MDate_Picker;
        private DataGridViewTextBoxColumn member_id;
        private DataGridViewTextBoxColumn member_name;
        private DataGridViewTextBoxColumn member_email;
        private DataGridViewTextBoxColumn membership_date;
    }
}