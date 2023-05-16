using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB02
{
    public partial class Bai_1 : Form
    {
        public Bai_1()
        {
            InitializeComponent();
        }

        private void read_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            read_and_write_box.Text = sr.ReadToEnd();
            fs.Close(); 
           
        }

        private void write_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(read_and_write_box.Text.ToUpper());    
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
