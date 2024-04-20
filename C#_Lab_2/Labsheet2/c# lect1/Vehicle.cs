using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__lect1
{
    internal class Vehicle
    {
        public string Brand;
        public int Wheels;

        public Vehicle(string aBrand,int aWheel)
        {
            Brand = aBrand;
            Wheels = aWheel;
        }
        
        public void Sound()
        {
            Console.WriteLine("vehicle sound");
        }
    }
}
