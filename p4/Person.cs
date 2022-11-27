using System;
using System.Collections.Generic;
using System.Text;

namespace p4
{
    internal class Person
    {
        public string? Name { get; set; }
        public int Money { get; set; }
        public Product Products { get; set; }

        public Person(string? name, int money, Product product)
        {
            this.Name = name;
            this.Money = money;
            this.Products = product;
        }

        public void validation_input()
        {
            if (this.Name == null)
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(1);
            }
            else if(this.Money < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(1);
            }
        }
    }
}
