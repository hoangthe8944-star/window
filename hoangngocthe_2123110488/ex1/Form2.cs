using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form2 : Form
    {
        Random random = new Random();
        int currentLevelTotalNumbers = 10;
        int nextNumberToClick = 1;
        int timeLeft = 1000; // <<< THAY ĐỔI: Tăng thời gian mặc định lên 90 giây

        public Form2()
        {
            InitializeComponent();

            // Kết nối sự kiện với hàm xử lý
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);

            // Cập nhật lại Text ban đầu cho label
            lblTimer.Text = "Thời gian: " + timeLeft;
        }

        private void StartGame()
        {
            // 1. Dọn dẹp các nút số của màn chơi cũ
            // (Chúng ta sẽ dùng vòng lặp để xóa thay vì Clear() để không bị mất nút Start và Label)
            ResetGameBoard();

            // 2. Reset các biến game
            nextNumberToClick = 1;
            timeLeft = 90; // <<< THAY ĐỔI: Reset thời gian cho mỗi màn là 90 giây
            lblTimer.Text = "Thời gian: " + timeLeft;

            // 3. Tạo các nút số mới
            for (int i = 1; i <= currentLevelTotalNumbers; i++)
            {
                Button numberButton = new Button();
                numberButton.Text = i.ToString();
                numberButton.Name = "btnNum" + i; // Đặt tên riêng để phân biệt với btnStart
                numberButton.Size = new Size(40, 40);
                numberButton.Font = new Font("Arial", 12, FontStyle.Bold);
                numberButton.BackColor = Color.FromArgb(random.Next(120, 256), random.Next(120, 256), random.Next(120, 256));

                bool positionOK;
                Point newLocation;
                do
                {
                    positionOK = true;
                    int x = random.Next(0, pnlGameArea.ClientSize.Width - numberButton.Width);
                    int y = random.Next(0, pnlGameArea.ClientSize.Height - numberButton.Height);
                    newLocation = new Point(x, y);

                    foreach (Control control in pnlGameArea.Controls)
                    {
                        if (control is Button)
                        {
                            if (control.Bounds.IntersectsWith(new Rectangle(newLocation, numberButton.Size)))
                            {
                                positionOK = false;
                                break;
                            }
                        }
                    }
                } while (!positionOK);

                numberButton.Location = newLocation;
                numberButton.Click += NumberButton_Click;
                pnlGameArea.Controls.Add(numberButton);
            }

            // 4. Bắt đầu đếm thời gian
            gameTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            currentLevelTotalNumbers = 10;
            StartGame();
            btnStart.Visible = false; // Ẩn nút "Bắt đầu" đi khi game đang chạy
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int buttonNumber = int.Parse(clickedButton.Text);

            if (buttonNumber == nextNumberToClick)
            {
                pnlGameArea.BackColor = SystemColors.Control;
                clickedButton.Visible = false;
                nextNumberToClick++;

                if (nextNumberToClick > currentLevelTotalNumbers)
                {
                    gameTimer.Stop();
                    MessageBox.Show("Tuyệt vời! Bạn đã hoàn thành màn chơi!");

                    if (currentLevelTotalNumbers < 100)
                    {
                        currentLevelTotalNumbers += 10;
                    }
                    StartGame();
                }
            }
            else
            {
                pnlGameArea.BackColor = Color.LightCoral;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "Thời gian: " + timeLeft;

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Hết giờ! Bạn đã thua. Hãy thử lại.", "Game Over");

                // <<< THAY ĐỔI: Logic để quay lại màn hình bắt đầu
                ResetGameBoard(); // Xóa các nút số cũ
                lblTimer.Text = "Thời gian: 90"; // Reset lại đồng hồ hiển thị
                btnStart.Visible = true; // Hiện lại nút "Bắt đầu"
                pnlGameArea.BackColor = SystemColors.Control; // Reset lại màu nền
            }
        }

        // Hàm mới để dọn dẹp các nút số trên màn hình
        private void ResetGameBoard()
        {
            // Dùng LINQ để tìm tất cả các nút (Button) trong Panel
            // mà không phải là nút "btnStart", sau đó chuyển thành một danh sách
            var numberButtons = pnlGameArea.Controls.OfType<Button>().Where(btn => btn.Name != "btnStart").ToList();

            // Lặp qua danh sách vừa tạo và xóa từng nút
            foreach (Button btn in numberButtons)
            {
                pnlGameArea.Controls.Remove(btn);
                btn.Dispose(); // Giải phóng tài nguyên của nút
            }
        }
    }
}