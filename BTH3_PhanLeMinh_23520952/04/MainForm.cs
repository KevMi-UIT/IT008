using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void formatMenu_Click(object sender, EventArgs e)
        {
            ColorDialog chooseColor = new ColorDialog();
            if (chooseColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = chooseColor.Color; 
            }
        }
    }
}
