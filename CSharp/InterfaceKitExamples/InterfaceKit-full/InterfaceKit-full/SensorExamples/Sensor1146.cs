using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1146 : UserControl
    {
        public int sensorValue;
        public Sensor1146()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = 0;
            try
            {
                tmp = Math.Pow(2.71828, (val * 0.001967)) * 1.3927;
            }
            catch
            {

            }
            textBox1.Text = tmp.ToString("0.####") + " mm";
            this.Update();
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
