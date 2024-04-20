using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width:");
            double w = Convert.ToDouble(Console.ReadLine());
            Area(l, w);

            Console.ReadLine();
        }

        static void Area(double l, double w)
        {
            double area = l * w;
            Console.WriteLine("Area is " + area);

        }
    }
}
