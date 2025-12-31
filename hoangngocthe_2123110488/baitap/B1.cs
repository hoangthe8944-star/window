using System;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace baitap
{
    public partial class B1 : Form
    {
        // Đường dẫn lưu file, bạn có thể đổi ổ D thành ổ khác nếu máy không có ổ D
        string path = @"D:\form.xml";

        public B1()
        {
            InitializeComponent();
        }

        // Hàm ghi đối tượng ra file XML
        public void Write(InfoWindow iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindow));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }

        // Sự kiện xảy ra khi kết thúc việc kéo giãn Form
        private void Bai1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindow iw = new InfoWindow();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        // Sự kiện xảy ra khi Form vừa được chạy lên
        private void Bai1_Load(object sender, EventArgs e)
        {
            InfoWindow iw = new InfoWindow();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}