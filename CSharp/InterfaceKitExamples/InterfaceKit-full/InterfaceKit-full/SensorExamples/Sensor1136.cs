using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1136: UserControl
    {
        public int sensorValue;
        public Sensor1136()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = (val / 200.000) - 2.500;
            textBox1.Text = tmp.ToString("0.####") + "kPa";
            tmp = (val / 1379.31) - 0.3625;
            textBox2.Text = tmp.ToString("0.####") + "psi";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
