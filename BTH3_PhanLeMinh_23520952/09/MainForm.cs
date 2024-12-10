using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool isValidInfo()
        {
            bool isValid = true;

            if (studentID_Box.Text == "" || name_Box.Text == "" || apartmentComboBox.Text == "")
                isValid = false;
            foreach (char c in studentID_Box.Text)
                if ((int)c < (int)'0' || (int)c > (int)'9')
                {
                    studentID_Box.Text = "";
                    isValid = false;
                }
            foreach (char c in name_Box.Text)
                if ((int)c > (int)'0' && (int)c < (int)'9')
                {
                    name_Box.Text = "";
                    isValid = false;
                }
            if (manCheckbox.Checked == womanCheckbox.Checked)
            {
                manCheckbox.Checked = womanCheckbox.Checked = false;
                isValid = false;
            }
            if (rightBox.Items.Count == 0)
                isValid = false;
            return isValid;
        }

        private void saveInfo_Button_Click(object sender, EventArgs e)
        {
            if (isValidInfo())
            {
                string gender;
                if (manCheckbox.Checked)
                    gender = manCheckbox.Text;
                else gender = womanCheckbox.Text;

                foreach (DataGridViewRow row in infoList.Rows)
                    if (row.Cells[0].Value != null)
                        if (studentID_Box.Text == row.Cells[0].Value.ToString())
                        {
                            row.Cells[1].Value = name_Box.Text;
                            row.Cells[2].Value = apartmentComboBox.SelectedItem.ToString();
                            row.Cells[3].Value = gender;
                            row.Cells[4].Value = rightBox.Items.Count.ToString();
                            MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                            return;
                        }
                infoList.Rows.Add(studentID_Box.Text, name_Box.Text, apartmentComboBox.SelectedItem.ToString(), gender, rightBox.Items.Count.ToString());
            }
            else MessageBox.Show("Thông tin bị thiếu hoặc không chính xác");
        }

        private void toRightBox_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < leftBox.SelectedItems.Count; i++)
            {
                rightBox.Items.Add(leftBox.SelectedItems[i]);
                leftBox.Items.Remove(leftBox.SelectedItems[i]);
            }
        }
        private void toLeftBox_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rightBox.SelectedItems.Count; i++)
            {
                leftBox.Items.Add(rightBox.SelectedItems[i]);
                rightBox.Items.Remove(rightBox.SelectedItems[i]);
            }
        }

        private void cancelChoice_Button_Click(object sender, EventArgs e)
        {
            if (infoList.SelectedRows.Count == 0)
                MessageBox.Show("Bạn chưa chọn dòng cần xóa");
            else for (int i = 0; i < infoList.SelectedRows.Count; i++)
                    infoList.Rows.RemoveAt(i);
        }
    }
}
