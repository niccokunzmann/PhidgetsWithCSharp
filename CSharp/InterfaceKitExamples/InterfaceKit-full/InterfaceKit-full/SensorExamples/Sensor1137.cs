using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1137: UserControl
    {
        public int sensorValue;
        public Sensor1137()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = (val / 57.143) - 8.75;
            textBox1.Text = tmp.ToString("0.####") + "kPa";
            tmp = (val / 394.09) - 1.269;
            textBox2.Text = tmp.ToString("0.####") + "psi";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
