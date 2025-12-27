using System;
using System.Windows.Forms;

namespace baitap
{
    public partial class B10 : Form
    {
        // Khai báo các biến theo đúng hình ảnh bạn cung cấp
        decimal workingMemory = 0;
        string opr = "";

        public B10()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện nhấn các nút số (0, 1, 2, 3)
        private void bt0_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDisplay.Text += bt3.Text;
        }

        // Nút dấu chấm thập phân
        private void btDot_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        // Xử lý nút Cộng (+)
        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // Xử lý nút Nhân (*)
        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        // Xử lý nút Bằng (=)
        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDisplay.Text);

            if (opr == "+")
            {
                tbDisplay.Text = (workingMemory + secondValue).ToString();
            }

            if (opr == "*")
            {
                tbDisplay.Text = (workingMemory * secondValue).ToString();
            }
        }
    }
}