using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Your number is even");
                    }

                    else
                    {
                        Console.WriteLine("Your number is odd");
                    }
                }
                else
                {
                    bool re = true;
                    while (re)
                    {
                        Console.WriteLine("Please enter an positive number");

                        Console.WriteLine("Enter the number again:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 % 2 == 0)
                        {
                            Console.WriteLine("Your number is even");
                        }

                        else
                        {
                            Console.WriteLine("Your number is odd");
                        }
                        re = false;
                    }


                }
            }

            Console.ReadLine();
        }
    }
    
}
