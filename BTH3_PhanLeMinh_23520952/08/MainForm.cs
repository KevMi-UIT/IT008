using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
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
            if (acountID.Text == "" || customerName.Text == "" || customerName.Text == "" || customerAddress.Text == "" || accountMoney.Text == "")
                isValid = false;
            foreach (char c in acountID.Text)
                if ((int)c < (int)'0' || (int)c > (int)'9')
                {
                    acountID.Text = "";
                    isValid = false;
                }
            foreach (char c in customerName.Text)
                if ((int)c >= (int)'0' && (int)c <= (int)'9')
                {
                    customerName.Text = "";
                    isValid = false;
                }
            foreach (char c in accountMoney.Text)
                if ((int)c < (int)'0' || (int)c > (int)'9')
                {
                    accountMoney.Text = "";
                    isValid = false;
                }
            return isValid;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (isValidInfo())
            {
                foreach (ListViewItem item in listView.Items)
                    if (item.SubItems[1].Text == acountID.Text)
                    {
                        item.SubItems[2].Text = customerName.Text;
                        item.SubItems[3].Text = customerAddress.Text;
                        item.SubItems[4].Text = long.Parse(accountMoney.Text).ToString();
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        return;
                    }
                ListViewItem addItem = new ListViewItem((listView.Items.Count + 1).ToString());
                addItem.SubItems.Add(acountID.Text);
                addItem.SubItems.Add(customerName.Text);
                addItem.SubItems.Add(customerAddress.Text);
                addItem.SubItems.Add(long.Parse(accountMoney.Text).ToString());
                listView.Items.Add(addItem);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
                acountID.Text = customerName.Text = accountMoney.Text = customerAddress.Text = "";
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ và chính xác thông tin!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Bảng chưa có thông tin");
                return;
            }
            else
            {
                ListViewItem removeIndexItem = null;
                foreach (ListViewItem item in listView.Items)
                    if (item.Selected == true || item.SubItems[1].Text == acountID.Text)
                        removeIndexItem = item;
                if (removeIndexItem != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        removeIndexItem.Remove();
                        MessageBox.Show("Xóa tài khoản thành công");
                        acountID.Text = customerName.Text = accountMoney.Text = customerAddress.Text = "";
                        for (int i = 0; i < listView.Items.Count; i++)
                            listView.Items[i].SubItems[0].Text = (i + 1).ToString();
                    }
                }
                else MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "XÁC NHẬN THOÁT CHƯƠNG TRÌNH", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
