using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap
{
    public partial class B25 : Form
    {
        // Khai báo các thành phần và biến theo đúng slide của bạn
        PictureBox pb = new PictureBox();
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();
        int xBall = 0;
        int yBall = 0;
        int xDelta = 5;
        int yDelta = 5;

        public B25()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form load (Khởi tạo game)
        private void Bai17_Load(object sender, EventArgs e)
        {
            // Thiết lập Timer
            tmGame.Interval = 10;
            tmGame.Tick += tmGame_Tick;
            tmGame.Start();

            // Thiết lập PictureBox (Quả bóng)
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(xBall, yBall);

            // Chú ý: Bạn cần có file ball.png tại ổ D hoặc đổi đường dẫn ảnh thực tế trên máy bạn
            pb.ImageLocation = @"d:\Images\ball.png";

            // Thêm quả bóng vào Form
            this.Controls.Add(pb);
        }

        // Hàm xử lý di chuyển bóng mỗi khi Timer "tích tắc" (Tick)
        void tmGame_Tick(object sender, EventArgs e)
        {
            // Cập nhật tọa độ
            xBall += xDelta;
            yBall += yDelta;

            // Kiểm tra va chạm cạnh Trái/Phải để đổi hướng (Bật lại)
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
            {
                xDelta = -xDelta;
            }

            // Kiểm tra va chạm cạnh Trên/Dưới để đổi hướng
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
            {
                yDelta = -yDelta;
            }

            // Cập nhật vị trí hiển thị mới của quả bóng
            pb.Location = new Point(xBall, yBall);
        }
    }
}