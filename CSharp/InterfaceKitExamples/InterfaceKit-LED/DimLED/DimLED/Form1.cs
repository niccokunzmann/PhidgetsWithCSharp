using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Needed for the InterfaceKit class, phidget base classes, and the PhidgetException class
using Phidgets;
//Needed for the event handling classes 
using Phidgets.Events;  


namespace DimLED
{
    public partial class Form1 : Form
    {

        static InterfaceKit ifKit;

        int sensor1_value = 0;

        Random random;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();

            ifKit = new InterfaceKit();

            //Hook the basica event handlers
            ifKit.Attach += new AttachEventHandler(ifKit_Attach);
            ifKit.Detach += new DetachEventHandler(ifKit_Detach);
            
            //Hook the phidget spcific event handlers
            ifKit.SensorChange += new SensorChangeEventHandler(ifKit_SensorChange);

            //Open the object for device connections
            ifKit.open(); 
            
        }

        //Attach event handler...Display the serial number of the attached InterfaceKit 
        //to the console
        void ifKit_Attach(object sender, AttachEventArgs e)
        {
            this.Text = "attached";
            // start the timer
            this.timer1.Start();
        }

        //Detach event handler...Display the serial number of the detached InterfaceKit 
        //to the console
        void ifKit_Detach(object sender, DetachEventArgs e)
        {
            this.Text = "detached";
            // stop the timer
            this.timer1.Stop();
        }

        //Sensor Change event handler...Display the sensor index and it's new value to 
        //the console
        void ifKit_SensorChange(object sender, SensorChangeEventArgs e)
        {
            if (e.Index == 0)
            {
                this.label1.Text = e.Value.ToString();
                sensor1_value = e.Value;
                bool on = sensor1_value > 500;
                ifKit.outputs[0] = on;
                label6.Text = on.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool on = random.Next(1000) < sensor1_value;
            ifKit.outputs[1] = on;
            label2.Text = on.ToString();
        }

    }
}
