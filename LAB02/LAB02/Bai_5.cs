using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02
{
    public partial class Bai_5 : Form
    {
        public Bai_5()
        {
            InitializeComponent();
        }


        private void btnCompress_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream inputStream = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                string outputFile = @"D:\Downloads\output5.zip";
                FileStream outputStream = new FileStream(outputFile, FileMode.Create);

                GZipStream gzipStream = new GZipStream(outputStream, CompressionMode.Compress);

                byte[] buffer = new byte[4096];
                long totalBytesRead = 0;

                int bytesRead;
                progressBar.Value = 0;
                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    gzipStream.Write(buffer, 0, bytesRead);
                    totalBytesRead += bytesRead;

                    double progress = (double)totalBytesRead / inputStream.Length * 100;
                    progressBar.Value = (int)progress;
                }

                gzipStream.Close();
                outputStream.Close();
                inputStream.Close();

                MessageBox.Show("Compression complete!");
            }
            catch
            {
                MessageBox.Show("Hãy chọn file bạn muốn nén ");
            }
        }

        private void btnDecompress_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream inputStream = new FileStream(ofd.FileName, FileMode.OpenOrCreate);

                GZipStream gzipStream = new GZipStream(inputStream, CompressionMode.Decompress);

                string outputFile = @"C:\Downloads\output5.txt";
                FileStream outputStream = new FileStream(outputFile, FileMode.Create);

                byte[] buffer = new byte[4096];

                long totalBytesRead = 0;

                int bytesRead;
                progressBar.Value = 0;
                while ((bytesRead = gzipStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputStream.Write(buffer, 0, bytesRead);
                    totalBytesRead += bytesRead;


                    double progress = (double)totalBytesRead / outputStream.Length * 100;
                    progressBar.Value = (int)progress;
                }

                outputStream.Close();
                gzipStream.Close();
                inputStream.Close();

                MessageBox.Show("Decompression complete!");
            }
            catch
            {
                MessageBox.Show("Hãy chọn file bạn muốn giải nén");
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath1 = @"C:\Downloads\input5.txt";
                string filePath2 = @"C:\Downloads\output5.txt";

                string fileContent1 = File.ReadAllText(filePath1);
                string fileContent2 = File.ReadAllText(filePath2);

                if (fileContent1.Equals(fileContent2))
                {
                    MessageBox.Show("2 file input5.txt và output5.txt giống nhau ");
                }
                else
                {
                    MessageBox.Show("2 file input5.txt và output5.txt khác nhau ");
                }
            }
            catch
            {
                MessageBox.Show("Hãy chọn đường dẫn phù hợp ");
            }
        }
    }
}
