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
            ViewAuthors_btn = new Button();
            Back_A = new Button();
            FPaid_btn = new Button();
            viewFineGrid = new DataGridView();
            MM_lbl = new Label();
            FineID = new DataGridViewTextBoxColumn();
            MemberId = new DataGridViewTextBoxColumn();
            BorrowId = new DataGridViewTextBoxColumn();
            FineAmount = new DataGridViewTextBoxColumn();
            PaymentStatus = new DataGridViewTextBoxColumn();
            FinePaid = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)viewFineGrid).BeginInit();
            SuspendLayout();
            // 
            // ViewAuthors_btn
            // 
            ViewAuthors_btn.BackColor = Color.DarkGray;
            ViewAuthors_btn.ForeColor = Color.White;
            ViewAuthors_btn.Location = new Point(598, 405);
            ViewAuthors_btn.Name = "ViewAuthors_btn";
            ViewAuthors_btn.Size = new Size(91, 33);
            ViewAuthors_btn.TabIndex = 69;
            ViewAuthors_btn.Text = "View All";
            ViewAuthors_btn.UseVisualStyleBackColor = false;
            // 
            // Back_A
            // 
            Back_A.BackColor = Color.IndianRed;
            Back_A.ForeColor = Color.White;
            Back_A.Location = new Point(695, 405);
            Back_A.Name = "Back_A";
            Back_A.Size = new Size(91, 33);
            Back_A.TabIndex = 68;
            Back_A.Text = "Back";
            Back_A.UseVisualStyleBackColor = false;
            // 
            // FPaid_btn
            // 
            FPaid_btn.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FPaid_btn.ForeColor = Color.DimGray;
            FPaid_btn.Location = new Point(23, 393);
            FPaid_btn.Name = "FPaid_btn";
            FPaid_btn.Size = new Size(121, 45);
            FPaid_btn.TabIndex = 64;
            FPaid_btn.Text = "Paid";
            FPaid_btn.UseVisualStyleBackColor = true;
            // 
            // viewFineGrid
            // 
            viewFineGrid.AllowUserToAddRows = false;
            viewFineGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewFineGrid.Columns.AddRange(new DataGridViewColumn[] { FineID, MemberId, BorrowId, FineAmount, PaymentStatus, FinePaid });
            viewFineGrid.Location = new Point(14, 78);
            viewFineGrid.Name = "viewFineGrid";
            viewFineGrid.RowHeadersVisible = false;
            viewFineGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            viewFineGrid.Size = new Size(772, 309);
            viewFineGrid.TabIndex = 60;
            // 
            // MM_lbl
            // 
            MM_lbl.AutoSize = true;
            MM_lbl.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MM_lbl.Location = new Point(216, 9);
            MM_lbl.Name = "MM_lbl";
            MM_lbl.Size = new Size(361, 50);
            MM_lbl.TabIndex = 70;
            MM_lbl.Text = "Fine Management";
            // 
            // FineID
            // 
            FineID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FineID.HeaderText = "Fine ID";
            FineID.Name = "FineID";
            FineID.ReadOnly = true;
            FineID.Resizable = DataGridViewTriState.False;
            // 
            // MemberId
            // 
            MemberId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MemberId.HeaderText = "Member ID";
            MemberId.Name = "MemberId";
            MemberId.ReadOnly = true;
            // 
            // BorrowId
            // 
            BorrowId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BorrowId.HeaderText = "Borrow ID";
            BorrowId.Name = "BorrowId";
            BorrowId.ReadOnly = true;
            BorrowId.Resizable = DataGridViewTriState.False;
            // 
            // FineAmount
            // 
            FineAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FineAmount.HeaderText = "Fine Amount";
            FineAmount.Name = "FineAmount";
            FineAmount.ReadOnly = true;
            FineAmount.Resizable = DataGridViewTriState.False;
            // 
            // PaymentStatus
            // 
            PaymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PaymentStatus.HeaderText = "Payment Status";
            PaymentStatus.Name = "PaymentStatus";
            PaymentStatus.ReadOnly = true;
            // 
            // FinePaid
            // 
            FinePaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FinePaid.HeaderText = "FinePaid";
            FinePaid.Name = "FinePaid";
            // 
            // Fine_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MM_lbl);
            Controls.Add(ViewAuthors_btn);
            Controls.Add(Back_A);
            Controls.Add(FPaid_btn);
            Controls.Add(viewFineGrid);
            Name = "Fine_Form";
            Text = "Fine_Form";
            ((System.ComponentModel.ISupportInitialize)viewFineGrid).EndInit();
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
        private DataGridView viewFineGrid;
        private Label MM_lbl;
        private DataGridViewTextBoxColumn FineID;
        private DataGridViewTextBoxColumn MemberId;
        private DataGridViewTextBoxColumn BorrowId;
        private DataGridViewTextBoxColumn FineAmount;
        private DataGridViewTextBoxColumn PaymentStatus;
        private DataGridViewButtonColumn FinePaid;
    }
}