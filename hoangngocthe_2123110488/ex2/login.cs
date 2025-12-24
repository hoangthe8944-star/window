using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ex2;

namespace ex1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*'; // ẩn mật khẩu
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "admin@gmail.com" && password == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                adminpanel frmMenu = new adminpanel(); 
                frmMenu.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Sai email hoặc mật khẩu!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register frmRegister = new register(); // form đăng ký
            frmRegister.Show();
            this.Hide();
        }
    }
}
