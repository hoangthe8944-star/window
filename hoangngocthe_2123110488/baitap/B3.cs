using System;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace baitap
{
    public partial class B3 : Form
    {
        string path = @"D:\form.xml";

        public B3()
        {
            InitializeComponent();
        }

        // Hàm ghi dữ liệu (Serialization)
        public void Write(InfoWindow iw)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindow));
            StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }

        // Hàm đọc dữ liệu (Deserialization) - Mới ở Article 02
        public InfoWindow Read()
        {
            XmlSerializer reader = new XmlSerializer(typeof(InfoWindow));
            StreamReader file = new StreamReader(path);
            InfoWindow iw = (InfoWindow)reader.Deserialize(file);
            file.Close();
            return iw;
        }

        // Khi kết thúc thay đổi kích thước -> Ghi lại kích thước mới vào file
        private void B3_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindow iw = new InfoWindow();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        // Khi Form vừa Load -> Đọc file XML để khôi phục kích thước cũ
        private void B3_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path)) // Kiểm tra xem file có tồn tại không trước khi đọc
                {
                    InfoWindow iw = Read();
                    this.Width = iw.Width;
                    this.Height = iw.Height;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu file bị hỏng hoặc không truy cập được
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }
    }
}