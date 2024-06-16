using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SearchProductTest
{
    public class Program
    {
        public class Product
        {
            private string _name;
            private string _productCode;
            private string _brandName;
            private int _stockLeft;
            private double _price;

            public Product() { }

            public Product(string name, string productCode, string brandName, int stockLeft, double price)
            {
                _name = name;
                _productCode = productCode;
                _brandName = brandName;
                _stockLeft = stockLeft;
                _price = price;
            }

            public string Name { get { return _name; } set { _name = value; } }
            public string ProductCode { get { return _productCode; } set { _productCode = value; } }
            public string BrandName { get { return _brandName; } set { _brandName = value; } }
            public int StockLeft { get { return _stockLeft; } set { _stockLeft = value; } }
            public double Price { get { return _price; } set { _price = value; } }
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product("Dairy milk", "#CA 12 DA-159", "Cadbury", 500, 25),
                new Product("Milky bar", "#NE 18 MI-162", "Nestle", 600, 10),
                new Product("Lifebuoy", "#UN 20 LI-285", "Unilever", 195, 31),
                new Product("Almond oil", "#BA 11 AL-789", "Bajaj", 400, 72),
                new Product("Fuse", "#CA 17 FU-110", "Cadbury", 300, 20)
            };

            Console.WriteLine("Enter a search type:\n1. By brand name\n2. By price");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the brand name:");
                string name = Console.ReadLine();
                // Write code to search the above products list based on brandname
                List<Product> result = products.Where(p => p.BrandName == name).ToList();
                if (result.Count > 0)
                {
                    Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7}", "Name", "Product code", "Brand name", "Stock left", "Price");
                    foreach (Product p in result)
                    {
                        Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7}", p.Name, p.ProductCode, p.BrandName, p.StockLeft, p.Price);
                    }
                }
                else
                {
                    Console.WriteLine("No such product is present");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the price:");
                double price = double.Parse(Console.ReadLine());
                //Write code to search the above products list based on price
                List<Product> result = products.Where(p => p.Price == price).ToList();
                if (result.Count > 0)
                {
                    Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7}", "Name", "Product code", "Brand name", "Stock left", "Price");
                    foreach (Product p in result)
                    {
                        Console.WriteLine("{0,-15} {1,-15} {2,-12} {3,-12} {4,-7}", p.Name, p.ProductCode, p.BrandName, p.StockLeft, p.Price);
                    }
                }
                else
                {
                    Console.WriteLine("No such product is present");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
