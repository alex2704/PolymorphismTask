using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Task2WInForm
{
    public partial class MobileOperatorForm : Form
    {
        public MobileOperatorForm()
        {
            InitializeComponent();
            Check_btn.Enabled = false;
            resBox.ReadOnly = true;
            radio_class1.Checked = true;
            PayTrue_radio.Enabled = false;
            PayFalse_radio.Enabled = false;
            Clear_btn.Enabled = false;
        }
        MobileOperator mobileOperator;
        PersonalMobileOperator personalMobileOperator;
        private void Check_btn_Click(object sender, EventArgs e)
        {
            if (radio_class1.Checked == true)
            {
                mobileOperator.Cost();
                resBox.Text = Convert.ToString(mobileOperator.Q);
                dataGridView.Rows.Add(name_box.Text, minutecost_box.Text, coverageArea_box.Text, "отсутствует", resBox.Text);
            }
            else if (radio_class2.Checked == true)
            {
                personalMobileOperator.Cost();
                resBox.Text = Convert.ToString(personalMobileOperator.Q);
                dataGridView.Rows.Add(name_box.Text, minutecost_box.Text, coverageArea_box.Text, PayTrue_radio.Checked, resBox.Text);
            }
            Check_btn.Enabled = false;
            Clear_btn.Enabled = true;
        }
        private void Choose_btn_Click(object sender, EventArgs e)
        {
            if (radio_class1.Checked == true && name_box.Text != "" && minutecost_box.Text != "" && coverageArea_box.Text != "")
            {
                Check_btn.Enabled = true;
                mobileOperator = new MobileOperator(name_box.Text, Convert.ToInt32(minutecost_box.Text), Convert.ToInt32(coverageArea_box.Text));
            }
            else if (radio_class2.Checked == true && (PayFalse_radio.Checked == true || PayTrue_radio.Checked == true) && name_box.Text != "" && minutecost_box.Text != "" && coverageArea_box.Text != "")
            {
                Check_btn.Enabled = true;
                personalMobileOperator = new PersonalMobileOperator(name_box.Text, Convert.ToInt32(minutecost_box.Text), Convert.ToInt32(coverageArea_box.Text), PayTrue_radio.Checked);
            }
            else
            {
                label2.Text = "Вы указали не все данные";
            }
        }

        private void Radio_class_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_class1.Checked == true)
            {
                PayFalse_radio.Enabled = false;
                PayTrue_radio.Enabled = false;
            }
            else
            {
                PayFalse_radio.Enabled = true;
                PayTrue_radio.Enabled = true;
            }
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8) && (e.KeyChar != 46) && (e.KeyChar <= 47 || e.KeyChar >= 58))
            {
                e.Handled = true;
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            Clear_btn.Enabled = false;
        }
    }
}
