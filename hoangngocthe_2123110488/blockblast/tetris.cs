using System;
using System.Drawing;
using System.Windows.Forms;

namespace blockblast
{
    public partial class tetris : Form
    {
        const int rows = 20;
        const int cols = 10;
        const int cellSize = 25;

        int[,] board = new int[rows, cols];

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        int[,] currentPiece;
        Point currentPos;

        Random rand = new Random();

        int[][,] pieces =
        {
            new int[,] {{1,1,1,1}},          // I
            new int[,] {{1,1},{1,1}},        // O
            new int[,] {{0,1,0},{1,1,1}},    // T
            new int[,] {{1,0,0},{1,1,1}},    // L
            new int[,] {{0,0,1},{1,1,1}}     // J
        };

        public tetris()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            this.Width = cols * cellSize + 16;
            this.Height = rows * cellSize + 39;

            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();

            SpawnPiece();

            this.KeyDown += tetris_KeyDown;
        }

        void SpawnPiece()
        {
            currentPiece = pieces[rand.Next(pieces.Length)];
            currentPos = new Point(cols / 2 - 1, 0);

            if (CheckCollision(currentPos.X, currentPos.Y))
            {
                timer.Stop();
                MessageBox.Show("GAME OVER");
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
            for (int py = 0; py < currentPiece.GetLength(0); py++)
                for (int px = 0; px < currentPiece.GetLength(1); px++)
                {
                    if (currentPiece[py, px] == 1)
                    {
                        int nx = x + px;
                        int ny = y + py;

                        if (nx < 0 || nx >= cols || ny >= rows)
                            return true;

                        if (ny >= 0 && board[ny, nx] == 1)
                            return true;
                    }
                }
            return false;
        }

        void MergePiece()
        {
            for (int y = 0; y < currentPiece.GetLength(0); y++)
                for (int x = 0; x < currentPiece.GetLength(1); x++)
                    if (currentPiece[y, x] == 1)
                        board[currentPos.Y + y, currentPos.X + x] = 1;
        }

        void ClearLines()
        {
            for (int y = rows - 1; y >= 0; y--)
            {
                bool full = true;
                for (int x = 0; x < cols; x++)
                    if (board[y, x] == 0)
                        full = false;

                if (full)
                {
                    for (int ty = y; ty > 0; ty--)
                        for (int x = 0; x < cols; x++)
                            board[ty, x] = board[ty - 1, x];
                    y++;
                }
            }
        }

        void Rotate()
        {
            int h = currentPiece.GetLength(0);
            int w = currentPiece.GetLength(1);
            int[,] rotated = new int[w, h];

            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    rotated[x, h - y - 1] = currentPiece[y, x];

            int[,] old = currentPiece;
            currentPiece = rotated;

            if (CheckCollision(currentPos.X, currentPos.Y))
                currentPiece = old;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Board
            for (int y = 0; y < rows; y++)
                for (int x = 0; x < cols; x++)
                    if (board[y, x] == 1)
                        g.FillRectangle(Brushes.Blue,
                            x * cellSize, y * cellSize,
                            cellSize - 1, cellSize - 1);

            // Current piece
            for (int y = 0; y < currentPiece.GetLength(0); y++)
                for (int x = 0; x < currentPiece.GetLength(1); x++)
                    if (currentPiece[y, x] == 1)
                        g.FillRectangle(Brushes.Red,
                            (currentPos.X + x) * cellSize,
                            (currentPos.Y + y) * cellSize,
                            cellSize - 1, cellSize - 1);
        }

        void tetris_KeyDown(object sender, KeyEventArgs e)
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
