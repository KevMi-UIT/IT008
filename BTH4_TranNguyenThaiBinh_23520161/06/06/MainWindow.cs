using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace _06
{
    public partial class MainForm : Form
    {
        string sourcePath = "";
        string destinationPath = "";
        bool finish = false;
        BackgroundWorker worker = new BackgroundWorker();
        ToolTip tip = new ToolTip();
        public MainForm()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += copyProcess_ProgressChanged;
            worker.DoWork += copyProcess_DoWork;
            tip.SetToolTip(progressBar, "Sẵn sàng");
        }
        
        private void startLocation_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog sourcePathDlg = new OpenFileDialog();
            if (sourcePathDlg.ShowDialog() == DialogResult.OK)
            {
                startLocation.Text = sourcePath = sourcePathDlg.FileName;
                startLocation.ReadOnly = true;
            }
        }

        private void endLocation_Button_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog destinationPathdlg = new CommonOpenFileDialog();
            destinationPathdlg.IsFolderPicker = true;
            if (destinationPathdlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                endLocation.Text = destinationPath = destinationPathdlg.FileName;
                destinationPath = Path.Combine(destinationPath, Path.GetFileName(sourcePath));
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (sourcePath == "" || destinationPath == "")
            {
                MessageBox.Show("Thiếu thông tin đường dẫn");
                return;
            }
            else
            {
                worker.RunWorkerAsync();
                timer.Start();
                statusLabel.Text = "Đang sao chép: " + sourcePath;
                tip.SetToolTip(progressBar, "Đang sao chép: " + sourcePath);
            }
        }

        private void copyProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(sourcePath, destinationPath);
        }
        private void copyProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        void CopyFile(string src, string dest)
        {
            FileStream fsOut = new FileStream(dest, FileMode.Create);
            FileStream fsIn = new FileStream(src, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readByte;
            while ((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            if (this.progressBar.Value == this.progressBar.Maximum)
            {
                finish = true;
                timer.Stop();
                statusLabel.Text = "Đang sao chép:";
                if (finish == true)
                {
                    tip.SetToolTip(progressBar, "Sẵn sàng");
                    MessageBox.Show("Sao chép thành công");
                }
            }
        }
    }
}
