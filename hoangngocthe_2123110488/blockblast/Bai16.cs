using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WinTimer = System.Windows.Forms.Timer;

namespace blockblast
{
    public partial class Bai16 : Form
    {
        // Cấu hình rổ
        private RectangleF basket;
        private float basketSpeed = 20f;

        // Cấu hình trứng
        private List<Egg> eggs = new List<Egg>();
        private float initialEggSpeed = 5f;
        private float currentEggSpeed;

        // Trạng thái game
        private int score = 0;
        private int misses = 0;
        private bool isPaused = false;
        private Random rand = new Random();
        private WinTimer gameTimer;

        public Bai16()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(600, 800);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Text = "Hứng Trứng - Level 1";

            ResetGame();

            // Khởi tạo Timer
            gameTimer = new WinTimer();
            gameTimer.Interval = 20; // 50 FPS
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        private void ResetGame()
        {
            score = 0;
            misses = 0;
            currentEggSpeed = initialEggSpeed;
            eggs.Clear();
            basket = new RectangleF(this.Width / 2 - 50, this.Height - 80, 100, 20);
        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (isPaused) return;

            // 1. Tạo trứng mới ngẫu nhiên
            if (rand.Next(0, 100) < 3) // Xác suất rơi trứng
            {
                eggs.Add(new Egg(rand.Next(20, this.Width - 40), currentEggSpeed, Color.Gold));
            }

            // 2. Di chuyển trứng và kiểm tra va chạm
            for (int i = eggs.Count - 1; i >= 0; i--)
            {
                eggs[i].Fall();

                // Kiểm tra trứng rơi vào rổ
                if (basket.IntersectsWith(new RectangleF(eggs[i].X, eggs[i].Y, 30, 30)))
                {
                    score++;
                    eggs.RemoveAt(i);
                    // Tăng tốc độ mỗi 5 điểm
                    if (score % 5 == 0) currentEggSpeed += 0.5f;
                    continue;
                }

                // Kiểm tra trứng rơi ra ngoài
                if (eggs[i].Y > this.Height)
                {
                    misses++;
                    eggs.RemoveAt(i);
                    if (misses >= 5) GameOver();
                }
            }

            this.Invalidate(); // Vẽ lại màn hình
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Vẽ rổ (Dùng Rounded Rect cho đẹp)
            DrawRoundedRect(g, basket, 10, Color.DodgerBlue);

            // Vẽ trứng
            foreach (var egg in eggs)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    new RectangleF(egg.X, egg.Y, 30, 40),
                    egg.EggColor, Color.White, 45f))
                {
                    g.FillEllipse(brush, egg.X, egg.Y, 30, 40);
                }
            }

            // Vẽ UI Điểm số
            g.DrawString($"Điểm: {score}", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.White, 20, 20);
            g.DrawString($"Bỏ lỡ: {misses}/5", new Font("Segoe UI", 14), Brushes.OrangeRed, 20, 55);
            g.DrawString($"Tốc độ: {currentEggSpeed:F1}", new Font("Segoe UI", 12), Brushes.Gray, 20, 85);
        }

        // Điều khiển rổ bằng phím
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && basket.X > 0)
                basket.X -= basketSpeed;
            if (e.KeyCode == Keys.Right && basket.X < this.Width - basket.Width)
                basket.X += basketSpeed;
        }

        private void GameOver()
        {
            gameTimer.Stop();
            MessageBox.Show($"GAME OVER!\nTổng điểm: {score}", "Kết quả");
            this.Close(); // Quay lại Menu
        }

        private void DrawRoundedRect(Graphics g, RectangleF rect, int radius, Color col)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                g.FillPath(new SolidBrush(col), path);
                g.DrawPath(new Pen(Color.White, 2), path);
            }
        }
    }
}