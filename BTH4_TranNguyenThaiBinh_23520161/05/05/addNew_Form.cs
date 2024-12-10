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
    public partial class addNew_Form : Form
    {
        public student newStudent;
        public addNew_Form()
        {
            InitializeComponent();
        }

        bool isValidInfo()
        {
            bool isValid = true;

            if (studentID_TextBox.Text == "" || studentName_TextBox.Text == "" || averageScore__TextBox.Text == "")
                isValid = false;

            foreach (char c in studentID_TextBox.Text)
                if ((int)c < (int)'0' || (int)c > (int)'9')
                {
                    isValid = false;
                    studentID_TextBox.Text = "";
                }

            foreach (char c in studentName_TextBox.Text) 
                if ((int)c >= (int)'0' && (int)c <= (int)'9')
                {
                    isValid = false;
                    studentName_TextBox.Text = "";
                }

            double temp;
            if (!double.TryParse(averageScore__TextBox.Text, out temp))
            {
                averageScore__TextBox.Text = "";
                isValid = false;
            }
            else if (temp > 10 || temp < 0)
            {
                averageScore__TextBox.Text = "";
                isValid = false;
            }

            return isValid;
        }

        private void addNew_Button_Click(object sender, EventArgs e)
        {
            if (isValidInfo())
            {
                newStudent = new student(studentID_TextBox.Text, studentName_TextBox.Text, apartment_ComboBox.Text, double.Parse(averageScore__TextBox.Text));
                this.Close();
            }
            else MessageBox.Show("Vui lòng điền lại các thông tin bị sai hoặc chưa được điền");
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (studentID_TextBox.Text == "" && studentName_TextBox.Text == "" && averageScore__TextBox.Text == "")
                this.Close();
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "XÁC NHẬN", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
