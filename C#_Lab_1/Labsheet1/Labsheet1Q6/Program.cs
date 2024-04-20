using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your mark:");
            int mark = Convert.ToInt32(Console.ReadLine());
            string grd;
            if (mark < 0 && mark > 100)
            {
                Console.WriteLine("Error");
            }
            else if (mark >= 75)
            {
                grd = "A";
                Console.WriteLine(name + " = " + grd);
            }
            else if (mark >= 60)
            {
                grd = "B";
                Console.WriteLine(name + " = " + grd);
            }
            else if (mark >= 50)
            {
                grd = "C";
                Console.WriteLine(name + " = " + grd);
            }
            else if (mark >= 40)
            {
                grd = "D";
                Console.WriteLine(name + " = " + grd);
            }
            else
            {
                grd = "Fail";
                Console.WriteLine(name + " = " + grd);
            }
        }
    }
}
