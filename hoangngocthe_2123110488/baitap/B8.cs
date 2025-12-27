using System;
using System.Windows.Forms;

namespace baitap
{
    public partial class B8 : Form
    {
        public B8()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculator";
        }

  

        private void bntcong_Click(object sender, EventArgs e)
        {
            int x, y;

            // Kiểm tra nhập số
            if (!int.TryParse(txtX.Text, out x) ||
                !int.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            TxtKq.Text = (x + y).ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            int x, y;
            // Kiểm tra nhập số
            if (!int.TryParse(txtX.Text, out x) ||
                !int.TryParse(txtY.Text, out y))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }
            TxtKq.Text = (x * y).ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
