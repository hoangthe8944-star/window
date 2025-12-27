using System;
using System.Collections; // Cần thiết để sử dụng ArrayList
using System.Windows.Forms;

namespace baitap
{
    public partial class B18 : Form
    {
        public B18()
        {
            InitializeComponent();
        }

        // Hàm giả lập lấy dữ liệu danh sách bài hát
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            // Có thể thêm các bài hát khác ở đây...
            return lst;
        }

        private void Bai26_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbSong.DataSource = lst;           // Kết nối nguồn dữ liệu
            lbSong.DisplayMember = "Name";     // Chỉ hiển thị tên bài hát trên danh sách
        }

        // Nút bấm ">" để chọn bài hát vào danh sách ưa thích
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                // Ép kiểu mục được chọn về lại đối tượng Song
                Song song = (Song)lbSong.SelectedItem;

                string id = song.Id.ToString();
                string name = song.Name;
                string author = song.Author;

                // Tạo chuỗi định dạng để hiển thị bên danh sách ưa thích
                string info = id + " - " + name + " - " + author;

                // Thêm vào ListBox bên phải
                lbFavorite.Items.Add(info);
            }
        }

        // Nút bấm "<" để xóa bài hát khỏi danh sách ưa thích (Bổ sung thêm cho đủ giao diện)
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1)
            {
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }
    }
}