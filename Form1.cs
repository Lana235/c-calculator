namespace CalCulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DigitalButtonClick(int k)
        {
            rez.Text += k.ToString();
            Console.WriteLine(rez.Text);
        }
        private void n0_Click(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(1);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(2);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(3);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(4);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(5);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(6);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(7);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(8);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(9);
        }

        private void pliusMinusi_Click(object sender, EventArgs e)
        {

        }

        private void mdzime_Click(object sender, EventArgs e)
        {

        }

        private void toloba_Click(object sender, EventArgs e)
        {

        }

        private void pliusi_Click(object sender, EventArgs e)
        {

        }

        private void minusi_Click(object sender, EventArgs e)
        {

        }

        private void gamravleba_Click(object sender, EventArgs e)
        {

        }

        private void gayofa_Click(object sender, EventArgs e)
        {

        }
    }
}