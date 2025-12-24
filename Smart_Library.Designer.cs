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
            SLMS_Label = new Label();
            AM_btn = new Button();
            BM_btn = new Button();
            MM_btn = new Button();
            BB_btn = new Button();
            FS_btn = new Button();
            SuspendLayout();
            // 
            // SLMS_Label
            // 
            SLMS_Label.AutoSize = true;
            SLMS_Label.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SLMS_Label.Location = new Point(100, 44);
            SLMS_Label.Name = "SLMS_Label";
            SLMS_Label.Size = new Size(638, 45);
            SLMS_Label.TabIndex = 0;
            SLMS_Label.Text = "Smart Library Management System";
            // 
            // AM_btn
            // 
            AM_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AM_btn.ForeColor = Color.Black;
            AM_btn.Location = new Point(252, 126);
            AM_btn.Name = "AM_btn";
            AM_btn.Size = new Size(367, 46);
            AM_btn.TabIndex = 1;
            AM_btn.Text = "Author Management";
            AM_btn.UseVisualStyleBackColor = true;
            // 
            // BM_btn
            // 
            BM_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BM_btn.Location = new Point(252, 193);
            BM_btn.Name = "BM_btn";
            BM_btn.Size = new Size(367, 46);
            BM_btn.TabIndex = 2;
            BM_btn.Text = "Book Management";
            BM_btn.UseVisualStyleBackColor = true;
            BM_btn.Click += BM_btn_Click;
            // 
            // MM_btn
            // 
            MM_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MM_btn.Location = new Point(252, 259);
            MM_btn.Name = "MM_btn";
            MM_btn.Size = new Size(367, 46);
            MM_btn.TabIndex = 3;
            MM_btn.Text = "Member Management";
            MM_btn.UseVisualStyleBackColor = true;
            // 
            // BB_btn
            // 
            BB_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BB_btn.Location = new Point(252, 329);
            BB_btn.Name = "BB_btn";
            BB_btn.Size = new Size(367, 46);
            BB_btn.TabIndex = 4;
            BB_btn.Text = "Borrow Book";
            BB_btn.UseVisualStyleBackColor = true;
            // 
            // FS_btn
            // 
            FS_btn.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FS_btn.Location = new Point(252, 390);
            FS_btn.Name = "FS_btn";
            FS_btn.Size = new Size(367, 46);
            FS_btn.TabIndex = 5;
            FS_btn.Text = "Fine Section";
            FS_btn.UseVisualStyleBackColor = true;
            // 
            // Smart_Library
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FS_btn);
            Controls.Add(BB_btn);
            Controls.Add(MM_btn);
            Controls.Add(BM_btn);
            Controls.Add(AM_btn);
            Controls.Add(SLMS_Label);
            Name = "Smart_Library";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SLMS_Label;
        private Button AM_btn;
        private Button BM_btn;
        private Button MM_btn;
        private Button BB_btn;
        private Button FS_btn;
    }
}
