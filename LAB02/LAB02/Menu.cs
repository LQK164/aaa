namespace LAB02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Excercise1_Click(object sender, EventArgs e)
        {
            Bai_1 myform = new Bai_1();
            myform.ShowDialog();
        }

        private void Excercise2_Click_1(object sender, EventArgs e)
        {
            Bai_2 myform = new Bai_2();
            myform.ShowDialog();
        }

        private void Excercise3_Click(object sender, EventArgs e)
        {
            Bai_3 myform = new Bai_3();
            myform.ShowDialog();
        }

        private void Excercise4_Click(object sender, EventArgs e)
        {
            Bai_4 myform = new Bai_4();
            myform.ShowDialog();
        }

        private void Excercise5_Click(object sender, EventArgs e)
        {
            Bai_5 myform = new Bai_5();
            myform.ShowDialog();
        }

        private void Excercise6_Click(object sender, EventArgs e)
        {
            Bai_6 myform = new Bai_6();
            myform.ShowDialog();
        }

        
    }
}