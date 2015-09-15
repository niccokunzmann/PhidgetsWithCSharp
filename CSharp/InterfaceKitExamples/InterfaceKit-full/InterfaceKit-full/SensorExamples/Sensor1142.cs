using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1142 : UserControl
    {
        public int sensorValue;
        public Sensor1142()
        {
            InitializeComponent();
            textBox2.Text = "1.478777";
            textBox3.Text = "33.67076";
        }

        public void changeDisplay(int val)
        {
            double tmp = 0;
            try
            {
                tmp = (val * Convert.ToDouble(textBox2.Text)) + Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                //User has copy+pasted text into the field, or placed a negative sign improperly, or left a field blank
                textBox2.Text = "0";
                textBox3.Text = "0";
            }
            textBox1.Text = tmp.ToString("0.####") + " lx";
            this.Update();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
