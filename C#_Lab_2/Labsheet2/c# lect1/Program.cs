using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Author = "J.K.Rowling";
            book1.Title = "Harry Potter";
            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);

            Console.ReadLine();
        }   
        
        
    }
     internal class Book
    {
        public string Title;
        public string Author;
    }
   
     
}
