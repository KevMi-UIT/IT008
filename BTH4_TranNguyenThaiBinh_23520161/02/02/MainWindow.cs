using System;
using System.Windows.Forms;

namespace _02
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            timeNow.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
            timeNow.Left = (this.ClientSize.Width - timeNow.Size.Width) / 2;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            clock.Start();
        }
    }
}
