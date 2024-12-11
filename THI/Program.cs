using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _23520161_TranNguyenThaiBinh
{
    internal static class Program
    {
        public static List<Sach> ListSach = new List<Sach>
        {
            new Sach {Stt = 1, TenSach = "LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG", TacGia = "Trương Hải Bằng", TheLoai = "Giáo trình", SoLuongTon = 5},
            new Sach {Stt = 2, TenSach = "LẬP TRÌNH TRÊN WINDOWS", TacGia = "Vũ Thanh Nguyên", TheLoai = "Giáo trình", SoLuongTon = 20},
            new Sach {Stt = 3, TenSach = "ĐẠI SỐ TUYẾN TÍNH", TacGia = "Cao Thanh Tình", TheLoai = "Giáo trình", SoLuongTon = 0},
            new Sach {Stt = 4, TenSach = "PHÂN TÍCH THIẾT KẾ HỆ THỐNG THÔNG TIN", TacGia = "Cao Thị Nhạn", TheLoai = "Giáo trình", SoLuongTon = 0 },
            new Sach {Stt = 5, TenSach = "HƯỚNG DẪN THỰC HÀNH  PHÁT TRIỂN ỨNG DỤNG THÔNG TIN", TacGia = "Trần Hồng Nghị", TheLoai = "Thực hành", SoLuongTon = 5 }
        };

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void InitializeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stt",
                HeaderText = "STT",
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenSach",
                HeaderText = "Tên sách"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TacGia",
                HeaderText = "Tác giả"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TheLoai",
                HeaderText = "Thể loại"
            });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuongTon",
                HeaderText = "Số lượng tồn"
            });
        }
    }
}
