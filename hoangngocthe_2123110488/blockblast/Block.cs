using System;
using System.Collections.Generic;
using System.Drawing;

namespace blockblast
{
    public class Block
    {
        public int[,] Shape { get; set; }
        public Color Color { get; set; }
        public int Rows => Shape.GetLength(0);
        public int Cols => Shape.GetLength(1);

        public Block(int[,] shape, Color color)
        {
            Shape = shape;
            Color = color;
        }

        public static Block GetRandom(int level)
        {
            Random r = new Random();
            Color[] colors = {
                Color.FromArgb(255, 61, 0),   // Đỏ
                Color.FromArgb(0, 200, 255),  // Xanh dương
                Color.FromArgb(255, 214, 0),  // Vàng
                Color.FromArgb(170, 0, 255),  // Tím
                Color.FromArgb(100, 255, 0),  // Xanh lá sáng
                Color.FromArgb(255, 128, 0),  // Cam
                Color.FromArgb(0, 255, 200)   // Ngọc bích
            };
            Color col = colors[r.Next(colors.Length)];

            List<int[,]> shapes = new List<int[,]>();

            // --- CẤP ĐỘ 1: KHỐI CƠ BẢN (DỄ) ---
            shapes.Add(new int[,] { { 1, 1 }, { 1, 1 } }); // Vuông 2x2
            shapes.Add(new int[,] { { 1, 1, 1 } });       // Ngang 3
            shapes.Add(new int[,] { { 1 }, { 1 }, { 1 } }); // Dọc 3

            // --- CẤP ĐỘ 3+: KHỐI TRUNG BÌNH ---
            if (level >= 3)
            {
                shapes.Add(new int[,] { { 1, 1, 1, 1 } });    // Thanh dài 4
                shapes.Add(new int[,] { { 1, 1, 1 }, { 0, 1, 0 } }); // Chữ T
                shapes.Add(new int[,] { { 1, 1 }, { 1, 0 }, { 1, 0 } }); // Chữ L
            }

            // --- CẤP ĐỘ 5+: KHỐI KHÓ (CHIẾM DIỆN TÍCH) ---
            if (level >= 5)
            {
                shapes.Add(new int[,] { { 1 } });  // Vuông 
                // Khối vuông 3x3 (Cực khó vì chiếm 9 ô)
                shapes.Add(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });

                // Thanh dài 5 (Rất khó đặt khi lưới đầy)
                shapes.Add(new int[,] { { 1, 1, 1, 1, 1 } });

                // Chữ L lớn (3x3)
                shapes.Add(new int[,] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } });
            }

            // --- CẤP ĐỘ 8+: KHỐI "HIỂM" (HÌNH DẠNG PHỨC TẠP) ---
            if (level >= 8)
            {
                // Khối dấu Cộng (Plus)
                shapes.Add(new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 1, 0 } });

                // Khối chữ U
                shapes.Add(new int[,] { { 1, 0, 1 }, { 1, 1, 1 } });

                // Khối rỗng giữa (Khung 3x3) - Cực hiểm vì tạo lỗ trống khó lấp
                shapes.Add(new int[,] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } });

                // Khối bậc thang (Z lớn)
                shapes.Add(new int[,] { { 1, 1, 0 }, { 0, 1, 1 }, { 0, 0, 1 } });
            }

            // Chọn ngẫu nhiên một hình trong danh sách đã lọc theo level
            return new Block(shapes[r.Next(shapes.Count)], col);
        }
    }
}