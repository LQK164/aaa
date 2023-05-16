using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TextBox;

namespace LAB02
{
    public partial class Bai_6 : Form
    {
        public Bai_6()
        {
            InitializeComponent();
        }

        private void Bai_6_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();
            treeFolder.BeginUpdate();
            foreach (string drive in drives)
            {
                TreeNode node = new TreeNode(drive.Remove(2, 1));

                switch (drive)
                {
                    case "C:":
                        treeFolder.SelectedNode = node;
                        node.SelectedImageIndex = 1;
                        node.ImageIndex = 1;
                        break;
                    case "D:":
                        node.SelectedImageIndex = 2;
                        node.ImageIndex = 2;
                        break;
                    default:
                        node.SelectedImageIndex = 3;
                        node.ImageIndex = 3;
                        break;
                }
                treeFolder.Nodes.Add(node);
            }
            treeFolder.EndUpdate();
        }

        private void AddDirectories(TreeNode node)
        {
            treeFolder.BeginUpdate();
            int directoriesCount = 0;
            try
            {
                DirectoryInfo diRoot;
                if (node.SelectedImageIndex < 11)
                {
                    diRoot = new DirectoryInfo(node.FullPath + "");
                }
                else
                {
                    diRoot = new DirectoryInfo(node.FullPath);
                }
                DirectoryInfo[] dirs = diRoot.GetDirectories();

                node.Nodes.Clear();

                foreach (DirectoryInfo dir in dirs)
                {
                    directoriesCount++;
                    TreeNode subNode = new TreeNode(dir.Name);
                    subNode.ImageIndex = 11;
                    subNode.SelectedImageIndex = 12;
                    node.Nodes.Add(subNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            treeFolder.EndUpdate();
        }

        private void AddFiles(string path)
        {
            listView.BeginUpdate();
            listView.Items.Clear();
            int filesCount = 0;
            try
            {
                DirectoryInfo di = new DirectoryInfo(path + "");
                FileInfo[] theFiles = di.GetFiles();
                string size = string.Empty;
                foreach (FileInfo theFile in theFiles)
                {
                    filesCount++;
                    ListViewItem lvItem = new ListViewItem(theFile.Name);
                    listView.Items.Add(lvItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listView.EndUpdate();
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AddDirectories(e.Node);
            treeFolder.SelectedNode.Expand();
            AddFiles(e.Node.FullPath.ToString());
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string path = treeFolder.SelectedNode.FullPath;
                string fileName = listView.FocusedItem.Text;
                string fullFileName = Path.Combine(path, fileName);

                if (File.Exists(fullFileName) && Path.GetExtension(fullFileName).ToLower() == ".txt")
                {

                    panel.Controls.Clear();

                    TextBox txtBox = new TextBox();
                    txtBox.Dock = DockStyle.Fill;
                    txtBox.Multiline = true;

                    txtBox.Text = File.ReadAllText(fullFileName);

                    panel.Controls.Add(txtBox);
                }
                else if (listView.SelectedItems.Count > 0)
                {
                    string filePath = Path.Combine(treeFolder.SelectedNode.FullPath, listView.SelectedItems[0].Text);
                    if (File.Exists(filePath))
                    {
                        byte[] fileContent = File.ReadAllBytes(filePath);
                        panel.BackgroundImage = Image.FromStream(new MemoryStream(fileContent));
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không thể mở file!");
            }
        }
    }
}
