using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1138: UserControl
    {
        public int sensorValue;
        public Sensor1138()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = (val / 18) - 2.222;
            textBox1.Text = tmp.ToString("0.####") + "kPa";
            tmp = (val / 124.14) - 0.322;
            textBox2.Text = tmp.ToString("0.####") + "psi";
        }

    }
}
