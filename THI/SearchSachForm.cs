using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _23520161_TranNguyenThaiBinh
{
    public partial class SearchSachForm : Form
    {
        public SearchSachForm()
        {
            InitializeComponent();
            Program.InitializeDataGridView(dataGridView);
            dataGridView.DataSource = Program.ListSach;
        }

        private void Submit_Button_Click(object sender, System.EventArgs e)
        {
            string pattern = Regex.Escape(TenSach_TextBox.Text);
            Regex regex = new Regex($".*{pattern}.*", RegexOptions.IgnoreCase);
            List<Sach> matchedSach = Program.ListSach.FindAll(s => regex.IsMatch(s.TenSach));
            dataGridView.DataSource = matchedSach;
        }
    }
}
