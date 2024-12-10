using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void drawButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics draw = contentPanel.CreateGraphics();

            int x = rnd.Next(10, 700);
            int y = rnd.Next(10, 600);

            var font = new Font(new FontFamily("Arial"), rnd.Next(20, 60), FontStyle.Bold, GraphicsUnit.Pixel);

            var solidBrush = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)));

            draw.DrawString("Paint Event", font, solidBrush, new PointF(x, y));
        }
    }
}
