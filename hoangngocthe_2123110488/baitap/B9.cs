using System;
using System.IO;
using System.Windows.Forms;

namespace baitap
{
    public partial class B9 : Form
    {
        public B9()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;

            tbKetQua.Text += $"{x} + {y} = {kq}\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;

            tbKetQua.Text += $"{x} * {y} = {kq}\r\n";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Calculator.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();

            MessageBox.Show("Đã lưu file Calculator.txt");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chặn nhập chữ
        private void tbSoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
