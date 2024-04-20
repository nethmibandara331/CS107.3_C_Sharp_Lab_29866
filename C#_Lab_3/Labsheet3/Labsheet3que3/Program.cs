﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet3que3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101,"Laptop",800,10);
            Console.WriteLine($"Product Information");
            product.DisplayProductInfo();

            //try to modify this product id from external code
            //this will result in a compile time error because the productid field is private
           //product.productId=102;//uncommenting this line cause a compile error

            Console.ReadLine();

        }
    }

    public class Product
    {
        private int productId;
        public string productName;
        public double price;
        public int quantityInStock;

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public void AddProduct(int quantity)
        {
            quantityInStock += quantity;
            Console.WriteLine($"{quantity}{productName}(s) added to stock.Total quantity in stock: {quantityInStock}");
        }

        public void BuyProduct(int quantity)
        {
            if(quantityInStock<=quantityInStock)
            {
                quantityInStock -= quantity;
                Console.WriteLine($"{quantity}{productName}(s) sold.remaining quantity in stock: {quantityInStock}");
            }

            else
            {
                Console.WriteLine($"insufficient stock. only{quantityInStock}{productName}(s) available.");
            }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product Id: {productId}");
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product Price: ${price}");
            Console.WriteLine($"Quantity: {quantityInStock}");
        }
    }
}
