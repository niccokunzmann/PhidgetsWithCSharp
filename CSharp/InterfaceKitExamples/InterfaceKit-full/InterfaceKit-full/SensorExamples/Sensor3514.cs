using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor3514 : UserControl
    {
        public Sensor3514()
        {
            InitializeComponent();
            textBox2.Text = "0";
        }

        public void changeDisplay(int val)
        {
            double tmp;
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        tmp = (val - Convert.ToDouble(textBox2.Text)) * 7.5;
                        textBox1.Text = tmp.ToString("0.####");
                        break;
                    case 1:
                        tmp = (val - Convert.ToDouble(textBox2.Text)) * 1.25;
                        textBox1.Text = tmp.ToString("0.####");
                        break;
                    case 2:
                        tmp = (val - Convert.ToDouble(textBox2.Text)) * 0.55;
                        textBox1.Text = tmp.ToString("0.####");
                        break;
                    case 3:
                        tmp = (val - Convert.ToDouble(textBox2.Text)) * 1.65;
                        textBox1.Text = tmp.ToString("0.####");
                        break;

                }
            }
            catch
            {
                //User has copy+pasted text into the field, or placed a negative sign improperly, or left a field blank
                textBox2.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label3.Text = "P(W) = (SensorValue - Offset) * 7.5";
                    break;
                case 1:
                    label3.Text = "P(W) = (SensorValue - Offset) * 1.25";
                    break;
                case 2:
                    label3.Text = "P(W) = (SensorValue - Offset) * 0.55";
                    break;
                case 3:
                    label3.Text = "P(W) = (SensorValue - Offset) * 1.65";
                    break;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore everything except numbers, periods, and dashes
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            // only allow one minus
            if (e.KeyChar == '-'
                && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
