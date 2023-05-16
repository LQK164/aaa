using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using System.Xml.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;

namespace LAB02
{
    public partial class Bai_4 : Form
    {
        public Bai_4()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Student
        {
            public Student()
            {

            }
            public string name { set; get; }
            public int id { set; get; }
            public string phone { set; get; }
            public float score1 { set; get; } = 0;
            public float score2 { set; get; } = 0;
            public float score3 { set; get; } = 0;
            public float average { set; get; } = 0;

            public Student(string name, int id, string phone, float score1, float score2, float score3, float average)
            {
                this.name = name;
                this.id = id;
                this.phone = phone;
                this.score1 = score1;
                this.score2 = score2;
                this.score3 = score3;
                this.average = average;
            }
        };

        List<Student> students = new List<Student>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtID1.Text);
                string name = txtName1.Text;
                string phone = txtPhone1.Text;
                float score1 = float.Parse(txtCourse1_1.Text);
                float score2 = float.Parse(txtCourse2_1.Text);
                float score3 = float.Parse(txtCourse3_1.Text);
                float average = 0;

                if (txtAverage1.Text == " ")
                {
                    average = 0;
                }
                else
                {
                    average = float.Parse(txtAverage1.Text);
                }
                if (txtID1.Text.Length != 8 || int.TryParse(txtID1.Text, out id) == false)
                {
                    MessageBox.Show("MSSV phải chứa 8 chữ số");
                }
                else if (phone.Length != 10 || phone[0] != '0')
                {
                    MessageBox.Show("Chữ số điện thoại đầu tiên phải là 0 và có 10 chữ số");
                }
                else if ((score1 < 0 || score1 > 10) || (score2 < 0 || score2 > 10) || (score3 < 0 || score3 > 10))
                {
                    MessageBox.Show("Điểm các môn từ 0 đến 10");
                }
                else
                {
                    lstInfo.Items.Add(txtName1.Text);
                    lstInfo.Items.Add(txtID1.Text);
                    lstInfo.Items.Add(phone);
                    lstInfo.Items.Add(score1.ToString());
                    lstInfo.Items.Add(score2.ToString());
                    lstInfo.Items.Add(score3.ToString());
                    lstInfo.Items.Add(txtAverage1.Text);
                    lstInfo.Items.Add('\n');

                    students.Add(new Student(
                        name,
                        id,
                        phone,
                        score1,
                        score2,
                        score3,
                        average
                        ));
                }
            }
            catch
            {
                MessageBox.Show("Hãy vui lòng nhập lại!");
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Student[] s = students.ToArray();
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(sfd.FileName, FileMode.Create))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Student));
                    xs.Serialize(fs, s);
                    
                }
            }
        }

        private void bntRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(ofd.FileName, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Student));
                    var student = (Student[])xs.Deserialize(fs);
                    foreach (Student s in students)
                    {
                        s.average = (s.score1 + s.score2 + s.score3) / 3.0f;
                    }
                    lbpage_num.Text = "0";
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Student[] s = students.ToArray();
            int num = Int32.Parse(lbpage_num.Text);
            if (num == s.Length)
            {
                return;
            }
            else
            {
                int prev_num = num;
                num++;
                lbpage_num.Text = (num).ToString();
                txtName2.Text = s[prev_num].name;
                txtID2.Text = s[prev_num].id.ToString();
                txtPhone2.Text = s[prev_num].phone;
                txtCourse1_2.Text = s[prev_num].score1.ToString();
                txtCourse2_2.Text = s[prev_num].score2.ToString();
                txtCourse3_2.Text = s[prev_num].score3.ToString();
                txtAverage2.Text = s[prev_num].average.ToString();
                txtAverage1.Text = txtAverage2.Text;
                txtName1.Text = s[prev_num].name;
                txtID1.Text = s[prev_num].id.ToString();
                txtPhone1.Text = s[prev_num].phone;
                txtCourse1_1.Text = s[prev_num].score1.ToString();
                txtCourse2_1.Text = s[prev_num].score2.ToString();
                txtCourse3_1.Text = s[prev_num].score3.ToString();
                txtAverage1.Text = s[prev_num].average.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student[] s = students.ToArray();
            int num = Int32.Parse(lbpage_num.Text);
            if (num == 1)
            {
                return;
            }
            else
            {

                --num;
                lbpage_num.Text = num.ToString();
                txtName2.Text = s[num - 1].name;
                txtID2.Text = s[num - 1].id.ToString();
                txtPhone2.Text = s[num - 1].phone;
                txtCourse1_2.Text = s[num - 1].score1.ToString();
                txtCourse2_2.Text = s[num - 1].score2.ToString();
                txtCourse3_2.Text = s[num - 1].score3.ToString();
                txtAverage2.Text = s[num - 1].average.ToString();
                txtAverage1.Text = txtAverage2.Text;
                txtName1.Text = s[num - 1].name;
                txtID1.Text = s[num - 1].id.ToString();
                txtPhone1.Text = s[num - 1].phone;
                txtCourse1_1.Text = s[num - 1].score1.ToString();
                txtCourse2_1.Text = s[num - 1].score2.ToString();
                txtCourse3_1.Text = s[num - 1].score3.ToString();
                txtAverage1.Text = s[num - 1].average.ToString();
            }
        }
    }
}
