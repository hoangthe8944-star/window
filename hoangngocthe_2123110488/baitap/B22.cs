using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace baitap
{
    public partial class B22 : Form
    {
        // Danh sách dữ liệu gốc
        List<Employee> lstEmp = new List<Employee>();
        // BindingSource làm trung gian
        BindingSource bs = new BindingSource();

        public B22()
        {
            InitializeComponent();
        }

        private void Bai29_Load(object sender, EventArgs e)
        {
            // Kết nối List vào BindingSource
            bs.DataSource = lstEmp;
            // Kết nối BindingSource vào DataGridView
            dgvEmployee.DataSource = bs;
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

            // Ở bài 22, ta thêm vào BindingSource, Grid sẽ tự hiện hàng mới
            bs.Add(em);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                bs.RemoveCurrent(); // Xóa phần tử đang chọn qua BindingSource
            }
        }

        private void btExit_Click(object sender, EventArgs e) => this.Close();
    }
}