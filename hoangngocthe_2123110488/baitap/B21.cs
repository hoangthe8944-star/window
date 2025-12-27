using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace baitap
{
    public partial class B21 : Form
    {
        public B21() { InitializeComponent(); }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Thêm trực tiếp mảng dữ liệu vào Rows
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                dgvEmployee.Rows.RemoveAt(dgvEmployee.CurrentRow.Index);
            }
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEmployee.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var row = dgvEmployee.Rows[e.RowIndex];
                tbId.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbAge.Text = row.Cells[2].Value.ToString();
                ckGender.Checked = (bool)row.Cells[3].Value;
            }
        }

        private void btExit_Click(object sender, EventArgs e) => this.Close();
    }
}