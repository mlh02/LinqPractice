using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = { 1,2,3,4,5,6,6,7,8,9,456,34,234,2134,234};
            Object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4, }, new List<int>() { 3, 56, 7, 83 }, "dd", "Hello", 1, 2, 3, 4 };
            List<Product> storeProducts = new List<Product>()
            {
                new Product() { Name = "Iphone", Price = 599, CompanyName = "Apple"},
                new Product() { Name = "Android", Price = 699, CompanyName = "Samsung"},
            };
            //storeProducts.ForEach(w => Console.WriteLine($"{w.Price}, {w.CompanyName}"));
            var allIntergers = mix.OfType<int>();

            Console.WriteLine(string.Join(", ", allIntergers));
        }

        internal class Product :Company
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        internal class Company
        {
            public string CompanyName { get; set; }
        }
    }
}
    
