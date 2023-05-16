using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();

            txbURL.Text = fs.Name.ToString();
            txbReading_file.Text = str;
            txbFile_name.Text = ofd.SafeFileName.ToString();
            txbLine_count.Text = str.Split('\n').Length.ToString();
            txbSize.Text = new FileInfo(fs.Name).Length.ToString();
            txbChar_count.Text = str.Length.ToString();
            txbWord_count.Text = str.Split(' ', '\n').Length.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txbURL.Text = null;
            txbReading_file.Text = null;
            txbFile_name.Text = null;
            txbLine_count.Text = null;
            txbSize.Text = null;
            txbChar_count.Text = null;
            txbWord_count.Text = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
