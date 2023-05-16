namespace LAB02
{
    partial class Bai_5
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
            btnCompress = new Button();
            btnDecompress = new Button();
            btnCompare = new Button();
            lbProgress = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // btnCompress
            // 
            btnCompress.Location = new Point(50, 263);
            btnCompress.Name = "btnCompress";
            btnCompress.Size = new Size(213, 77);
            btnCompress.TabIndex = 0;
            btnCompress.Text = "Nén file";
            btnCompress.UseVisualStyleBackColor = true;
            btnCompress.Click += btnCompress_Click;
            // 
            // btnDecompress
            // 
            btnDecompress.Location = new Point(488, 263);
            btnDecompress.Name = "btnDecompress";
            btnDecompress.Size = new Size(213, 77);
            btnDecompress.TabIndex = 1;
            btnDecompress.Text = "Giải nén file";
            btnDecompress.UseVisualStyleBackColor = true;
            btnDecompress.Click += btnDecompress_Click;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(269, 263);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(213, 77);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "So sánh";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // lbProgress
            // 
            lbProgress.AutoSize = true;
            lbProgress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbProgress.Location = new Point(319, 108);
            lbProgress.Name = "lbProgress";
            lbProgress.Size = new Size(124, 38);
            lbProgress.TabIndex = 3;
            lbProgress.Text = "Progress";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(269, 164);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(213, 34);
            progressBar.TabIndex = 5;
            // 
            // Bai_5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(lbProgress);
            Controls.Add(btnCompare);
            Controls.Add(btnDecompress);
            Controls.Add(btnCompress);
            Name = "Bai_5";
            Text = "Bai_5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCompress;
        private Button btnDecompress;
        private Button btnCompare;
        private Label lbProgress;
        private ProgressBar progressBar;
    }
}