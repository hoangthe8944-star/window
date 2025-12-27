using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class B27 : Form
    {
        // --- PHẦN KHAI BÁO BIẾN (Theo hình 5) ---
        PictureBox pbBasket = new PictureBox();
        int xBasket = 300; // Vị trí X ban đầu của giỏ
        int yBasket = 500; // Vị trí Y ban đầu của giỏ
        int xDelta = 30;   // Khoảng cách mỗi lần di chuyển (tốc độ)

        public B27()
        {
            InitializeComponent();
            // Đừng quên đăng ký các sự kiện nếu bạn không dùng giao diện Design để click
            this.Load += new EventHandler(Bai19_Load);
            this.KeyDown += new KeyEventHandler(Bai19_KeyDown);
        }

        // --- SỰ KIỆN LOAD FORM (Theo hình 1) ---
        private void Bai19_Load(object sender, EventArgs e)
        {
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;

            // Thêm PictureBox vào Form
            this.Controls.Add(pbBasket);

            // Load ảnh từ thư mục Images (Lưu ý đường dẫn tương đối)
            // "../../Images/basket.png" dùng khi chạy trong bin/Debug
            try
            {
                pbBasket.ImageLocation = @"d:\Images\basket.png";
            }
            catch
            {
                // Nếu lỗi đường dẫn, bạn có thể kiểm tra lại vị trí file ảnh
            }
        }

        // --- SỰ KIỆN ĐIỀU KHIỂN BÀN PHÍM (Theo hình 1) ---
        private void Bai19_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím mũi tên Sang Phải (KeyValue 39)
            // Điều kiện: xBasket < Chiều rộng Form - Chiều rộng Giỏ (để không chạy ra ngoài lề phải)
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
            {
                xBasket += xDelta;
            }

            // Phím mũi tên Sang Trái (KeyValue 37)
            // Điều kiện: xBasket > 0 (để không chạy ra ngoài lề trái)
            if (e.KeyValue == 37 && xBasket > 0)
            {
                xBasket -= xDelta;
            }

            // Cập nhật lại vị trí mới cho PictureBox
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}