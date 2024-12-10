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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Form Activated");
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Click");
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("Form Deactivate");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Close");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form Closing");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load");
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("Form Resize");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form Shown");
        }
    }
}
