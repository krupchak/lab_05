using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> product = new List<Product>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ");

                string name = input[0];
                int cost = int.Parse(input[1]);

                product.Add(new Product(name, cost));
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split(" ");

                if (input.Length == 2)
                {
                    int money = int.Parse(input[0]);
                    Product products = product.First(p => p.Name == input[1]);

                    people.Add(new Person(null, money, products));
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    int money = int.Parse(input[1]);
                    Product products = product.First(p => p.Name == input[2]);

                    people.Add(new Person(name, money, products));
                }
            }

            foreach (var person in people) 
            {
                person.validation_input();

                if(person.Money >= person.Products.Cost)
                {
                    Console.WriteLine($"{person.Name} bought {person.Products.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} – Nothing bought");
                }
            }
        }
    }
}
