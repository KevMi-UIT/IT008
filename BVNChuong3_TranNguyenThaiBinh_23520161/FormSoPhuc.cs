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
    public partial class FormSoPhuc : Form
    {
        public FormSoPhuc()
        {
            InitializeComponent();
            LabelKetQuaTong.Text = "";
            LabelKetQuaHieu.Text = "";
            LabelKetQuaTich.Text = "";
            LabelKetQuaThuong.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoPhuc a;
            SoPhuc b;
            try
            {
                if (!int.TryParse(TextBoxReal1.Text, out int phanThuc1) || !int.TryParse(TextBoxImagine1.Text, out int phanAo1) ||
                    !int.TryParse(TextBoxReal2.Text, out int phanThuc2) || !int.TryParse(TextBoxImagine2.Text, out int phanAo2))
                {
                    MessageBox.Show("Please enter valid integers for all fields.");
                    return;
                }
                a = new SoPhuc(phanThuc1, phanAo1);
                b = new SoPhuc(phanThuc2, phanAo2);
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
