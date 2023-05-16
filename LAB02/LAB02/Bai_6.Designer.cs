namespace LAB02
{
    partial class Bai_6
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
            treeFolder = new TreeView();
            listView = new ListView();
            panel = new Panel();
            SuspendLayout();
            // 
            // treeFolder
            // 
            treeFolder.Location = new Point(0, 0);
            treeFolder.Name = "treeFolder";
            treeFolder.Size = new Size(318, 458);
            treeFolder.TabIndex = 0;
            treeFolder.AfterSelect += treeFolder_AfterSelect;
            // 
            // listView
            // 
            listView.Location = new Point(343, 12);
            listView.Name = "listView";
            listView.Size = new Size(445, 190);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // panel
            // 
            panel.Location = new Point(343, 240);
            panel.Name = "panel";
            panel.Size = new Size(445, 198);
            panel.TabIndex = 2;
            // 
            // Bai_6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel);
            Controls.Add(listView);
            Controls.Add(treeFolder);
            Name = "Bai_6";
            Text = "Bai_6";
            Load += Bai_6_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeFolder;
        private ListView listView;
        private Panel panel;
    }
}