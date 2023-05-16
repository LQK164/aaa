using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB02
{
    public partial class Bai_3 : Form
    {
        public Bai_3()
        {
            InitializeComponent();
        }
        public static string ToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfix = "";

            Dictionary<char, int> priority = new Dictionary<char, int>()
            {
                {'+', 1},
                {'-', 1},
                {'*', 2},
                {'/', 2},
                {'^', 3},
            };
            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];
                if (Char.IsLetterOrDigit(c))
                {
                    while (i < infix.Length && (Char.IsLetterOrDigit(infix[i]) || infix[i] == '.'))
                    {
                        postfix += infix[i];
                        i++;
                    }
                    i--;
                    postfix += " ";
                }
                else if (priority.ContainsKey(c))
                {
                    while (stack.Count > 0 && priority.ContainsKey(stack.Peek()) && priority[stack.Peek()] >= priority[c])
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(c);
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        stack.Pop();
                    }
                }
            }
            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }
            return postfix;
        }
        public double Calculate(string s)
        {
            Stack stack0 = new Stack();
            int n = s.Length;
            s.ToCharArray();
            int kt = 0;
            for (int i = kt; i < n; i++)
            {
                if (s[i] == '.' | ('0' <= s[i] && s[i] <= '9'))
                {
                    string num = "";
                    for (int k = i; k < n; k++)
                    {
                        if (s[k] == '.' | ('0' <= s[k] && s[k] <= '9'))
                        {
                            num += s[k];
                        }
                        else
                        {
                            kt = k;
                            stack0.Push(double.Parse(num));
                            break;
                        }
                    }
                    i = kt;
                }
                else if (s[i] != ',' && stack0.Count > 1)
                {
                    double num1 = double.Parse(stack0.Pop().ToString());
                    double num2 = double.Parse(stack0.Pop().ToString());
                    if (s[i] == '+')
                    {
                        double res = num1 + num2;
                        stack0.Push(res);
                    }
                    if (s[i] == '-')
                    {
                        double res = num1 - num2;
                        stack0.Push(res);
                    }
                    if (s[i] == '/')
                    {
                        double res = num1 / num2;
                        stack0.Push(res);
                    }

                    if (s[i] == '*')
                    {
                        double res = num1 * num2;
                        stack0.Push(res);
                    }
                    if (s[i] == '^')
                    {
                        double res = Math.Pow(double.Parse(num1.ToString()),
                            double.Parse(num2.ToString()));
                        stack0.Push(res);
                    }
                }
            }
            double result = double.Parse(stack0.Pop().ToString());
            return result;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadToEnd();
            string[] words = s.Split('\n');
            string newStr = "";
            string newWord = "";
            double result = 0;

            foreach (string word in words)
            {
                newWord = word.TrimEnd('\r', '\n');

                newStr = ToPostfix(newWord);

                result = Calculate(newStr);
                result = Math.Round(result, 2);
                txtResult.Text = txtResult.Text.ToString() + newWord + "=" + result.ToString() + '\n';
                fs.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(txtResult.Text);

            sw.Flush();
            fs.Close();
        }
    }
}
