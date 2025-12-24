using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace blockblast
{
    public partial class Form1 : Form
    {
        // --- CẤU HÌNH LƯỚI DỰA THEO ẢI ---
        private int GridSize;
        private int CellSize;
        private int Padding = 4;
        private Rectangle gridArea;
        private int[,] grid;
        private Color[,] gridColors;

        // --- BIẾN TRẠNG THÁI GAME ---
        private List<Block> slots = new List<Block>();
        private Block draggingBlock = null;
        private int draggingIdx = -1;
        private Point mouseOffset;
        private Point currentMousePos;
        private int score = 0;
        private int level = 1;

        // Constructor nhận size từ MenuForm
        public Form1(int size)
        {
            InitializeComponent();
            this.GridSize = size;

            // Tính toán kích thước ô: Lưới luôn rộng 440px
            this.CellSize = (440 / GridSize) - Padding;
            // Căn lề lưới ở tọa độ (50, 150)
            this.gridArea = new Rectangle(50, 150, GridSize * (CellSize + Padding), GridSize * (CellSize + Padding));

            grid = new int[GridSize, GridSize];
            gridColors = new Color[GridSize, GridSize];

            GenerateSlots();
            // Cập nhật điểm ban đầu
            this.Load += (s, e) => UpdateUI();
        }

        private void GenerateSlots()
        {
            slots.Clear();
            // Độ khó dựa trên kích thước lưới
            int stageDifficulty = (GridSize <= 8) ? 1 : (GridSize <= 10 ? 5 : 8);
            for (int i = 0; i < 3; i++)
                slots.Add(Block.GetRandom(stageDifficulty));
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate(); // Vẽ lại màn hình liên tục để tạo hiệu ứng mượt
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // 1. Vẽ lưới nền (Các ô trống)
            for (int r = 0; r < GridSize; r++)
                for (int c = 0; c < GridSize; c++)
                {
                    Rectangle rect = new Rectangle(gridArea.X + c * (CellSize + Padding),
                                                 gridArea.Y + r * (CellSize + Padding), CellSize, CellSize);
                    DrawRoundedRect(g, rect, 8, Color.FromArgb(35, 35, 35));

                    if (grid[r, c] == 1)
                        DrawRoundedRect(g, rect, 8, gridColors[r, c], true);
                }

            // 2. Vẽ Ghost Block (Bóng ma dự đoán)
            if (draggingBlock != null) DrawGhost(g);

            // 3. Vẽ 3 khối chờ ở khay dưới
            for (int i = 0; i < slots.Count; i++)
            {
                if (draggingIdx == i) continue;
                // Vị trí các khay chứa gạch
                Point p = new Point(60 + i * 150, 650);
                DrawBlock(g, slots[i], p, 0.6f);
            }

            // 4. Vẽ khối đang được kéo theo chuột
            if (draggingBlock != null)
            {
                Point p = new Point(currentMousePos.X - mouseOffset.X, currentMousePos.Y - mouseOffset.Y);
                DrawBlock(g, draggingBlock, p, 1.0f);
            }
        }

        private void DrawRoundedRect(Graphics g, Rectangle r, int radius, Color col, bool isBlock = false)
        {
            if (r.Width <= 0 || r.Height <= 0) return;
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = radius * 2;
                if (d > r.Width) d = r.Width;
                path.AddArc(r.X, r.Y, d, d, 180, 90);
                path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                if (isBlock)
                {
                    using (LinearGradientBrush lgb = new LinearGradientBrush(r, col, Color.FromArgb(200, col), 45f))
                        g.FillPath(lgb, path);
                    g.DrawPath(new Pen(Color.FromArgb(100, Color.White), 2), path);
                }
                else g.FillPath(new SolidBrush(col), path);
            }
        }

        private void DrawBlock(Graphics g, Block b, Point p, float scale)
        {
            int s = (int)(CellSize * scale);
            for (int r = 0; r < b.Rows; r++)
                for (int c = 0; c < b.Cols; c++)
                    if (b.Shape[r, c] == 1)
                        DrawRoundedRect(g, new Rectangle(p.X + c * s, p.Y + r * s, s - 2, s - 2), (int)(8 * scale), b.Color, true);
        }

        private void DrawGhost(Graphics g)
        {
            int c = (currentMousePos.X - mouseOffset.X - gridArea.X + CellSize / 2) / (CellSize + Padding);
            int r = (currentMousePos.Y - mouseOffset.Y - gridArea.Y + CellSize / 2) / (CellSize + Padding);

            if (CanPlace(draggingBlock, r, c))
            {
                for (int i = 0; i < draggingBlock.Rows; i++)
                    for (int j = 0; j < draggingBlock.Cols; j++)
                        if (draggingBlock.Shape[i, j] == 1)
                        {
                            Rectangle rect = new Rectangle(gridArea.X + (c + j) * (CellSize + Padding),
                                                         gridArea.Y + (r + i) * (CellSize + Padding), CellSize, CellSize);
                            DrawRoundedRect(g, rect, 8, Color.FromArgb(100, draggingBlock.Color));
                        }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            for (int i = 0; i < slots.Count; i++)
            {
                // Vùng bấm để lấy gạch
                Rectangle slotRect = new Rectangle(60 + i * 150, 630, 120, 150);
                if (slotRect.Contains(e.Location))
                {
                    draggingBlock = slots[i];
                    draggingIdx = i;
                    mouseOffset = new Point(CellSize / 2, CellSize / 2);
                    break;
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            currentMousePos = e.Location;
            // Không cần gọi Invalidate ở đây vì Timer đã lo việc đó
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (draggingBlock != null)
            {
                int c = (e.X - mouseOffset.X - gridArea.X + CellSize / 2) / (CellSize + Padding);
                int r = (e.Y - mouseOffset.Y - gridArea.Y + CellSize / 2) / (CellSize + Padding);

                if (CanPlace(draggingBlock, r, c))
                {
                    PlaceBlock(draggingBlock, r, c);
                    slots.RemoveAt(draggingIdx);
                    CheckLines();
                    if (slots.Count == 0) GenerateSlots();
                    CheckGameOver();
                }
                draggingBlock = null;
                draggingIdx = -1;
            }
        }

        bool CanPlace(Block b, int row, int col)
        {
            if (row < 0 || col < 0 || row + b.Rows > GridSize || col + b.Cols > GridSize) return false;
            for (int i = 0; i < b.Rows; i++)
                for (int j = 0; j < b.Cols; j++)
                    if (b.Shape[i, j] == 1 && grid[row + i, col + j] == 1) return false;
            return true;
        }

        void PlaceBlock(Block b, int row, int col)
        {
            for (int i = 0; i < b.Rows; i++)
                for (int j = 0; j < b.Cols; j++)
                    if (b.Shape[i, j] == 1)
                    {
                        grid[row + i, col + j] = 1;
                        gridColors[row + i, col + j] = b.Color;
                    }
            score += 10;
            UpdateUI();
        }

        void CheckLines()
        {
            List<int> rToClear = new List<int>();
            List<int> cToClear = new List<int>();

            for (int i = 0; i < GridSize; i++)
            {
                bool rFull = true, cFull = true;
                for (int j = 0; j < GridSize; j++)
                {
                    if (grid[i, j] == 0) rFull = false;
                    if (grid[j, i] == 0) cFull = false;
                }
                if (rFull) rToClear.Add(i);
                if (cFull) cToClear.Add(i);
            }

            foreach (int r in rToClear) for (int j = 0; j < GridSize; j++) grid[r, j] = 0;
            foreach (int c in cToClear) for (int i = 0; i < GridSize; i++) grid[i, c] = 0;

            if (rToClear.Count > 0 || cToClear.Count > 0)
            {
                score += (rToClear.Count + cToClear.Count) * 100;
                level = (score / 500) + 1;
                UpdateUI();
            }
        }

        void UpdateUI()
        {
            if (lblScore != null) lblScore.Text = $"Score: {score}";
            if (lblLevel != null) lblLevel.Text = $"Grid: {GridSize}x{GridSize}";
        }

        void CheckGameOver()
        {
            bool possible = false;
            foreach (var b in slots)
                for (int r = 0; r < GridSize; r++)
                    for (int c = 0; c < GridSize; c++)
                        if (CanPlace(b, r, c)) possible = true;

            if (!possible && slots.Count > 0)
            {
                MessageBox.Show($"Game Over! Điểm của bạn: {score}");
                // Reset game hoặc đóng Form quay về Menu
                this.Close();
            }
        }
    }
}