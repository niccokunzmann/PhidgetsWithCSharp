using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1140: UserControl
    {
        public int sensorValue;
        public Sensor1140()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = (val / 2.421) + 3.478;
            textBox1.Text = tmp.ToString("0.####") + "kPa";
            tmp = (val / 16.697) + 0.504;
            textBox2.Text = tmp.ToString("0.####") + "psi";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
