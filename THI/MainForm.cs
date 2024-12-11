using System;
using System.Windows.Forms;

namespace _23520161_TranNguyenThaiBinh
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Program.InitializeDataGridView(dataGridView);
            ToolStripComboBox.SelectedIndex = 0;
        }


        private void GioiThieu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieuForm gioiThieuForm = new GioiThieuForm();
            gioiThieuForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Program.ListSach;
        }

        private void ThemMoi_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSachForm addSachForm = new AddSachForm();
            addSachForm.FormClosed += AddSachForm_FormClosed;
            addSachForm.Show();
        }

        private void AddSachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Refresh the DataGridView
            dataGridView.DataSource = null;
            dataGridView.DataSource = Program.ListSach;
        }

        private void TimKiem_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSachForm searchSachForm = new SearchSachForm();
            searchSachForm.Show();
        }

        private void ToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToolStripComboBox.SelectedIndex == 0)
            {
                dataGridView.DataSource = Program.ListSach;
            }
            else if (ToolStripComboBox.SelectedIndex == 1)
            {
                dataGridView.DataSource = Program.ListSach.FindAll(s => s.SoLuongTon > 0);
            }
            else if (ToolStripComboBox.SelectedIndex == 2)
            {
                dataGridView.DataSource = Program.ListSach.FindAll(s => s.SoLuongTon == 0);
            }
        }
    }
}
