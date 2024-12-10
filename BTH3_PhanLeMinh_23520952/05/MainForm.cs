using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private bool isValidNumber()
        {
            double a;
            if (num1.Text == "" || num2.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return false;
            }
            try
            {
                a = double.Parse(num1.Text) + double.Parse(num2.Text);
            }
            catch (FormatException)
            {
                num1.Text = num2.Text = "";
                MessageBox.Show("Giá trị nhập vào không hợp lệ, hãy nhập lại");
                return false;
            }
            return true;
        }

        private void congButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
                answer.Text = (double.Parse(num1.Text) + double.Parse(num2.Text)).ToString();
        }

        private void truButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
                answer.Text = (double.Parse(num1.Text) - double.Parse(num2.Text)).ToString();
        }

        private void nhanButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
                answer.Text = (double.Parse(num1.Text) * double.Parse(num2.Text)).ToString();
        }

        private void chiaButton_Click(object sender, EventArgs e)
        {
            if (isValidNumber())
                answer.Text = (double.Parse(num1.Text) / double.Parse(num2.Text)).ToString();
        }
    }
}
