using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace blockblast
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            // Chỉ gán sự kiện ở đây
            btnStage1.Click += (s, e) => StartGame(8);
            btnStage2.Click += (s, e) => StartGame(10);
            btnStage3.Click += (s, e) => StartGame(12);
        }

        // ĐẢM BẢO HÀM NÀY CHỈ CÓ MỘT BẢN TRONG FILE NÀY
        private void StartGame(int size)
        {
            Form1 gameForm = new Form1(size);
            gameForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            gameForm.Show();
        }
    }
}