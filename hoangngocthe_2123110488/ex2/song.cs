using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class song : Form
    {
        public song()
        {
            InitializeComponent();
            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(186, 0);
            panelContent.Name = "panelContent";
            //panelContent.Size = new Size(614, 450);

            Controls.Add(panelContent);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void song_Load(object sender, EventArgs e)
        {

        }
    }
}
