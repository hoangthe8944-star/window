using System;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Drawing;

namespace baitap
{
    public partial class Bai23 : Form
    {
        string path = @"D:\form.xml";
        InfoWindow iw = new InfoWindow();

        public Bai23()
        {
            InitializeComponent();
        }

        public void Write(InfoWindow iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindow));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }

        public InfoWindow Read()
        {
            if (!File.Exists(path)) return null;

            XmlSerializer reader = new XmlSerializer(typeof(InfoWindow));
            StreamReader file = new StreamReader(path);
            InfoWindow data = (InfoWindow)reader.Deserialize(file);
            file.Close();
            return data;
        }

        // Khi mở ứng dụng: Đọc và khôi phục Kích thước + Vị trí
        private void Bai23_Load(object sender, EventArgs e)
        {
            try
            {
                iw = Read();
                if (iw != null)
                {
                    this.Width = iw.Width;
                    this.Height = iw.Height;
                    this.Location = iw.Location;
                }
            }
            catch { /* Xử lý lỗi nếu cần */ }
        }

        // Khi đóng ứng dụng: Lưu lại toàn bộ trạng thái hiện tại
        private void Bai23_FormClosing(object sender, FormClosingEventArgs e)
        {
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location;
            Write(iw);
        }
    }
}