namespace LAB02
{
    partial class Menu
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
            Excercise1 = new Button();
            Excercise2 = new Button();
            Excercise3 = new Button();
            Excercise6 = new Button();
            Excercise4 = new Button();
            Excercise5 = new Button();
            SuspendLayout();
            // 
            // Excercise1
            // 
            Excercise1.Location = new Point(130, 86);
            Excercise1.Name = "Excercise1";
            Excercise1.Size = new Size(141, 51);
            Excercise1.TabIndex = 0;
            Excercise1.Text = "Bài 1";
            Excercise1.UseVisualStyleBackColor = true;
            Excercise1.Click += Excercise1_Click;
            // 
            // Excercise2
            // 
            Excercise2.Location = new Point(130, 191);
            Excercise2.Name = "Excercise2";
            Excercise2.Size = new Size(141, 51);
            Excercise2.TabIndex = 1;
            Excercise2.Text = "Bài 2";
            Excercise2.UseVisualStyleBackColor = true;
            Excercise2.Click += Excercise2_Click_1;
            // 
            // Excercise3
            // 
            Excercise3.Location = new Point(130, 301);
            Excercise3.Name = "Excercise3";
            Excercise3.Size = new Size(141, 51);
            Excercise3.TabIndex = 2;
            Excercise3.Text = "Bài 3";
            Excercise3.UseVisualStyleBackColor = true;
            Excercise3.Click += Excercise3_Click;
            // 
            // Excercise6
            // 
            Excercise6.Location = new Point(459, 301);
            Excercise6.Name = "Excercise6";
            Excercise6.Size = new Size(141, 51);
            Excercise6.TabIndex = 3;
            Excercise6.Text = "Bài 6";
            Excercise6.UseVisualStyleBackColor = true;
            Excercise6.Click += Excercise6_Click;
            // 
            // Excercise4
            // 
            Excercise4.Location = new Point(459, 86);
            Excercise4.Name = "Excercise4";
            Excercise4.Size = new Size(141, 51);
            Excercise4.TabIndex = 4;
            Excercise4.Text = "Bài 4";
            Excercise4.UseVisualStyleBackColor = true;
            Excercise4.Click += Excercise4_Click;
            // 
            // Excercise5
            // 
            Excercise5.Location = new Point(459, 191);
            Excercise5.Name = "Excercise5";
            Excercise5.Size = new Size(141, 51);
            Excercise5.TabIndex = 5;
            Excercise5.Text = "Bài 5";
            Excercise5.UseVisualStyleBackColor = true;
            Excercise5.Click += Excercise5_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Excercise5);
            Controls.Add(Excercise4);
            Controls.Add(Excercise6);
            Controls.Add(Excercise3);
            Controls.Add(Excercise2);
            Controls.Add(Excercise1);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Excercise1;
        private Button Excercise2;
        private Button Excercise3;
        private Button Excercise6;
        private Button Excercise4;
        private Button Excercise5;
    }
}