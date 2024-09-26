using BVNChuong3_TranNguyenThaiBinh_23520161.DataStructures;
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
    public partial class FormPhanSo : Form
    {
        public FormPhanSo()
        {
            InitializeComponent();
            LabelKetQuaTong.Text = "";
            LabelKetQuaHieu.Text = "";
            LabelKetQuaTich.Text = "";
            LabelKetQuaThuong.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhanSo a;
            PhanSo b;
            try
            {
                if (!int.TryParse(TextBoxTu1.Text, out int tu1) || !int.TryParse(TextBoxMau1.Text, out int mau1) ||
                    !int.TryParse(TextBoxTu2.Text, out int tu2) || !int.TryParse(TextBoxMau2.Text, out int mau2))
                {
                    MessageBox.Show("Please enter valid integers for all fields.");
                    return;
                }
                a = new PhanSo(tu1, mau1);
                b = new PhanSo(tu2, mau2);
            }
            catch (ArgumentException _e)
            {
                MessageBox.Show(_e.Message);
                return;
            }
            catch (Exception _e)
            {
                MessageBox.Show($"Unkown Error: {_e.Message}");
                return;
            }
            LabelKetQuaTong.Text = (a + b).ToString();
            LabelKetQuaHieu.Text = (a - b).ToString();
            LabelKetQuaTich.Text = (a * b).ToString();
            LabelKetQuaThuong.Text = (a / b).ToString();
        }
    }
}
