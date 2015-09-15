/* 
 * Phidget Hello World Program for all devices
 * (c) Phidgets 2012
 */

using System;
using Phidgets;
using Phidgets.Events;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.open();


        }
    }
}