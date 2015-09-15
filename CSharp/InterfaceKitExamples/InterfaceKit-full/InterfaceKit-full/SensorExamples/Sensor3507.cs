using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor3507 : UserControl
    {
        public Sensor3507()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        public void changeDisplay(int val)
        {
            double tmp;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    tmp = (val * 0.25);
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 1:
                    tmp = (val * 0.2);
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 2:
                    tmp = (val * 0.075);
                    textBox1.Text = tmp.ToString("0.####");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label3.Text = "AC Volts (RMS) = (SensorValue * 0.25)";
                    break;
                case 1:
                    label3.Text = "DC Volts = (SensorValue * 0.2)";
                    break;
                case 2:
                    label3.Text = "DC Volts = (SensorValue * 0.075)";
                    break;
            }
        }
    }
}
