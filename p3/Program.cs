using System;
using System.Collections.Generic;
using System.Linq;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Chicken> chicken = new List<Chicken>();

            var input = Console.ReadLine().Split();

            if (input.Length == 1)
            {
                int age = int.Parse(input[0]);
                chicken.Add(new Chicken(age));
            }
            else if (input.Length == 2)
            {
                string name = input[0];
                int age = int.Parse(input[1]);
                chicken.Add(new Chicken(name, age));
            }

            foreach(var c in chicken)
            {
                if(c.Name == null)
                {
                    Console.WriteLine("Name cannot be empty.");
                }
                else if(c.Age >= 0 && c.Age <= 15)
                {
                    Console.WriteLine($"Chicken {c.Name} (age {c.Age}) can produce 1 eggs per day.");
                }
                else
                {
                    Console.WriteLine("Age should be between 0 and 15.");
                }
            }
        }
    }
}
