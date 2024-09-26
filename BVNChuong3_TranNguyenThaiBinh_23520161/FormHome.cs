using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVNChuong3_TranNguyenThaiBinh_23520161
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PhanSoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhanSo formPhanSo = new FormPhanSo { MdiParent = this };
            formPhanSo.Show();
        }

        private void SoPhucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoPhuc formSoPhuc = new FormSoPhuc { MdiParent = this };
            formSoPhuc.Show();
        }
    }
}
