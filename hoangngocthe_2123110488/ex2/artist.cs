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
    public partial class artist : Form
    {
        public artist()
        {
            InitializeComponent();
            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(186, 0);
            panelContent.Name = "panelContent";
            //panelContent.Size = new Size(614, 450);

            Controls.Add(panelContent);


        }
    }
}
