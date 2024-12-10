using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            clock.Start();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video/Sound File | *.avi; *.mpeg; *.wav; *.midi; *.mp4; *.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = Path.GetFileName(dialog.FileName);
                mediaPlayer.URL = dialog.FileName;
                mediaPlayer.Ctlcontrols.play();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeNow.Text = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy") + " - Bây giờ là " + DateTime.Now.ToString("HH:mm:ss tt").ToUpper();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
