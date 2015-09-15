using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1141: UserControl
    {
        public int sensorValue;
        public Sensor1141()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = (val / 9.2) + 10.652;
            textBox1.Text = tmp.ToString("0.####") + "kPa";
            tmp = (val / 63.45) + 1.54;
            textBox2.Text = tmp.ToString("0.####") + "psi";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
