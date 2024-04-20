using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int totl = num;
            for (int i = 1; i < num; i++)
            {
                totl = totl + i;
            }
            Console.WriteLine("Sum is " + totl);

            Console.ReadLine();
        }
    }
}
