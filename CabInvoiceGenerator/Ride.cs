using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    //Ride Class to Set Data for Particular Ride
    public class Ride
    {
        //Variables
        public double distance;
        public int time;

        //Parameterized Constructor
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}