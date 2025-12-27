using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace baitap
{
    public partial class B20 : Form
    {
        List<Employee> lstEmp = new List<Employee>();
        BindingSource bs = new BindingSource();

        public B20()
        {
            InitializeComponent();
        }

        private void Bai21_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu mẫu
            lstEmp.Add(new Employee { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
            lstEmp.Add(new Employee { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });

            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;
        }

        // Chức năng XÓA theo đúng ảnh Article 21
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                bs.RemoveAt(idx);      // Xóa trên giao diện (thông qua BindingSource)
                lstEmp.RemoveAt(idx);  // Xóa trong danh sách dữ liệu gốc
            }
        }

        // Chức năng HIỂN THỊ NGƯỢC theo đúng ảnh Article 21
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && dgvEmployee.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Ép kiểu bool để check/uncheck CheckBox giới tính
                ckGender.Checked = bool.Parse(dgvEmployee.Rows[idx].Cells[3].Value.ToString());
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee
            {
                Id = tbId.Text,
                Name = tbName.Text,
                Age = int.Parse(tbAge.Text),
                Gender = ckGender.Checked
            };
            bs.Add(em);
        }
    }
}