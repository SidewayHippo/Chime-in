namespace Calculator
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        //Numbers
        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "0";
            this.txtbox1.Text += input;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "1";
            this.txtbox1.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "2";
            this.txtbox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "3";
            this.txtbox1.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "4";
            this.txtbox1.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "5";
            this.txtbox1.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "6";
            this.txtbox1.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "7";
            this.txtbox1.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "8";
            this.txtbox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += "9";
            this.txtbox1.Text += input;
        }
        private void btnp_Click(object sender, EventArgs e)
        {
            this.txtbox1.Text = "";
            input += ".";
            this.txtbox1.Text += input;
        }

        //Equal
        private void btne_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtbox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtbox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtbox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                txtbox1.Text = result.ToString();
            }
        }
        //Operators
        private void btna_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btns_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
        //clear button 
        private void btnc_Click(object sender, EventArgs e)
        {
            txtbox1.Clear();
        }
     
    }
}
