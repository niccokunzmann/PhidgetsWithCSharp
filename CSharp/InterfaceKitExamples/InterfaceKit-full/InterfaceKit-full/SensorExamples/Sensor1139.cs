using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1139: UserControl
    {
        public int sensorValue;
        public Sensor1139()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = (val / 9) - 4.444;
            textBox1.Text = tmp.ToString("0.####") + "kPa";
            tmp = (val / 62.07) - 0.6444;
            textBox2.Text = tmp.ToString("0.####") + "psi";
        }

    }
}
