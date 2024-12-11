using System;
using System.Windows.Forms;

namespace _23520161_TranNguyenThaiBinh
{
    public partial class AddSachForm : Form
    {
        public AddSachForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TenSach_TextBox.Text) || string.IsNullOrWhiteSpace(TacGia_TextBox.Text) || string.IsNullOrWhiteSpace(TheLoai_TextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sach sach = new Sach
            {
                Stt = Program.ListSach.Count + 1,
                TenSach = TenSach_TextBox.Text,
                TacGia = TacGia_TextBox.Text,
                TheLoai = TheLoai_TextBox.Text,
                SoLuongTon = (int)SoLuongTon_numericUpDown.Value
            };
            Program.ListSach.Add(sach);
            Close();
        }
    }
}
