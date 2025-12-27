using System;
using System.Windows.Forms;

namespace MyThi_490
{
    public partial class B5 : Form
    {
        public B5()
        {
            InitializeComponent();
        }

   
        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            decimal value = numericUpDown1.Value;
            string gender = radioButton1.Checked ? "RadioButton được chọn" : "Chưa chọn Radio";
            string isChecked = checkBox1.Checked ? "Đã check" : "Chưa check";
            string date = dateTimePicker1.Value.ToShortDateString();
            string selectedItem = listBox1.SelectedItem != null ? listBox1.SelectedItem.ToString() : "Chưa chọn item";


            string info = $"Tên: {name}\n" +
                          $"Số: {value}\n" +
                          $"Ngày: {date}\n" +
                          $"ListBox chọn: {selectedItem}\n" +
                          $"{isChecked}";

            MessageBox.Show(info, "Thông tin đã nhập");
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
    }
}