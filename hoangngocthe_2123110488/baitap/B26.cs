using System;
using System.Drawing;
using System.Windows.Forms;

namespace baitap
{
    public partial class B26 : Form
    {
        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300;
        float yEgg = 0;

        float speedY = 0f;      // vận tốc
        float gravity = 0.25f;  // gia tốc (giảm số này = mượt hơn)

        public B26()
        {
            InitializeComponent();
        }

        private void Bai18_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 15;   // chậm hơn chút cho mượt
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, (int)yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            try
            {
                pbEgg.ImageLocation = @"d:\Images\egg2.png";
            }
            catch { }
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            speedY += gravity;     // tăng tốc dần
            yEgg += speedY;

            // Chạm đất
            if (yEgg >= this.ClientSize.Height - pbEgg.Height)
            {
                yEgg = this.ClientSize.Height - pbEgg.Height;

                try
                {
                    pbEgg.ImageLocation = @"d:\Images\egg.png";
                }
                catch { }

                tmEgg.Stop(); // dừng khi vỡ → giống game
            }

            pbEgg.Location = new Point(xEgg, (int)yEgg);
        }
    }
}
