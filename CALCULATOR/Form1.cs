namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num = 0;
        string nummy = "";
        int num2 = 0;
        string coperation = "";



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 1;
            textBox1.Text = "1";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num=2;
            textBox1.Text = "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num=3;
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num=4;
            textBox1.Text = "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num=5;
            textBox1.Text = "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = 6;
            textBox1.Text = "6";
        }
        private void button16_Click(object sender, EventArgs e)
        {
            num=7;
            textBox1.Text = "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num=8;
            textBox1.Text = "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = 0;
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (coperation == "+")
            {
                num2 = num + num2;
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                Convert.ToInt32(textBox1.Text);

            }
            else
            {
                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = 9;
            textBox1.Text = "9";
        }
    }
}