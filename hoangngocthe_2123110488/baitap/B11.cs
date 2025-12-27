using System;
using System.Windows.Forms;

namespace baitap
{
    public partial class B11 : Form
    {
        decimal memory = 0;
        decimal workingMemory = 0;
        string opr = "";

        public B11()
        {
            InitializeComponent();
        }

 

        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            // Kiểm tra TextBox có dữ liệu hay không để tránh lỗi Parse
            bool coDuLieu = !string.IsNullOrEmpty(txtDisplay.Text);

            if (char.IsDigit(bt.Text, 0) || bt.Text == ".")
            {
                // Tránh nhập 2 dấu chấm
                if (bt.Text == "." && txtDisplay.Text.Contains(".")) return;
                txtDisplay.Text += bt.Text;
            }
            else if ("+-*/".Contains(bt.Text) && coDuLieu)
            {
                opr = bt.Text;
                workingMemory = decimal.Parse(txtDisplay.Text);
                txtDisplay.Clear();
            }
            else if (bt.Text == "=" && coDuLieu)
            {
                decimal b = decimal.Parse(txtDisplay.Text);
                switch (opr)
                {
                    case "+": txtDisplay.Text = (workingMemory + b).ToString(); break;
                    case "-": txtDisplay.Text = (workingMemory - b).ToString(); break;
                    case "*": txtDisplay.Text = (workingMemory * b).ToString(); break;
                    case "/":
                        if (b == 0) MessageBox.Show("Không chia cho 0");
                        else txtDisplay.Text = (workingMemory / b).ToString();
                        break;
                }
            }
            else if (bt.Text == "±" && coDuLieu)
                txtDisplay.Text = (-decimal.Parse(txtDisplay.Text)).ToString();

            else if (bt.Text == "√" && coDuLieu)
                txtDisplay.Text = Math.Sqrt(double.Parse(txtDisplay.Text)).ToString();

            else if (bt.Text == "%" && coDuLieu)
                txtDisplay.Text = (decimal.Parse(txtDisplay.Text) / 100).ToString();

            else if (bt.Text == "1/x" && coDuLieu)
            {
                decimal val = decimal.Parse(txtDisplay.Text);
                if (val != 0) txtDisplay.Text = (1 / val).ToString();
            }
            else if (bt.Text == "←" && coDuLieu)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

            else if (bt.Text == "C") { txtDisplay.Clear(); opr = ""; workingMemory = 0; }
            else if (bt.Text == "CE") txtDisplay.Clear();
            else if (bt.Text == "MC") memory = 0;
            else if (bt.Text == "MR") txtDisplay.Text = memory.ToString();
            else if (bt.Text == "MS" && coDuLieu) { memory = decimal.Parse(txtDisplay.Text); txtDisplay.Clear(); }
            else if (bt.Text == "M+" && coDuLieu) memory += decimal.Parse(txtDisplay.Text);
            else if (bt.Text == "M-" && coDuLieu) memory -= decimal.Parse(txtDisplay.Text);
        }
    }
}
