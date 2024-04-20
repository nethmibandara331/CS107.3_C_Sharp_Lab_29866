using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                int Val = num * i;
                Console.WriteLine(num + " x " + i + " = " + val);
            }
            Console.ReadLine();
        }
    }
}
