using System.Buffers;
using System.Drawing.Text;

namespace Severity
{
    public partial class Form1 : Form


    {
        double firstnumber = 0;
        private string operation = "";
        private bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnz_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "0";

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtboxnum.Text += "9";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtboxnum.Text = "";
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(txtboxnum.Text);
            operation = "add";
            isNewEntry = true;
            txtboxnum.Text = "";
        }

        private void btns_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(txtboxnum.Text);
            operation = "subtract";
            isNewEntry = true;
            txtboxnum.Text = "";
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(txtboxnum.Text);
            operation = "multiply";
            isNewEntry = true;
            txtboxnum.Text = "";
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(txtboxnum.Text);
            operation = "divide";
            isNewEntry = true;
            txtboxnum.Text = "";
        }

        private void btne_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxnum.Text))
                return;

            double SecondNumber = double.Parse(txtboxnum.Text);
            double result = 0;

            switch (operation)
            {
                case "add":
                    result = firstnumber + SecondNumber;
                    break;
                case "subtract":
                    result = firstnumber -SecondNumber;
                    break;
                case "multiply":
                    result = firstnumber * SecondNumber;
                    break;
                case "divide":
                    
                    if (SecondNumber == 0)
                    {
                        MessageBox.Show("cannot divide by 0");
                        operation = "";
                        isNewEntry = true;
                        return;
                    }
                    result = firstnumber / SecondNumber;
                    break;
            }
            txtboxnum.Text = result.ToString();
            operation = "";
            isNewEntry = true;
        }
    }
}
