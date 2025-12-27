using System;
using System.Drawing;
using System.Windows.Forms;
using WinTimer = System.Windows.Forms.Timer;
namespace baitap
{
    public partial class B28 : Form
    {
        PictureBox pbBasket = new PictureBox();
        PictureBox pbEgg = new PictureBox();
        PictureBox pbChicken = new PictureBox();
        WinTimer tmEgg = new WinTimer();
        WinTimer tmChicken = new WinTimer();

        int xBasket = 300, yBasket = 550, xDeltaBasket = 30;
        int xChicken = 300, yChicken = 10, xDeltaChicken = 5;
        int xEgg = 300, yEgg = 120, yDeltaEgg = 3;

        public B28()
        {
            InitializeComponent();

            this.Text = "Catch Egg - Bai16";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            this.Load += Bai16_Load;
            this.KeyDown += Bai16_KeyDown;
        }

        private void Bai16_Load(object sender, EventArgs e)
        {
            // TIMER
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            tmChicken.Interval = 10;
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            // GIỎ
            pbBasket.Size = new Size(70, 70);
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.ImageLocation = @"d:\Images\basket.png";
            this.Controls.Add(pbBasket);

            // GÀ
            pbChicken.Size = new Size(100, 100);
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.ImageLocation = @"d:\Images\object.png";
            this.Controls.Add(pbChicken);

            // TRỨNG
            pbEgg.Size = new Size(50, 50);
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.ImageLocation = @"d:\Images\basketball.png";
            this.Controls.Add(pbEgg);
        }

        void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;

            if (xChicken <= 0 || xChicken >= this.ClientSize.Width - pbChicken.Width)
                xDeltaChicken = -xDeltaChicken;

            pbChicken.Location = new Point(xChicken, yChicken);
        }

        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg;

            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                yEgg = pbChicken.Bottom;
                xEgg = pbChicken.Left + pbChicken.Width / 2 - pbEgg.Width / 2;
            }

            if (yEgg >= this.ClientSize.Height - pbEgg.Height)
            {
                pbEgg.ImageLocation = @"d:\Images\x.png";
                tmEgg.Stop();
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void Bai16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && xBasket > 0)
                xBasket -= xDeltaBasket;

            if (e.KeyCode == Keys.Right &&
                xBasket < this.ClientSize.Width - pbBasket.Width)
                xBasket += xDeltaBasket;

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}