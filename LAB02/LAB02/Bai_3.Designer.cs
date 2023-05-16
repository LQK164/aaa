namespace LAB02
{
    partial class Bai_3
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
            btnWrite = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(67, 66);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(199, 66);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(377, 66);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(199, 66);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(67, 167);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(509, 262);
            txtResult.TabIndex = 2;
            // 
            // Bai_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Bai_3";
            Text = "Bai_3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private TextBox txtResult;
    }
}