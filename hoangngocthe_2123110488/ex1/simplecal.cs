using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{

    public partial class simplecal : Form
    {
        public simplecal()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);

            txtResult.Text = (x + y).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtX.Text);
            double y = double.Parse(txtY.Text);

            txtResult.Text = (x * y).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
