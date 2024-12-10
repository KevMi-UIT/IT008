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
        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        // Menu Button
        private void addNew_Menu_Click(object sender, EventArgs e)
        {
            addNew_Click(sender, e);
        }
        private void exit_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            addNew_Form addStudent = new addNew_Form();
            this.Hide();
            addStudent.ShowDialog();
            if (addStudent.newStudent != null)
                studentInfoList.Rows.Add(count++.ToString(), addStudent.newStudent.ID, addStudent.newStudent.name, addStudent.newStudent.apartment, addStudent.newStudent.score.ToString());
            this.Show();
        }

        static int count = 1;
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < studentInfoList.RowCount; i++)
            {
                if (studentInfoList.Rows[i].Cells[2].Value != null && studentInfoList.Rows[i].Cells[2].Value.ToString().ToLower().Contains(searchBox.Text.ToLower()))
                    studentInfoList.Rows[i].Visible = true;
                else studentInfoList.Rows[i].Visible = false;
            }
        }
    }
}
