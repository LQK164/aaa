namespace LAB02
{
    partial class Bai_2
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
            btnRead = new Button();
            btnClose = new Button();
            btnDel = new Button();
            txbFile_name = new TextBox();
            txbChar_count = new TextBox();
            txbWord_count = new TextBox();
            txbLine_count = new TextBox();
            txbURL = new TextBox();
            txbSize = new TextBox();
            lbFile_name = new Label();
            lbSize = new Label();
            lbURL = new Label();
            lbLine_count = new Label();
            lbWords_count = new Label();
            lbCharacter_count = new Label();
            txbReading_file = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(31, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(344, 70);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(225, 411);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(172, 70);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(31, 411);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(172, 70);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // txbFile_name
            // 
            txbFile_name.Location = new Point(225, 105);
            txbFile_name.Name = "txbFile_name";
            txbFile_name.Size = new Size(150, 31);
            txbFile_name.TabIndex = 3;
            // 
            // txbChar_count
            // 
            txbChar_count.Location = new Point(225, 364);
            txbChar_count.Name = "txbChar_count";
            txbChar_count.Size = new Size(150, 31);
            txbChar_count.TabIndex = 4;
            // 
            // txbWord_count
            // 
            txbWord_count.Location = new Point(225, 313);
            txbWord_count.Name = "txbWord_count";
            txbWord_count.Size = new Size(150, 31);
            txbWord_count.TabIndex = 5;
            // 
            // txbLine_count
            // 
            txbLine_count.Location = new Point(225, 261);
            txbLine_count.Name = "txbLine_count";
            txbLine_count.Size = new Size(150, 31);
            txbLine_count.TabIndex = 6;
            // 
            // txbURL
            // 
            txbURL.Location = new Point(225, 210);
            txbURL.Name = "txbURL";
            txbURL.Size = new Size(150, 31);
            txbURL.TabIndex = 7;
            // 
            // txbSize
            // 
            txbSize.Location = new Point(225, 162);
            txbSize.Name = "txbSize";
            txbSize.Size = new Size(150, 31);
            txbSize.TabIndex = 8;
            // 
            // lbFile_name
            // 
            lbFile_name.AutoSize = true;
            lbFile_name.Location = new Point(56, 111);
            lbFile_name.Name = "lbFile_name";
            lbFile_name.RightToLeft = RightToLeft.No;
            lbFile_name.Size = new Size(91, 25);
            lbFile_name.TabIndex = 10;
            lbFile_name.Text = "File name:";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(56, 168);
            lbSize.Name = "lbSize";
            lbSize.RightToLeft = RightToLeft.No;
            lbSize.Size = new Size(47, 25);
            lbSize.TabIndex = 11;
            lbSize.Text = "Size:";
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(56, 216);
            lbURL.Name = "lbURL";
            lbURL.RightToLeft = RightToLeft.No;
            lbURL.Size = new Size(47, 25);
            lbURL.TabIndex = 12;
            lbURL.Text = "URL:";
            // 
            // lbLine_count
            // 
            lbLine_count.AutoSize = true;
            lbLine_count.Location = new Point(56, 267);
            lbLine_count.Name = "lbLine_count";
            lbLine_count.RightToLeft = RightToLeft.No;
            lbLine_count.Size = new Size(97, 25);
            lbLine_count.TabIndex = 13;
            lbLine_count.Text = "Line count:";
            // 
            // lbWords_count
            // 
            lbWords_count.AutoSize = true;
            lbWords_count.Location = new Point(56, 319);
            lbWords_count.Name = "lbWords_count";
            lbWords_count.RightToLeft = RightToLeft.No;
            lbWords_count.Size = new Size(118, 25);
            lbWords_count.TabIndex = 14;
            lbWords_count.Text = "Words count:";
            // 
            // lbCharacter_count
            // 
            lbCharacter_count.AutoSize = true;
            lbCharacter_count.Location = new Point(56, 370);
            lbCharacter_count.Name = "lbCharacter_count";
            lbCharacter_count.RightToLeft = RightToLeft.No;
            lbCharacter_count.Size = new Size(140, 25);
            lbCharacter_count.TabIndex = 15;
            lbCharacter_count.Text = "Character count:";
            // 
            // txbReading_file
            // 
            txbReading_file.Location = new Point(450, 12);
            txbReading_file.Multiline = true;
            txbReading_file.Name = "txbReading_file";
            txbReading_file.ReadOnly = true;
            txbReading_file.Size = new Size(348, 383);
            txbReading_file.TabIndex = 16;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 493);
            Controls.Add(txbReading_file);
            Controls.Add(lbCharacter_count);
            Controls.Add(lbWords_count);
            Controls.Add(lbLine_count);
            Controls.Add(lbURL);
            Controls.Add(lbSize);
            Controls.Add(lbFile_name);
            Controls.Add(txbSize);
            Controls.Add(txbURL);
            Controls.Add(txbLine_count);
            Controls.Add(txbWord_count);
            Controls.Add(txbChar_count);
            Controls.Add(txbFile_name);
            Controls.Add(btnDel);
            Controls.Add(btnClose);
            Controls.Add(btnRead);
            Name = "Bai_2";
            Text = "Bai_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnClose;
        private Button btnDel;
        private TextBox txbFile_name;
        private TextBox txbChar_count;
        private TextBox txbWord_count;
        private TextBox txbLine_count;
        private TextBox txbURL;
        private TextBox txbSize;
        private Label lbFile_name;
        private Label lbSize;
        private Label lbURL;
        private Label lbLine_count;
        private Label lbWords_count;
        private Label lbCharacter_count;
        private TextBox txbReading_file;
    }
}