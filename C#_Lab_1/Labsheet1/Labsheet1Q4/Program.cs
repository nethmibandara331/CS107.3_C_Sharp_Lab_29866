using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet1Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("first " + num + " terms of the fibonacci series:");

            for (int i = 0; i < num; i++)
            {
                int result = Fibonacci(i);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            Console.ReadLine();
        }
    }
    
}
