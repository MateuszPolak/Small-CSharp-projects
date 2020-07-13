using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polak9
{
    public partial class Calculator : Form
    {
        
        //public delegate void ReturnResult(string text);
        Action<string> dlg = null;

        Func<double, double> operation1 = null;// = x => x
        Func<double, double, double> operation2;

        double res = 0;
        double arg1;
        double arg2;

        public Calculator()
        {
            InitializeComponent();
            buttonGo.Enabled = false;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == false && checkBoxSave.Checked == false)
            {
                buttonGo.Enabled = false;
            }
            if (checkBoxShow.Checked == true)
            {
                dlg += Output.ShowDialogBox;
                buttonGo.Enabled = true;
            }
            else
            {
                dlg -= Output.ShowDialogBox;
            }
        }

        private void checkBoxSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == false && checkBoxSave.Checked == false)
            {
                buttonGo.Enabled = false;
            }
            if (checkBoxSave.Checked == true)
            {
                dlg += Output.SaveToFile;
                buttonGo.Enabled = true;
            }
            else
            {
                dlg -= Output.SaveToFile;
            }
        }

        private void radioButton1arg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1arg.Checked == true)
            {
                radioButton2arg.Checked = false;
                textBox2ndarg.Visible = false;
                comboBoxSelect.Items.Clear();
                comboBoxSelect.Items.Add("sqrt");
                comboBoxSelect.Items.Add("factorial");
                comboBoxSelect.Text = "select";
            }
        }

        private void radioButton2arg_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2arg.Checked == true)
            {
                radioButton1arg.Checked = false;
                textBox2ndarg.Visible = true;
                comboBoxSelect.Items.Clear();
                comboBoxSelect.Items.Add("+");
                comboBoxSelect.Items.Add("-");
                comboBoxSelect.Items.Add("*");
                comboBoxSelect.Items.Add("/");
                comboBoxSelect.Text = "select";
            }
        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelect.Text == "sqrt")
            {
                operation1 = (x) => Math.Sqrt(x);
            }
            else if (comboBoxSelect.Text == "factorial")
            {
                operation1 = (x) => (x < 2) ? 1 : x * operation1(x - 1);
            }
            else if (comboBoxSelect.Text == "+")
            {
                operation2 = (x, y) => x + y;
            }
            else if (comboBoxSelect.Text == "-")
            {
                operation2 = (x, y) => x - y;
            }
            else if (comboBoxSelect.Text == "*")
            {
                operation2 = (x, y) => x * y;
            }
            else if (comboBoxSelect.Text == "/")
            {
                operation2 = (x, y) => x / y;
            }
            else
            {
                dlg("Unexpected error");
            }
        }

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            if (comboBoxSelect.Text != "select")
            {
                if (comboBoxSelect.Text == "sqrt")
                {
                    res = operation1(arg1);
                }
                else if (comboBoxSelect.Text == "factorial")
                {
                    res = operation1(arg1);
                }
                else if (comboBoxSelect.Text == "+")
                {
                    res = operation2(arg1, arg2);
                }
                else if (comboBoxSelect.Text == "-")
                {
                    res = operation2(arg1, arg2);
                }
                else if (comboBoxSelect.Text == "*")
                {
                    res = operation2(arg1, arg2);
                }
                else if (comboBoxSelect.Text == "/")
                {
                    res = operation2(arg1, arg2);
                }
                dlg("Result: " + res);
            }
            else if (comboBoxSelect.Text == "select")
            {
                dlg("Choose operation");
            }
            else
            {
                dlg("Unexpected error");
            }
        }

        private void textBox1starg_TextChanged(object sender, EventArgs e)
        {
            arg1 = double.Parse(textBox1starg.Text);
            comboBoxSelect.SelectedItem = comboBoxSelect.SelectedItem;
        }

        private void textBox2ndarg_TextChanged(object sender, EventArgs e)
        {
            arg2 = double.Parse(textBox2ndarg.Text);
            comboBoxSelect.SelectedItem = comboBoxSelect.SelectedItem;
        }
    }
}
