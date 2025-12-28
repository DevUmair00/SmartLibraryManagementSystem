namespace Smart_Library_Management_System
{
    partial class Smart_Library
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Smart_Library));
            SLMS_Label = new Label();
            AM_btn = new Button();
            BM_btn = new Button();
            MM_btn = new Button();
            btn_newBorrow = new Button();
            FS_btn = new Button();
            btn_activeBorrow = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SLMS_Label
            // 
            SLMS_Label.AutoSize = true;
            SLMS_Label.BackColor = SystemColors.Control;
            SLMS_Label.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SLMS_Label.ForeColor = Color.Black;
            SLMS_Label.Location = new Point(283, 9);
            SLMS_Label.Name = "SLMS_Label";
            SLMS_Label.Size = new Size(638, 45);
            SLMS_Label.TabIndex = 0;
            SLMS_Label.Text = "Smart Library Management System";
            SLMS_Label.Click += SLMS_Label_Click;
            // 
            // AM_btn
            // 
            AM_btn.BackColor = Color.WhiteSmoke;
            AM_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AM_btn.ForeColor = Color.DimGray;
            AM_btn.Location = new Point(447, 168);
            AM_btn.Name = "AM_btn";
            AM_btn.Size = new Size(314, 55);
            AM_btn.TabIndex = 1;
            AM_btn.Text = "Author Management";
            AM_btn.UseVisualStyleBackColor = false;
            AM_btn.Click += AM_btn_Click;
            // 
            // BM_btn
            // 
            BM_btn.BackColor = Color.WhiteSmoke;
            BM_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_btn.ForeColor = Color.DimGray;
            BM_btn.Location = new Point(447, 240);
            BM_btn.Name = "BM_btn";
            BM_btn.Size = new Size(314, 55);
            BM_btn.TabIndex = 2;
            BM_btn.Text = "Book Management";
            BM_btn.UseVisualStyleBackColor = false;
            BM_btn.Click += BM_btn_Click;
            // 
            // MM_btn
            // 
            MM_btn.BackColor = Color.WhiteSmoke;
            MM_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MM_btn.ForeColor = Color.DimGray;
            MM_btn.Location = new Point(447, 317);
            MM_btn.Name = "MM_btn";
            MM_btn.Size = new Size(314, 55);
            MM_btn.TabIndex = 3;
            MM_btn.Text = "Member Management";
            MM_btn.UseVisualStyleBackColor = false;
            MM_btn.Click += MM_btn_Click;
            // 
            // btn_newBorrow
            // 
            btn_newBorrow.BackColor = SystemColors.Menu;
            btn_newBorrow.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_newBorrow.ForeColor = Color.DimGray;
            btn_newBorrow.Location = new Point(476, 414);
            btn_newBorrow.Name = "btn_newBorrow";
            btn_newBorrow.Size = new Size(195, 101);
            btn_newBorrow.TabIndex = 4;
            btn_newBorrow.Text = "New Borrow";
            btn_newBorrow.UseVisualStyleBackColor = false;
            btn_newBorrow.Click += btn_newBorrow_Click;
            // 
            // FS_btn
            // 
            FS_btn.BackColor = SystemColors.Menu;
            FS_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FS_btn.ForeColor = Color.DimGray;
            FS_btn.Location = new Point(701, 414);
            FS_btn.Name = "FS_btn";
            FS_btn.Size = new Size(195, 101);
            FS_btn.TabIndex = 5;
            FS_btn.Text = "Fine Section";
            FS_btn.UseVisualStyleBackColor = false;
            FS_btn.Click += FS_btn_Click;
            // 
            // btn_activeBorrow
            // 
            btn_activeBorrow.BackColor = SystemColors.Menu;
            btn_activeBorrow.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_activeBorrow.ForeColor = Color.DimGray;
            btn_activeBorrow.Location = new Point(253, 414);
            btn_activeBorrow.Name = "btn_activeBorrow";
            btn_activeBorrow.Size = new Size(195, 101);
            btn_activeBorrow.TabIndex = 6;
            btn_activeBorrow.Text = "Active Borrow";
            btn_activeBorrow.UseVisualStyleBackColor = false;
            btn_activeBorrow.Click += btn_activeBorrow_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PaleVioletRed;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1137, 547);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 61);
            panel2.TabIndex = 60;
            // 
            // Smart_Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 545);
            Controls.Add(btn_activeBorrow);
            Controls.Add(FS_btn);
            Controls.Add(btn_newBorrow);
            Controls.Add(MM_btn);
            Controls.Add(BM_btn);
            Controls.Add(AM_btn);
            Controls.Add(SLMS_Label);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Smart_Library";
            ShowInTaskbar = false;
            Text = "Form1";
            Load += Smart_Library_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SLMS_Label;
        private Button AM_btn;
        private Button BM_btn;
        private Button MM_btn;
        private Button btn_newBorrow;
        private Button FS_btn;
        private Button btn_activeBorrow;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}
