using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor3584 : UserControl
    {
        public Sensor3584()
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
                    tmp = (val * 0.05);
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 1:
                    tmp = (val * 0.1);
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 2:
                    tmp = (val * 0.25);
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 3:
                    tmp = (val * 0.1) - 50;
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 4:
                    tmp = (val * 0.2) - 100;
                    textBox1.Text = tmp.ToString("0.####");
                    break;
                case 5:
                    tmp = (val * 0.5) - 250;
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
                    label3.Text = "Current (mA) = (SensorValue * 0.05)";
                    break;
                case 1:
                    label3.Text = "Current (mA) = (SensorValue * 0.1)";
                    break;
                case 2:
                    label3.Text = "Current (mA) = (SensorValue * 0.25)";
                    break;
                case 3:
                    label3.Text = "Current (mA) = (SensorValue * 0.1) - 50";
                    break;
                case 4:
                    label3.Text = "Current (mA) = (SensorValue * 0.2) - 100";
                    break;
                case 5:
                    label3.Text = "Current (mA) = (SensorValue * 0.5) - 250";
                    break;
            }
        }
    }
}