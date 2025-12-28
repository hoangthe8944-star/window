using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ex1;

namespace blockblast
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            // 1. Làm đẹp các nút ải của Block Blast
            StyleStageButton(btnStage1, "ẢI 1: EASY", Color.DodgerBlue, 8);
            StyleStageButton(btnStage2, "ẢI 2: MEDIUM", Color.Orange, 10);
            StyleStageButton(btnStage3, "ẢI 3: HARD", Color.Crimson, 12);

            // 2. Khởi tạo danh sách Game khác
            InitializeGameList();
        }

        private void InitializeGameList()
        {
            // Xóa các mục cũ (nếu có)
            ctxGameMenu.Items.Clear();

            // THÊM GAME VÀO ĐÂY: Chỉ cần thêm dòng AddGameToMenu
            AddGameToMenu("Break Block", () => { /* Đang ở đây rồi */ });
            AddGameToMenu("Number Game", () => OpenOtherGame(new numbergame()));
            AddGameToMenu("Tetris", () => OpenOtherGame(new tetris()));


            // Sau này muốn thêm game khác chỉ cần:
            // AddGameToMenu("Bắn gà", () => OpenOtherGame(new banGaForm()));

            ctxGameMenu.Items.Add(new ToolStripSeparator());
            AddGameToMenu("Thoát ứng dụng", () => Application.Exit());
        }

        private void AddGameToMenu(string gameName, Action openAction)
        {
            var item = new ToolStripMenuItem(gameName);
            item.ForeColor = Color.White;
            item.Click += (s, e) => openAction();
            ctxGameMenu.Items.Add(item);
        }

        private void OpenOtherGame(Form otherGame)
        {
            otherGame.FormClosed += (s, e) => this.Show();
            this.Hide();
            otherGame.Show();
        }

        private void btnGameList_Click(object sender, EventArgs e)
        {
            // Hiển thị danh sách ngay dưới nút bấm
            ctxGameMenu.Show(btnGameList, new Point(0, btnGameList.Height));
        }

        private void StyleStageButton(Button btn, string text, Color themeColor, int size)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(40, 40, 40);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Text = text;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = themeColor;
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(40, 40, 40);
            btn.Click += (s, e) => {
                Form1 game = new Form1(size);
                game.FormClosed += (sender, args) => this.Show();
                this.Hide();
                game.Show();
            };
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Vẽ nền trầm dịu mắt (Sage/Neutral tone)
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.FromArgb(45, 45, 45), Color.FromArgb(25, 25, 25), 45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}