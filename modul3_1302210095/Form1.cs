namespace modul3_1302210095
{
    public partial class Form1 : Form
    {
        int[] numArr = new int[100];
        char[] oprationArr = new char[100];

        int num = 0;

        int num1, num2;

        bool submit = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void change_label(Label label, string word)
        {
            
            if(label.Text == "Label Output" || submit)
            {
                label.Text = "";
            }
            label.Text += word;
            submit = false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            change_label(label1, button1.Text);
            num = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_label(label1, button2.Text);
            num = 2;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            change_label(label1, button3.Text);
            num = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            change_label(label1, button4.Text);
            num = 4;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            change_label(label1, button5.Text);
            num = 5;
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            change_label(label1, button6.Text);
            num = 6;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change_label(label1, button7.Text);
            num = 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            change_label(label1, button8.Text);
            num = 8;

        }
        private void button9_Click(object sender, EventArgs e)
        {
            change_label(label1, button9.Text);
            num = 9;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            change_label(label1, button10.Text);
            num = num * 10;

        }
        private void button11_Click(object sender, EventArgs e)
        {
            change_label(label1, button11.Text);
            num1 = num;

        }
        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            change_label(label1, Convert.ToString(num+num1));
            submit = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}