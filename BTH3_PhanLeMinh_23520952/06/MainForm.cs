using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06
{
    public partial class MainForm : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((resultBox.Text == "0") || (isOperationPerformed))
                resultBox.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                    resultBox.Text = resultBox.Text + button.Text;
            }
            else resultBox.Text = resultBox.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(resultBox.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "*":
                    resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "/":
                    resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(resultBox.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
//How to Create a Calculator in Visual Studio C#
//