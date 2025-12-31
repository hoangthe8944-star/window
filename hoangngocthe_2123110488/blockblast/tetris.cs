using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace blockblast
{
    public partial class tetris : Form
    {
        const int rows = 20;
        const int cols = 12;
        const int cellSize = 30;

        int[,] board = new int[rows, cols];
        Color[,] colorBoard = new Color[rows, cols];

        System.Windows.Forms.Timer timer;

        int[,] currentPiece;
        Color currentColor;
        Point currentPos;

        Random rand = new Random();

        int score = 0;

        int[][,] pieces =
        {
            new int[,] {{1,1,1,1}},
            new int[,] {{1,1},{1,1}},
            new int[,] {{0,1,0},{1,1,1}},
            new int[,] {{1,0,0},{1,1,1}},
            new int[,] {{0,0,1},{1,1,1}}
        };

        Color[] pieceColors =
        {
            Color.Cyan, Color.Yellow, Color.Purple,
            Color.Orange, Color.Blue, Color.Green, Color.Red
        };

        List<SoundPlayer> musicList = new List<SoundPlayer>();
        int musicIndex = 0;

        public tetris()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(18, 18, 18);
            DoubleBuffered = true;
            KeyPreview = true;

            Width = cols * cellSize + 16;
            Height = rows * cellSize + 39;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

            LoadMusic();
            PlayNextMusic();

            SpawnPiece();
            KeyDown += Tetris_KeyDown;
        }

        // ================= MUSIC =================
        void LoadMusic()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds");
            musicList.Add(new SoundPlayer(Path.Combine(path, "bg1.wav")));
            musicList.Add(new SoundPlayer(Path.Combine(path, "bg2.wav")));
            musicList.Add(new SoundPlayer(Path.Combine(path, "bg3.wav")));
        }

        void PlayNextMusic()
        {
            if (musicList.Count == 0) return;
            musicList[musicIndex].Play();
            musicIndex = (musicIndex + 1) % musicList.Count;
        }

        // ================= GAME =================
        void SpawnPiece()
        {
            currentPiece = pieces[rand.Next(pieces.Length)];
            currentColor = pieceColors[rand.Next(pieceColors.Length)];
            currentPos = new Point(cols / 2 - 1, 0);

            if (CheckCollision(currentPos.X, currentPos.Y))
            {
                timer.Stop();
                MessageBox.Show($"GAME OVER\nScore: {score}");
                Application.Restart();
            }
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (!CheckCollision(currentPos.X, currentPos.Y + 1))
                currentPos.Y++;
            else
            {
                MergePiece();
                ClearLines();
                SpawnPiece();
            }
            Invalidate();
        }

        bool CheckCollision(int x, int y)
        {
            if (currentPiece == null) return false;

            for (int py = 0; py < currentPiece.GetLength(0); py++)
                for (int px = 0; px < currentPiece.GetLength(1); px++)
                    if (currentPiece[py, px] == 1)
                    {
                        int nx = x + px;
                        int ny = y + py;

                        if (nx < 0 || nx >= cols || ny >= rows) return true;
                        if (ny >= 0 && board[ny, nx] == 1) return true;
                    }
            return false;
        }

        void MergePiece()
        {
            for (int y = 0; y < currentPiece.GetLength(0); y++)
                for (int x = 0; x < currentPiece.GetLength(1); x++)
                    if (currentPiece[y, x] == 1)
                    {
                        board[currentPos.Y + y, currentPos.X + x] = 1;
                        colorBoard[currentPos.Y + y, currentPos.X + x] = currentColor;
                    }
        }

        void ClearLines()
        {
            int lines = 0;

            for (int y = rows - 1; y >= 0; y--)
            {
                bool full = true;
                for (int x = 0; x < cols; x++)
                    if (board[y, x] == 0) full = false;

                if (full)
                {
                    lines++;
                    for (int ty = y; ty > 0; ty--)
                        for (int x = 0; x < cols; x++)
                        {
                            board[ty, x] = board[ty - 1, x];
                            colorBoard[ty, x] = colorBoard[ty - 1, x];
                        }
                    y++;
                }
            }

            if (lines > 0)
            {
                int[] points = { 0, 100, 300, 500, 800 };
                score += points[lines];
            }
        }

        void Rotate()
        {
            int h = currentPiece.GetLength(0);
            int w = currentPiece.GetLength(1);
            int[,] r = new int[w, h];

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    r[x, h - y - 1] = currentPiece[y, x];

            var old = currentPiece;
            currentPiece = r;
            if (CheckCollision(currentPos.X, currentPos.Y))
                currentPiece = old;
        }

        // ================= DRAW =================
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Pen p = new Pen(Color.FromArgb(40, Color.White)))
            {
                for (int x = 0; x <= cols; x++)
                    g.DrawLine(p, x * cellSize, 0, x * cellSize, rows * cellSize);
                for (int y = 0; y <= rows; y++)
                    g.DrawLine(p, 0, y * cellSize, cols * cellSize, y * cellSize);
            }

            for (int y = 0; y < rows; y++)
                for (int x = 0; x < cols; x++)
                    if (board[y, x] == 1)
                        g.FillRectangle(new SolidBrush(colorBoard[y, x]),
                            x * cellSize + 1, y * cellSize + 1,
                            cellSize - 2, cellSize - 2);

            for (int y = 0; y < currentPiece.GetLength(0); y++)
                for (int x = 0; x < currentPiece.GetLength(1); x++)
                    if (currentPiece[y, x] == 1)
                        g.FillRectangle(new SolidBrush(currentColor),
                            (currentPos.X + x) * cellSize + 1,
                            (currentPos.Y + y) * cellSize + 1,
                            cellSize - 2, cellSize - 2);

            g.DrawString($"Score: {score}",
                new Font("Segoe UI", 14, FontStyle.Bold),
                Brushes.White, 5, 5);
        }

        // ================= CONTROL =================
        void Tetris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !CheckCollision(currentPos.X - 1, currentPos.Y))
                currentPos.X--;
            if (e.KeyCode == Keys.Right && !CheckCollision(currentPos.X + 1, currentPos.Y))
                currentPos.X++;
            if (e.KeyCode == Keys.Down && !CheckCollision(currentPos.X, currentPos.Y + 1))
                currentPos.Y++;
            if (e.KeyCode == Keys.Up)
                Rotate();

            Invalidate();
        }
    }
}
