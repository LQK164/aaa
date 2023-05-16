namespace LAB02
{
    partial class Bai_1
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
            read_file = new Button();
            write_file = new Button();
            read_and_write_box = new RichTextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // read_file
            // 
            read_file.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            read_file.Location = new Point(74, 84);
            read_file.Name = "read_file";
            read_file.Size = new Size(166, 76);
            read_file.TabIndex = 0;
            read_file.Text = "Đọc file";
            read_file.UseVisualStyleBackColor = true;
            read_file.Click += read_file_Click;
            // 
            // write_file
            // 
            write_file.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            write_file.Location = new Point(74, 187);
            write_file.Name = "write_file";
            write_file.Size = new Size(166, 76);
            write_file.TabIndex = 1;
            write_file.Text = "Ghi file";
            write_file.UseVisualStyleBackColor = true;
            write_file.Click += write_file_Click;
            // 
            // read_and_write_box
            // 
            read_and_write_box.ForeColor = SystemColors.InactiveCaptionText;
            read_and_write_box.Location = new Point(323, 84);
            read_and_write_box.Name = "read_and_write_box";
            read_and_write_box.ReadOnly = true;
            read_and_write_box.Size = new Size(445, 288);
            read_and_write_box.TabIndex = 2;
            read_and_write_box.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(74, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 76);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(read_and_write_box);
            Controls.Add(write_file);
            Controls.Add(read_file);
            Name = "Bai_1";
            Text = "Bài 1: Đọc và ghi file";
            ResumeLayout(false);
        }

        #endregion

        private Button read_file;
        private Button write_file;
        private RichTextBox read_and_write_box;
        private Button btnExit;
    }
}