
using System.Media;
namespace blockblast

{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Timer gameTimer;
        private SoundPlayer scoreSound = new SoundPlayer("score.wav");
        private Color[] bgColors = {
    Color.FromArgb(235, 235, 230), // Màu Kem giấy (Muted Cream) - Rất dịu
    Color.FromArgb(220, 225, 220), // Xanh rêu nhạt (Sage Green) - Trầm lắng
    Color.FromArgb(220, 225, 230), // Xanh xám đá (Slate Gray Light)
    Color.FromArgb(230, 220, 220), // Hồng tro nhạt (Dusty Rose)
    Color.FromArgb(225, 225, 220), // Màu Cát khô (Sand)
    Color.FromArgb(215, 220, 225)  // Màu xanh sương mù (Misty Blue)
};
        private bool isGameOver = false;
        private SoundPlayer loseSound = new SoundPlayer("lose.wav"); // Tự chuẩn bị file lose.wav


        private int currentColorIndex = 0;
        private SoundPlayer placeSound = new SoundPlayer("place.wav");


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblScore = new Label();
            lblLevel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(20, 20);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(171, 54);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score: 0";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblLevel.ForeColor = Color.Gold;
            lblLevel.Location = new Point(380, 25);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(81, 41);
            lblLevel.TabIndex = 0;
            lblLevel.Text = "Lv: 1";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(559, 811);
            Controls.Add(lblLevel);
            Controls.Add(lblScore);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block Blast Pro";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}