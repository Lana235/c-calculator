using System;
namespace CalCulator
{
    public partial class Form1 : Form
    {
        private double firstNum = 0;
        private string operation = " ";
        public Form1()
        {
            InitializeComponent();
        }
        private void DigitalButtonClick(int k)
        {
            rez.Text += k.ToString();
            Console.WriteLine(rez.Text);
            //HACK
            //rez.Text += k.ToString(); 
        }
        private void ArithmeticOperations(string o)
        {
            if (!string.IsNullOrEmpty(rez.Text))
            {
              firstNum = double.Parse(rez.Text);
              operation = o;
              rez.Text += "" + o; 
              // rez.Clear();
            }
            
        }
        private void n0_Click(object sender, EventArgs e)
        {
            DigitalButtonClick(0);
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
            if (rez.Text != "")
            {
                double number = double.Parse(rez.Text.Replace(",",""));
                rez.Text = (-number).ToString("#,0.#####");
            }
        }

        private void mdzime_Click(object sender, EventArgs e)
        {
            rez.Text += ","; 
        }

        private void toloba_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rez.Text))
            {
                double secondNum = double.Parse(rez.Text.Replace(",",""));
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                    case "x":
                        result = firstNum * secondNum;
                        break;
                    case "/":
                        if (secondNum != 0)
                        {
                            result = firstNum / secondNum;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                }
                rez.Text = result.ToString("#,0.#####");
            }
        }

        private void pliusi_Click(object sender, EventArgs e)
        {
            ArithmeticOperations("+");
        }

        private void minusi_Click(object sender, EventArgs e)
        {
            ArithmeticOperations("-");
        }

        private void gamravleba_Click(object sender, EventArgs e)
        {
            ArithmeticOperations("x");
        }

        private void gayofa_Click(object sender, EventArgs e)
        {
            ArithmeticOperations("/");
        }

        private void C_Click(object sender, EventArgs e)
        {
            if(rez.Text.Length > 0)
            {
                rez.Text = rez.Text.Substring(0,rez.Text.Length - 1);
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            rez.Clear();
        }
    }
}