using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Tọa độ nhấp chuột: (" + e.X.ToString() + ", " + e.Y.ToString() + ")");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Phím vừa bấm: '" + e.KeyChar.ToString() + "' với mã ASCII là " + ((int)e.KeyChar).ToString() + " và mã phím là " + keyCode);
        }

        string keyCode;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            keyCode = e.KeyCode.ToString();
        }
    }
}
