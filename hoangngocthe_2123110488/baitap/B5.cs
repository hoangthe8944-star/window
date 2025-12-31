using System;
using System.IO;
using System.Windows.Forms;

namespace baitap
{
    public partial class B5 : Form
    {
        public B5()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Mở file để ghi nối tiếp (true)
            using (StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true))
            {
                sw.Write(e.KeyCode + " "); // Ghi mã phím nhấn vào file
            }
        }
    }
}